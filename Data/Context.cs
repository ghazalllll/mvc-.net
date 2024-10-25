using Microsoft.EntityFrameworkCore;
using tamrin_ba_ghazale.Models;

namespace tamrin_ba_ghazale.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Race> Races { get; set; }

    }
}
