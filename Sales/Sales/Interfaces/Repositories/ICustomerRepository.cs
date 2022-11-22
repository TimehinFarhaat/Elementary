using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Entities;


namespace Sales.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Customer Create (Customer    customer);
        Customer UpdateCustomer (Customer customer);
        bool DeleteCustomer (Customer customer);
        Customer GetCustomer(int id);
        IList<Customer> GetCustomers();
    }
}
