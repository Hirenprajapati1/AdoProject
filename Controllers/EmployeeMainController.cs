using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdoProject.Models;
using AdoProject.Repository;

namespace AdoProject.Controllers
{
    public class EmployeeMainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEmployees()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployees(EmployeeModel emp)
        {
            EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
            if (EmployeeRepositoryObject.AddEmployee(emp))
            {
                ViewBag.Msg = "Employee Details are successfully Added";
            }
            else
            {
                ViewBag.Msg = "Employee Details are Not successfully Added";
            }
            return View(emp);


        } 

        public IActionResult GetEmployees()
        {
            EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
            ModelState.Clear();

            return View(EmployeeRepositoryObject.GetEmployees());
        }

        public IActionResult UpdateEmployee(int ID)
        {
            EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
            return View(EmployeeRepositoryObject.GetEmployees().Find(asd => asd.ID == ID));
        }

        [HttpPost]
        public IActionResult UpdateEmployee(int ID, EmployeeModel s1)
        {
            EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
            if (EmployeeRepositoryObject.UpdateEmployee(s1))
            {
                return RedirectToAction("GetEmployees");
            }
            else
            {
                return View();

            }
        }

        public IActionResult DeleteEmployee(int ID)
        {
            EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
            return View(EmployeeRepositoryObject.GetEmployees().Find(asd => asd.ID == ID));
        }



        [HttpPost]
        public IActionResult DeleteEmployee(int ID, EmployeeRepository s1)
        {
            EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
            if (EmployeeRepositoryObject.DeleteEmployee(ID))
            {
                return RedirectToAction("GetEmployees");
            }
            else
            {
                return View();
            }
        }



        //public IActionResult DeleteEmployee(int ID)
        //{
        //    EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
        //    return View(EmployeeRepositoryObject.GetEmployees().Find(asd => asd.ID == ID));
        //}


        //[HttpPost]
        //public IActionResult DeleteEmployee(int ID)
        //{
        //    EmployeeRepository EmployeeRepositoryObject = new EmployeeRepository();
        //    if (EmployeeRepositoryObject.DeleteEmployee(ID))
        //    {
        //        return RedirectToAction("GetEmployees");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}

    }
}