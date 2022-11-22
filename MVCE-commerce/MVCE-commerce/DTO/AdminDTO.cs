using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCE_commerce.DTO
{
    public class AdminDTO
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public string EmailAddress { get; set; }
    }




    public class AdminResponseModel:BaseResponse
    {
        public AdminDTO Data { get; set; }
    }




    public class AdminResponseModels : BaseResponse
    {
        public IList<AdminDTO> Data { get; set; }
    }




    public class AdminRequest
    {
        public string password { get; set; }
        public string EmailAddress { get; set; }
    }




    public class AdminRequestModel
    {
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
