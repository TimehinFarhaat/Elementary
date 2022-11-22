using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netIdentitys.Entities;
using Microsoft.AspNetCore.Identity;


namespace Asp.netIdentitys.Identity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ProfilePicture { get; set; }
        public int UserNameChangeLimit { get; set; }
        public string ProfilePictureUrl { get; set; }
        public ICollection<Messages> Messages { get; set; }=new HashSet<Messages>();
    }
}
  