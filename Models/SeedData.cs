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
                    AvgLifeSpan = 400,
                    Homeworld = "Kashyyyk"
                };
                context.SWSpecies.Add(species);
            }
            if (!context.Starships.Any()) // only do this if it hasn't been done already
            {
                Starship starship = new Starship()
                {
                    Name = "Millenium Falcon",
                    Model = "YT-1300 Light Freighter",
                    Manufacturer = "Corellian Engineering Corporation",
                    Cost = 100000,
                    Length = 34.37,
                    MaxAtmoshperingSpeed = "1050",
                    Crew = 4,
                    Passengers = 6,
                    CargoCapacity = 100000,
                    Consumables = 2,
                    HyperdriveRating = 0.5,
                    Class = "Light Freighter"
                };
                context.Starships.Add(starship);
            }
            context.SaveChanges(); // save all the data
        }
    }
}
