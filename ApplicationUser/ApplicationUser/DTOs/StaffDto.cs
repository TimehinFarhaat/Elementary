using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationUser.DTOs
{
    public class StaffDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StaffNumber { get; set; }
    }


    public class BaseResponse
    {
        public string Message { get; set; }
        public bool Status { get; set; }

    }


    public class StaffRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PassWord { get; set; }
        public IList<int> UserRoles { get; set; }

    }

    public class StaffsResponseModel : BaseResponse
    {
        public IList<StaffDto> Data { get; set; }

    }



    public class StaffResponseModel : BaseResponse
    {
        public StaffDto Data { get; set; }

    }
}

