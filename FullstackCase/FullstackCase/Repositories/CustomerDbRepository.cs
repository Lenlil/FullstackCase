using FullstackCase.Data;
using FullstackCase.Interfaces;
using FullstackCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullstackCase.Repositories
{
    public class CustomerDbRepository : ICustomerRepository
    {
        private readonly ApplicationDBContext dbContext;

        public CustomerDbRepository(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(Customer customer)
        {
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
        }

        public IQueryable<Customer> GetAll()
        {
            return dbContext.Customers;
        }

        public Customer GetOneByID(int customerId)
        {
            return dbContext.Customers.Find(customerId);
        }

        public void Update(Customer customer)
        {
            dbContext.Customers.Update(customer);
            dbContext.SaveChanges();
        }
    }
}
