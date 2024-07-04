using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace Repositories
{
    public class APIDbContext : DbContext
    {
     
        public APIDbContext(DbContextOptions options) : base(options) { }
        #region Dbset
        public DbSet<Book> Customers { get; set; }
        #endregion

    }
}
