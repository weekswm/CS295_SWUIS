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