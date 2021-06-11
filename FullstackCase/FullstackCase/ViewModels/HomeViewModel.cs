using FullstackCase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FullstackCase.ViewModels
{
    public class HomeViewModel
    {
        public List<Country> AllCountries { get; set; }
        public List<Customer> AllCustomers { get; set; }

        [Required]
        public string NewCustomerName { get; set; }
        public int NewCustomerCountryId { get; set; }
    }
}
