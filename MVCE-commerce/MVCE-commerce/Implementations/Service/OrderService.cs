using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Service
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICustomerRepository _customerRepository;


        public OrderService(IOrderRepository orderRepository,ICustomerRepository customerRepository)
        {
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;


        }


        public OrderResponse GetOrder(int id)
        {
            var t = _orderRepository.FindOrder(id);
            if (t != null)
            {
                return new OrderResponse()
                {
        
                    Message = "Successful",
                    Status = true,
                    Data = new OrderDTO()
                    {
                        id = t.Id
                    }
                };
            }
            return new OrderResponse()
            {
                Message = "UnSuccessful",
                Status = false,
            };
        }





        public OrderResponse GetsOrder (int id)
        {
            var g = _orderRepository.GetOrder(id);
            if (g == null)
            {
                return new OrderResponse()
                {
                    Message = "Not found",
                    Status = false
                };
            }

            return new OrderResponse()
            {
                Message = "Found",
                Status = true,
                Data = new OrderDTO()
                {
                   id = g.Id
                }
            };
        }


        public OrderResponse CreateOrder(string email)
        {
            var d = _customerRepository.GetCustomer(email);
            if (d != null )
            {
                var ordee=new Order()
                {
                    customer = d,
                    CustomerId = d.Id,
                };

              var t=  _orderRepository.CreateOrder(ordee);
                return new OrderResponse()
                {
                    Message = "Succcessful",
                    Status = true,
                    Data = new OrderDTO()
                    {
                        id = t.Id
                    }
                };
            }
            return new OrderResponse()
            {
                Message = "UnSuccessful",
               Status = false,
            };
        }


    }
}
