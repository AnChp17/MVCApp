using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            List<Customer> customersList = new List<Customer>()
            {
                new Customer(){ID = 1, Name = "Andy"},
                new Customer(){ID = 2, Name = "Randy"}
            };

            return customersList;
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.ID == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}