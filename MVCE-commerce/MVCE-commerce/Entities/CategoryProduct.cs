using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCE_commerce.Entities
{
    public class CategoryProduct
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
       public int ProductId { get; set; }
        public Product Products { get; set; }
    }
}
