using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netIdentitys.Identity;


namespace Asp.netIdentitys.Entities
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string  PhoneNumber{ get; set; }
        public string StaffNumber { get; set; }
        public User User { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}
