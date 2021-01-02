using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRSystem.Models;
namespace HRSystem.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            VMemp vm = new VMemp();
            HRcontext context = new HRcontext();
            vm.lisCity = new List<City>();
            vm.lisCount = new List<Country>();
            vm.listDepartment = new List<Department>();
            vm.emp = new Employee();

            // var x = from a in context.CounEntity select a;
//            var x = context.CounEntity.Select(a => new { a.ID, a.Name });
            //var s = from a in context.CityEntity select a;
  //          var s = context.CityEntity.Select(a => new { a.ID, a.Name });
            //var d = from a in context.DeptEntity select a;
    //        var d = context.DeptEntity.Select(a => new { a.ID, a.name});

            //foreach (var z in x)
            //{
            //    Country cnt = new Country();
            //    cnt.ID = z.ID;
            //    cnt.Name = z.Name;
            //    vm.lisCount.Add(cnt);
            //}

            vm.lisCount = context.CounEntity.ToList();


            //foreach (var z in s)
            //{
            //    City ct = new City();
            //    ct.ID = z.ID;
            //    ct.Name = z.Name;
            //    vm.lisCity.Add(ct);
            //}

            vm.lisCity = context.CityEntity.ToList();

            //foreach( var z in d)
            //{
            //    Department dpt = new Department();
            //    dpt.ID = z.ID;
            //    dpt.name = z.name;
            //    vm.listDepartment.Add(dpt);
            //}
            vm.listDepartment = context.DeptEntity.ToList();
            
            return View("Emp",vm);
        }

        public ActionResult savedata(VMemp vm)
        {

            if (ModelState.IsValid)
            {

                HRcontext context = new HRcontext();
                vm.lisCity = new List<City>();
                vm.lisCount = new List<Country>();
                vm.listDepartment = new List<Department>();


                vm.emp.ImageFile.SaveAs(@"C:\\inetpub\\wwwroot\\HRSystem\\HRSystem\\images\\" + vm.emp.ImageFile.FileName);
                vm.emp.ImagePath = @"C:\\inetpub\\wwwroot\\HRSystem\\HRSystem\\images\\" + vm.emp.ImageFile.FileName;




                // var x = from a in context.CounEntity select a;
      //          var x = context.CounEntity.Select(a => new { a.ID, a.Name });
                //var s = from a in context.CityEntity select a;
        //        var s = context.CityEntity.Select(a => new { a.ID, a.Name });
                //var d = from a in context.DeptEntity select a;
          //      var d = context.DeptEntity.Select(a => new { a.ID, a.name });


                //foreach (var z in x)
                //{
                //    Country cnt = new Country();
                //    cnt.ID = z.ID;
                //    cnt.Name = z.Name;
                //    vm.lisCount.Add(cnt);
                //}


                vm.lisCount = context.CounEntity.ToList();


                //foreach (var z in s)
                //{
                //    City ct = new City();
                //    ct.ID = z.ID;
                //    ct.Name = z.Name;
                //    vm.lisCity.Add(ct);
                //}

                vm.lisCity = context.CityEntity.ToList();

                //foreach (var z in d)
                //{
                //    Department dpt = new Department();
                //    dpt.ID = z.ID;
                //    dpt.name = z.name;
                //    vm.listDepartment.Add(dpt);
                //}

                vm.listDepartment = context.DeptEntity.ToList();

                context.EmpEntity.Add(vm.emp);
                context.SaveChanges();
            }
            return View("Emp", vm);
        }
        

        public ActionResult List()
        {
            VMemp VMem = new VMemp();
            VMem.listEmployee = new List<Employee>();
            return View("EmpList",VMem);
        }

        public ActionResult search(VMemp vm)
        {
            HRcontext context = new HRcontext();
            vm.listEmployee = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = Request.Form["emp.FirstName"];


            //var x = from a in context.EmpEntity where a.FirstName == em.FirstName  select a ;
            vm.listEmployee = context.EmpEntity.Where(a => a.FirstName == emp.FirstName).ToList();

            //foreach(var z in x)
            //{
                
            //    emp.FirstName = z.FirstName;
            //    emp.LastName = z.LastName;
            //    emp.Phone = z.Phone;
            //    emp.salary = z.salary;
            //    vm.listEmployee.Add(emp);
            //}
            


            return View("EmpList",vm);
        }
    }
}