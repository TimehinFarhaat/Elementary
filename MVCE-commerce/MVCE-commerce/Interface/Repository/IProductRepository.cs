using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Repository
{
  public   interface IProductRepository
  {
      Product AddProducts(Product products);
      bool DeleteProducts (Product products);
      Product UpdateProducts (Product products);
      Product GetProduct (int id);
      Product GetProduct (string name);
      Product GetsProduct (string productId);
        IList<Product> GetProducts ();

    }
}
