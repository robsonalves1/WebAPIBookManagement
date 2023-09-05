using Microsoft.EntityFrameworkCore;
using WebAPIBookManagement.Models;

namespace WebAPIBookManagement.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) { }

        public DbSet<Book> Book { get; set; }
    }
}
