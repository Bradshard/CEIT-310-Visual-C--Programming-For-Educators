
namespace SongsToDatabase
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
            this.txt_songTitle = new System.Windows.Forms.TextBox();
            this.txt_singer = new System.Windows.Forms.TextBox();
            this.txt_album = new System.Windows.Forms.TextBox();
            this.lst_songs = new System.Windows.Forms.ListBox();
            this.btn_addSong = new System.Windows.Forms.Button();
            this.lbl_songTitle = new System.Windows.Forms.Label();
            this.lbl_singer = new System.Windows.Forms.Label();
            this.lbl_album = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_songTitle
            // 
            this.txt_songTitle.Location = new System.Drawing.Point(63, 81);
            this.txt_songTitle.Name = "txt_songTitle";
            this.txt_songTitle.Size = new System.Drawing.Size(204, 27);
            this.txt_songTitle.TabIndex = 0;
            // 
            // txt_singer
            // 
            this.txt_singer.Location = new System.Drawing.Point(63, 134);
            this.txt_singer.Name = "txt_singer";
            this.txt_singer.Size = new System.Drawing.Size(204, 27);
            this.txt_singer.TabIndex = 1;
            // 
            // txt_album
            // 
            this.txt_album.Location = new System.Drawing.Point(63, 187);
            this.txt_album.Name = "txt_album";
            this.txt_album.Size = new System.Drawing.Size(204, 27);
            this.txt_album.TabIndex = 2;
            // 
            // lst_songs
            // 
            this.lst_songs.FormattingEnabled = true;
            this.lst_songs.ItemHeight = 20;
            this.lst_songs.Location = new System.Drawing.Point(297, 78);
            this.lst_songs.Name = "lst_songs";
            this.lst_songs.Size = new System.Drawing.Size(206, 204);
            this.lst_songs.TabIndex = 3;
            // 
            // btn_addSong
            // 
            this.btn_addSong.Location = new System.Drawing.Point(63, 253);
            this.btn_addSong.Name = "btn_addSong";
            this.btn_addSong.Size = new System.Drawing.Size(204, 29);
            this.btn_addSong.TabIndex = 4;
            this.btn_addSong.Text = "Add Song";
            this.btn_addSong.UseVisualStyleBackColor = true;
            this.btn_addSong.Click += new System.EventHandler(this.btn_addSong_Click);
            // 
            // lbl_songTitle
            // 
            this.lbl_songTitle.AutoSize = true;
            this.lbl_songTitle.Location = new System.Drawing.Point(63, 58);
            this.lbl_songTitle.Name = "lbl_songTitle";
            this.lbl_songTitle.Size = new System.Drawing.Size(83, 20);
            this.lbl_songTitle.TabIndex = 5;
            this.lbl_songTitle.Text = "Song Title :";
            // 
            // lbl_singer
            // 
            this.lbl_singer.AutoSize = true;
            this.lbl_singer.Location = new System.Drawing.Point(63, 111);
            this.lbl_singer.Name = "lbl_singer";
            this.lbl_singer.Size = new System.Drawing.Size(58, 20);
            this.lbl_singer.TabIndex = 6;
            this.lbl_singer.Text = "Singer :";
            // 
            // lbl_album
            // 
            this.lbl_album.AutoSize = true;
            this.lbl_album.Location = new System.Drawing.Point(63, 164);
            this.lbl_album.Name = "lbl_album";
            this.lbl_album.Size = new System.Drawing.Size(60, 20);
            this.lbl_album.TabIndex = 7;
            this.lbl_album.Text = "Album :";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 337);
            this.Controls.Add(this.lbl_album);
            this.Controls.Add(this.lbl_singer);
            this.Controls.Add(this.lbl_songTitle);
            this.Controls.Add(this.btn_addSong);
            this.Controls.Add(this.lst_songs);
            this.Controls.Add(this.txt_album);
            this.Controls.Add(this.txt_singer);
            this.Controls.Add(this.txt_songTitle);
            this.Name = "Frm_Main";
            this.Text = "Song List Form";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_songTitle;
        private System.Windows.Forms.TextBox txt_singer;
        private System.Windows.Forms.TextBox txt_album;
        private System.Windows.Forms.ListBox lst_songs;
        private System.Windows.Forms.Button btn_addSong;
        private System.Windows.Forms.Label lbl_songTitle;
        private System.Windows.Forms.Label lbl_singer;
        private System.Windows.Forms.Label lbl_album;
    }
}

