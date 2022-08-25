using MVCDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{id=1,FirstName="John",LastName="Kabir"},
                new Employee{id=2,FirstName="Tom",LastName="Scott"},
                new Employee{id=3,FirstName="Mike",LastName="Pound"},

            };

            return View(employees.ToList());
        }

        public ActionResult SignUpForm()
        {
            return View();
        }
        public ActionResult SignUp()
        {
            TempData["sucess"] = "User Signed Up Sucessfully";
            return RedirectToAction("SignUpForm");
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Submit()
        {
            return View();
        }
    }
}