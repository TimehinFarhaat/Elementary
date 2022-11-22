using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCE_commerce.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TimeAdded { get; set; }
        public DateTime  TimeBought { get; set; }
        public  Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Admin Admin { get; set; }
        public int AdminId { get; set; }
        public IList<StockProduct> Products { get; set; } =
        new List<StockProduct>();


    }
}
