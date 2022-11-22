using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Inetrface.Service
{
 public    interface IOrderService
    {
        OrderResponse CreateOrder (string email);
        public OrderResponse GetOrder(int id);
        public OrderResponse GetsOrder(int id);
    }
}
