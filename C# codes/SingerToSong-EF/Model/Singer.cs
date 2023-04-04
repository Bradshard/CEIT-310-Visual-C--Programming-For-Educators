using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SingerToSong_EF.Model
{
    [Table("SingerList")]
    public class Singer
    {
        [Key]
        public int SingerId { get; set; }

        [MinLength(3), MaxLength(50)]
        public string SingerName { get; set; }

        [MinLength(3), MaxLength(150)]
        public string SingerSurname
        {
            get; set;
        }
        [Column("ActiveSince")]
        public int ActiveFrom { get; set; }

        public List<Album> Albums { get; set; }
    }
}
