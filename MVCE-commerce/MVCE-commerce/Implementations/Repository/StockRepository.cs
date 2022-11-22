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
    public class StockRepository:IStockRepository
    {
        private readonly ApplicationContext _context;


        public StockRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Stock CreateStock(Stock stock)
        {
            _context.Stocks.Add(stock);
            _context.SaveChanges();
            return stock;
        }



        public Stock UpdateStock(Stock stock)
        {
            _context.Stocks.Update(stock);
            _context.SaveChanges();
            return stock;
        }



        public bool DeleteStock(Stock stock)
        {
            _context.Stocks.Remove(stock);
            _context.SaveChanges();
            return true;
        }



        public Stock GetStock(string StockNo)
        {
           var s= _context.Stocks.Include(d=>d.Admin).Include(i=>i.StockProducts).ThenInclude(o=>o.Products)
                          .SingleOrDefault(h => h.StockNo== StockNo);
           return s;
        }



        public IList<Stock> GetStocks()
        {
            var s= _context.Stocks.Include(d=>d.Admin).ThenInclude(o=>o.Stocks).ThenInclude(i=>i.StockProducts).
                            ThenInclude(p=>p.Products).ToList();
            return s;
        }
    }
}
