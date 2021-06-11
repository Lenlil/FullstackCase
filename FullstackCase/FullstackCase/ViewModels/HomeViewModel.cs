using FullstackCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullstackCase.ViewModels
{
    public class HomeViewModel
    {
        public List<Country> AllCountries { get; set; }
        public List<Customer> AllCustomers { get; set; }

        public string NewCustomerName { get; set; }
        public int NewCustomerCountryId { get; set; }
    }
}
