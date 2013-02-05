using System.Data.Entity;
using Domain.BooksFlowers;
using Domain.Entities;

namespace Domain
{
    public class BooksContext : DbContext
    {
        public BooksContext()
            : base("BooksContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
