using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWarsUniverseInfoSite.Models;

namespace StarWarsUniverseInfoSite.Controllers
{
    public class PlanetController : Controller
    {
        Species species;
        public PlanetController()
        {
            // This is temporary code, just for testing
            if (InfoRepository.SWSpecies.Count == 0) // only do this if it hasn't been done already
            {
                species = new Species()
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
                InfoRepository.AddSpecies(species);
            }
        }
        public ViewResult Planet()
        {
            List<Planet> planets = InfoRepository.Planets;
            return View(planets);
        }

        public ViewResult Species()
        {
            List<Species> species = InfoRepository.SWSpecies;
            return View(species);
        }

        public ViewResult ViewSpecies(Species species)
        {
            return View(species);
        }

        [HttpPost]
        public RedirectToActionResult Species(string species)
        {
            Species speciesName = InfoRepository.GetSpeciesBySpeciesName(species);
            // this is temporary, in the future the data will go in a database

            return RedirectToAction("ViewSpecies", speciesName);
        }
    }
}