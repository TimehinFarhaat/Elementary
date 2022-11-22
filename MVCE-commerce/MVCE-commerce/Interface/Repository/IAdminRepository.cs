using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MVCE_commerce.Entities;


namespace MVCE_commerce.Interface.Repository
{
  public  interface IAdminRepository
  {
      Admin CreateAdmin(Admin admin);
      bool DeleteAdmin(Admin admin);
      Admin UpdateAdmin(Admin admin);
      Admin GetAdmin(int id);
      Admin GetAdmin (string email);
      bool EmailExist(string email);
      public Admin Get(Expression<Func<Admin, bool>> expression);
      IList<Admin> GetAllAdmin();


  }
}
