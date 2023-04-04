using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Album_Songs_EF.Model;
using Microsoft.EntityFrameworkCore;

namespace Album_Songs_EF
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }
        MusicDbContext dbContext = new MusicDbContext();
        private void btn_createAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an instance of Album class
                Album album = new Album();
                album.AlbumName = txt_albumName.Text;
                album.Released = dtp_releaseDate.Value;

                //Add the album instance to the database
                dbContext.Albums.Add(album);
                dbContext.SaveChanges();

                //Show message and reset the fields
                lbl_albumMessage.Text = "Album is successfully created.";
                lbl_albumMessage.ForeColor = Color.DarkOliveGreen;
                txt_albumName.Text = "";
                dtp_releaseDate.Value = DateTime.Now;
                
            }
            catch (Exception ex)
            {
                lbl_albumMessage.Text = "An error has occured. More info: " + ex.Message;
            }
        }
        private void tab_albumAndSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_albumAndSongs.SelectedTab == tab_listAlbumSong)
            {
                lst_albums.DisplayMember = "AlbumName";
                lst_albums.ValueMember = "AlbumId";
                lst_albums.DataSource = dbContext.Albums.ToList();
            }
            else if (tab_albumAndSongs.SelectedTab == tab_songs)
            {
                comboBox_albums.DisplayMember = "AlbumName";
                comboBox_albums.ValueMember = "AlbumId";
                comboBox_albums.DataSource = dbContext.Albums.ToList();
            }
        }

        private void btn_createSongs_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an instance of Song class
                Song song = new Song();
                song.Title = txt_songTitle.Text;
                song.Length = int.Parse(txt_lengthSeconds.Text);
                song.AlbumId = (int)comboBox_albums.SelectedValue;

                //Add the song instance to the database
                dbContext.Songs.Add(song);
                dbContext.SaveChanges();

                //Show message and reset the fields
                lbl_songMessage.Text = "Song is successfully created.";
                lbl_songMessage.ForeColor = Color.DarkOliveGreen;
                txt_songTitle.Text = "";
                txt_lengthSeconds.Text = "";
            }
            catch (Exception ex)
            {
                lbl_songMessage.Text = "An error has occured. More info: " + ex.Message;
            }
        }

        private void btn_showSongs_Click(object sender, EventArgs e)
        {
            int selectedAlbumId = (int)lst_albums.SelectedValue;

            List<Song> filteredSongs = dbContext.Songs.Where(s => s.AlbumId == selectedAlbumId).ToList();

            lst_songs.DataSource = filteredSongs;
            lst_songs.ValueMember = "Id";
            lst_songs.DisplayMember = "Title";
        }
    }
}
