using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Context;
using Sales.Entities;
using Sales.Interfaces.Repositories;


namespace Sales.Implementations.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly ApplicationContext _context;


        public CustomerRepository (ApplicationContext context)
        {
            _context = context;
        }

        public Customer Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }


        public Customer UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }



        public bool DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return true;
        }



        public Customer GetCustomer(int id)
        {
            var s = _context.Customers.Find(id);
            return s;
        }



        public IList<Customer> GetCustomers()
        {
            var g = _context.Customers.ToList();
            return g;
        }
    }
}
