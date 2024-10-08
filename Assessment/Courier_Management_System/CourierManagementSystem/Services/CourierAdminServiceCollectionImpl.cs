using CourierManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Services
{
    internal class CourierAdminServiceCollectionImpl:CourierUserServiceCollectionImpl,ICourierAdminService
    {
        public int AddCourierStaff(Employee obj)
        {
            CourierCompanyCollection companyObj = new CourierCompanyCollection();
            companyObj.EmployeeDetails.Add(obj);
            return obj.EmployeeID;
        }
    }
}
