
namespace Album_Songs_EF
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
            this.tab_albumAndSongs = new System.Windows.Forms.TabControl();
            this.tab_albums = new System.Windows.Forms.TabPage();
            this.lbl_albumMessage = new System.Windows.Forms.Label();
            this.btn_createAlbum = new System.Windows.Forms.Button();
            this.lbl_releaseDate = new System.Windows.Forms.Label();
            this.lbl_albumName = new System.Windows.Forms.Label();
            this.dtp_releaseDate = new System.Windows.Forms.DateTimePicker();
            this.txt_albumName = new System.Windows.Forms.TextBox();
            this.tab_songs = new System.Windows.Forms.TabPage();
            this.comboBox_albums = new System.Windows.Forms.ComboBox();
            this.lbl_songMessage = new System.Windows.Forms.Label();
            this.txt_lengthSeconds = new System.Windows.Forms.TextBox();
            this.txt_songTitle = new System.Windows.Forms.TextBox();
            this.lbl_albums = new System.Windows.Forms.Label();
            this.lbl_lengthSeconds = new System.Windows.Forms.Label();
            this.btn_createSongs = new System.Windows.Forms.Button();
            this.lbl_songTitle = new System.Windows.Forms.Label();
            this.tab_listAlbumSong = new System.Windows.Forms.TabPage();
            this.btn_showSongs = new System.Windows.Forms.Button();
            this.lst_songs = new System.Windows.Forms.ListBox();
            this.lst_albums = new System.Windows.Forms.ListBox();
            this.tab_albumAndSongs.SuspendLayout();
            this.tab_albums.SuspendLayout();
            this.tab_songs.SuspendLayout();
            this.tab_listAlbumSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_albumAndSongs
            // 
            this.tab_albumAndSongs.Controls.Add(this.tab_albums);
            this.tab_albumAndSongs.Controls.Add(this.tab_songs);
            this.tab_albumAndSongs.Controls.Add(this.tab_listAlbumSong);
            this.tab_albumAndSongs.Location = new System.Drawing.Point(46, 32);
            this.tab_albumAndSongs.Name = "tab_albumAndSongs";
            this.tab_albumAndSongs.SelectedIndex = 0;
            this.tab_albumAndSongs.Size = new System.Drawing.Size(425, 257);
            this.tab_albumAndSongs.TabIndex = 0;
            this.tab_albumAndSongs.SelectedIndexChanged += new System.EventHandler(this.tab_albumAndSongs_SelectedIndexChanged);
            // 
            // tab_albums
            // 
            this.tab_albums.Controls.Add(this.lbl_albumMessage);
            this.tab_albums.Controls.Add(this.btn_createAlbum);
            this.tab_albums.Controls.Add(this.lbl_releaseDate);
            this.tab_albums.Controls.Add(this.lbl_albumName);
            this.tab_albums.Controls.Add(this.dtp_releaseDate);
            this.tab_albums.Controls.Add(this.txt_albumName);
            this.tab_albums.Location = new System.Drawing.Point(4, 29);
            this.tab_albums.Name = "tab_albums";
            this.tab_albums.Padding = new System.Windows.Forms.Padding(3);
            this.tab_albums.Size = new System.Drawing.Size(417, 224);
            this.tab_albums.TabIndex = 0;
            this.tab_albums.Text = "Manage Albums";
            this.tab_albums.UseVisualStyleBackColor = true;
            // 
            // lbl_albumMessage
            // 
            this.lbl_albumMessage.AutoSize = true;
            this.lbl_albumMessage.Location = new System.Drawing.Point(22, 177);
            this.lbl_albumMessage.Name = "lbl_albumMessage";
            this.lbl_albumMessage.Size = new System.Drawing.Size(221, 20);
            this.lbl_albumMessage.TabIndex = 5;
            this.lbl_albumMessage.Text = "Fill the form to create an album.";
            // 
            // btn_createAlbum
            // 
            this.btn_createAlbum.Location = new System.Drawing.Point(283, 147);
            this.btn_createAlbum.Name = "btn_createAlbum";
            this.btn_createAlbum.Size = new System.Drawing.Size(94, 29);
            this.btn_createAlbum.TabIndex = 4;
            this.btn_createAlbum.Text = "Create";
            this.btn_createAlbum.UseVisualStyleBackColor = true;
            this.btn_createAlbum.Click += new System.EventHandler(this.btn_createAlbum_Click);
            // 
            // lbl_releaseDate
            // 
            this.lbl_releaseDate.AutoSize = true;
            this.lbl_releaseDate.Location = new System.Drawing.Point(22, 92);
            this.lbl_releaseDate.Name = "lbl_releaseDate";
            this.lbl_releaseDate.Size = new System.Drawing.Size(99, 20);
            this.lbl_releaseDate.TabIndex = 3;
            this.lbl_releaseDate.Text = "Release Date:";
            // 
            // lbl_albumName
            // 
            this.lbl_albumName.AutoSize = true;
            this.lbl_albumName.Location = new System.Drawing.Point(22, 33);
            this.lbl_albumName.Name = "lbl_albumName";
            this.lbl_albumName.Size = new System.Drawing.Size(100, 20);
            this.lbl_albumName.TabIndex = 2;
            this.lbl_albumName.Text = "Album Name:";
            // 
            // dtp_releaseDate
            // 
            this.dtp_releaseDate.Location = new System.Drawing.Point(127, 87);
            this.dtp_releaseDate.Name = "dtp_releaseDate";
            this.dtp_releaseDate.Size = new System.Drawing.Size(250, 27);
            this.dtp_releaseDate.TabIndex = 1;
            // 
            // txt_albumName
            // 
            this.txt_albumName.Location = new System.Drawing.Point(127, 30);
            this.txt_albumName.Name = "txt_albumName";
            this.txt_albumName.Size = new System.Drawing.Size(250, 27);
            this.txt_albumName.TabIndex = 0;
            // 
            // tab_songs
            // 
            this.tab_songs.Controls.Add(this.comboBox_albums);
            this.tab_songs.Controls.Add(this.lbl_songMessage);
            this.tab_songs.Controls.Add(this.txt_lengthSeconds);
            this.tab_songs.Controls.Add(this.txt_songTitle);
            this.tab_songs.Controls.Add(this.lbl_albums);
            this.tab_songs.Controls.Add(this.lbl_lengthSeconds);
            this.tab_songs.Controls.Add(this.btn_createSongs);
            this.tab_songs.Controls.Add(this.lbl_songTitle);
            this.tab_songs.Location = new System.Drawing.Point(4, 29);
            this.tab_songs.Name = "tab_songs";
            this.tab_songs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_songs.Size = new System.Drawing.Size(417, 224);
            this.tab_songs.TabIndex = 1;
            this.tab_songs.Text = "Manage Songs";
            this.tab_songs.UseVisualStyleBackColor = true;
            // 
            // comboBox_albums
            // 
            this.comboBox_albums.FormattingEnabled = true;
            this.comboBox_albums.Location = new System.Drawing.Point(154, 120);
            this.comboBox_albums.Name = "comboBox_albums";
            this.comboBox_albums.Size = new System.Drawing.Size(191, 28);
            this.comboBox_albums.TabIndex = 8;
            // 
            // lbl_songMessage
            // 
            this.lbl_songMessage.AutoSize = true;
            this.lbl_songMessage.Location = new System.Drawing.Point(35, 198);
            this.lbl_songMessage.Name = "lbl_songMessage";
            this.lbl_songMessage.Size = new System.Drawing.Size(203, 20);
            this.lbl_songMessage.TabIndex = 7;
            this.lbl_songMessage.Text = "Fill the form to create a song.";
            // 
            // txt_lengthSeconds
            // 
            this.txt_lengthSeconds.Location = new System.Drawing.Point(154, 77);
            this.txt_lengthSeconds.Name = "txt_lengthSeconds";
            this.txt_lengthSeconds.Size = new System.Drawing.Size(191, 27);
            this.txt_lengthSeconds.TabIndex = 5;
            // 
            // txt_songTitle
            // 
            this.txt_songTitle.Location = new System.Drawing.Point(154, 33);
            this.txt_songTitle.Name = "txt_songTitle";
            this.txt_songTitle.Size = new System.Drawing.Size(191, 27);
            this.txt_songTitle.TabIndex = 4;
            // 
            // lbl_albums
            // 
            this.lbl_albums.AutoSize = true;
            this.lbl_albums.Location = new System.Drawing.Point(35, 123);
            this.lbl_albums.Name = "lbl_albums";
            this.lbl_albums.Size = new System.Drawing.Size(60, 20);
            this.lbl_albums.TabIndex = 3;
            this.lbl_albums.Text = "Album :";
            // 
            // lbl_lengthSeconds
            // 
            this.lbl_lengthSeconds.AutoSize = true;
            this.lbl_lengthSeconds.Location = new System.Drawing.Point(35, 80);
            this.lbl_lengthSeconds.Name = "lbl_lengthSeconds";
            this.lbl_lengthSeconds.Size = new System.Drawing.Size(113, 20);
            this.lbl_lengthSeconds.TabIndex = 2;
            this.lbl_lengthSeconds.Text = "Length in Secs. :";
            // 
            // btn_createSongs
            // 
            this.btn_createSongs.Location = new System.Drawing.Point(251, 162);
            this.btn_createSongs.Name = "btn_createSongs";
            this.btn_createSongs.Size = new System.Drawing.Size(94, 29);
            this.btn_createSongs.TabIndex = 1;
            this.btn_createSongs.Text = "Create";
            this.btn_createSongs.UseVisualStyleBackColor = true;
            this.btn_createSongs.Click += new System.EventHandler(this.btn_createSongs_Click);
            // 
            // lbl_songTitle
            // 
            this.lbl_songTitle.AutoSize = true;
            this.lbl_songTitle.Location = new System.Drawing.Point(35, 36);
            this.lbl_songTitle.Name = "lbl_songTitle";
            this.lbl_songTitle.Size = new System.Drawing.Size(79, 20);
            this.lbl_songTitle.TabIndex = 0;
            this.lbl_songTitle.Text = "Song Title:";
            // 
            // tab_listAlbumSong
            // 
            this.tab_listAlbumSong.Controls.Add(this.btn_showSongs);
            this.tab_listAlbumSong.Controls.Add(this.lst_songs);
            this.tab_listAlbumSong.Controls.Add(this.lst_albums);
            this.tab_listAlbumSong.Location = new System.Drawing.Point(4, 29);
            this.tab_listAlbumSong.Name = "tab_listAlbumSong";
            this.tab_listAlbumSong.Padding = new System.Windows.Forms.Padding(3);
            this.tab_listAlbumSong.Size = new System.Drawing.Size(417, 224);
            this.tab_listAlbumSong.TabIndex = 2;
            this.tab_listAlbumSong.Text = "List Albums and Songs";
            this.tab_listAlbumSong.UseVisualStyleBackColor = true;
            // 
            // btn_showSongs
            // 
            this.btn_showSongs.Location = new System.Drawing.Point(25, 171);
            this.btn_showSongs.Name = "btn_showSongs";
            this.btn_showSongs.Size = new System.Drawing.Size(186, 29);
            this.btn_showSongs.TabIndex = 2;
            this.btn_showSongs.Text = "Show Songs";
            this.btn_showSongs.UseVisualStyleBackColor = true;
            this.btn_showSongs.Click += new System.EventHandler(this.btn_showSongs_Click);
            // 
            // lst_songs
            // 
            this.lst_songs.FormattingEnabled = true;
            this.lst_songs.ItemHeight = 20;
            this.lst_songs.Location = new System.Drawing.Point(229, 17);
            this.lst_songs.Name = "lst_songs";
            this.lst_songs.Size = new System.Drawing.Size(186, 184);
            this.lst_songs.TabIndex = 1;
            // 
            // lst_albums
            // 
            this.lst_albums.FormattingEnabled = true;
            this.lst_albums.ItemHeight = 20;
            this.lst_albums.Location = new System.Drawing.Point(25, 17);
            this.lst_albums.Name = "lst_albums";
            this.lst_albums.Size = new System.Drawing.Size(186, 144);
            this.lst_albums.TabIndex = 0;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 320);
            this.Controls.Add(this.tab_albumAndSongs);
            this.Name = "Frm_Main";
            this.Text = "Song Album Listing Form";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.tab_albumAndSongs.ResumeLayout(false);
            this.tab_albums.ResumeLayout(false);
            this.tab_albums.PerformLayout();
            this.tab_songs.ResumeLayout(false);
            this.tab_songs.PerformLayout();
            this.tab_listAlbumSong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_albumAndSongs;
        private System.Windows.Forms.TabPage tab_albums;
        private System.Windows.Forms.Label lbl_releaseDate;
        private System.Windows.Forms.Label lbl_albumName;
        private System.Windows.Forms.DateTimePicker dtp_releaseDate;
        private System.Windows.Forms.TextBox txt_albumName;
        private System.Windows.Forms.TabPage tab_songs;
        private System.Windows.Forms.TabPage tab_listAlbumSong;
        private System.Windows.Forms.Label lbl_albumMessage;
        private System.Windows.Forms.Button btn_createAlbum;
        private System.Windows.Forms.Button btn_showSongs;
        private System.Windows.Forms.ListBox lst_songs;
        private System.Windows.Forms.ListBox lst_albums;
        private System.Windows.Forms.ComboBox comboBox_albums;
        private System.Windows.Forms.Label lbl_songMessage;
        private System.Windows.Forms.TextBox txt_lengthSeconds;
        private System.Windows.Forms.TextBox txt_songTitle;
        private System.Windows.Forms.Label lbl_albums;
        private System.Windows.Forms.Label lbl_lengthSeconds;
        private System.Windows.Forms.Button btn_createSongs;
        private System.Windows.Forms.Label lbl_songTitle;
    }
}

