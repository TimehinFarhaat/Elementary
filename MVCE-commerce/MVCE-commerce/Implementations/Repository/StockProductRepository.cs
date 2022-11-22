using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCE_commerce.Context;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Repository
{
    public class StockProductRepository:IStockProductRepository
    {
        private readonly ApplicationContext _applicationContext;


        public StockProductRepository(ApplicationContext context)
        {
            _applicationContext = context;
        }


        public StockProduct AddStockProduct(StockProduct product)
        {
            _applicationContext.StockProducts.Add(product);
            _applicationContext.SaveChanges();
            return product;
        }

        public StockProduct ProductExist (string productNo)
        {
            var d = _applicationContext.StockProducts.SingleOrDefault(u => u.ProductNo == productNo);
            return d;
        }

        public StockProduct UpdateStockProduct(StockProduct product)
        {
            _applicationContext.StockProducts.Update(product);
            _applicationContext.SaveChanges();
            return product;
        }



        public bool DeleteStockProduct(StockProduct product)
        {
            _applicationContext.StockProducts.Remove(product);
            _applicationContext.SaveChanges();
            return true;
        }



        public StockProduct GetStockProduct(string stockId)
        {
           var d=  _applicationContext.StockProducts.Include(v=>v.Products).SingleOrDefault(u => u.StockProductNo == stockId);
           return d;
        }
        public StockProduct GetStocksProduct (string stockId)
        {
            var d=  _applicationContext.StockProducts.Include(v=>v.Products).SingleOrDefault(u => u.StockNo == stockId);
            return d;
        }


        public StockProduct GetStockProductByProductNo (string id)
        {
            var d=  _applicationContext.StockProducts.Where(u => u.ProductNo==id).OrderBy(t => t.ProductId).LastOrDefault();
            return d;  
        }


        public IList<StockProduct> GetStockProducts()
        {
            var stockProduct = _applicationContext.StockProducts.Where(r=>r.Quantity != 0).ToList();
            return stockProduct;
        }
    }
}
