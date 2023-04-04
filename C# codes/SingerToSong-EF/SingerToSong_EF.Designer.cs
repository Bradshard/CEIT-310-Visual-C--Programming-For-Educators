
namespace SingerToSong_EF
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_singerAlbumSong = new System.Windows.Forms.TabControl();
            this.tab_singers = new System.Windows.Forms.TabPage();
            this.lbl_activeSince = new System.Windows.Forms.Label();
            this.lbl_singerSurname = new System.Windows.Forms.Label();
            this.lbl_singerName = new System.Windows.Forms.Label();
            this.lbl_singerMessage = new System.Windows.Forms.Label();
            this.btn_createSinger = new System.Windows.Forms.Button();
            this.txt_activeSince = new System.Windows.Forms.TextBox();
            this.txt_singerSurname = new System.Windows.Forms.TextBox();
            this.txt_singerName = new System.Windows.Forms.TextBox();
            this.tab_albums = new System.Windows.Forms.TabPage();
            this.lbl_albumMessage = new System.Windows.Forms.Label();
            this.dtp_dateReleased = new System.Windows.Forms.DateTimePicker();
            this.comboBox_albumSinger = new System.Windows.Forms.ComboBox();
            this.txt_albumName = new System.Windows.Forms.TextBox();
            this.lbl_singerAlbum = new System.Windows.Forms.Label();
            this.lbl_releaseDate = new System.Windows.Forms.Label();
            this.lbl_albumName = new System.Windows.Forms.Label();
            this.btn_createAlbum = new System.Windows.Forms.Button();
            this.tab_songs = new System.Windows.Forms.TabPage();
            this.comboBox_albums = new System.Windows.Forms.ComboBox();
            this.txt_lengthSeconds = new System.Windows.Forms.TextBox();
            this.txt_songTitle = new System.Windows.Forms.TextBox();
            this.btn_createSongs = new System.Windows.Forms.Button();
            this.lbl_songMessage = new System.Windows.Forms.Label();
            this.lbl_albums = new System.Windows.Forms.Label();
            this.lbl_lengthSeconds = new System.Windows.Forms.Label();
            this.lbl_songTitle = new System.Windows.Forms.Label();
            this.tab_singerAlbumAndSongs = new System.Windows.Forms.TabPage();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_showSongs = new System.Windows.Forms.Button();
            this.lst_songs = new System.Windows.Forms.ListBox();
            this.lst_albums = new System.Windows.Forms.ListBox();
            this.btn_showAlbums = new System.Windows.Forms.Button();
            this.lst_singers = new System.Windows.Forms.ListBox();
            this.tab_singerAlbumSong.SuspendLayout();
            this.tab_singers.SuspendLayout();
            this.tab_albums.SuspendLayout();
            this.tab_songs.SuspendLayout();
            this.tab_singerAlbumAndSongs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_singerAlbumSong
            // 
            this.tab_singerAlbumSong.Controls.Add(this.tab_singers);
            this.tab_singerAlbumSong.Controls.Add(this.tab_albums);
            this.tab_singerAlbumSong.Controls.Add(this.tab_songs);
            this.tab_singerAlbumSong.Controls.Add(this.tab_singerAlbumAndSongs);
            this.tab_singerAlbumSong.Location = new System.Drawing.Point(36, 39);
            this.tab_singerAlbumSong.Name = "tab_singerAlbumSong";
            this.tab_singerAlbumSong.SelectedIndex = 0;
            this.tab_singerAlbumSong.Size = new System.Drawing.Size(704, 374);
            this.tab_singerAlbumSong.TabIndex = 0;
            this.tab_singerAlbumSong.SelectedIndexChanged += new System.EventHandler(this.tab_singerAlbumSong_SelectedIndexChanged);
            // 
            // tab_singers
            // 
            this.tab_singers.Controls.Add(this.lbl_activeSince);
            this.tab_singers.Controls.Add(this.lbl_singerSurname);
            this.tab_singers.Controls.Add(this.lbl_singerName);
            this.tab_singers.Controls.Add(this.lbl_singerMessage);
            this.tab_singers.Controls.Add(this.btn_createSinger);
            this.tab_singers.Controls.Add(this.txt_activeSince);
            this.tab_singers.Controls.Add(this.txt_singerSurname);
            this.tab_singers.Controls.Add(this.txt_singerName);
            this.tab_singers.Location = new System.Drawing.Point(4, 29);
            this.tab_singers.Name = "tab_singers";
            this.tab_singers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_singers.Size = new System.Drawing.Size(696, 341);
            this.tab_singers.TabIndex = 0;
            this.tab_singers.Text = "Manage Singers";
            this.tab_singers.UseVisualStyleBackColor = true;
            // 
            // lbl_activeSince
            // 
            this.lbl_activeSince.AutoSize = true;
            this.lbl_activeSince.Location = new System.Drawing.Point(63, 170);
            this.lbl_activeSince.Name = "lbl_activeSince";
            this.lbl_activeSince.Size = new System.Drawing.Size(96, 20);
            this.lbl_activeSince.TabIndex = 7;
            this.lbl_activeSince.Text = "Active Since :";
            // 
            // lbl_singerSurname
            // 
            this.lbl_singerSurname.AutoSize = true;
            this.lbl_singerSurname.Location = new System.Drawing.Point(63, 101);
            this.lbl_singerSurname.Name = "lbl_singerSurname";
            this.lbl_singerSurname.Size = new System.Drawing.Size(74, 20);
            this.lbl_singerSurname.TabIndex = 6;
            this.lbl_singerSurname.Text = "Surname :";
            // 
            // lbl_singerName
            // 
            this.lbl_singerName.AutoSize = true;
            this.lbl_singerName.Location = new System.Drawing.Point(63, 37);
            this.lbl_singerName.Name = "lbl_singerName";
            this.lbl_singerName.Size = new System.Drawing.Size(56, 20);
            this.lbl_singerName.TabIndex = 5;
            this.lbl_singerName.Text = "Name :";
            // 
            // lbl_singerMessage
            // 
            this.lbl_singerMessage.AutoSize = true;
            this.lbl_singerMessage.Location = new System.Drawing.Point(45, 276);
            this.lbl_singerMessage.Name = "lbl_singerMessage";
            this.lbl_singerMessage.Size = new System.Drawing.Size(211, 20);
            this.lbl_singerMessage.TabIndex = 4;
            this.lbl_singerMessage.Text = "Fill the form to create a singer.";
            // 
            // btn_createSinger
            // 
            this.btn_createSinger.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_createSinger.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_createSinger.Location = new System.Drawing.Point(266, 231);
            this.btn_createSinger.Name = "btn_createSinger";
            this.btn_createSinger.Size = new System.Drawing.Size(146, 29);
            this.btn_createSinger.TabIndex = 3;
            this.btn_createSinger.Text = "Create";
            this.btn_createSinger.UseVisualStyleBackColor = false;
            this.btn_createSinger.Click += new System.EventHandler(this.btn_createSinger_Click);
            // 
            // txt_activeSince
            // 
            this.txt_activeSince.Location = new System.Drawing.Point(217, 167);
            this.txt_activeSince.Name = "txt_activeSince";
            this.txt_activeSince.Size = new System.Drawing.Size(195, 27);
            this.txt_activeSince.TabIndex = 2;
            // 
            // txt_singerSurname
            // 
            this.txt_singerSurname.Location = new System.Drawing.Point(217, 98);
            this.txt_singerSurname.Name = "txt_singerSurname";
            this.txt_singerSurname.Size = new System.Drawing.Size(195, 27);
            this.txt_singerSurname.TabIndex = 1;
            // 
            // txt_singerName
            // 
            this.txt_singerName.Location = new System.Drawing.Point(217, 34);
            this.txt_singerName.Name = "txt_singerName";
            this.txt_singerName.Size = new System.Drawing.Size(195, 27);
            this.txt_singerName.TabIndex = 0;
            // 
            // tab_albums
            // 
            this.tab_albums.Controls.Add(this.lbl_albumMessage);
            this.tab_albums.Controls.Add(this.dtp_dateReleased);
            this.tab_albums.Controls.Add(this.comboBox_albumSinger);
            this.tab_albums.Controls.Add(this.txt_albumName);
            this.tab_albums.Controls.Add(this.lbl_singerAlbum);
            this.tab_albums.Controls.Add(this.lbl_releaseDate);
            this.tab_albums.Controls.Add(this.lbl_albumName);
            this.tab_albums.Controls.Add(this.btn_createAlbum);
            this.tab_albums.Location = new System.Drawing.Point(4, 29);
            this.tab_albums.Name = "tab_albums";
            this.tab_albums.Padding = new System.Windows.Forms.Padding(3);
            this.tab_albums.Size = new System.Drawing.Size(696, 341);
            this.tab_albums.TabIndex = 1;
            this.tab_albums.Text = "Manage Albums";
            this.tab_albums.UseVisualStyleBackColor = true;
            // 
            // lbl_albumMessage
            // 
            this.lbl_albumMessage.AutoSize = true;
            this.lbl_albumMessage.Location = new System.Drawing.Point(56, 275);
            this.lbl_albumMessage.Name = "lbl_albumMessage";
            this.lbl_albumMessage.Size = new System.Drawing.Size(221, 20);
            this.lbl_albumMessage.TabIndex = 8;
            this.lbl_albumMessage.Text = "Fill the form to create an album.";
            // 
            // dtp_dateReleased
            // 
            this.dtp_dateReleased.Location = new System.Drawing.Point(241, 98);
            this.dtp_dateReleased.Name = "dtp_dateReleased";
            this.dtp_dateReleased.Size = new System.Drawing.Size(250, 27);
            this.dtp_dateReleased.TabIndex = 7;
            // 
            // comboBox_albumSinger
            // 
            this.comboBox_albumSinger.FormattingEnabled = true;
            this.comboBox_albumSinger.Location = new System.Drawing.Point(241, 160);
            this.comboBox_albumSinger.Name = "comboBox_albumSinger";
            this.comboBox_albumSinger.Size = new System.Drawing.Size(250, 28);
            this.comboBox_albumSinger.TabIndex = 6;
            // 
            // txt_albumName
            // 
            this.txt_albumName.Location = new System.Drawing.Point(241, 39);
            this.txt_albumName.Name = "txt_albumName";
            this.txt_albumName.Size = new System.Drawing.Size(250, 27);
            this.txt_albumName.TabIndex = 4;
            // 
            // lbl_singerAlbum
            // 
            this.lbl_singerAlbum.AutoSize = true;
            this.lbl_singerAlbum.Location = new System.Drawing.Point(56, 168);
            this.lbl_singerAlbum.Name = "lbl_singerAlbum";
            this.lbl_singerAlbum.Size = new System.Drawing.Size(58, 20);
            this.lbl_singerAlbum.TabIndex = 3;
            this.lbl_singerAlbum.Text = "Singer :";
            // 
            // lbl_releaseDate
            // 
            this.lbl_releaseDate.AutoSize = true;
            this.lbl_releaseDate.Location = new System.Drawing.Point(56, 103);
            this.lbl_releaseDate.Name = "lbl_releaseDate";
            this.lbl_releaseDate.Size = new System.Drawing.Size(103, 20);
            this.lbl_releaseDate.TabIndex = 2;
            this.lbl_releaseDate.Text = "Release Date :";
            // 
            // lbl_albumName
            // 
            this.lbl_albumName.AutoSize = true;
            this.lbl_albumName.Location = new System.Drawing.Point(56, 39);
            this.lbl_albumName.Name = "lbl_albumName";
            this.lbl_albumName.Size = new System.Drawing.Size(104, 20);
            this.lbl_albumName.TabIndex = 1;
            this.lbl_albumName.Text = "Album Name :";
            // 
            // btn_createAlbum
            // 
            this.btn_createAlbum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_createAlbum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_createAlbum.Location = new System.Drawing.Point(328, 231);
            this.btn_createAlbum.Name = "btn_createAlbum";
            this.btn_createAlbum.Size = new System.Drawing.Size(163, 29);
            this.btn_createAlbum.TabIndex = 0;
            this.btn_createAlbum.Text = "Create";
            this.btn_createAlbum.UseVisualStyleBackColor = false;
            this.btn_createAlbum.Click += new System.EventHandler(this.btn_createAlbum_Click);
            // 
            // tab_songs
            // 
            this.tab_songs.Controls.Add(this.comboBox_albums);
            this.tab_songs.Controls.Add(this.txt_lengthSeconds);
            this.tab_songs.Controls.Add(this.txt_songTitle);
            this.tab_songs.Controls.Add(this.btn_createSongs);
            this.tab_songs.Controls.Add(this.lbl_songMessage);
            this.tab_songs.Controls.Add(this.lbl_albums);
            this.tab_songs.Controls.Add(this.lbl_lengthSeconds);
            this.tab_songs.Controls.Add(this.lbl_songTitle);
            this.tab_songs.Location = new System.Drawing.Point(4, 29);
            this.tab_songs.Name = "tab_songs";
            this.tab_songs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_songs.Size = new System.Drawing.Size(696, 341);
            this.tab_songs.TabIndex = 2;
            this.tab_songs.Text = "Manage Songs";
            this.tab_songs.UseVisualStyleBackColor = true;
            // 
            // comboBox_albums
            // 
            this.comboBox_albums.FormattingEnabled = true;
            this.comboBox_albums.Location = new System.Drawing.Point(297, 180);
            this.comboBox_albums.Name = "comboBox_albums";
            this.comboBox_albums.Size = new System.Drawing.Size(206, 28);
            this.comboBox_albums.TabIndex = 7;
            // 
            // txt_lengthSeconds
            // 
            this.txt_lengthSeconds.Location = new System.Drawing.Point(297, 117);
            this.txt_lengthSeconds.Name = "txt_lengthSeconds";
            this.txt_lengthSeconds.Size = new System.Drawing.Size(206, 27);
            this.txt_lengthSeconds.TabIndex = 6;
            // 
            // txt_songTitle
            // 
            this.txt_songTitle.Location = new System.Drawing.Point(297, 55);
            this.txt_songTitle.Name = "txt_songTitle";
            this.txt_songTitle.Size = new System.Drawing.Size(206, 27);
            this.txt_songTitle.TabIndex = 5;
            // 
            // btn_createSongs
            // 
            this.btn_createSongs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_createSongs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_createSongs.Location = new System.Drawing.Point(358, 238);
            this.btn_createSongs.Name = "btn_createSongs";
            this.btn_createSongs.Size = new System.Drawing.Size(145, 29);
            this.btn_createSongs.TabIndex = 4;
            this.btn_createSongs.Text = "Create";
            this.btn_createSongs.UseVisualStyleBackColor = false;
            this.btn_createSongs.Click += new System.EventHandler(this.btn_createSongs_Click);
            // 
            // lbl_songMessage
            // 
            this.lbl_songMessage.AutoSize = true;
            this.lbl_songMessage.Location = new System.Drawing.Point(76, 291);
            this.lbl_songMessage.Name = "lbl_songMessage";
            this.lbl_songMessage.Size = new System.Drawing.Size(203, 20);
            this.lbl_songMessage.TabIndex = 3;
            this.lbl_songMessage.Text = "Fill the form to create a song.";
            // 
            // lbl_albums
            // 
            this.lbl_albums.AutoSize = true;
            this.lbl_albums.Location = new System.Drawing.Point(99, 183);
            this.lbl_albums.Name = "lbl_albums";
            this.lbl_albums.Size = new System.Drawing.Size(60, 20);
            this.lbl_albums.TabIndex = 2;
            this.lbl_albums.Text = "Album :";
            // 
            // lbl_lengthSeconds
            // 
            this.lbl_lengthSeconds.AutoSize = true;
            this.lbl_lengthSeconds.Location = new System.Drawing.Point(99, 120);
            this.lbl_lengthSeconds.Name = "lbl_lengthSeconds";
            this.lbl_lengthSeconds.Size = new System.Drawing.Size(136, 20);
            this.lbl_lengthSeconds.TabIndex = 1;
            this.lbl_lengthSeconds.Text = "Length in Seconds :";
            // 
            // lbl_songTitle
            // 
            this.lbl_songTitle.AutoSize = true;
            this.lbl_songTitle.Location = new System.Drawing.Point(99, 58);
            this.lbl_songTitle.Name = "lbl_songTitle";
            this.lbl_songTitle.Size = new System.Drawing.Size(83, 20);
            this.lbl_songTitle.TabIndex = 0;
            this.lbl_songTitle.Text = "Song Title :";
            // 
            // tab_singerAlbumAndSongs
            // 
            this.tab_singerAlbumAndSongs.Controls.Add(this.btn_delete);
            this.tab_singerAlbumAndSongs.Controls.Add(this.btn_showSongs);
            this.tab_singerAlbumAndSongs.Controls.Add(this.lst_songs);
            this.tab_singerAlbumAndSongs.Controls.Add(this.lst_albums);
            this.tab_singerAlbumAndSongs.Controls.Add(this.btn_showAlbums);
            this.tab_singerAlbumAndSongs.Controls.Add(this.lst_singers);
            this.tab_singerAlbumAndSongs.Location = new System.Drawing.Point(4, 29);
            this.tab_singerAlbumAndSongs.Name = "tab_singerAlbumAndSongs";
            this.tab_singerAlbumAndSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_singerAlbumAndSongs.Size = new System.Drawing.Size(696, 341);
            this.tab_singerAlbumAndSongs.TabIndex = 3;
            this.tab_singerAlbumAndSongs.Text = "Singers, Albums and Songs";
            this.tab_singerAlbumAndSongs.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(473, 304);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(198, 29);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_showSongs
            // 
            this.btn_showSongs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_showSongs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_showSongs.Location = new System.Drawing.Point(239, 267);
            this.btn_showSongs.Name = "btn_showSongs";
            this.btn_showSongs.Size = new System.Drawing.Size(228, 29);
            this.btn_showSongs.TabIndex = 4;
            this.btn_showSongs.Text = "Show Songs >";
            this.btn_showSongs.UseVisualStyleBackColor = false;
            this.btn_showSongs.Click += new System.EventHandler(this.btn_showSongs_Click);
            // 
            // lst_songs
            // 
            this.lst_songs.FormattingEnabled = true;
            this.lst_songs.ItemHeight = 20;
            this.lst_songs.Location = new System.Drawing.Point(473, 33);
            this.lst_songs.Name = "lst_songs";
            this.lst_songs.Size = new System.Drawing.Size(198, 264);
            this.lst_songs.TabIndex = 3;
            // 
            // lst_albums
            // 
            this.lst_albums.FormattingEnabled = true;
            this.lst_albums.ItemHeight = 20;
            this.lst_albums.Location = new System.Drawing.Point(239, 33);
            this.lst_albums.Name = "lst_albums";
            this.lst_albums.Size = new System.Drawing.Size(227, 224);
            this.lst_albums.TabIndex = 2;
            // 
            // btn_showAlbums
            // 
            this.btn_showAlbums.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_showAlbums.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_showAlbums.Location = new System.Drawing.Point(25, 228);
            this.btn_showAlbums.Name = "btn_showAlbums";
            this.btn_showAlbums.Size = new System.Drawing.Size(208, 29);
            this.btn_showAlbums.TabIndex = 1;
            this.btn_showAlbums.Text = "Show Albums >";
            this.btn_showAlbums.UseVisualStyleBackColor = false;
            this.btn_showAlbums.Click += new System.EventHandler(this.btn_showAlbums_Click);
            // 
            // lst_singers
            // 
            this.lst_singers.FormattingEnabled = true;
            this.lst_singers.ItemHeight = 20;
            this.lst_singers.Location = new System.Drawing.Point(25, 33);
            this.lst_singers.Name = "lst_singers";
            this.lst_singers.Size = new System.Drawing.Size(208, 184);
            this.lst_singers.TabIndex = 0;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_singerAlbumSong);
            this.Name = "Frm_Main";
            this.Text = "SingerToSong_EF";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.tab_singerAlbumSong.ResumeLayout(false);
            this.tab_singers.ResumeLayout(false);
            this.tab_singers.PerformLayout();
            this.tab_albums.ResumeLayout(false);
            this.tab_albums.PerformLayout();
            this.tab_songs.ResumeLayout(false);
            this.tab_songs.PerformLayout();
            this.tab_singerAlbumAndSongs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_singerAlbumSong;
        private System.Windows.Forms.TabPage tab_singers;
        private System.Windows.Forms.TabPage tab_albums;
        private System.Windows.Forms.TabPage tab_songs;
        private System.Windows.Forms.TabPage tab_singerAlbumAndSongs;
        private System.Windows.Forms.Label lbl_activeSince;
        private System.Windows.Forms.Label lbl_singerSurname;
        private System.Windows.Forms.Label lbl_singerName;
        private System.Windows.Forms.Label lbl_singerMessage;
        private System.Windows.Forms.Button btn_createSinger;
        private System.Windows.Forms.TextBox txt_activeSince;
        private System.Windows.Forms.TextBox txt_singerSurname;
        private System.Windows.Forms.TextBox txt_singerName;
        private System.Windows.Forms.Label lbl_albumMessage;
        private System.Windows.Forms.DateTimePicker dtp_dateReleased;
        private System.Windows.Forms.ComboBox comboBox_albumSinger;
        private System.Windows.Forms.TextBox txt_albumName;
        private System.Windows.Forms.Label lbl_singerAlbum;
        private System.Windows.Forms.Label lbl_releaseDate;
        private System.Windows.Forms.Label lbl_albumName;
        private System.Windows.Forms.Button btn_createAlbum;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_showSongs;
        private System.Windows.Forms.ListBox lst_songs;
        private System.Windows.Forms.ListBox lst_albums;
        private System.Windows.Forms.Button btn_showAlbums;
        private System.Windows.Forms.ListBox lst_singers;
        private System.Windows.Forms.ComboBox comboBox_albums;
        private System.Windows.Forms.TextBox txt_lengthSeconds;
        private System.Windows.Forms.TextBox txt_songTitle;
        private System.Windows.Forms.Button btn_createSongs;
        private System.Windows.Forms.Label lbl_songMessage;
        private System.Windows.Forms.Label lbl_albums;
        private System.Windows.Forms.Label lbl_lengthSeconds;
        private System.Windows.Forms.Label lbl_songTitle;
    }
}

