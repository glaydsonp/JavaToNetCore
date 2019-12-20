using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netcoremvc.Data;
using netcoremvc.Models;

namespace netcoremvc.Repositories
{
    public class AuthorRepository
    {
        private readonly StoreDataContext _context;

        public AuthorRepository(StoreDataContext context)
        {
            _context = context;
        }

        public AuthorRepository()
        {
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

        public async Task<ActionResult<IEnumerable<Author>>> Get()
        {
            return await _context.Authors.Select(x => new Author
            {
                Id = x.Id,
                LName = x.LName,
                Fname = x.Fname,
            }).AsNoTracking().ToListAsync();
        }

        public Author Get(int id)
        {
            return _context.Authors.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }
        public Author Find(int id)
        {
            return _context.Authors.Find(id);
        }
        public void Save(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
        public void Update(Author author)
        {
            _context.Entry<Author>(author).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}