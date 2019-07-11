using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;
namespace Dependency_Injection_MVC.Controllers
{
    
    public class HomeController : Controller
    {
        private IEmployee employee = null;
        private IStudent student = null;

        public HomeController(IEmployee _employee,IStudent _student)
        {
            employee = _employee;
            student = _student;
        }

        public ActionResult Index()
        {
            int count = employee.GetTotalStudents();
            bool data = student.IsStudent();
            return View();
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