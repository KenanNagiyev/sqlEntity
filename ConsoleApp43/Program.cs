using ConsoleApp43.DAL;
using ConsoleApp43.Models;
using System;

namespace ConsoleApp43
{
    class Program
    {
        public static int Buy { get; private set; }

        static void Main(string[] args)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                Books book = sql.Book.Find(1);//1 kitabin id-sidi.kitab table-sinde olan her hansi kitabin id-sini vermek olar
                book.StokCount--;
                sql.SaveChanges();
            }
        } 
    }
}
