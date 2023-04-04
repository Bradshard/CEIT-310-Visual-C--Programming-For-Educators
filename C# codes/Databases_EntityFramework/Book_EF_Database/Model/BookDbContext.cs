using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;

namespace BooksToDatabase.Model
{
    class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; } //a proxy to the Books table in the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookManagement_v1");
        }

    }
}
