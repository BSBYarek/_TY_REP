using System.Data.Entity;
using Domain.Entities;

namespace Domain
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(string connectionString)
        {
            Database.Connection.ConnectionString = connectionString;
        }

        public DbSet<Book> Books { get; set; }
    }
}
