using Microsoft.EntityFrameworkCore;

namespace netcoremvc.Models
{
    public class PublisherContext : DbContext
    {
        public PublisherContext()
        {

        }
        public PublisherContext(DbContextOptions<PublisherContext> options)
            : base(options)
        {
        }

        public DbSet<Publisher> Publishers { get; set; }
    }
}