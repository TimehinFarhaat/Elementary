using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCE_commerce.Context;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Repository
{
    public class OrderRepository:IOrderRepository
    {
        private readonly ApplicationContext _context;


        public OrderRepository(ApplicationContext context)
        {
            _context = context;
        }


        public Order CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;
        }



        public Order GetOrder (int customerId)
        {
            var s=  _context.Orders.Include(y=>y.customer).SingleOrDefault(o=>o.CustomerId == customerId);
            return s;
        }




        public Order FindOrder(int id)
        {
           var s=   _context.Orders.Find(id);
              return s;
        }



        public IList<Order> GetCustomerOrders(int id)
        {
            var g = _context.Orders.Include(o=>o.Charts).Include(o=>o.customer).Where(o => o.CustomerId == id).ToList();
            return g;

        }
    }
}
