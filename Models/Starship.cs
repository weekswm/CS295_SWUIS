using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsUniverseInfoSite.Models
{
    public class Starship
    {
        private List<Starship> starships = new List<Starship>();

        //public int StarshipID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Cost { get; set; }
        public double Length { get; set; }
        public string MaxAtmoshperingSpeed { get; set; }
        public int Passengers { get; set; }
        public int CargoCapacity { get; set; }
        public int Consumables { get; set; }
        public int Class { get; set; }
        public string HyperdriveRating { get; set; }
        public string MGLT { get; set; }

        public List<Starship> Starships { get { return starships; } }
    }
}
