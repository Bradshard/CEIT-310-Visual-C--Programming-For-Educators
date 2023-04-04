using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SongsToDatabase.Model
{
    class SongToDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; } //a proxy to the Songs table in the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Song_Management");
        }
    }
}
