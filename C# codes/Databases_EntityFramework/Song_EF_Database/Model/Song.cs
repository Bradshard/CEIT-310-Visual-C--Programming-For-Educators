using System;
using System.Collections.Generic;
using System.Text;

namespace SongsToDatabase.Model
{
    public class Song
    {
        public int Id { get; set; }
        public string Song_Title { get; set; }
        public string Singer { get; set; }
        public string Album { get; set; }
    }
}
