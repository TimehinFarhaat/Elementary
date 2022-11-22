using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCE_commerce.Entities
{
    public class Ewallet
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string PassWord { get; set; }
        public decimal Amount { get; set; }

    }
}
