using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Model
{
    internal class CourierServices
    {
        private int serviceID;
        private string serviceName;
        private decimal cost;

        // Default Constructor
        public CourierServices() { }

        // Parametrized Constructor
        public CourierServices(int serviceID, string serviceName, decimal cost)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.cost = cost;
        }

        // Getters and Setters
        public int ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public decimal Cost { get => cost; set => cost = value; }

        // toString method
        public override string ToString()
        {
            return $"CourierService [serviceID={serviceID}, serviceName={serviceName}, cost={cost}]";
        }
    }
}
