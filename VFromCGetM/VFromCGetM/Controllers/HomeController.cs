using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VFromCGetM.Models;
using VFromCGetM.ViewModels;

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
            Employee emp = new Employee();
                emp.FirstName = "Sukesh";
                emp.LastName = "Marla";
                 emp.Salary = 20000;
             
       EmployeeViewModel vmEmp = new EmployeeViewModel();
                vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
                 vmEmp.Salary = emp.Salary.ToString("C");
                 if (emp.Salary > 15000)
                      {
                          vmEmp.SalaryColor = "yellow";
                      }
                else
       {
                        vmEmp.SalaryColor = "green";
                    }
            
  // vmEmp.UserName = "Admin";
   
      return View("About", vmEmp);

           
        }

        public ActionResult Contact()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            
        EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
               List<Employee> employees = empBal.GetEmployees();
             
        List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();
           
      foreach (Employee emp in employees)
                     {
                         EmployeeViewModel empViewModel = new EmployeeViewModel();
                          empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                          empViewModel.Salary = emp.Salary.ToString("C");
                          if (emp.Salary > 15000)
                            {
                                empViewModel.SalaryColor = "yellow";
                            }
                       else
           {
                                empViewModel.SalaryColor = "green";
                            }
                          empViewModels.Add(empViewModel);
                      }
                 employeeListViewModel.Employees = empViewModels;
                employeeListViewModel.UserName = "Admin";
                  return View("About", employeeListViewModel.ToList());

        }
       
    }
}