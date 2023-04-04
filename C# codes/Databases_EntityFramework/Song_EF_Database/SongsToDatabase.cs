using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SongsToDatabase.Model;

namespace SongsToDatabase
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            BindSongs();
        }
        public void BindSongs()
        {
            SongToDbContext _db = new SongToDbContext();

            lst_songs.DataSource = _db.Songs.ToList();
            lst_songs.ValueMember = "Id";
            lst_songs.DisplayMember = "Song_Title";
        }

        private void btn_addSong_Click(object sender, EventArgs e)
        {
            {
                Song mysong = new Song();
                mysong.Song_Title = txt_songTitle.Text;
                mysong.Singer = txt_singer.Text;
                mysong.Album = txt_album.Text;

                SongToDbContext _db = new SongToDbContext();
                _db.Songs.Add(mysong);

                _db.SaveChanges();

                BindSongs();
            }
        }
    }
}
