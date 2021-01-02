using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRSystem.Models
{
    public class Country
    {
        public int ID { set; get; }
        public string Name { set; get; }

        public List<Employee> liscnt { set; get; }

        
    }
}