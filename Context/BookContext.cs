using Microsoft.EntityFrameworkCore;
using ZeissMVCDemo.Models;

namespace ZeissMVCDemo.Context
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
    }
}
