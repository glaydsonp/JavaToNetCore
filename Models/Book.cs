using System;

namespace netcoremvc.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int PublisherId { get; set; }
        public decimal Price { get; set; }
        public Publisher Publisher { get; set; }
    }
}