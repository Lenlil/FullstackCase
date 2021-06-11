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
    public class CustomerController : Controller
    {
        private ApplicationDBContext _context;
        private CountryService _countryService;
        private CustomerService _customerService;

        public CustomerController(ApplicationDBContext context, CountryService countryService, CustomerService customerService)
        {
            _context = context;
            _countryService = countryService;
            _customerService = customerService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCustomer(HomeViewModel model)
        {
            bool ok = true;

            if (!ModelState.IsValid || !ok)
            {
                ModelState.AddModelError(string.Empty, "Please fill in all the required fields.");

                return RedirectToAction("Index", "Home");
            }

            _customerService.AddNewCustomer(model.NewCustomerName, model.NewCustomerCountryId);

            return RedirectToAction("Index", "Home");
        }
    }
}
