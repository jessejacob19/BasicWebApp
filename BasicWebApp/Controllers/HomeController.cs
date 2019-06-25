﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime.Caching;
using BasicWebApp.Models;

namespace BasicWebApp.Controllers
{
    public class HomeController : Controller
    {
        ObjectCache cache = MemoryCache.Default;
        List<Customer> customers;

        public HomeController()
        {
            customers = cache["customers"] as List<Customer>;
            if (customers == null)
            {
                customers = new List<Customer>();
            }
        }

        public void SaveCache()
        {
            cache["customers"] = customers;
        }
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


        public ActionResult ViewCustomer(string id)
        {

            Customer customer = customers.FirstOrDefault(c => c.Id == id);
            
            if (customer == null)
            {
                return HttpNotFound();
            } else
            {
                return View(customer);
            }
        }

        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            customer.Id = Guid.NewGuid().ToString();
            customers.Add(customer);
            SaveCache();

            return RedirectToAction("CustomerList");
        }

        public ActionResult EditCustomer(string id)
        {
            Customer customer = customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        //public ActionResult EditCustomer(Customer customer, string Id)
        //{
            //var customerToEdit = customers.FirstOrDefault(c => c.Id == Id);

           // if (customer)
       // }

        public ActionResult CustomerList()
        {

            return View(customers);
        }
    }
}