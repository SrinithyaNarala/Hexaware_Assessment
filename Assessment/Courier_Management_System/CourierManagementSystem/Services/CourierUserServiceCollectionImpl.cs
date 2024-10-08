using CourierManagementSystem.Exceptions;
using CourierManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Services
{
    internal class CourierUserServiceCollectionImpl:ICourierUserService
    {
        private CourierCompanyCollection companyObj;

        public CourierUserServiceCollectionImpl()
        {
            companyObj = new CourierCompanyCollection("SpeedyCourier");
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
            throw new TrackingNumberNotFoundException($"Tracking number {trackingNumber} not found.");
        }

        public bool CancelOrder(int trackingNumber)
        {
            for (int i = 0; i < companyObj.CourierDetails.Count; i++)
            {
                if (companyObj.CourierDetails[i].TrackingNumber == trackingNumber)
                {
                    companyObj.CourierDetails.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<Courier> GetAssignedOrder(int courierStaffId)
        {
            List<Courier> assignedOrders = new List<Courier>();
            foreach (var courier in companyObj.CourierDetails)
            {
                if (courier.UserID == courierStaffId)
                {
                    assignedOrders.Add(courier);
                }
            }
            return assignedOrders;
        }
    }
}
