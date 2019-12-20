using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using netcoremvc.Data;
using netcoremvc.Models;

namespace netcoremvc.Repositories
{
    public class BookRepository
    {
        private readonly StoreDataContext _context;

        public BookRepository(StoreDataContext context)
        {
            _context = context;
        }

        // public IEnumerable<ListProductViewModel> Get()
        // {
        //     return _context.Products.Include(x => x.Category).Select(x => new ListProductViewModel
        //     {
        //         Id = x.Id,
        //         Title = x.Title,
        //         Price = x.Price,
        //         Category = x.Category.Title,
        //         CategoryId = x.CategoryId
        //     }).AsNoTracking().ToList();
        // }

        public IEnumerable<Book> Get()
        {
            return _context.Books.Include(x => x.Publisher).Select(x => new Book
            {
                Id = x.Id,
                Isbn = x.Isbn,
                Title = x.Title,
                PublisherId = x.PublisherId,
                Price = x.Price,
                Publisher = x.Publisher
            }).AsNoTracking().ToList();
        }

        public Book Get(int id)
        {
            return _context.Books.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }
        public Book Find(int id)
        {
            return _context.Books.Find(id);
        }
        public void Save(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void Update(Book book)
        {
            _context.Entry<Book>(book).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}