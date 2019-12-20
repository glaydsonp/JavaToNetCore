using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using netcoremvc.Data;
using netcoremvc.Models;

namespace netcoremvc.Repositories
{
    public class PublisherRepository
    {
        private readonly StoreDataContext _context;

        public PublisherRepository(StoreDataContext context)
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

        public IEnumerable<Publisher> Get()
        {
            return _context.Publishers.Select(x => new Publisher
            {
                Id = x.Id,
                Name = x.Name,
                Url = x.Url
            }).AsNoTracking().ToList();
        }

        public Publisher Get(int id)
        {
            return _context.Publishers.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }
        public Publisher Find(int id)
        {
            return _context.Publishers.Find(id);
        }
        public void Save(Publisher Publisher)
        {
            _context.Publishers.Add(Publisher);
            _context.SaveChanges();
        }
        public void Update(Publisher Publisher)
        {
            _context.Entry<Publisher>(Publisher).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}