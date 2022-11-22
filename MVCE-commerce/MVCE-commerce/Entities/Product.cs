using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCE_commerce.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string Name { get; set; }
        public IList<CategoryProduct> CategoryProducts { get; set; }=new List<CategoryProduct>();
        public  IList<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
        public IList<StockProduct>StockProducts { get; set; }=new List<StockProduct>();
    }
}
