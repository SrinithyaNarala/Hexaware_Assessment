using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Model
{
    internal class CourierCompany
    {
        private string companyName;
        private List<Courier> courierDetails;
        private List<Employee> employeeDetails;
        private List<Location> locationDetails;

        // Default Constructor
        public CourierCompany()
        {
            courierDetails = new List<Courier>();
            employeeDetails = new List<Employee>();
            locationDetails = new List<Location>();
        }

        // Parametrized Constructor
        public CourierCompany(string companyName)
        {
            this.companyName = companyName;
            this.courierDetails = new List<Courier>();
            this.employeeDetails = new List<Employee>();
            this.locationDetails = new List<Location>();
        }

        // Getters and Setters
        public string CompanyName { get => companyName; set => companyName = value; }
        public List<Courier> CourierDetails { get => courierDetails; set => courierDetails = value; }
        public List<Employee> EmployeeDetails { get => employeeDetails; set => employeeDetails = value; }
        public List<Location> LocationDetails { get => locationDetails; set => locationDetails = value; }

        // toString method
        public override string ToString()
        {
            return $"CourierCompany [companyName={companyName}, courierCount={courierDetails.Count}, employeeCount={employeeDetails.Count}, locationCount={locationDetails.Count}]";
        }
    }
}
