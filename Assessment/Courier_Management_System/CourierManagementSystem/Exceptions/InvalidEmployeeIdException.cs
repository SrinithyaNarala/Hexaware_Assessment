using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Exceptions
{
    internal class InvalidEmployeeIdException : Exception
    {
        public InvalidEmployeeIdException() { }
        public InvalidEmployeeIdException(string message):base(message)
        { 
        }
        public InvalidEmployeeIdException(string message, Exception inner)
            : base(message, inner) { }
    }
}
