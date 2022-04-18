using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp43.Models
{
    class BookWriter
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int WriterId { get; set; }
        public Books Book { get; set; }
        public Writer Writers { get; set; }
    }
}
