using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWarsUniverseInfoSite.Models;

namespace StarWarsUniverseInfoSite.Controllers
{
    public class VehicleController : Controller
    {
        IInfoRepository repo;
        public VehicleController(IInfoRepository r)
        {
            repo = r;
        }
            // This is temporary code, just for testing
            /*if (InfoRepository.Starships.Count == 0) // only do this if it hasn't been done already
            {
                starship = new Starship()
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
                InfoRepository.AddStarship(starship);
            }*/
        
        public ViewResult Vehicle()
        {
            List<Vehicle> vehicles = repo.Vehicles;
            return View(vehicles);
        }

        public ViewResult Starship()
        {
            List<Starship> starship = repo.Starships;
            return View(starship);
        }

        public ViewResult ViewStarship(Starship starship)
        {
            List<Starship> starships = repo.Starships;
            return View(starship);
        }

        [HttpPost]
        public RedirectToActionResult Starship(string starshipDropdown)
        {
            Starship starship = repo.GetStarshipByName(starshipDropdown);
            // this is temporary, in the future the data will go in a database

            return RedirectToAction("ViewStarship", starship);
        }
    }
}