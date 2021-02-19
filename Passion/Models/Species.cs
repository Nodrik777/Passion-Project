using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Passion.Models
{
    public class Species
    {
        public int SpeciesID { get; set; }

        public string SpeciesType { get; set; }

        public string SpeciesClass { get; set; }

        

        //A team can have many players
        public ICollection<Pet> Pets { get; set; }

        //A team can have many sponsors
        public ICollection<Employee> Employees { get; set; }
    }

    public class SpeciesDto
    {
        public int SpeciesID { get; set; }

        public string SpeciesType { get; set; }


        public string SpeciesClass { get; set; }
        
          

    }
}