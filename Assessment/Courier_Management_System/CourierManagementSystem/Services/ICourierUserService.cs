using CourierManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Services
{
    internal interface ICourierUserService
    {
        string PlaceOrder(Courier courierObj);   // Generate a tracking number

        string GetOrderStatus(int trackingNumber);

        bool CancelOrder(int trackingNumber);

        List<Courier> GetAssignedOrder(int courierStaffId);
    }
}
