using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsUniverseInfoSite.Models
{
    public class Vehicle
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public int VehicleID { get; set; }
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

        public List<Vehicle> Vehicles { get { return vehicles; } }
    }
}
