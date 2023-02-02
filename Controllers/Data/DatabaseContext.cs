using Microsoft.EntityFrameworkCore;

namespace HotelListing.Controllers.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {



        }

        public DbSet<Country> countries { get; set; }
        public DbSet<Hotel> hotels { get; set; }
    }
}
