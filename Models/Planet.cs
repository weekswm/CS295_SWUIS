using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsUniverseInfoSite.Models
{
    public class Planet
    {
        private List<Planet> planets = new List<Planet>();
        private List<Species> speciesList = new List<Species>();

        public int PlanetID { get; set; }
        public string PlanetName { get; set; }
        public int RotationalPeriod { get; set; }
        public int OrbitalPeriod { get; set; }
        public int Diameter { get; set; }
        public string Climate { get; set; }
        public int Gravity { get; set; }

        public List<Planet> Planets { get { return planets; } }
        public List<Species> SWSpecies { get { return speciesList; } }
    }
}
