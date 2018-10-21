namespace MusicPlayer
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.createPlaylistButton = new System.Windows.Forms.Button();
            this.loadPlaylistButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.loadPlaylistPanel = new System.Windows.Forms.Panel();
            this.randomButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seekBarPanel = new System.Windows.Forms.Panel();
            this.songDurationLabel = new System.Windows.Forms.Label();
            this.currentProgressLabel = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.songNamePanel = new System.Windows.Forms.Panel();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.loadPlaylistLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.loadedPlaylistBox = new System.Windows.Forms.ListBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.loadCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.backToMainButton2 = new System.Windows.Forms.Button();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.aboutBackbutton = new System.Windows.Forms.Button();
            this.createPlaylistPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.backToMainbutton = new System.Windows.Forms.Button();
            this.removeSongButton = new System.Windows.Forms.Button();
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.createPlaylistLabel = new System.Windows.Forms.Label();
            this.savePlaylistButton = new System.Windows.Forms.Button();
            this.coverArtPictureBox = new System.Windows.Forms.PictureBox();
            this.addSongButton = new System.Windows.Forms.Button();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStripLoadMenu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerScroll = new System.Windows.Forms.Timer(this.components);
            this.loadPlaylistPanel.SuspendLayout();
            this.seekBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.songNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadCoverPictureBox)).BeginInit();
            this.aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.createPlaylistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverArtPictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.statusStripLoadMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // createPlaylistButton
            // 
            this.createPlaylistButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createPlaylistButton.Location = new System.Drawing.Point(305, 224);
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.Size = new System.Drawing.Size(200, 60);
            this.createPlaylistButton.TabIndex = 9;
            this.createPlaylistButton.Text = "CREATE PLAYLIST";
            this.createPlaylistButton.UseVisualStyleBackColor = true;
            this.createPlaylistButton.Click += new System.EventHandler(this.CreatePlaylistButton_Click);
            this.createPlaylistButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // loadPlaylistButton
            // 
            this.loadPlaylistButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPlaylistButton.Location = new System.Drawing.Point(305, 311);
            this.loadPlaylistButton.Name = "loadPlaylistButton";
            this.loadPlaylistButton.Size = new System.Drawing.Size(200, 60);
            this.loadPlaylistButton.TabIndex = 10;
            this.loadPlaylistButton.Text = "PLAY PLAYLIST";
            this.loadPlaylistButton.UseVisualStyleBackColor = true;
            this.loadPlaylistButton.Click += new System.EventHandler(this.LoadPlaylistButton_Click);
            this.loadPlaylistButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.SystemColors.Control;
            this.aboutButton.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(305, 400);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(200, 60);
            this.aboutButton.TabIndex = 11;
            this.aboutButton.Text = "ABOUT";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            this.aboutButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // loadPlaylistPanel
            // 
            this.loadPlaylistPanel.BackgroundImage = global::MusicPlayer.Properties.Resources.finalRSTtest;
            this.loadPlaylistPanel.Controls.Add(this.randomButton);
            this.loadPlaylistPanel.Controls.Add(this.label1);
            this.loadPlaylistPanel.Controls.Add(this.seekBarPanel);
            this.loadPlaylistPanel.Controls.Add(this.songNamePanel);
            this.loadPlaylistPanel.Controls.Add(this.loadPlaylistLabel);
            this.loadPlaylistPanel.Controls.Add(this.loadButton);
            this.loadPlaylistPanel.Controls.Add(this.loadedPlaylistBox);
            this.loadPlaylistPanel.Controls.Add(this.previousButton);
            this.loadPlaylistPanel.Controls.Add(this.nextButton);
            this.loadPlaylistPanel.Controls.Add(this.loadCoverPictureBox);
            this.loadPlaylistPanel.Controls.Add(this.pauseButton);
            this.loadPlaylistPanel.Controls.Add(this.stopButton);
            this.loadPlaylistPanel.Controls.Add(this.playButton);
            this.loadPlaylistPanel.Controls.Add(this.backToMainButton2);
            this.loadPlaylistPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadPlaylistPanel.Location = new System.Drawing.Point(0, 0);
            this.loadPlaylistPanel.Name = "loadPlaylistPanel";
            this.loadPlaylistPanel.Size = new System.Drawing.Size(792, 603);
            this.loadPlaylistPanel.TabIndex = 27;
            this.loadPlaylistPanel.Visible = false;
            this.loadPlaylistPanel.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // randomButton
            // 
            this.randomButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.randomButton.Location = new System.Drawing.Point(497, 513);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(97, 41);
            this.randomButton.TabIndex = 42;
            this.randomButton.Text = "RANDOM";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Play Playlist";
            // 
            // seekBarPanel
            // 
            this.seekBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.seekBarPanel.Controls.Add(this.songDurationLabel);
            this.seekBarPanel.Controls.Add(this.currentProgressLabel);
            this.seekBarPanel.Controls.Add(this.trackBar);
            this.seekBarPanel.Location = new System.Drawing.Point(13, 420);
            this.seekBarPanel.Name = "seekBarPanel";
            this.seekBarPanel.Size = new System.Drawing.Size(357, 64);
            this.seekBarPanel.TabIndex = 40;
            // 
            // songDurationLabel
            // 
            this.songDurationLabel.AutoSize = true;
            this.songDurationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.songDurationLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songDurationLabel.ForeColor = System.Drawing.Color.White;
            this.songDurationLabel.Location = new System.Drawing.Point(312, 20);
            this.songDurationLabel.Name = "songDurationLabel";
            this.songDurationLabel.Size = new System.Drawing.Size(44, 18);
            this.songDurationLabel.TabIndex = 36;
            this.songDurationLabel.Text = "00:00";
            // 
            // currentProgressLabel
            // 
            this.currentProgressLabel.AutoSize = true;
            this.currentProgressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.currentProgressLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentProgressLabel.ForeColor = System.Drawing.Color.White;
            this.currentProgressLabel.Location = new System.Drawing.Point(3, 20);
            this.currentProgressLabel.Name = "currentProgressLabel";
            this.currentProgressLabel.Size = new System.Drawing.Size(44, 18);
            this.currentProgressLabel.TabIndex = 37;
            this.currentProgressLabel.Text = "00:00";
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.trackBar.Location = new System.Drawing.Point(53, 15);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(254, 56);
            this.trackBar.TabIndex = 35;
            this.trackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // songNamePanel
            // 
            this.songNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.songNamePanel.Controls.Add(this.songNameLabel);
            this.songNamePanel.Location = new System.Drawing.Point(11, 89);
            this.songNamePanel.Name = "songNamePanel";
            this.songNamePanel.Size = new System.Drawing.Size(358, 30);
            this.songNamePanel.TabIndex = 39;
            this.songNamePanel.MouseLeave += new System.EventHandler(this.SongNamePanel_MouseLeave);
            this.songNamePanel.MouseHover += new System.EventHandler(this.SongNamePanel_MouseHover);
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songNameLabel.ForeColor = System.Drawing.Color.White;
            this.songNameLabel.Location = new System.Drawing.Point(0, 5);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(97, 20);
            this.songNameLabel.TabIndex = 40;
            this.songNameLabel.Text = "Song Name";
            this.songNameLabel.MouseEnter += new System.EventHandler(this.SongNamePanel_MouseHover);
            // 
            // loadPlaylistLabel
            // 
            this.loadPlaylistLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(41)))));
            this.loadPlaylistLabel.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadPlaylistLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loadPlaylistLabel.Location = new System.Drawing.Point(73, 42);
            this.loadPlaylistLabel.Name = "loadPlaylistLabel";
            this.loadPlaylistLabel.Size = new System.Drawing.Size(40, 5);
            this.loadPlaylistLabel.TabIndex = 33;
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(600, 513);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(178, 41);
            this.loadButton.TabIndex = 32;
            this.loadButton.Text = "LOAD PLAYLIST";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            this.loadButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // loadedPlaylistBox
            // 
            this.loadedPlaylistBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.loadedPlaylistBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadedPlaylistBox.ForeColor = System.Drawing.Color.White;
            this.loadedPlaylistBox.FormattingEnabled = true;
            this.loadedPlaylistBox.HorizontalScrollbar = true;
            this.loadedPlaylistBox.ItemHeight = 20;
            this.loadedPlaylistBox.Location = new System.Drawing.Point(497, 119);
            this.loadedPlaylistBox.Name = "loadedPlaylistBox";
            this.loadedPlaylistBox.Size = new System.Drawing.Size(278, 384);
            this.loadedPlaylistBox.TabIndex = 31;
            this.loadedPlaylistBox.SelectedIndexChanged += new System.EventHandler(this.LoadedPlaylistBox_SelectedIndexChanged);
            // 
            // previousButton
            // 
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previousButton.Image = global::MusicPlayer.Properties.Resources.icons8_skip_to_start_26;
            this.previousButton.Location = new System.Drawing.Point(43, 505);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(50, 50);
            this.previousButton.TabIndex = 30;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            this.previousButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Image = global::MusicPlayer.Properties.Resources.icons8_end_26;
            this.nextButton.Location = new System.Drawing.Point(297, 505);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(50, 50);
            this.nextButton.TabIndex = 29;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.nextButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // loadCoverPictureBox
            // 
            this.loadCoverPictureBox.Image = global::MusicPlayer.Properties.Resources.Uninstall_Groove_Music_from_Windows_10_thumb;
            this.loadCoverPictureBox.Location = new System.Drawing.Point(13, 119);
            this.loadCoverPictureBox.Name = "loadCoverPictureBox";
            this.loadCoverPictureBox.Size = new System.Drawing.Size(357, 303);
            this.loadCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadCoverPictureBox.TabIndex = 28;
            this.loadCoverPictureBox.TabStop = false;
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseButton.Image = global::MusicPlayer.Properties.Resources.icons8_pause_26;
            this.pauseButton.Location = new System.Drawing.Point(99, 505);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(50, 50);
            this.pauseButton.TabIndex = 26;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            this.pauseButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Image = global::MusicPlayer.Properties.Resources.icons8_stop_26;
            this.stopButton.Location = new System.Drawing.Point(241, 505);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(50, 50);
            this.stopButton.TabIndex = 25;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            this.stopButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playButton.Image = global::MusicPlayer.Properties.Resources.icons8_play_50;
            this.playButton.Location = new System.Drawing.Point(155, 490);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(80, 80);
            this.playButton.TabIndex = 24;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.Playbutton_Click);
            this.playButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // backToMainButton2
            // 
            this.backToMainButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.backToMainButton2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMainButton2.Image = global::MusicPlayer.Properties.Resources.icons8_back_26;
            this.backToMainButton2.Location = new System.Drawing.Point(13, 38);
            this.backToMainButton2.Name = "backToMainButton2";
            this.backToMainButton2.Size = new System.Drawing.Size(40, 41);
            this.backToMainButton2.TabIndex = 29;
            this.backToMainButton2.UseVisualStyleBackColor = true;
            this.backToMainButton2.Click += new System.EventHandler(this.BackToMainbutton_Click);
            this.backToMainButton2.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackgroundImage = global::MusicPlayer.Properties.Resources.finalRSTtest;
            this.aboutPanel.Controls.Add(this.label2);
            this.aboutPanel.Controls.Add(this.logoPictureBox);
            this.aboutPanel.Controls.Add(this.label3);
            this.aboutPanel.Controls.Add(this.aboutLabel);
            this.aboutPanel.Controls.Add(this.aboutBackbutton);
            this.aboutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutPanel.Location = new System.Drawing.Point(0, 0);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(792, 603);
            this.aboutPanel.TabIndex = 28;
            this.aboutPanel.Visible = false;
            this.aboutPanel.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(41)))));
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(73, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 5);
            this.label2.TabIndex = 33;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::MusicPlayer.Properties.Resources.majna;
            this.logoPictureBox.Location = new System.Drawing.Point(255, 164);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(299, 400);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 32;
            this.logoPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(240, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 48);
            this.label3.TabIndex = 31;
            this.label3.Text = "The application is developed by:\r\nNikolay Kyurkchiyski 1701681001";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.aboutLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutLabel.Location = new System.Drawing.Point(70, 52);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(63, 24);
            this.aboutLabel.TabIndex = 28;
            this.aboutLabel.Text = "About";
            // 
            // aboutBackbutton
            // 
            this.aboutBackbutton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutBackbutton.Image = global::MusicPlayer.Properties.Resources.icons8_back_26;
            this.aboutBackbutton.Location = new System.Drawing.Point(13, 38);
            this.aboutBackbutton.Name = "aboutBackbutton";
            this.aboutBackbutton.Size = new System.Drawing.Size(40, 41);
            this.aboutBackbutton.TabIndex = 27;
            this.aboutBackbutton.UseVisualStyleBackColor = true;
            this.aboutBackbutton.Click += new System.EventHandler(this.BackToMainbutton_Click);
            this.aboutBackbutton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // createPlaylistPanel
            // 
            this.createPlaylistPanel.BackgroundImage = global::MusicPlayer.Properties.Resources.finalRSTtest;
            this.createPlaylistPanel.Controls.Add(this.label4);
            this.createPlaylistPanel.Controls.Add(this.selectImageButton);
            this.createPlaylistPanel.Controls.Add(this.backToMainbutton);
            this.createPlaylistPanel.Controls.Add(this.removeSongButton);
            this.createPlaylistPanel.Controls.Add(this.playlistBox);
            this.createPlaylistPanel.Controls.Add(this.createPlaylistLabel);
            this.createPlaylistPanel.Controls.Add(this.savePlaylistButton);
            this.createPlaylistPanel.Controls.Add(this.coverArtPictureBox);
            this.createPlaylistPanel.Controls.Add(this.addSongButton);
            this.createPlaylistPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createPlaylistPanel.Location = new System.Drawing.Point(0, 0);
            this.createPlaylistPanel.Name = "createPlaylistPanel";
            this.createPlaylistPanel.Size = new System.Drawing.Size(792, 603);
            this.createPlaylistPanel.TabIndex = 13;
            this.createPlaylistPanel.Visible = false;
            this.createPlaylistPanel.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(41)))));
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(73, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 5);
            this.label4.TabIndex = 28;
            // 
            // selectImageButton
            // 
            this.selectImageButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectImageButton.Location = new System.Drawing.Point(11, 428);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(178, 41);
            this.selectImageButton.TabIndex = 27;
            this.selectImageButton.Text = "SELECT IMAGE";
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            this.selectImageButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // backToMainbutton
            // 
            this.backToMainbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMainbutton.Image = global::MusicPlayer.Properties.Resources.icons8_back_26;
            this.backToMainbutton.Location = new System.Drawing.Point(13, 38);
            this.backToMainbutton.Name = "backToMainbutton";
            this.backToMainbutton.Size = new System.Drawing.Size(40, 41);
            this.backToMainbutton.TabIndex = 26;
            this.backToMainbutton.UseVisualStyleBackColor = true;
            this.backToMainbutton.Click += new System.EventHandler(this.BackToMainbutton_Click);
            this.backToMainbutton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // removeSongButton
            // 
            this.removeSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeSongButton.Image = global::MusicPlayer.Properties.Resources.icons8_subtract_26;
            this.removeSongButton.Location = new System.Drawing.Point(611, 513);
            this.removeSongButton.Name = "removeSongButton";
            this.removeSongButton.Size = new System.Drawing.Size(50, 50);
            this.removeSongButton.TabIndex = 25;
            this.removeSongButton.UseVisualStyleBackColor = true;
            this.removeSongButton.Click += new System.EventHandler(this.RemoveSongButton_Click);
            this.removeSongButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // playlistBox
            // 
            this.playlistBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playlistBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playlistBox.ForeColor = System.Drawing.Color.White;
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.HorizontalScrollbar = true;
            this.playlistBox.ItemHeight = 20;
            this.playlistBox.Location = new System.Drawing.Point(497, 119);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(278, 384);
            this.playlistBox.TabIndex = 24;
            // 
            // createPlaylistLabel
            // 
            this.createPlaylistLabel.AutoSize = true;
            this.createPlaylistLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.createPlaylistLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPlaylistLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.createPlaylistLabel.Location = new System.Drawing.Point(70, 52);
            this.createPlaylistLabel.Name = "createPlaylistLabel";
            this.createPlaylistLabel.Size = new System.Drawing.Size(140, 24);
            this.createPlaylistLabel.TabIndex = 21;
            this.createPlaylistLabel.Text = "Create Playlist";
            // 
            // savePlaylistButton
            // 
            this.savePlaylistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePlaylistButton.Image = global::MusicPlayer.Properties.Resources.icons8_save_26;
            this.savePlaylistButton.Location = new System.Drawing.Point(667, 513);
            this.savePlaylistButton.Name = "savePlaylistButton";
            this.savePlaylistButton.Size = new System.Drawing.Size(50, 50);
            this.savePlaylistButton.TabIndex = 20;
            this.savePlaylistButton.UseVisualStyleBackColor = true;
            this.savePlaylistButton.Click += new System.EventHandler(this.SavePlaylistButton_Click);
            this.savePlaylistButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // coverArtPictureBox
            // 
            this.coverArtPictureBox.Image = global::MusicPlayer.Properties.Resources.Uninstall_Groove_Music_from_Windows_10_thumb;
            this.coverArtPictureBox.Location = new System.Drawing.Point(13, 119);
            this.coverArtPictureBox.Name = "coverArtPictureBox";
            this.coverArtPictureBox.Size = new System.Drawing.Size(357, 303);
            this.coverArtPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverArtPictureBox.TabIndex = 18;
            this.coverArtPictureBox.TabStop = false;
            // 
            // addSongButton
            // 
            this.addSongButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addSongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSongButton.Image = global::MusicPlayer.Properties.Resources.icons8_plus_math_26;
            this.addSongButton.Location = new System.Drawing.Point(555, 513);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(50, 50);
            this.addSongButton.TabIndex = 14;
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.SelectButton_Click);
            this.addSongButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // timerProgress
            // 
            this.timerProgress.Enabled = true;
            this.timerProgress.Tick += new System.EventHandler(this.TimerProgress_Tick);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.aboutToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(792, 25);
            this.toolStrip.TabIndex = 40;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(71, 22);
            this.toolStripDropDownButton1.Text = "Playlist";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreatePlaylistButton_Click);
            this.createToolStripMenuItem.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.loadToolStripMenuItem.Text = "Play";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadPlaylistButton_Click);
            this.loadToolStripMenuItem.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripButton.Image")));
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripButton.Text = "About";
            this.aboutToolStripButton.Click += new System.EventHandler(this.AboutButton_Click);
            this.aboutToolStripButton.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            // 
            // statusStripLoadMenu
            // 
            this.statusStripLoadMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripLoadMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStripLoadMenu.Location = new System.Drawing.Point(0, 580);
            this.statusStripLoadMenu.Name = "statusStripLoadMenu";
            this.statusStripLoadMenu.Size = new System.Drawing.Size(792, 23);
            this.statusStripLoadMenu.TabIndex = 41;
            this.statusStripLoadMenu.Text = "statusStripLoadMenu";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(94, 18);
            this.toolStripStatusLabel.Text = "Music Player";
            // 
            // timerScroll
            // 
            this.timerScroll.Interval = 20;
            this.timerScroll.Tick += new System.EventHandler(this.TimerScroll_Tick);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::MusicPlayer.Properties.Resources.finalFST;
            this.ClientSize = new System.Drawing.Size(792, 603);
            this.Controls.Add(this.statusStripLoadMenu);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.loadPlaylistPanel);
            this.Controls.Add(this.createPlaylistPanel);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.loadPlaylistButton);
            this.Controls.Add(this.createPlaylistButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.MouseHover += new System.EventHandler(this.StatusStripLoadMenu_MouseHover);
            this.loadPlaylistPanel.ResumeLayout(false);
            this.loadPlaylistPanel.PerformLayout();
            this.seekBarPanel.ResumeLayout(false);
            this.seekBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.songNamePanel.ResumeLayout(false);
            this.songNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadCoverPictureBox)).EndInit();
            this.aboutPanel.ResumeLayout(false);
            this.aboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.createPlaylistPanel.ResumeLayout(false);
            this.createPlaylistPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverArtPictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStripLoadMenu.ResumeLayout(false);
            this.statusStripLoadMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createPlaylistButton;
        private System.Windows.Forms.Button loadPlaylistButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Panel createPlaylistPanel;
        private System.Windows.Forms.Label createPlaylistLabel;
        private System.Windows.Forms.Button savePlaylistButton;
        private System.Windows.Forms.PictureBox coverArtPictureBox;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.ListBox playlistBox;
        private System.Windows.Forms.Button removeSongButton;
        private System.Windows.Forms.Button backToMainbutton;
        private System.Windows.Forms.Panel loadPlaylistPanel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ListBox loadedPlaylistBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox loadCoverPictureBox;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button backToMainButton2;
        private System.Windows.Forms.Label loadPlaylistLabel;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Button aboutBackbutton;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label currentProgressLabel;
        private System.Windows.Forms.Label songDurationLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.StatusStrip statusStripLoadMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Panel songNamePanel;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.Timer timerScroll;
        private System.Windows.Forms.Panel seekBarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button randomButton;
    }
}

