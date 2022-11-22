using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MVCE_commerce.DTO;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Repository;
using MVCE_commerce.Interface.Service;


namespace MVCE_commerce.Implementations.Service
{
    public class AdminService:IAdminService
    {
        private readonly IAdminRepository _adminRepository;


        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }



        public AdminResponseModel CreateAdmin(AdminRequestModel requestModel)
        {
            var exist = _adminRepository.GetAdmin(requestModel.EmailAddress);
            if (exist != null)
            {
                throw  new Exception("Admin already exist");
            }
            var admin=new Admin()
            {
                FirstName = requestModel.FirstName,
                LastName = requestModel.LastName,
                EmailAddress = requestModel.EmailAddress,
                PassWord = requestModel.password
            };

            var d = _adminRepository.CreateAdmin(admin);
            if (d== null)
            {
                return  new AdminResponseModel()
                {
                    Message = "Unsuccessful",
                    Status = false
                };
            }
            return new AdminResponseModel()
            {
                  Data = new AdminDTO()
                  {
                      AdminId = d.Id,
                      FirstName = d.FirstName,
                      LastName = d.LastName,
                      EmailAddress = d.EmailAddress,
                  },
                  Message = "Successful",
                  Status = true
            };
        }





        public AdminResponseModel UpdateAdmin(int Id,AdminRequestModel requestModel)
        {
               
            {
                var admin = _adminRepository.GetAdmin(Id);
                if (admin != null)
                {

                    admin.FirstName = requestModel.FirstName;
                    admin.LastName = requestModel.LastName;
                    admin.EmailAddress = requestModel.EmailAddress;
                    admin.PassWord = requestModel.password;

                    var d = _adminRepository.UpdateAdmin(admin);
                    return new AdminResponseModel()
                    {
                        Data = new AdminDTO()
                        {
                            EmailAddress = admin.EmailAddress,
                            FirstName = admin.FirstName,
                            LastName = admin.LastName
                        },
                        Message = "Successful",
                        Status = true
                    };
                }
            }
          
            
            return new AdminResponseModel()
            {
                    Message = "Unsuccessful",
                    Status = false
            };
            
          
        }



        public AdminResponseModel GetAdmin(int id)
        {
            var g = _adminRepository.GetAdmin(id);
            if (g== null)
            {
                return  new AdminResponseModel()
                {
                    Message = "Not found",
                    Status = false
                };
            }
            return new AdminResponseModel()
            {
                Message = "Found",
                Status = true,
                Data = new AdminDTO()
                {
                    AdminId = g.Id,
                    EmailAddress = g.EmailAddress,
                    FirstName = g.FirstName,
                    LastName = g.LastName
                }
            };
        }




        public AdminResponseModels GetAllAdmin()
        {
            var f = _adminRepository.GetAllAdmin();
            if (f == null)
            {
                return new AdminResponseModels()
                {
                    Message = "No available Admin",
                    Status = false
                };
            }
            return new AdminResponseModels()
            {
                Message = "Available",
                Status = true,
                Data = f.Select(b=>new AdminDTO()
                {
                    AdminId = b.Id,
                   FirstName =  b.FirstName,
                   LastName = b.LastName,
                    EmailAddress = b.EmailAddress,
                }).ToList()
            };
        }




        public AdminResponseModel DeleteAdmin(int id)
        {
            var admin = _adminRepository.GetAdmin(id);
            if (admin==null)
            {
                return new AdminResponseModel()
                {
                    Message = "Not found",
                    Status = false
                };
            }

            _adminRepository.DeleteAdmin(admin);
            return new AdminResponseModel()
            {
                Message = "Deleted Succesfully",
                Status =true,
                Data = new AdminDTO()
                {
                    FirstName = admin.FirstName,
                    AdminId = admin.Id
                }
            };
        }


     public    AdminResponseModel LoginAdmin(AdminRequest requestModel)
        {
            var g = _adminRepository.Get(y=>y.EmailAddress==requestModel.EmailAddress);
            if (g != null && g.PassWord==requestModel.password)
            {
                return new AdminResponseModel()
                {
                    Message = "Found",
                    Status = true,
                    Data = new AdminDTO()
                    {
                        AdminId = g.Id,
                        EmailAddress = g.EmailAddress,
                        FirstName = g.FirstName,
                        LastName = g.LastName
                    }
                };
            }
            return new AdminResponseModel()
            {
                Message = "Not found",
                Status = false
            };
        }
    }
}
 