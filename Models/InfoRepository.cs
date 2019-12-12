using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsUniverseInfoSite.Models
{
    public class InfoRepository : IInfoRepository
    {
        private List<Planet> planets = new List<Planet>();

        public List<Planet> Planets { get { return planets; } }
        public void AddPlanet(Planet planet)
        {
            planets.Add(planet);
        }

        public Planet GetPlanetByName(string name)
        {
            Planet planet = planets.Find(p => p.PlanetName == name);
            return planet;
        }

        private List<Species> speciesList = new List<Species>();

        public List<Species> SWSpecies { get { return speciesList; } }
        public void AddSpecies(Species species)
        {
            speciesList.Add(species);
        }
        public Species GetSpeciesBySpeciesName(string speciesName)
        {
            Species species = speciesList.Find(s => s.SpeciesName == speciesName);
            return species;
        }

        private List<Vehicle> vehicles = new List<Vehicle>();

        public List<Vehicle> Vehicles { get { return vehicles; } }
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
        public Vehicle GetVehicleByName(string name)
        {
            Vehicle vehicle = vehicles.Find(s => s.Name == name);
            return vehicle;
        }

        private List<Starship> starships = new List<Starship>();

        public List<Starship> Starships { get { return starships; } }
        public void AddStarship(Starship starship)
        {
            starships.Add(starship);
        }
        public Starship GetStarshipByName(string name)
        {
            Starship starship = starships.Find(s => s.Name == name);
            return starship;
        }

    }
}
