using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using Vidly.Services;

namespace Vidly.ViewModels
{
    public class CustomerDetailsViewModel
    {
        private readonly ICustomerService _customerService;
        public Customer Customer { get; set; }

        public CustomerDetailsViewModel()
        {
            _customerService = new CustomerService();
        }

        public void Initialize(int id)
        {
            Customer = _customerService.CustomerById(id);
        }
    }
}