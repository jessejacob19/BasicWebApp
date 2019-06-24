using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.MySuperProperty = "This is my first App!";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult ViewCustomer(string Name, string Telephone)
        {
            Models.Customer customer = new Models.Customer();

            customer.Id = Guid.NewGuid().ToString();
            customer.Name = Name;
            customer.Telephone = Telephone;

            return View(customer);
        }

        public ActionResult AddCustomer()
        {
            return View();
        }
    }
}