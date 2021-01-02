using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRSystem.Models
{
    public class Employee
    {
        public int ID { set; get; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Field can't be empty")]
        public string FirstName { set; get; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Field can't be empty")]
        public string LastName { set; get; }

        [Required(ErrorMessage = "Provided phone number not valid")]
        [RegularExpression(@"07(7|8|9)\d{7}")]
        public string Phone { set; get; }

        [Display(Name = "Gender")]
        public int Gender_id { set; get; }


        [Display(Name = "Country")]
        [ForeignKey("Cnt")]
        public int Country_id { set; get; }


        [Display(Name = "City")]
        [ForeignKey("Cty")]
        public int City_id { set; get; }
        public string Address { set; get; }

        [Required(ErrorMessage = "Field can't be empty")]
        
        public string Email { set; get; }

        [Required(ErrorMessage = "Field can't be empty")]
        public double salary { set; get; }

        [Display(Name = "Expected Salary")]
        [Required(ErrorMessage = "Field can't be empty")]
        public double ExpectedSalary { set; get; }

        [Display(Name = "Department")]
        [ForeignKey("Dept")]
        public int Department_id { set; get; }

        [Display(Name = "Date")]
        [DateValidation(ErrorMessage = "A valid Date or Date and Time must be entered eg. January 1, 2014 12:00AM")]
        public DateTime hireDate { set; get; }

        public Country Cnt { get; set; }
        public City Cty { get; set; }
        public Department Dept { get; set; }


        public string ImagePath { set; get; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { set; get; }

    }
}