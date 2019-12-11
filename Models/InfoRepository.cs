using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsUniverseInfoSite.Models
{
    public class InfoRepository
    {
        private static List<Planet> planets = new List<Planet>();

        public static List<Planet> Planets { get { return planets; } }
        public static void AddPlanet(Planet planet)
        {
            planets.Add(planet);
        }

        private static List<Species> speciesList = new List<Species>();

        public static List<Species> SWSpecies { get { return speciesList; } }
        public static void AddSpecies(Species species)
        {
            speciesList.Add(species);
        }

        private static List<Vehicle> vehicles = new List<Vehicle>();

        public static List<Vehicle> Vehicles { get { return vehicles; } }
        public static void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        private static List<Starship> starships = new List<Starship>();

        public static List<Starship> Starships { get { return starships; } }
        public static void AddStarship(Starship starship)
        {
            starships.Add(starship);
        }
    }
}
