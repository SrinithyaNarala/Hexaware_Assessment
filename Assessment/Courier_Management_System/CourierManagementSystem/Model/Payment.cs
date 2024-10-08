using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Model
{
    internal class Payment
    {
        private long paymentID;
        private long courierID;
        private long locationID;
        private double amount;
        private DateTime paymentDate;

        // Default Constructor
        public Payment() { }

        // Parametrized Constructor
        public Payment(long paymentID, long courierID, double amount, DateTime paymentDate)
        {
            this.paymentID = paymentID;
            this.courierID = courierID;
            this.locationID = locationID;
            this.amount = amount;
            this.paymentDate = paymentDate;
        }

        // Getters and Setters
        public long PaymentID { get => paymentID; set => paymentID = value; }
        public long CourierID { get => courierID; set => courierID = value; }
        public double Amount { get => amount; set => amount = value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }

        // toString method
        public override string ToString()
        {
            return $"Payment [paymentID={paymentID}, courierID={courierID}, amount={amount}, paymentDate={paymentDate}]";
        }
    }
}
