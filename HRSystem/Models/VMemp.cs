using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRSystem.Models
{
    public class VMemp
    {
        public Employee emp { set; get; }

        public  List<Department> listDepartment { set; get; }
        public List<Employee> listEmployee { set; get; }
        public List<Country> lisCount { set; get; }
        public List<City> lisCity { set; get; }

    }
}