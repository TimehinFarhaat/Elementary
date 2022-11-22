using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineShopping.Models.Entities
{
  public  class Vendor
    {
        [Key]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public string  Address { get; set; }
        public List<Products>products { get; set; }
        public List<Order>orders { get; set; }
    }
}
