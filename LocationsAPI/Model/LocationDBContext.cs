using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationsAPI.Model
{
    public class LocationDBContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }

        public LocationDBContext(DbContextOptions<LocationDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().ToTable("Location");
        }
    }
}
