using System;
using System.Collections.Generic;
using System.Text;
using OnlineShopping.Models.Entities;


namespace OnlineShopping
{
   public   class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SellingPrice { get; set; }
        public int Quantity { get; set; }
        public int CostPrice { get; set; }
        public int CategoryId { get; set; }
        public  Category Category { get; set; }
        public IList<Order>Orders { get; set; }
        public DateTime DateAdded { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
       

    }
}
