using Microsoft.EntityFrameworkCore;
using WebApplicationBasic.Core.Models;

namespace WebApplicationBasic.Persistence
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Make> Makes {get;set;}
        public DbSet<Model> Models {get;set;}
        public DbSet<Feature> Features {get;set;}
        public VegaDbContext(DbContextOptions<VegaDbContext> options) 
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            // To Define Composite Key
            modelBuilder.Entity<VehicleFeature>().HasKey(vf => new {vf.VehicleId, vf.FeatureId});
        }
    }
}