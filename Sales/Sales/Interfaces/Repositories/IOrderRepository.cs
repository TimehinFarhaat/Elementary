using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Entities;


namespace Sales.Interfaces.Repositories
{
    public interface IOrderRepository
    { 
        Order CreateOrder(Order   order);
        Order  UpdateOrder (Order order);
        bool    DeleteOrder (Order order);
        Order  GetOrder (int  id);
        IList<Order> GetOrderByCustomer(int CustomerId);
        IList<Order> GetOrders ();
    }
}
