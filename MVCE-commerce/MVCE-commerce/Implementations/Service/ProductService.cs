using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Inetrface.Repository;
using MVCE_commerce.Inetrface.Service;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Service
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;


        public ProductService(IProductRepository productRepository,ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }



        public ProductResponseModel AddProducts(ProductRequestModel products)
        {
            var d = _productRepository.GetProduct(products.Name);
            if (d == null)
            {
                var item=new Product()
                {
                    Name = products.Name,
                    ItemId = GenerateId()
                };

                var categories = _categoryRepository.GetsCategory(products.CategoryItems);
                foreach (var g in categories)
                {
                    var itemCategory=new CategoryProduct()
                    {
                        ProductId = item.Id,
                        Products = item,
                        Category = g,
                        CategoryId = g.Id
                    };
                    item.CategoryProducts.Add(itemCategory);
                }

                var myItem = _productRepository.AddProducts(item);
                if (myItem != null)
                {
                    return new ProductResponseModel()
                    {
                        Message =$"item Number is {myItem.ItemId}",
                        Status = true,
                        Data = new ProductDTO()
                        {
                            Id = myItem.Id,
                            Name = myItem.Name,
                            ItemId = myItem.ItemId
                        }
                    };
                }
                else
                {
                    return new ProductResponseModel()
                    {
                        Message = "UnSuccessful",
                        Status = false
                    };
                }
            }

            return new ProductResponseModel()
            {
                Message = "UnSuccessful",
                Status = false
            };
        }


       


        private string GenerateId()
        {
            var f = Guid.NewGuid().ToString().Substring(0,4);
            return f;
        }


        public ProductResponseModel DeleteProducts(string products)
        {
            var e = _productRepository.GetsProduct(products);
            if (e != null)
            {
                _productRepository.DeleteProducts(e);
                return new ProductResponseModel()
                {
                    Message = "Deleted",
                    Status = true,
                    Data = new ProductDTO()
                    {
                        Id = e.Id,
                        Name = e.Name,
                        ItemId = e.ItemId
                    }
                };
            }

            return new ProductResponseModel()
            {
                Message = "UnSuccessful",
                Status = false
            };
        }






        public ProductResponseModel UpdateProducts(string item,ProductRequestModel products)
        {
            var d = _productRepository.GetsProduct(item);
            if (d != null)
            {
                d.Name = products.Name;
                d.ItemId = item;
                var categories = _categoryRepository.GetsCategory(products.CategoryItems);
                foreach (var iten in categories)
                {
                    var category = new CategoryProduct()
                    {
                        Category = iten,
                        CategoryId = iten.Id,
                        Products = d,
                        ProductId = d.Id
                    };
                }
                var f = _productRepository.UpdateProducts(d);
                if (f != null)
                {
                    return new ProductResponseModel()
                    {
                        Message = "Deleted",
                        Status = true,
                        Data = new ProductDTO()
                        {
                            Id = f.Id,
                            Name = f.Name,
                            ItemId = f.ItemId
                        }
                    };
                }
                return new ProductResponseModel()
                {
                    Message = "UnSuccessful",
                    Status = false
                };
            }

            return new ProductResponseModel()
            {
                    Message = "UnSuccessful",
                    Status = false
            };
            
        }






        public ProductResponseModel GetProduct(string productNo)
        {
            var d = _productRepository.GetsProduct(productNo);
            if (d != null)
            {
                return new ProductResponseModel()
                {
                    Message = "Deleted",
                    Status = true,
                    Data = new ProductDTO()
                    {
                        Id = d.Id,
                        Name = d.Name,
                        ItemId = d.ItemId,
                        CategoryItems = d.CategoryProducts
                    }
                };
            }

            return new ProductResponseModel()
            {
                Message = "UnSuccessful",
                Status = false
            };
        }





        public ProductsResponseModel GetProducts()
        {
            var f = _productRepository.GetProducts();
            if (f == null)
            {
               return new ProductsResponseModel()
               {
                   Message = "Not found",
                   Status = false
               };
            }
            return new ProductsResponseModel()
            {
                Data = f.Select(k => new ProductDTO()
                {
                    ItemId = k.ItemId,
                    Name = k.Name,
                    Id = k.Id
                }).ToList()

            };

        }
    }
}
