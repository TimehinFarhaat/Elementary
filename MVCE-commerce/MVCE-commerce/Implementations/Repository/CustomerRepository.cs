using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCE_commerce.Context;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly ApplicationContext _context;


        public CustomerRepository(ApplicationContext context)
        {
            _context = context;
        }


        public Customer CreateCustomer(Customer customer)
        { 
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }


        public bool DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return true;
        }



        public Customer UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }



        public Customer GetCustomer(int id)
        {
            var s=  _context.Customers.Include(y=>y.EWallet).SingleOrDefault(o=>o.Id==id);
            return s;
        }



      


        public Customer GetCustomer(string email)
        {
            var g = _context.Customers.SingleOrDefault(o => o.EmailAddress == email);
            return g;
        }



        public Customer Get(Expression<Func<Customer, bool>> expression)
        {
            {
                var g = _context.Customers.SingleOrDefault(expression);
                return g;
            }
        }


        public bool EmailExist(string email)
        {
            var h = _context.Customers.Any(i => i.EmailAddress == email);
            return h;
        }


        public IList<Customer> GetAllCustomer()
        {
            var s = _context.Customers.ToList();
            return s;
        }
    }
}
