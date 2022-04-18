using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp43.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp43.DAL
{
    class AppDbContext:DbContext
    {
        internal object book;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-NRGGF91I\SQLEXPRESS;Database=BookSelling;Trusted_Connection=True;");
        }
        public DbSet<Books> Book { get; set; }
        public DbSet<Writer> Writer { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<BookWriter> BookWriters { get; set; }
        public DbSet<BookGenre> bookGenres { get; set; }
        public DbSet<Buying> buy { get; set; }
    }
}
