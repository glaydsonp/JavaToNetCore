using Microsoft.EntityFrameworkCore;
using netcoremvc.Data.Maps;
using netcoremvc.Models;

namespace netcoremvc.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,8000;Database=livraria;User ID=SA;Password=Root@123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new PublisherMap());
        }
    }
}