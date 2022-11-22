using System;
using System.Collections.Generic;
using System.Text;
using OnlineShopping.Models.Entities;


namespace OnlineShopping
{
  public  class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int Quantity { get; set; }
        public int  ProductId { get; set; }
        public Products Products { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderSTatus OrderSTatus { get; set; }
        public Vendor Vendor { get; set; }
        public  int  VendorId { get; set; }
    }
}
