using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4projekt3.Model
{
    public class WorkDBContext : DbContext
    {
        public WorkDBContext()
        {

        }
        public DbSet<KierowcaModel>Kierowca { get; set; }
        public DbSet<AutobusModel>Autobus { get; set; }

        public WorkDBContext(DbContextOptions<WorkDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutobusModel>()
                .HasMany(x => x.KierowcaId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }
    }
}
