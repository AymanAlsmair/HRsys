using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace HRSystem.Models
{
    public class City
    {
        public int ID { set; get; }
        public string Name { set; get; }

        public List<Employee> liscity { set; get; }

        [ForeignKey("Cnt")]
        public int Country_ID { set; get; }
        public Country Cnt { set; get; }
    }
}