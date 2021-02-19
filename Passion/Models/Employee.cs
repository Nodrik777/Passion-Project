using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Passion.Models
{
    public class Employee
    {

        [Key]
        public int EmployeeID { get; set; }

        public string EmployeeFName { get; set; }

        public string EmployeeLName { get; set; }

        public DateTime EmployeeHireDate { get; set; }
        public string EmployeeBio { get; set; }

        [ForeignKey("Species")]
        public int SpeciesID { get; set; }
        public virtual Species Species { get; set; }


        //Utilizes the inverse property to specify the "Many"
        //https://www.entityframeworktutorial.net/code-first/inverseproperty-dataannotations-attribute-in-code-first.aspx
        //One Sponsor Many Teams
        
    }

    public class EmpolyeeDto
    {
        
        public int EmployeeID { get; set; }
        
        public string EmployeeFName { get; set; }
       
        public string EmployeeLName { get; set; }
        
        public DateTime EmployeeHireDate { get; set; }
       
        public string EmployeeBio { get; set; }
        
        public int SpeciesID { get; set; }
    }
}