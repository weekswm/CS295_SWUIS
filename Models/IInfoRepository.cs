using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace StarWarsUniverseInfoSite.Models
{
    public interface IInfoRepository
    {
        /*List<Story> Stories { get; }
        void AddStory(Story story);
        Story GetUserStoryByTitle(string title);*/

        List<Species> SWSpecies { get; }
        void AddSpecies(Species species);
        Species GetSpeciesBySpeciesName(string speciesName);

        List<Planet> Planets { get; }
        void AddPlanet(Planet planet);
        Planet GetPlanetByName(string name);

        List<Vehicle> Vehicles { get; }
        void AddVehicle(Vehicle vehicle);
        Vehicle GetVehicleByName(string name);

        List<Starship> Starships { get; }
        void AddStarship(Starship starship);
        Starship GetStarshipByName(string name);
    }
}
