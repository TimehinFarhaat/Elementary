using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCE_commerce.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public string StockNo { get; set; }
        public DateTime Time { get; set; }
        public Admin Admin { get; set; }
        public IList<StockProduct> StockProducts { get; set; }=new List<StockProduct>();
    }
}
