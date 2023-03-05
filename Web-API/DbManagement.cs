using Microsoft.EntityFrameworkCore;
using Web_API.Models;

namespace Web_API
{
    public class DbManagement : DbContext
    {
        public DbManagement(DbContextOptions<DbManagement> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Patient> patients { get; set; }
    }
}

