using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Repository
{
    public interface IStockProductRepository
    {
        StockProduct AddStockProduct(StockProduct product);
        StockProduct UpdateStockProduct (StockProduct product);
        bool DeleteStockProduct (StockProduct product);
        StockProduct GetStockProduct (string id);
        StockProduct GetStockProductByProductNo(string id);
        IList<StockProduct> GetStockProducts ();
        public StockProduct ProductExist (string productNo);
        public StockProduct GetStocksProduct(string id);
    }
}
