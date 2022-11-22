using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Sales.Entities;


namespace Sales.DTOs.ItemDTO
{
    public class ItemDtO
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public IList<OrderItem>    OrderItems { get; set; }=new List<OrderItem>();
        public IList<CategoryItem> CategoryItems { get; set; }=new List<CategoryItem>();
    }
}
