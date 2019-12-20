using Microsoft.EntityFrameworkCore;

namespace netcoremvc.Models
{
    public class AuthorContext : DbContext
    {
        public AuthorContext()
        {

        }
        public AuthorContext(DbContextOptions<AuthorContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
    }
}