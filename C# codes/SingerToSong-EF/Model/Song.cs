using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SingerToSong_EF.Model
{
    public class Song
    {
        public int Id { get; set; }

        [MinLength(2), MaxLength(50)]
        public string Title { get; set; }

        [Range(30, 600)]
        public int Length { get; set; }

        //Navigation property to indicate the parent entity
        //A song can have ONLY ONE album
        public Album ParentAlbum { get; set; }

        //Defining the foreign key
        [ForeignKey("ParentAlbum")]
        public int AlbumId { get; set; }
    }
}
