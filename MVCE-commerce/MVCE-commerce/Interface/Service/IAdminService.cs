using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Service
{
    public interface IAdminService
    {
        AdminResponseModel CreateAdmin(AdminRequestModel requestModel);
        AdminResponseModel UpdateAdmin(int id,AdminRequestModel requestModel); 
        AdminResponseModel LoginAdmin(AdminRequest requestModel);
        AdminResponseModel GetAdmin(int id);
        AdminResponseModels GetAllAdmin();
        AdminResponseModel DeleteAdmin(int id);


    }
}
