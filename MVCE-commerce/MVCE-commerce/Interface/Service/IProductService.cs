using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Inetrface.Service
{
  public  interface IProductService
    {
        ProductResponseModel AddProducts (ProductRequestModel    products);
        ProductResponseModel DeleteProducts (string  products);
        ProductResponseModel UpdateProducts (string item,ProductRequestModel products);
        ProductResponseModel   GetProduct (string productNo);
        ProductsResponseModel GetProducts ();
    }
}
