using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Context;
using ApplicationUser.Entities;
using ApplicationUser.Interfaces.Repository;


namespace ApplicationUser.Implementations.Repository
{
    public class StaffRepository:IStaffRepository
    {
        private readonly ApplicationContext _context;


        public StaffRepository (ApplicationContext context)
        {
            _context = context;
        }


        public Staff AddStaff (Staff staff)
        {
            _context.Staffs.Add(staff);
            _context.SaveChanges();
            return staff;
        }



        public Staff UpdateStaff (Staff staff)
        {
            _context.Staffs.Update(staff);
            _context.SaveChanges();
            return staff;
        }



        public bool DeleteStaff (Staff staff)
        {
            _context.Staffs.Remove(staff);
            _context.SaveChanges();
            return true;
        }



        public Staff GetStaff (int id)
        {
            var staff = _context.Staffs.Find(id);
            return staff;
        }


        public IList<Staff> GetStaffs ()
        {
            var staffs = _context.Staffs.ToList();
            return staffs;
        }
    }
}
