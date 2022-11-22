using MVCE_commerce.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCE_commerce.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public IList<Chart> Charts { get; set; }
        public  IList<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

        
    }
}
