using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCE_commerce.Entities
{
    public class StockProduct
    {
      
        public int Id { get; set; }
        public int StockId { get; set; }
        public string StockNo { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public Stock Stock { get; set; }
        public string StockProductNo { get; set; }
        public int ProductId { get; set; }
        public string ProductNo { get; set; }
        public  string ProductName { get; set; }
        public Product Products { get; set; }
    }
}
