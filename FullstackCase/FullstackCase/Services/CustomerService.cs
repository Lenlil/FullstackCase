using FullstackCase.Interfaces;
using FullstackCase.Models;
using FullstackCase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullstackCase.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository repository)
        {
            _customerRepository = repository;
        }

        public bool AddNewCustomer(string newCustomerName, int newCountryID)
        {
            Customer newCustomer = new Customer
            {
                Name = newCustomerName,
                CountryId = newCountryID
            };

            _customerRepository.Create(newCustomer);        

            return true;
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll().ToList();
        }
    }
}
