using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Student_Engagement_Score_Form_EF_DB.Model
{
    class EngagementToDatabase : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Engagement> Engagements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EngagementManagement");
        }
    }
}
