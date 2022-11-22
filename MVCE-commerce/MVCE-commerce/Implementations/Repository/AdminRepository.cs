using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MVCE_commerce.Context;
using MVCE_commerce.Entities;
using MVCE_commerce.Interface.Repository;


namespace MVCE_commerce.Implementations.Repository
{
    public class AdminRepository:IAdminRepository
    {
        private readonly ApplicationContext _context;

        public AdminRepository(ApplicationContext context)
        {
            _context = context;
        }


        public Admin CreateAdmin(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
            return admin;
        }



        public bool DeleteAdmin(Admin admin)
        {
            _context.Admins.Remove(admin);
            _context.SaveChanges();
            return true;
        }



        public Admin UpdateAdmin(Admin admin)
        {
            _context.Admins.Update(admin);
            _context.SaveChanges();
            return admin;
        }



        public Admin GetAdmin(int id)
        {
            var s=_context.Admins.Find(id);
            return s;
        }



        public Admin GetAdmin(string email)
        {
            var g = _context.Admins.SingleOrDefault(x => x.EmailAddress == email);
            return g;
        }




        public Admin Get(Expression<Func<Admin,bool>>expression)
        {
            var g = _context.Admins.SingleOrDefault(expression);
            return g;
        }


        public bool EmailExist(string email)
        {
            var h = _context.Admins.Any(u => u.EmailAddress == email);
            return h;
        }


        public IList<Admin> GetAllAdmin()
        {
            var g = _context.Admins.ToList();
            return g;
        }
    }
}
