using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartaoDigital.Controllers.Classes;

namespace CartaoDigital.Services
{
    public class CustomerService
    {
        // Criar métodos para realizar operações
        public List<Customer> GetCustomers()
        {
            // TODO: Susbtiruir o método BuildFakeCustomers por uma chamada ao banco de dados
            var customers = BuildFakeCustomer();
            return customers;
        }
        private List<Customer> BuildFakeCustomer()
        {
            var custormers = new List<Customer>
            {
                new Customer
                {
                    CustomerId = 1,
                    FullName = "Joe Smith",
                    DocumentNumber = "123456789",
                    BirthDate = new DateTime(1990, 1, 1)

                }
            };
            return custormers;
        }

        public Customer CreateCustomer(string fullName, DateTime birthDate, string documentNumber)
        {
            var customer = new Customer
            {
                FullName = fullName,
                BirthDate = birthDate,
                DocumentNumber = documentNumber
            };

            // TODO: Salvar no banco de dados
            return customer;
        }
    }
}