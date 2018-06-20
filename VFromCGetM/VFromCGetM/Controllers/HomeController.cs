using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VFromCGetM.Models;


namespace VFromCGetM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //  Employee emp = new Employee();
            //  emp.FirstName = "Sukesh";
            //  emp.LastName = "Marla";
            //  emp.Salary = 20000;
            //  ViewData["Employee"] = emp;
            //  return View();
             Employee emp = new Employee();
             emp.FirstName = "Sukesh";
             emp.LastName = "Marla";
              emp.Salary = 20000;
             return View("Index", emp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}