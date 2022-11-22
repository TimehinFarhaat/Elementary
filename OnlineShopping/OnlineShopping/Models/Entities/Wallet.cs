using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping
{
  public  class Wallet
    {
        public int Id { get; set; }   
        public int UserId { get; set; }
        public double Balance { get; set; }
        public string  Pin { get; set; }
    }
}
