using CourierManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Services
{
    internal class CourierAdminServiceImpl : CourierUserServiceImpl, ICourierAdminService
    {
        public int AddCourierStaff(Employee obj)
        {
            CourierCompany companyObj = new CourierCompany("SpeedyCourier");
            companyObj.EmployeeDetails.Add(obj);
            return obj.EmployeeID;
        }
    }
}
