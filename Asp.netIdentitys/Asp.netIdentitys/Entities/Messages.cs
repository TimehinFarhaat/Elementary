using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netIdentitys.Identity;


namespace Asp.netIdentitys.Entities
{
    public class Messages
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime When { get; set; }
        public string UserId { get; set; }
      public User User { get; set; }
    }
}
