using CourierManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Services
{
    internal interface ICourierAdminService
    {
        int AddCourierStaff(Employee obj);
    }
}
