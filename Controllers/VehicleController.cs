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
        Starship starship;
        public VehicleController()
        {
            // This is temporary code, just for testing
            if (InfoRepository.Starships.Count == 0) // only do this if it hasn't been done already
            {
                starship = new Starship()
                {
                    Name = "Executor",
                    Model = "Executor-Class Star Dreadnought",
                    Manufacturer = "Kuat Drive Yards, Fondor Shipyards",
                    Cost = 1143350000,
                    Length = 19000,
                    MaxAtmoshperingSpeed = "N/A",
                    Crew = 279144,
                    Passengers = 38000,
                    CargoCapacity = 250000000,
                    Consumables = 72,
                    HyperdriveRating = 2.0,
                    Class = "Star Dreadnought"
                };
                InfoRepository.AddStarship(starship);
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
            }
        }
        public ViewResult Vehicle()
        {
            List<Vehicle> vehicles = InfoRepository.Vehicles;
            return View(vehicles);
        }

        public ViewResult Starship()
        {
            List<Starship> starships = InfoRepository.Starships;
            return View(starships);
        }
        [HttpPost]
        public RedirectToActionResult Starship(string starship)
        {
            Starship starshipPick = InfoRepository.GetStarshipByName(starship);
            // this is temporary, in the future the data will go in a database

            return RedirectToAction("ViewStarship", starshipPick);
        }

    }
}