using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int OrderId { get; set; }
        public Order Order{ get; set; }
        public DateTime Time { get; set; }
        public string Reference { get; set; }
    }
}
