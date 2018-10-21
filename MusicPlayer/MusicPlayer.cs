using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Drawing;

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        public WindowsMediaPlayer musicPlayer;

        public string currentSongPath = "";

        public Playlist playlist;

        public int index = 0;

        int counter = 0;

        static string[] mediaExtensions = { ".WAV", ".MID", ".MIDI", ".WMA", ".MP3", ".OGG", ".RMA" };

        public MusicPlayer()
        {
            InitializeComponent();
            musicPlayer = new WindowsMediaPlayer();
            playlist = new Playlist() { AllSongs = new List<Song>(), CoverPath = @"C:\Users\Nikolay Kyurkchiyski\Documents\Visual Studio 2017\Projects\MusicPlayer\MusicPlayer\Resources\Uninstall-Groove-Music-from-Windows-10_thumb.jpg" };
            musicPlayer.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(MusicPlayer_PlayStateChange);
        }

        private void MusicPlayer_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPPlayState.wmppsMediaEnded)
            {
                BeginInvoke(new Action(AutoPlay));
            }

            if (NewState == (int)WMPPlayState.wmppsPlaying)
            {
                double duration = musicPlayer.currentMedia.duration;
                trackBar.Maximum = (int)duration;
                TimeSpan timeSpan = TimeSpan.FromSeconds(duration);
                songDurationLabel.Text = $"{timeSpan.Minutes:00}:{timeSpan.Seconds:00}";

            }
        }

        private void AutoPlay()
        {
            if (index == playlist.AllSongs.Count - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            musicPlayer.URL = playlist.AllSongs[index].PathToSong;
            toolStripStatusLabel.Text = $"Now Playing: {playlist.AllSongs[index].Name}";
            songNameLabel.Text = playlist.AllSongs[index].Name;
            musicPlayer.controls.play();

        }

        public void Playbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (musicPlayer.playState == WMPPlayState.wmppsPaused)
                {
                    musicPlayer.controls.play();
                }
                else if (musicPlayer.playState != WMPPlayState.wmppsPlaying)
                {
                    musicPlayer.URL = playlist.AllSongs[index].PathToSong;
                    songNameLabel.Text = playlist.AllSongs[index].Name;
                    musicPlayer.controls.play();

                }

            }
            catch
            {
                MessageBox.Show("The playlist is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (playlist.AllSongs.Count > 0)
            {
                musicPlayer.controls.stop();
            }
            else
            {
                MessageBox.Show("You haven't loaded a playlist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Songs",
                Multiselect = true,
                Filter = "Media files(*.mp3,*.wav,*.mid,*.midi,*.wma,*.ogg,*.rma) | *.mp3; *.wav; *.mid; *.midi; *.wma; *.ogg; *.rma"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] songPaths = openFileDialog.FileNames;

                foreach (var songPath in songPaths)
                {
                    FileInfo fileInfo = new FileInfo(songPath);
                    string extension = fileInfo.Extension;
                    string songName = fileInfo.Name.Remove(fileInfo.Name.Length - extension.Length, fileInfo.Extension.Length);

                    if (IsMediaFile(songPath))
                    {
                        Song newSong = new Song()
                        {
                            Name = songName,
                            PathToSong = songPath
                        };
                        if (!playlist.AllSongs.Exists(x => x.Name == songName) && !playlistBox.Items.Contains(songName))
                        {
                            playlist.AllSongs.Add(newSong);
                            playlistBox.Items.Add(songName);
                        }
                        else
                        {
                            MessageBox.Show("The selected song is already in the playlist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected file is not a media file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (playlist.AllSongs.Count > 0)
            {
                musicPlayer.controls.pause();
            }
            else
            {
                MessageBox.Show("You haven't loaded a playlist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsMediaFile(string path)
        {
            return -1 != Array.IndexOf(mediaExtensions, Path.GetExtension(path).ToUpperInvariant());
        }

        private string ConvertToString(Song song)
        {
            StringBuilder res = new StringBuilder();
            res.Append(song.Name);
            res.Append("|");
            res.Append(song.PathToSong);
            return res.ToString();
        }

        private Song ConvertToSong(string[] temp)
        {
            Song newSong = new Song()
            {
                Name = temp[0],
                PathToSong = temp[1]
            };
            return newSong;
        }

        private string[] ConvertToStringArray(Playlist playlist)
        {
            string[] res = new string[playlist.AllSongs.Count + 1];
            res[0] = playlist.CoverPath;
            for (int i = 1; i < playlist.AllSongs.Count + 1; i++)
            {
                res[i] = ConvertToString(playlist.AllSongs[i - 1]);
            }
            return res;
        }

        private Playlist ConvertToPlaylist(string path)
        {
            Playlist newPlaylist = new Playlist() { AllSongs = new List<Song>() };
            string[] arrayOfSongs = File.ReadAllLines(path);
            newPlaylist.CoverPath = arrayOfSongs[0];
            for (int i = 1; i < arrayOfSongs.Length; i++)
            {
                string[] temp = arrayOfSongs[i].Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                Song newSong = ConvertToSong(temp);
                newPlaylist.AllSongs.Add(newSong);
            }

            return newPlaylist;

        }

        private void SavePlaylistButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "newPlaylist",
                Title = "Save Playlist"
            };
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                File.WriteAllLines(Path.GetFullPath(saveFileDialog.FileName + ".txt"), ConvertToStringArray(playlist));
            }

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (playlist.AllSongs.Count > 0)
            {
                index--;
                if (index <= -1)
                {
                    index = playlist.AllSongs.Count - 1;

                }
                musicPlayer.URL = playlist.AllSongs[index].PathToSong;
                songNameLabel.Text = playlist.AllSongs[index].Name;
                musicPlayer.controls.play();
            }
            else
            {
                MessageBox.Show("You haven't loaded a playlist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (playlist.AllSongs.Count > 0)
            {
                index++;
                if (index >= playlist.AllSongs.Count)
                {
                    index = 0;
                }
                musicPlayer.URL = playlist.AllSongs[index].PathToSong;
                songNameLabel.Text = playlist.AllSongs[index].Name;
                musicPlayer.controls.play();
            }
            else
            {
                MessageBox.Show("You haven't loaded a playlist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveSongButton_Click(object sender, EventArgs e)
        {
            try
            {
                int markedSong = playlistBox.SelectedIndex;

                playlistBox.Items.RemoveAt(markedSong);
                playlist.AllSongs.RemoveAt(markedSong);
            }
            catch
            {
                if (playlist.AllSongs.Count == 0)
                {
                    MessageBox.Show("The playlist is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("You haven't selected a song!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreatePlaylistButton_Click(object sender, EventArgs e)
        {
            aboutPanel.Visible = false;
            loadPlaylistPanel.Visible = false;
            if (musicPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                musicPlayer.controls.stop();
            }
            ClearFields();
            createPlaylistPanel.Visible = true;

        }

        private void LoadPlaylistButton_Click(object sender, EventArgs e)
        {
            createPlaylistPanel.Visible = false;
            aboutPanel.Visible = false;
            if (musicPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                musicPlayer.controls.stop();
            }
            ClearFields();
            loadPlaylistPanel.Visible = true;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            createPlaylistPanel.Visible = false;
            loadPlaylistPanel.Visible = false;
            if (musicPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                musicPlayer.controls.stop();
            }
            ClearFields();
            aboutPanel.Visible = true;
        }

        private void BackToMainbutton_Click(object sender, EventArgs e)
        {
            timerScroll.Enabled = false;
            createPlaylistPanel.Visible = false;
            aboutPanel.Visible = false;
            loadPlaylistPanel.Visible = false;
            songNameLabel.Location = new Point(0, songNameLabel.Location.Y);
            if (musicPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                musicPlayer.controls.stop();
            }
            ClearFields();
        }

        private void ClearFields()
        {
            playlist.AllSongs.Clear();
            index = 0;
            playlist.CoverPath = @"C:\Users\Nikolay Kyurkchiyski\Documents\Visual Studio 2017\Projects\MusicPlayer\MusicPlayer\Resources\Uninstall-Groove-Music-from-Windows-10_thumb.jpg";
            loadedPlaylistBox.Items.Clear();
            playlistBox.Items.Clear();
            coverArtPictureBox.Load(playlist.CoverPath);
            loadCoverPictureBox.Load(playlist.CoverPath);
            songDurationLabel.Text = "00:00";
            currentProgressLabel.Text = "00:00";
            songNameLabel.Text = "Song Name";
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Playlist",
                Filter = "Text files(*.txt) | *.txt"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (filePath.EndsWith(".txt"))
                {
                    currentProgressLabel.Text = "00:00";
                    songDurationLabel.Text = "00:00";
                    songNameLabel.Text = "Song Name";
                    musicPlayer.controls.stop();
                    loadedPlaylistBox.Items.Clear();
                    playlist.AllSongs.Clear();
                    index = 0;
                    playlist = ConvertToPlaylist(filePath);
                    loadCoverPictureBox.Load(playlist.CoverPath);
                    for (int i = 0; i < playlist.AllSongs.Count; i++)
                    {
                        loadedPlaylistBox.Items.Add(playlist.AllSongs[i].Name);
                    }

                }
                else
                {
                    MessageBox.Show("The selected file is not a text file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Image",
                Filter = "Image Files(*.bmp,*.jpg,*.gif,*.png)|*.bmp;*.jpg;*.gif;*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string picturePath = openFileDialog.FileName;
                coverArtPictureBox.Load(picturePath);
                playlist.CoverPath = picturePath;
            }
        }

        private void TimerProgress_Tick(object sender, EventArgs e)
        {
            double currentPos = musicPlayer.controls.currentPosition;
            trackBar.Value = (int)currentPos;
            TimeSpan timeSpan = TimeSpan.FromSeconds(currentPos);
            currentProgressLabel.Text = $"{timeSpan.Minutes:00}:{timeSpan.Seconds:00}";
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            musicPlayer.controls.currentPosition = trackBar.Value;
        }

        private void StatusStripLoadMenu_MouseHover(object sender, EventArgs e)
        {
            if (sender == stopButton)
            {
                toolStripStatusLabel.Text = "Stop";
            }
            else if (sender == playButton)
            {
                toolStripStatusLabel.Text = "Play";
            }
            else if (sender == nextButton)
            {
                toolStripStatusLabel.Text = "Next";
            }
            else if (sender == previousButton)
            {
                toolStripStatusLabel.Text = "Previous";
            }
            else if (sender == pauseButton)
            {
                toolStripStatusLabel.Text = "Pause";
            }
            else if (sender == backToMainButton2 || sender == backToMainbutton || sender == aboutBackbutton)
            {
                toolStripStatusLabel.Text = "Back";
            }
            else if (sender == loadButton)
            {
                toolStripStatusLabel.Text = "Load Playlist";
            }
            else if (sender == addSongButton)
            {
                toolStripStatusLabel.Text = "Add Song";
            }
            else if (sender == removeSongButton)
            {
                toolStripStatusLabel.Text = "Remove Song";
            }
            else if (sender == savePlaylistButton)
            {
                toolStripStatusLabel.Text = "Save Playlist";
            }
            else if (sender == selectImageButton)
            {
                toolStripStatusLabel.Text = "Select Cover Art";
            }
            else if (sender == createPlaylistButton || sender == createToolStripMenuItem)
            {
                toolStripStatusLabel.Text = "Create Playlist!";
            }
            else if (sender == aboutButton || sender == aboutToolStripButton)
            {
                toolStripStatusLabel.Text = "About";
            }
            else if (sender == loadPlaylistButton || sender == loadToolStripMenuItem)
            {
                toolStripStatusLabel.Text = "Play Playlist!";
            }
            else if ((musicPlayer.playState == WMPPlayState.wmppsPlaying || musicPlayer.playState == WMPPlayState.wmppsStopped || musicPlayer.playState == WMPPlayState.wmppsPaused) && (playlist.AllSongs.Count > 0))
            {
                toolStripStatusLabel.Text = $"Now Playing: {playlist.AllSongs[index].Name}";
            }
            else
            {
                toolStripStatusLabel.Text = "Music Player";
            }
        }

        private void SongNamePanel_MouseLeave(object sender, EventArgs e)
        {
            timerScroll.Enabled = true;
            timerScroll.Start();

        }

        private void TimerScroll_Tick(object sender, EventArgs e)
        {
            if (songNameLabel.Location.X == -songNameLabel.Width)
            {
                counter = 0;
            }
            songNameLabel.Location = new Point(songNamePanel.Width - counter, songNameLabel.Location.Y);
            counter++;
        }

        private void SongNamePanel_MouseHover(object sender, EventArgs e)
        {
            timerScroll.Stop();
            counter = 0;
            songNameLabel.Location = new Point(0, songNameLabel.Location.Y);
        }

        private void LoadedPlaylistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = loadedPlaylistBox.SelectedIndex;
            musicPlayer.URL = playlist.AllSongs[index].PathToSong;
            songNameLabel.Text = playlist.AllSongs[index].Name;
            musicPlayer.controls.play();
        }
        
        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            index = rnd.Next(0, playlist.AllSongs.Count);
            musicPlayer.URL = playlist.AllSongs[index].PathToSong;
            songNameLabel.Text = playlist.AllSongs[index].Name;
            musicPlayer.controls.play();
        }
    }

    public class Song
    {
        public string Name { get; set; }

        public string PathToSong { get; set; }

    }

    public class Playlist
    {
        public List<Song> AllSongs { get; set; }

        public string CoverPath { get; set; }
    }
}
