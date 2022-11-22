using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCE_commerce.Context;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Repository
{
    public class ProductRepository:IProductRepository
    {
        private readonly ApplicationContext _context;


        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }


        public Product AddProducts(Product products)
        {
            _context.Products.Add(products);
            _context.SaveChanges();
            return products;
        }



        public bool DeleteProducts(Product products)
        {
            _context.Products.Remove(products);
            _context.SaveChanges();
            return true;
        }



        public Product UpdateProducts(Product products)
        {
            _context.Products.Update(products);
            _context.SaveChanges();
            return products;
        }



        public Product GetProduct(int id)
        {
            var g = _context.Products.Find(id);
            return g;
        }



        public Product GetProduct(string name)
        {
            var g = _context.Products.FirstOrDefault(d => d.Name == name);      
            return g;
        }



        public Product GetsProduct(string productId)
        {
            var f = _context.Products.Include(o=>o.CategoryProducts).ThenInclude(i=>i.Category).SingleOrDefault(d => d.ItemId == productId);
            return f;
        }   


        public IList<Product> GetProducts()
        {
            var g = _context.Products.ToList();
            return g;
        }
    }
}
