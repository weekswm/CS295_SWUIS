using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StarWarsUniverseInfoSite.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Species> SWSpecies { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Starship> Starships { get; set; }
    }
}
