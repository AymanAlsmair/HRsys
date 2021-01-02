using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRSystem.Models
{
    public class VMdept
    {
        public Department Dept { set; get; }
        public List<Department> lisDept { set; get; }
    }
}