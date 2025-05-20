using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartaoDigital.Controllers.Classes;
using CartaoDigital.Services;
using Microsoft.AspNetCore.Mvc;

namespace CartaoDigital.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CustomerController : ControllerBase
    {
        [HttpGet("Customer")]
        public List<Customer> GetCustomers()
        {
            var customerService = new CustomerService();
            return customerService.GetCustomers();
        }

        [HttpPost]
        public Customer CreateCustomer(string fullName, DateTime birthDate, string documentNumber)
        {
            var customerService = new CustomerService();
            return customerService.CreateCustomer(fullName, birthDate, documentNumber);
        }

    }
}