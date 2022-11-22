using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Repository
{
   public interface ICustomerRepository
    {
        Customer  CreateCustomer (Customer customer);
        bool     DeleteCustomer (Customer customer);
        Customer UpdateCustomer (Customer customer); 
        Customer GetCustomer (int id);
        Customer GetCustomer (string   email);
        public Customer Get (Expression<Func<Customer, bool>> expression);
        bool     EmailExist (string email);
        IList<Customer> GetAllCustomer ();
    }
}
