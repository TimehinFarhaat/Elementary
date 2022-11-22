using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.DTOs;
using ApplicationUser.Entities;
using ApplicationUser.Identity;
using ApplicationUser.Interfaces.Identity;
using ApplicationUser.Interfaces.Repository;
using ApplicationUser.Interfaces.Services;


namespace ApplicationUser.Implementations.Service
{
    public class StaffService:IStaffService
    {
        private readonly IStaffRepository _staffRepository;
        private readonly IUserRepository _userRepository;
        private readonly IIdentityService _identityService;
        private readonly IRoleRepository _roleRepository;


        public StaffService (IStaffRepository staffRepository, IUserRepository userRepository, IIdentityService identityService, IRoleRepository roleRepository)
        {
            _staffRepository = staffRepository;
            _userRepository = userRepository;
            _identityService = identityService;
            _roleRepository = roleRepository;
        }



        public BaseResponse AddStaff (StaffRequestModel staff)
        {
            int authenticatedUser = int.Parse(_identityService.GetUserIdentity());
            var user=new User
            {
                UserName   = staff.Email,
                PassWord = staff.PassWord,
                CreatedBy = authenticatedUser,
                Email=staff.Email
            };
            _userRepository.AddUser(user);
            var roles = _roleRepository.GetSelectedRoles(staff.UserRoles);
            foreach (var role in roles)
            {
                var userRole = new UserRole
                {
                    ApplicationUserId = user.Id,
                    User = user,
                    ApplicationRoleId = role.Id,
                    Role = role,
                    CreatedBy = authenticatedUser
                };

                user.ApplicationUserRoles.Add(userRole);
            }

            _userRepository.UpdateUser(user);
            var staffs = new Staff
            {
                FirstName =staff.FirstName,
                LastName = staff.LastName,
                Email = staff.Email,
                PhoneNumber =staff.PhoneNumber,
                CreatedBy =authenticatedUser,
                staffNumber = $"SP{Guid.NewGuid().ToString().Substring(0,5)}",
                UserId = user.Id
            };

            _staffRepository.AddStaff(staffs);
            return new BaseResponse()
            {
                Message = "Successfully added",
                Status = true
            };

        }



        public BaseResponse UpdateStaff (int id, Staff staff) => throw new NotImplementedException();



        public bool DeleteStaff (Staff staff) => throw new NotImplementedException();



        public StaffResponseModel GetStaff (int id) => throw new NotImplementedException();


        public StaffsResponseModel GetStaffs () => throw new NotImplementedException();
    }
}
