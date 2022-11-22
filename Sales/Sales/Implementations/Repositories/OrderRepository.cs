using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Context;
using Sales.Entities;
using Sales.Interfaces.Repositories;


namespace Sales.Implementations.Repositories
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


        public Order UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
            return order;
        }



        public bool DeleteOrder(Order order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return true;
        }



        public Order GetOrder(int id)
        {
            var f = _context.Orders.Find(id);
            return f;
        }


        public IList<Order> GetOrderByCustomer(int CustomerId)
        {
            var f = _context.Orders.Where(k => k.CustomerId == CustomerId).ToList();
            return f;
        }


        public IList<Order> GetOrders()
        {
            var d = _context.Orders.ToList();
            return d;
        }
    }
}
