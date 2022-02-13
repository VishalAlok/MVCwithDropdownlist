using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_with_Dropdownlist.Models;

namespace MVC_with_Dropdownlist.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Test()
        {

            var CountriesFromClass = new List<Country>()
            {
                new Country(){ Id = 1, Text ="India" },
                new Country(){ Id = 1, Text ="Pakistan" },
                new Country(){ Id = 1, Text ="Bangladesh" },
                new Country(){ Id = 1, Text ="Nepal" },
                new Country(){ Id = 1, Text ="Sri Lanka" }
            };

            ViewBag.CountriesListFromClass = CountriesFromClass;

            Employee emp = new Employee() { Country = 1 };

            return View();
        }

        [HttpPost]
        public ActionResult Test(Employee Obj)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Test");
            }
            return View();
        }
    }

}