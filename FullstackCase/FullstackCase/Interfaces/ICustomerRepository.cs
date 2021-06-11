using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullstackCase.Models;

namespace FullstackCase.Interfaces
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetAll();
        Customer GetOneByID(int customerId);
        void Create(Customer customer);
        void Update(Customer customer);
    }
}
