using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;


namespace MVCE_commerce.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public Ewallet EWallet { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public IList<Order> Orders { get; set; } = new List<Order>();
        public IList< Transaction> Transactions=new List<Transaction>();
    }
}
