using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Repository
{
    public interface IOrderRepository
    {
         Order     CreateOrder (Order order);
         public Order GetOrder(int id);
         Order FindOrder (int id);
         IList<Order> GetCustomerOrders (int id);

    }
}
