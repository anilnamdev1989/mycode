using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentRegistrationController : Controller
    {
        // GET: StudentRegistration
       
        [HttpGet]

        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(string fname,string lname)
        {
            return View();
        }
    }
}