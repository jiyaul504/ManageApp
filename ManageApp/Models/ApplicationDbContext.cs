using Microsoft.EntityFrameworkCore;

namespace ManageApp.Models
{
    public class ApplicationDbContext : DbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
         {

         }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
