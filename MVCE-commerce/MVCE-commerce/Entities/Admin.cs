using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCE_commerce.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public IList<Stock> Stocks { get; set; }=new List<Stock>();
        public  IList<Transaction> Transactions { get; set; }
    }
}
