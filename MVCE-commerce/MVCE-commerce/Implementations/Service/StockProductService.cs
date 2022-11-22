using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Repository;
using MVCE_commerce.Interface.Service;


namespace MVCE_commerce.Implementations.Service
{
    public class StockProductService:IStockProductService
    {
        private readonly IStockProductRepository _stockProductRepository;
        private readonly IStockRepository _stockRepository;
        private readonly IProductRepository _productRepository;
        private readonly ITransactionRepository  _transaction;


        public StockProductService(IStockProductRepository stockProductRepository,IStockRepository stockRepository,IProductRepository product,ITransactionRepository transaction)
        {
            _stockProductRepository = stockProductRepository;
            _stockRepository = stockRepository;
            _productRepository = product;
            _transaction = transaction;
        }


        public StockProductResponseModels AddStockProduct(StockProductRequestModel product)
        {
            var s = _stockRepository.GetStock(product.StockId);
            var d = _productRepository.GetsProduct(product.ProductNo);
            if (s != null && d != null )
            {
                var stockProduct = _stockProductRepository.ProductExist(d.ItemId);
                if (stockProduct != null)
                {
                    stockProduct.ProductId = d.Id;
                    stockProduct.ProductNo = d.ItemId;
                    stockProduct.Products = d;
                    stockProduct.StockNo = s.StockNo;
                    stockProduct.StockProductNo = GenerateId();
                    stockProduct.Quantity += product.Quantity;
                    stockProduct.UnitPrice = product.UnitPrice;
                    stockProduct.CostPrice = product.CostPrice;
                    stockProduct.StockId =s.Id;
                    stockProduct.StockNo = product.StockId;
                    stockProduct.ProductName = d.Name;
                    stockProduct.Stock = s;


                    var stockProducts = _stockProductRepository.UpdateStockProduct(stockProduct);
                    return new StockProductResponseModels()
                    {
                        Status = true,
                        Data = new StockProductDTO()
                        {
                            ProductNo = stockProducts.ProductNo,
                            StockId = stockProducts.StockNo,
                            UnitPrice = stockProducts.UnitPrice,
                            Quantity = stockProducts.Quantity,
                            CostPrice = stockProducts.CostPrice,
                            ProductName = stockProducts.ProductName,
                            Id = stockProducts.Id,
                            StockProductNo = stockProducts.StockProductNo
                        }
                    };
                }
                var stocksProduct=new StockProduct()
                {
                    ProductId = d.Id,
                    ProductNo = d.ItemId,
                    StockId = s.Id,
                    StockNo = product.StockId,
                    CostPrice = product.CostPrice,
                    Quantity = product.Quantity,
                    UnitPrice = product.UnitPrice,
                    Products = d,
                    StockProductNo = GenerateId(),
                    Stock = s,
                    ProductName = d.Name
                };

                var stockProductss = _stockProductRepository.AddStockProduct(stocksProduct);
                return new StockProductResponseModels()
                {
                    Status = true,
                    Data = new StockProductDTO()
                    {
                        ProductNo = stockProductss.ProductNo,
                         StockId = stockProductss.StockNo,
                         UnitPrice = stockProductss.UnitPrice,
                         Quantity = stockProductss.Quantity,
                         CostPrice = stockProductss.CostPrice,
                         ProductName = stockProductss.ProductName,
                         Id = stockProductss.Id,
                         StockProductNo = stockProductss.StockProductNo
                    }
                };
            }
            return new StockProductResponseModels()
            {
               Message = "Invalid Stock number or invalid product number",
               Status = false
            };
        }


        private string GenerateId ()
        {
            var f = Guid.NewGuid().ToString().Substring(0,4);
            return f;
        }




        public StockProductResponseModels UpdateStockProduct(string productNo,StockProductRequestModel product)
        {
            var d = _stockProductRepository.GetStockProduct(productNo);
            if (d != null)
            {
                d.ProductNo = product.ProductNo;
                var g = _productRepository.GetsProduct(d.ProductNo);
                d.ProductId = g.Id;
                d.Products = g;
                d.CostPrice = product.CostPrice;
                d.Quantity += product.Quantity;
                d.StockProductNo = d.StockProductNo;
                d.UnitPrice = product.UnitPrice;
                var h = _stockRepository.GetStock(d.StockNo);
                d.StockId = h.Id;
                d.Stock = h;
                d.Id = d.Id;
                d.StockNo = product.StockId;
                var stockProducts = _stockProductRepository.UpdateStockProduct(d);
                return new StockProductResponseModels()
                {
                    Data = new StockProductDTO()
                    {
                        ProductNo = stockProducts.ProductNo,
                        StockId = stockProducts.StockNo,
                        UnitPrice = stockProducts.UnitPrice,
                        Quantity = stockProducts.Quantity,
                        CostPrice = stockProducts.CostPrice,
                        ProductName = g.Name,
                        Id = stockProducts.Id,
                        StockProductNo = stockProducts.StockProductNo
                    }
                };
            }
            return new StockProductResponseModels()
            {
                Message = "Invalid Stock number or invalid product number",
                Status = false
            };
        }



        public bool DeleteStockProduct(string  productNo)
        {
            var stock = _stockProductRepository.GetStockProduct(productNo);
            if (stock != null)
            {
                _stockProductRepository.DeleteStockProduct(stock);
                return true;
            }

            return false;
        }



        public StockProductResponseModels GetStockProduct(string id)
        {
            var stock = _stockProductRepository.GetStockProduct(id);
            
            if (stock != null)
            {
                var f = _productRepository.GetsProduct(stock.ProductNo);
                return new StockProductResponseModels()
                {
                    Status = true,  
                    Data = new StockProductDTO()
                    {
                        ProductNo= stock.ProductNo,
                        StockId = stock.StockNo,
                        UnitPrice = stock.UnitPrice,
                        Quantity = stock.Quantity,
                        CostPrice = stock.CostPrice,
                        ProductName = f.Name,
                        Id = stock.Id,
                        StockProductNo = stock.StockProductNo
                    }
                };
            }
            return new StockProductResponseModels()
           {
               Message = "Item does not exist",
               Status = false
           };
        }



        public StockProductResponseModel GetStockProducts()
        {
            var stocks = _stockProductRepository.GetStockProducts();
            if (stocks != null)
            {
                return new StockProductResponseModel()
                {
                    Status =true,
                    Data = stocks.Select(u=>new StockProductDTO ()
                    { 
                     
                          ProductNo = u.ProductNo,
                             StockId = u.StockNo,
                            StockProductNo = u.StockProductNo,
                            UnitPrice = u.UnitPrice,
                            Quantity = u.Quantity,
                           CostPrice = u.CostPrice,
                            ProductName = _productRepository.GetsProduct(u.ProductNo).Name,
                            Id = u.Id
                           }).ToList()
                         

                      
                };
            }
            return  new StockProductResponseModel()
            {
                Message = " No list found",
                Status = false
            };
        }
    }
}
