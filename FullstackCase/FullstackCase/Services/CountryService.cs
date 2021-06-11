using FullstackCase.Interfaces;
using FullstackCase.Models;
using FullstackCase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullstackCase.Services
{
    public class CountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository repository)
        {
            _countryRepository = repository;
        }

        public List<Country> GetAllCountries()
        {
            return _countryRepository.GetAll().ToList();
        }
    }
}
