using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Passion.Models
{
    public class Pet
    {

        [Key]
        public int PetID { get; set; }

        public string PetName { get; set; }

        public string PetBreed { get; set; }

        public int PetWeight { get; set; }

        //Foreign keys in Entity Framework
        /// https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx

        //A player plays for one team
        [ForeignKey("Species")]
        public int SpeciesID { get; set; }
        public virtual Species Species { get; set; }
    }

    //This class can be used to transfer information about a player.
    //also known as a "Data Transfer Object"
    //https://docs.microsoft.com/en-us/aspnet/web-api/overview/data/using-web-api-with-entity-framework/part-5
    //You can think of this class as the 'Model' that was used in 5101.
    //It is simply a vessel of communication
    public class PetDto
    {
        [Key]

        public int PetID { get; set; }
     
        public string PetName { get; set; }
        
        public string PetBreed { get; set; }
       
        public int PetWeight { get; set; }
      
        public int SpeciesID { get; set; }
    }
}