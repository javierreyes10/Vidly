using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using Vidly.Services;

namespace Vidly.ViewModels
{
    public class CustomersViewModel
    {
        public List<Customer> Customers { get; set; }
        private readonly ICustomerService _customerService;

        public CustomersViewModel()
        {
            _customerService = new CustomerService();
        }

        public void Initialize()
        {
            Customers = _customerService.Customers();
        }

    }
}