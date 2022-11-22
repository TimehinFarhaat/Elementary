using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Service
{
    public class StockService:IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly IAdminRepository _adminRepository;
        private readonly IStockProductRepository _productRepository;


        public StockService(IStockRepository stockRepository,IAdminRepository adminRepository, IStockProductRepository productRepository)
        {
            _stockRepository = stockRepository;
            _adminRepository = adminRepository;
            _productRepository = productRepository;
        }


        public StockResponseModel CreateStock(string email)
        {
            var f =  _adminRepository.GetAdmin(email);
            if (f != null )
            {
                
                {
                    var stok=new Stock()
                    {
                        Admin = f,
                        AdminId = f.Id,
                        StockNo = GenerateId(),
                        Time = DateTime.UtcNow
                    };

                    var s= _stockRepository.CreateStock(stok);
                    return new StockResponseModel()
                    {
                        Status = true,
                        Data = new StockDTO()
                        {
                            StockNo = s.StockNo,
                            Time = s.Time.ToLongDateString() + " " + s.Time.ToShortTimeString()
                        },
                        Message = $"Successful your stock number is {s.StockNo}"
                    };
                }
               
            }
            return new StockResponseModel()
            {
                Message = "Unsuccessful",
                Status = false
            };
        }


        private string GenerateId ()
        {
            var f = Guid.NewGuid().ToString().Substring(0,4);
            return f;
        }



        public StockResponseModel UpdateStock(string stockNo, string email)
        {
            var f = _adminRepository.GetAdmin(email);
            
            {
                var stock1 = _stockRepository.GetStock(stockNo);
                if (stock1 != null)
                {
                    stock1.Time=DateTime.UtcNow;
                    stock1.StockNo = stockNo;
                    stock1.AdminId = f.Id;
                    stock1.Admin = f;
                    stock1.Id = stock1.Id;
                  var s=    _stockRepository.UpdateStock(stock1);
                    return new StockResponseModel()
                    {
                        Status = true,
                        Data = new StockDTO()
                        {
                            StockNo = s.StockNo,
                            Time = s.Time.ToLongDateString() + " " + s.Time.ToShortTimeString()
                        },
                        Message = $"Successful stock number is {stockNo}",
                    };
                }
                return new StockResponseModel()
                {
                    Message = $"Stock with No {stockNo} does not exist",
                    Status = false
                };

            }
           
        }



        public StockResponseModel DeleteStock(string stockNo)
        {
            var stock = _stockRepository.GetStock(stockNo);
            if (stock != null)
            {
                _stockRepository.DeleteStock(stock);
                return new StockResponseModel()
                {
                    Message = $"deleted Successfully",
                    Status = true
                };
            }
            return new StockResponseModel()
            {
                Message = $"deleted Unsuccessfully",
                Status = false
            };

        }



        public StockResponseModel GetStock(string stockNo)
        {
            var stock = _stockRepository.GetStock(stockNo);
            if (stock != null)
            {
                return new StockResponseModel()
                {
                    Status = true,
                    Data = new StockDTO()
                    {
                        StockNo = stock.StockNo,
                        Time = stock.Time.ToLongDateString() + " " + stock.Time.ToShortTimeString(),
                        AdminName = stock.Admin.FirstName,
                        Id = stock.Id,
                       
                    },
                    Message = "Successful"
                };
            }
            return new StockResponseModel()
            {
                Message = $"Stock with id {stockNo} does not exist",
                Status = false
            };
        }




        public StockResponseModel GetsStock (string stockNo)
        {
            var stock = _stockRepository.GetStock(stockNo);
            if (stock != null)
            {
                if (stock.StockProducts.Count  > 0)
                {
                    return new StockResponseModel()
                    {
                        Status = true,
                        Data = new StockDTO()
                        {
                            StockNo = stock.StockNo,
                            Time = stock.Time.ToLongDateString() + " " + stock.Time.ToShortTimeString(),
                            AdminName = stock.Admin.FirstName,
                            Id = stock.Id,
                            StockProducts = stock.StockProducts
                        },
                        Message = "Successful"
                    };
                }
                return new StockResponseModel()
                {
                    Message = $"Add stocck items",
                    Status = false
                };
            }
            return new StockResponseModel()
            {
                Message = $"Stock with id {stockNo} does not exist",
                Status = false
            };
        }

        public StocksResponseModel GetStocks()
        {
            var stocks = _stockRepository.GetStocks();
            if (stocks == null)
            {
                return new StocksResponseModel()
                {
                    Message = "No available stock",
                    Status = false
                };
            }
            return new StocksResponseModel()
            {
               Message = "Available",
               Status = true,
               Data = stocks.Select(b => new StockDTO()
               { 
                   StockNo= b.StockNo,
                   AdminName = b.Admin.FirstName,
                   Time = b.Time.ToLongDateString()+"  "+b.Time.ToShortTimeString(),
                   Id = b.Id
               }).ToList()
           };

        }
    }
}
