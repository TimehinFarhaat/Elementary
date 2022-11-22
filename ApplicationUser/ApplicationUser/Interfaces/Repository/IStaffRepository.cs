using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Entities;


namespace ApplicationUser.Interfaces.Repository
{
    public interface IStaffRepository
    {
        Staff        AddStaff (Staff    staff);
        Staff        UpdateStaff (Staff staff);
        bool         DeleteStaff (Staff staff);
        Staff        GetStaff (int      id);
        IList<Staff> GetStaffs ();
    }
}
