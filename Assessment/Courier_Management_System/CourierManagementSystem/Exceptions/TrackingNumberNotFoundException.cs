using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Exceptions
{
    internal class TrackingNumberNotFoundException : Exception
    {
        public TrackingNumberNotFoundException() { }
        public TrackingNumberNotFoundException(string message): base(message) { }
        public TrackingNumberNotFoundException(string message, Exception inner)
                : base(message, inner) { }
    }
}
