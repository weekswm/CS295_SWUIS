﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsUniverseInfoSite.Models
{
    public class Species
    {
        private List<Species> speciesList = new List<Species>();
        private List<Planet> planets = new List<Planet>();

        //public int SpeciesID { get; set; }
        public string SpeciesName { get; set; }
        public string Classification { get; set; }
        public string Designation { get; set; }
        public int AvgHeight { get; set; }
        public string Language { get; set; }
        public int AvgLifeSpan { get; set; }
        public Planet Homeworld { get; set; }

        public List<Species> SWSpecies { get { return speciesList; } }
        public List<Planet> Planets { get { return planets; } }
    }
}
