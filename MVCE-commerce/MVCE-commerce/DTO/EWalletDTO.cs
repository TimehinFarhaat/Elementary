using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.DTO
{
    public class EWalletDTO
    {
        
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public CustomerDTO Customer { get; set; }
    }


    public class EwalletRequestModel
    {
        public int Id { get; set; }
        public string PassWord { get; set; }
        public decimal Amount { get; set; }
    }


    public class EwalletResponseModel:BaseResponse
    {
        public EWalletDTO Data { get; set; }
    }


    public class EwalletResponseModels:BaseResponse
    {
        public IList<EWalletDTO> Data { get; set; }
    }
}
