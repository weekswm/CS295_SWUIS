using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace StarWarsUniverseInfoSite.Models
{
    public class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.SWSpecies.Any()) // only do this if it hasn't been done already
            {
                Species species = new Species()
                {
                    SpeciesName = "Wookiee",
                    Classification = "mammal",
                    Designation = "sentient",
                    AvgHeight = 210,
                    Language = "Shyriiwook",
                    AvgLifeSpan = 400
                };
                species.Homeworld = new Planet
                {
                    PlanetName = "Kashyyyk",
                    RotationalPeriod = 26,
                    OrbitalPeriod = 381,
                    Diameter = 12765,
                    Climate = "tropical",
                    Gravity = 1
                };
                context.SWSpecies.Add(species);
                context.Planets.Add(species.Homeworld);
                context.SaveChanges(); // save all the data
            }
        }
    }
}
