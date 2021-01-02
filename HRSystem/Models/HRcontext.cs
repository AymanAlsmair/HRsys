using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HRSystem.Models
{
    public class HRcontext : DbContext
    {
        public HRcontext() : base("name = abc") { }

        public virtual DbSet<Employee> EmpEntity { set; get; }
        public virtual DbSet<Department> DeptEntity { set; get; }
        public virtual DbSet<City> CityEntity { set; get; }
        public virtual DbSet<Country> CounEntity { set; get; }

    }
}