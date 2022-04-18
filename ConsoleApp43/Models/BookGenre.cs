using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp43.Models
{
    class BookGenre
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int GenreId { get; set; }
        public Books Book { get; set; }
        public Genre Genre { get; set; }
    }
}
