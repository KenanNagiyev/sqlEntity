using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp43.Models
{
    class Writer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookWriter> BookWriters { get; set; }
    }
}
