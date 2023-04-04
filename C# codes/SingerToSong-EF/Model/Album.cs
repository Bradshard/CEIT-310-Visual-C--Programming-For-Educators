using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SingerToSong_EF.Model
{
    [Table("AlbumRecords")]
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        [MinLength(3), MaxLength(150)]
        public string AlbumName { get; set; }
        [Column("ReleaseDate")]
        public DateTime Released { get; set; }
        [NotMapped]
        public int Length { get; set; }

        //Naviagtion property to indicate the child entity
        //An album can have many songs

        public List<Song> Songs { get; set; }

        //Defining the foreign key
        [ForeignKey("ParentSinger")]
        public int SingerId { get; set; }
    }
}
