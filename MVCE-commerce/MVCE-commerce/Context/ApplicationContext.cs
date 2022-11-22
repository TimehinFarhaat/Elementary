using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                        .HasOne(o => o.EWallet)
                        .WithOne(c => c.Customer)
                        .HasForeignKey<Ewallet>(d => d.CustomerId)
                        .OnDelete(DeleteBehavior.Restrict);
        }

         public   DbSet<Admin> Admins { get; set; }
         public DbSet<Order> Orders { get; set; }
         public DbSet<OrderProduct>OrderProducts { get; set; }
         public DbSet<Chart>Charts { get; set; }
         public  DbSet<Transaction> Transactions { get; set; }
         public DbSet<Product>Products { get; set; }
         public DbSet<StockProduct> StockProducts { get; set; }
         public DbSet<Stock> Stocks { get; set; }
         public DbSet<Customer>Customers { get; set; }
         public DbSet<Category> Categories { get; set; }
         public DbSet<Ewallet>Ewallets { get; set; }
    }
}
