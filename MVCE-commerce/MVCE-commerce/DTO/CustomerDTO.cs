using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;


namespace MVCE_commerce.DTO
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public int walletId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string EmailAddress { get; set; }
    }


    public class CustomerRequest
    {
        public string password { get; set; }
        public string EmailAddress { get; set; }
    }

    public class CustomerResponseModel : BaseResponse
    {
        public CustomerDTO Data { get; set; }
    }


    public class CustomerResponseModels : BaseResponse
    {
        public IList<CustomerDTO> Data { get; set; }
    }


    public class CustomerRequestModel
    {
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}


