using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sales.Entities;


namespace Sales.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Item>Items { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<CategoryItem>CategoryItems { get; set; }

    }
}
