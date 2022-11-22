using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Repositories
{
  public  interface IUserRepository: IBaseRepository<User>
    {
      public User CreateUser (User user);
      public User GetUser (string email);
      public User GetUser (string email,string password);
      public User GetUser (int id);
      public User DeleteUser (int id);
      public User UpdateUser (User user);


    }
}
