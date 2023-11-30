using Microsoft.EntityFrameworkCore;

using SyncPoint365.Core.Entities;

namespace SyncPoint365.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = default!;
        public DbSet<Country> Countries { get; set; } = default!;
        public DbSet<Company> Companies { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<AbsenceRequest> AbsenceRequests { get; set; } = default!;
        public DbSet<Competency> Competencies { get; set; } = default!;
        public DbSet<VrstaKompetencije> VrstaKompetencija { get; set; } = default!;

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}
