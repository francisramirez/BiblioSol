
using BiblioSol.Domain.Base;
using BiblioSol.Domain.Entities.insurance;
using BiblioSol.Domain.Entities.users;
using Microsoft.EntityFrameworkCore;

namespace BiblioSol.Persistence.Context
{
    public class HealtSyncContext : DbContext
    {
        public HealtSyncContext(DbContextOptions<HealtSyncContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure your entities here if needed
        }

        public DbSet<Doctor> Doctors { get; set; }
      
        public DbSet<InsuranceProvider> InsuranceProviders { get; set; }

        public DbSet<NetworkType> NetworkTypes { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Person> Persons { get; set; }

   
    }
    
}
