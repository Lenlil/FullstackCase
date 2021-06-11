using FullstackCase.Data;
using FullstackCase.Interfaces;
using FullstackCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullstackCase.Repositories
{
    public class CountryDbRepository : ICountryRepository
    {
        private readonly ApplicationDBContext dbContext;

        public CountryDbRepository(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Country country)
        {
            dbContext.Countries.Add(country);
            dbContext.SaveChanges();
        }

        public IQueryable<Country> GetAll()
        {
            return dbContext.Countries;
        }

        public Country GetOneByID(int id)
        {
            return dbContext.Countries.Find(id);
        }

        public void Update(Country country)
        {
            dbContext.Countries.Update(country);
            dbContext.SaveChanges();
        }
    }
}
