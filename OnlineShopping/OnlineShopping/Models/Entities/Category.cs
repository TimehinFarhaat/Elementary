using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping
{
  public  class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Products> Product { get; set; }

    }
}
