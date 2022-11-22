using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.DTOs;
using ApplicationUser.Entities;


namespace ApplicationUser.Interfaces.Services
{
    public interface  IStaffService
    {
        BaseResponse        AddStaff (StaffRequestModel staff);
        BaseResponse        UpdateStaff (int    id, Staff staff);
        bool                DeleteStaff (Staff   staff);
        StaffResponseModel  GetStaff (int    id);
        StaffsResponseModel GetStaffs ();
    }
}
