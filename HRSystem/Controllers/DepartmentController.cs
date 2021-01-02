using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRSystem.Models;
namespace HRSystem.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            VMdept vm = new VMdept();
            vm.lisDept = new List<Department>();
            vm.Dept = new Department();

            return View("Department",vm);
        }

        public ActionResult savedata(VMdept vm)
        {
            if (ModelState.IsValid)
            { 
                HRcontext context = new HRcontext();
                context.DeptEntity.Add(vm.Dept);
                context.SaveChanges();
            }

            return View("Department");
        }

        public ActionResult search(VMdept vm)
        {
            HRcontext context = new HRcontext();
            vm.lisDept = new List<Department>();
            Department dpt = new Department();
            dpt.name = Request.Form["Dept.name"];

            //var x = from a in context.DeptEntity where a.name == dpt.name select a;

            vm.lisDept = context.DeptEntity.Where(a => a.name == dpt.name).ToList();

            //foreach(var z in x)
            //{
            //    dpt.name = z.name;
            //    dpt.Description = z.Description;
            //    vm.lisDept.Add(dpt);
            //}

            // vm.lisDept = context.DeptEntity.ToList();

            return View("depList",vm);
        }



        public ActionResult list()
        {
            VMdept vm = new VMdept();
            vm.lisDept = new List<Department>();
            return View("depList",vm);
        }
    }
}