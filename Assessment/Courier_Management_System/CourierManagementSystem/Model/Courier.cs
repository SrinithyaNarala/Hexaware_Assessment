using System;

namespace CourierManagementSystem.Model
{
    internal class Courier
    {
        private static int trackingCounter;
        private int courierID;
        private int serviceID;
        private int employeeID;
        private int locationID;
        private string senderName;
        private string senderAddress;
        private string receiverName;
        private string receiverAddress;
        private double weight;
        private string status;
        private int trackingNumber;
        private DateTime orderedDate;
        private DateTime deliveryDate;
        private int userID;

        // Default Constructor
        public Courier()
        {
            trackingNumber = ++trackingCounter;
        }

        // Parametrized Constructor
        public Courier(int courierID, string senderName, string senderAddress, string receiverName, string receiverAddress, double weight, string status, DateTime deliveryDate, int userId)
        {
            this.courierID = courierID;
            this.employeeID = employeeID;
            this.locationID = locationID;
            this.serviceID = serviceID;
            this.senderName = senderName;
            this.senderAddress = senderAddress;
            this.receiverName = receiverName;
            this.receiverAddress = receiverAddress;
            this.weight = weight;
            this.status = status;
            this.orderedDate = orderedDate;
            this.deliveryDate = deliveryDate;
            this.userID = userID;
            this.trackingNumber = ++trackingCounter; // Automatically incremented
        }

        // Getters and Setters
        public int CourierID { get => courierID; set => courierID = value; }
        public string SenderName { get => senderName; set => senderName = value; }
        public int ServiceID { get => serviceID; set => serviceID = value; } 
        public int EmployeeID { get => employeeID; set => employeeID = value; } 
        public int LocationID { get => locationID; set => locationID = value; }
        public string SenderAddress { get => senderAddress; set => senderAddress = value; }
        public string ReceiverName { get => receiverName; set => receiverName = value; }
        public string ReceiverAddress { get => receiverAddress; set => receiverAddress = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Status { get => status; set => status = value; }
        public int TrackingNumber { get => trackingNumber; set => trackingNumber = value; }
        public DateTime OrderedDate { get => orderedDate; set => orderedDate = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public int UserID { get => userID; set => userID = value; }

        // toString method
        public override string ToString()
        {
            return $"Courier [courierID={courierID},senderName={senderName}, receiverName={receiverName}, trackingNumber={trackingNumber}, status={status}]";
        }
    }
}
