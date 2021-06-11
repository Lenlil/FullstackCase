using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullstackCase.Models;

namespace FullstackCase.Interfaces
{
    public interface ICountryRepository
    {
        IQueryable<Country> GetAll();
        Country GetOneByID(int id);
        void Create(Country country);
        void Update(Country country);
    }
}
