using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Model
{
    internal class User
    {
        private long userID;
        private string userName;
        private string email;
        private string password;
        private string contactNumber;
        private string address;

        // Default Constructor
        public User() { }

        // Parameterized Constructor
        public User(int userID, string userName, string email, string password, string contactNumber, string address)
        {
            this.userID = userID;
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.contactNumber = contactNumber;
            this.address = address;
        }

        // Getters and Setters
        public int UserID { get => (int)userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Address { get => address; set => address = value; }

        // ToString method
        public override string ToString()
        {
            return $"User ID: {userID}, Name: {userName}, Email: {email}, Contact: {contactNumber}, Address: {address}";
        }
    }
}
