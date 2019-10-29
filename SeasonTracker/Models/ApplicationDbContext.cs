using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeasonTracker.Models
{
    // To Enable Migrations, once this file is completed:
    //  1) PM > Install-Package Microsoft.EntityFrameworkCore.Tools
    //  2) PM > EntityFrameworkCore\add-migration InitialCreate
    //  3) PM > EntityFrameworkCore\update-database
    public class ApplicationDbContext : DbContext
    {
        const string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SeasonTrackerWPF;Trusted_Connection=True;";

        public ApplicationDbContext() : base() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //Define DbSets for our entities:
        public DbSet<User> Users { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        //public static ApplicationDbContext Create()
        //{
        //    return new ApplicationDbContext();
        //}
    }
}
