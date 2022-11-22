using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternAPI.Entities.Identity
{
    public class UserConstant
    {
        public const string FirstName = "Adeyemo";
        public const bool EmailConfirmed = true;
        public const bool PhoneNumberConfirmed = true;
        public const string SurName = "Yusrah";
        public const string UserName = "User";
        public const string Email= "User@gmail.com";
        public const string Password = "password";
        public const RoleConstant Role = RoleConstant.User;
        public const string PhoneNumber = "08123456789";
    }
}
