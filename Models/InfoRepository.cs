using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StarWarsUniverseInfoSite.Models
{
    public class InfoRepository : IInfoRepository
    {
        private AppDbContext context;
        public InfoRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        private List<Planet> planets = new List<Planet>();

        public List<Planet> Planets { get { return context.Planets.ToList(); } }
        public void AddPlanet(Planet planet)
        {
            context.Planets.Add(planet);
            context.SaveChanges();
        }

        public Planet GetPlanetByName(string name)
        {
            Planet planet = planets.Find(p => p.PlanetName == name);
            return planet;
        }

        //private List<Species> speciesList = new List<Species>();

        public List<Species> SWSpecies { get { return context.SWSpecies.ToList(); } }
        public void AddSpecies(Species species)
        {
            context.SWSpecies.Add(species);
            context.SaveChanges();
        }
        public Species GetSpeciesBySpeciesName(string speciesName)
        {
            Species species = context.SWSpecies.ToList().Find(s => s.SpeciesName == speciesName);
            return species;
        }

        private List<Vehicle> vehicles = new List<Vehicle>();

        public List<Vehicle> Vehicles { get { return context.Vehicles.ToList(); } }
        public void AddVehicle(Vehicle vehicle)
        {
            context.Vehicles.Add(vehicle);
            context.SaveChanges();
        }
        public Vehicle GetVehicleByName(string name)
        {
            Vehicle vehicle = vehicles.Find(s => s.Name == name);
            return vehicle;
        }

        private List<Starship> starships = new List<Starship>();

        public List<Starship> Starships { get { return context.Starships.ToList(); } }
        public void AddStarship(Starship starship)
        {
            context.Starships.Add(starship);
            context.SaveChanges();
        }
        public Starship GetStarshipByName(string name)
        {
            Starship starship = starships.Find(s => s.Name == name);
            return starship;
        }

    }
}
