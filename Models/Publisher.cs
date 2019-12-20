using System;
using System.Collections.Generic;

namespace netcoremvc.Models
{
    public class Publisher
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}