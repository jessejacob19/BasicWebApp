using BasicWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicWebApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewCustomer()
        {
            Customer customer = new Customer();

            customer.Id = Guid.NewGuid().ToString();
            customer.Name = "Fred";
            customer.Telephone = "123456";

            return View(customer);
        }
    }
}