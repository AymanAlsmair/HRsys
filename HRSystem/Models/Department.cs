using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HRSystem.Models
{
    public class Department
    {
        public int ID { set; get; }

        [Required(ErrorMessage = "Field can't be empty")]
        [Display(Name ="Department Name")]
        public string name { set; get; }

        [Display(Name = "Department Description")]
        public string Description { set; get; }

        public List<Employee> lisdep { set; get; }
    }
}