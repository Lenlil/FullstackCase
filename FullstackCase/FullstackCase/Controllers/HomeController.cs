using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullstackCase.Data;
using FullstackCase.Services;
using FullstackCase.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FullstackCase.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDBContext _context;
        private CountryService _countryService;
        private CustomerService _customerService;

        public HomeController(ApplicationDBContext context, CountryService countryService, CustomerService customerService)
        {
            _context = context;
            _countryService = countryService;
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var allCountries = _countryService.GetAllCountries();
            var allCustomers = _customerService.GetAllCustomers();

            var model = new HomeViewModel
            {
                AllCountries = allCountries,
                AllCustomers = allCustomers
            };

            return View(model);
        }
    }
}
