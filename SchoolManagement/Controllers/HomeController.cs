using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class HomeController : Controller
    {
        //Every method you have here you should have a corresponding
        //view file and that is what this returns.
        //When you send a request for index from the home controller
        //it will search through the view folder and then look for a follow the
        //corresponding name or home and then it will look for a controller with a view
        public ActionResult Index()
        {
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
        //New view
        public ActionResult TestView()
        {
            return View();
        }
    }
}