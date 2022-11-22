using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;


namespace MVCE_commerce.Inetrface.Service
{
  public  interface ICustomerService
    {
        CustomerResponseModel CreateCustomer (CustomerRequestModel requestModel);
        CustomerResponseModel UpdateCustomer (int id, CustomerRequestModel requestModel);
        CustomerResponseModel GetCustomer (int id);
        CustomerResponseModel LoginCustomer (CustomerRequest requestModel);
        CustomerResponseModels GetAllCustomer ();
        CustomerResponseModel DeleteCustomer (int id);
      
    }
}
