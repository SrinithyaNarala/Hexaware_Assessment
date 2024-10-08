using CourierManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Services
{
    internal class CourierUserServiceImpl : ICourierUserService
    {
        private CourierCompany companyObj;

        public CourierUserServiceImpl()
        {
            companyObj = new CourierCompany("SpeedyCourier");
        }

        public string PlaceOrder(Courier courierObj)
        {
            companyObj.CourierDetails.Add(courierObj);
            return courierObj.TrackingNumber.ToString();
        }

        public string GetOrderStatus(int trackingNumber)
        {
            foreach (var courier in companyObj.CourierDetails)
            {
                if (courier.TrackingNumber == trackingNumber)
                {
                    return courier.Status;
                }
            }
            return "Tracking number not found.";
        }

        public bool CancelOrder(int trackingNumber)
        {
            var courier = companyObj.CourierDetails.Find(c => c.TrackingNumber == trackingNumber);
            if (courier != null)
            {
                companyObj.CourierDetails.Remove(courier);
                return true;
            }
            return false;
        }

        public List<Courier> GetAssignedOrder(int courierStaffId)
        {
            return companyObj.CourierDetails.FindAll(c => c.UserID == courierStaffId);
        }
    }
}
