using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingerToSong_EF.Model;

namespace SingerToSong_EF
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
        MusicToDatabase dbContext = new MusicToDatabase();
        List<Song> filteredSongs = new List<Song>();
        private void btn_createSinger_Click(object sender, EventArgs e)
        {
            try
            {
                Singer singer = new Singer();
                singer.SingerName = txt_singerName.Text;
                singer.SingerSurname = txt_singerSurname.Text;
                singer.ActiveFrom = int.Parse(txt_activeSince.Text);

                //Add the singer instance to the database
                dbContext.Singers.Add(singer);
                dbContext.SaveChanges();

                //Show message and reset the fields
                lbl_singerMessage.Text = "Singer is successfully created. ";
                lbl_singerMessage.ForeColor = Color.DarkOliveGreen;
                txt_singerName.Text = "";
                txt_singerSurname.Text = "";
                txt_activeSince.Text = "";
            }
            catch(Exception ex)
            {
                lbl_singerMessage.Text = "An error has occured. More info: " + ex.Message;
            }
        }

        private void btn_createAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an instance of Album class
                Album album = new Album();
                album.AlbumName = txt_albumName.Text;
                album.Released = dtp_dateReleased.Value;
                album.SingerId = (int)comboBox_albumSinger.SelectedValue;

                //Add the album instance to the database
                dbContext.Albums.Add(album);
                dbContext.SaveChanges();

                //Show message and reset the fields
                lbl_albumMessage.Text = "Album is successfully created.";
                lbl_albumMessage.ForeColor = Color.DarkOliveGreen;
                txt_albumName.Text = "";
                dtp_dateReleased.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                lbl_albumMessage.Text = "An error has occured. More info: " + ex.Message;
            }
        }
        private void tab_singerAlbumSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_singerAlbumSong.SelectedTab == tab_singerAlbumAndSongs)
            {
                lst_singers.DisplayMember = "SingerName";
                lst_singers.ValueMember = "SingerId";
                lst_singers.DataSource = dbContext.Singers.ToList();

            }
            else if (tab_singerAlbumSong.SelectedTab == tab_songs)
            {
                comboBox_albums.DisplayMember = "AlbumName";
                comboBox_albums.ValueMember = "AlbumId";
                comboBox_albums.DataSource = dbContext.Albums.ToList();
            }
            else if (tab_singerAlbumSong.SelectedTab == tab_albums)
            {
                comboBox_albumSinger.DisplayMember = "SingerName";
                comboBox_albumSinger.ValueMember = "SingerId";
                comboBox_albumSinger.DataSource = dbContext.Singers.ToList();
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

        private void btn_showAlbums_Click(object sender, EventArgs e)
        {
            int selectedSingerId = (int)lst_singers.SelectedValue;

            List<Album> filteredAlbums = dbContext.Albums.Where(s => s.SingerId == selectedSingerId).ToList();

            lst_albums.DataSource = filteredAlbums;
            lst_albums.ValueMember = "AlbumId";
            lst_albums.DisplayMember = "AlbumName";
        }

        private void btn_showSongs_Click(object sender, EventArgs e)
        {
            int selectedAlbumId = (int)lst_albums.SelectedValue;

            List<Song> filteredSongs = dbContext.Songs.Where(s => s.AlbumId == selectedAlbumId).ToList();

            lst_songs.DataSource = filteredSongs;
            lst_songs.ValueMember = "Id";
            lst_songs.DisplayMember = "Title";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int selectedSongId = (int)lst_songs.SelectedValue;
            Song songdeletion = dbContext.Songs.Single(d => d.Id == selectedSongId);
            filteredSongs.Remove(dbContext.Songs.Single(d => d.Id == selectedSongId));

            lst_songs.DataSource = filteredSongs;
            lst_songs.ValueMember = "Id";
            lst_songs.DisplayMember = "Title";

            dbContext.Songs.Remove(songdeletion);
            dbContext.SaveChanges();
        }
        /* To this project upper letter and lowercase letter limitation with a restriction of
         * not entering same singer, album or song limitation to limit someone enter same song
         repetitively, will try that in future time :)*/
    }
}
