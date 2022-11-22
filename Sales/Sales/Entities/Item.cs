using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string image { get; set; }
        public IList<OrderItem>OrderItems { get; set; }=new List<OrderItem>();
        public IList<CategoryItem> CategoryItems { get; set; } = new List<CategoryItem>();
    }
}
