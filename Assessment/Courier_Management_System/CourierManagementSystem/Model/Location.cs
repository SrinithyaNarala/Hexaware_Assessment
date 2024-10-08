using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Model
{
    internal class Location
    {
        private int locationID;
        private string locationName;
        private string address;

        // Default Constructor
        public Location() { }

        // Parametrized Constructor
        public Location(int locationID, string locationName, string address)
        {
            this.locationID = locationID;
            this.locationName = locationName;
            this.address = address;
        }

        // Getters and Setters
        public int LocationID { get => locationID; set => locationID = value; }
        public string LocationName { get => locationName; set => locationName = value; }
        public string Address { get => address; set => address = value; }

        // toString method
        public override string ToString()
        {
            return $"Location [locationID={locationID}, locationName={locationName}, address={address}]";
        }
    }
}
