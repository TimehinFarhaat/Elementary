using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Entities;


namespace Sales.DTOs.CustomerDTO
{
    public class CustomerDtO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
