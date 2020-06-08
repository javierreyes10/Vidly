using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customersViewModel = new CustomersViewModel();
            customersViewModel.Initialize();

            return View(customersViewModel);
        }

        public ActionResult Details(int id)
        {
            var customerDetailsViewModel = new CustomerDetailsViewModel();
            customerDetailsViewModel.Initialize(id);

            if (customerDetailsViewModel.Customer == null) return HttpNotFound();

            return View(customerDetailsViewModel);
        }
    }
}