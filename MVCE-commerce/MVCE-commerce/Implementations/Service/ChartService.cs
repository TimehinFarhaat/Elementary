using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Repository;
using MVCE_commerce.Interface.Service;
using Chart = MVCE_commerce.Entities.Chart;


namespace MVCE_commerce.Implementations.Service
{
    public class ChartService:IChartService
    {
        private readonly IChartRepository _chartRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IStockProductRepository _stockRepository;
        private readonly IEWalletRepository _eWalletRepository;



        public ChartService(IChartRepository chartRepository,IProductRepository productRepository, IOrderRepository orderRepository, IStockProductRepository stockRepository, IEWalletRepository eWalletRepository)
        {
            _chartRepository = chartRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _stockRepository = stockRepository; 
            _eWalletRepository=eWalletRepository;

        }


        public ResponseModel CreateChart(ChartRequestModel model,int customerId)
        {
            var s = _productRepository.GetsProduct(model.ProductNo);
            var ig = _chartRepository.GetChart(customerId);
            if (s != null )
            {
                if (ig != null)
                {
                    var chart=new Chart()
                    {

                        Quantity = model.Quantity,
                        ProductNo = s.ItemId,
                        OrderId =ig.Id
                    };
                    var g = _chartRepository.CreateChart(chart);
                    return new ResponseModel()
                    {
                        Data = new ChartDTO()
                        {
                            Quantity = g.Quantity,
                            Id = g.Id
                        },
                        Status = true

                    };
                }
               

                return new ResponseModel()
                {
                   Message = "Create your order first",
                    Status = false

                };
            }

            return new ResponseModel()
            {
                Status = false,
                Message="Product not found"
            };
        }




        public ResponseModel UpdateChart(int id,ChartRequestModel model,int customerId)
        {
            var s = _productRepository.GetsProduct(model.ProductNo);
            var chart = _chartRepository.FindChart(id);

            if (s != null)
            {

                {
                   
                    chart.Quantity = model.Quantity;

                    chart.ProductNo = s.ItemId;
                };

                var g = _chartRepository.UpdateChart(chart);
                return new ResponseModel()
                {
                    Data = new ChartDTO()
                    {
                        Quantity = g.Quantity,
                        Id = g.Id
                    },
                    Status = true

                };
            }

            return new ResponseModel()
            {
                Status = false,
                Message = "Product not found"
            };  
        }




        public ResponseModel DeleteChart(int id)
        {
            var chart = _chartRepository.FindChart(id);
            if (chart != null)
            {
                _chartRepository.DeleteChart(chart);
                
                return new ResponseModel()
                {
                    Status = true,
                    Message = "Successfully"

                };
            }
            return new ResponseModel()
            {
                Status = false,
                Message = "UnSuccessfully"

            };
        }




       


       


        public Response BuyChart(int orderId)
        {
            var chart = _chartRepository.GetAllChart(orderId);
           
            decimal amount = 0;
            foreach (var item in chart)
            {
                var g = _stockRepository.GetStockProductByProductNo(item.ProductNo);
                if (item.Quantity  < g.Quantity )
                {
                    g.Quantity -= item.Quantity;
                    amount += _stockRepository.GetStockProductByProductNo(item.ProductNo).UnitPrice * item.Quantity;
                    _stockRepository.UpdateStockProduct(g);
                    var OrderP=new OrderProduct()
                    {
                        Products = g.Products,
                        Order = item.Order,
                        OrderId = item.OrderId,
                        ProductId = g.ProductId,
                    };
                    item.Order.OrderProducts.Add(OrderP);
                }
                else
                {
                    return new Response()
                    {
                      Status = false,
                      Message = $"{g.ProductName}  is not up to {item.Quantity} only {g.Quantity} is available",

                    };
                }
               
            }
            var order = _orderRepository.FindOrder(orderId);
            var wallet = _eWalletRepository.FindEwallet(order.CustomerId);
            if (wallet.Amount > amount)
            {
                wallet.Amount -= amount;
                var wall = _eWalletRepository.UpdateEwallet(wallet);
                return new Response()
                {
                    Amount = amount,
                    Data = chart.Select(i => new ChartDTOs()
                    {
                        Quantity = i.Quantity,
                        Id = i.Id,
                        TotalPrice = _stockRepository.GetStockProductByProductNo(i.ProductNo).UnitPrice * i.Quantity,
                        Name = _productRepository.GetsProduct(i.ProductNo).Name


                    }).ToList(),
                    Message = $" YOU HAVE BEEN DEDUCTED {amount}" +
                              $"Your account balance is {wall.Amount}",
                    Status = true,
                };

            }
            else
            {
                return new Response()
                {
                    Message = $"Your wallet balance is not sufficient to buy your order " +
                              $"Go to your menu to add  your wallet",
                    Status = false

                };

            }


            

        }




        public ResponseModels GetChart (int orderId)
        {
            var d = _chartRepository.GetAllChart(orderId);
            if (d != null)
            {
                return new ResponseModels()
                {
                    Status = true,
                    Data = d.Select(i => new ChartDTO()
                    {
                        Quantity = i.Quantity,
                        Id = i.Id,
                        Name = _productRepository.GetsProduct(i.ProductNo).Name


                    }).ToList()
                };
            }
            return new ResponseModels()
            {
                Status = false,
                Message = "No Order Found"
            };
        }


        


        public ResponseModels GetAllChart(int orderId)
        {
            var d = _chartRepository.GetAllChart(orderId);
            if (d != null)
            {
                return new ResponseModels()
                {
                    Status = true,
                    Data = d.Select(i=>new ChartDTO()
                    {
                        Quantity = i.Quantity,
                      Id = i.Id,
                      Name = _productRepository.GetsProduct(i.ProductNo).Name
                      

                    }).ToList()
                };
            }
            return new ResponseModels()
            {
              Status = false,
              Message = "No Order Found"
            };
        }
    }
}
