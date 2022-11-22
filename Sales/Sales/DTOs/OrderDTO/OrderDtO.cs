using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Entities;


namespace Sales.DTOs.OrderDTO
{
    public class OrderDtO
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime Time { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
    }
}
