using CourierManagementSystem.ConnectionUtil;
using CourierManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Dao
{
    internal class CourierServiceDb
    {
        private static SqlConnection connection;

        // Constructor assigns the connection object
        public CourierServiceDb()
        {
            connection = DBConnection.GetConnection();
        }

        // Method to insert a new courier order into the database
        public bool InsertCourier(Courier courier)
        {
            try
            {
                string query = "INSERT INTO Courier (SenderName, SenderAddress, ReceiverName, ReceiverAddress, Weight, Status, TrackingNumber, DeliveryDate, UserId) " +
                               "VALUES (@SenderName, @SenderAddress, @ReceiverName, @ReceiverAddress, @Weight, @Status, @TrackingNumber, @DeliveryDate, @UserId)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SenderName", courier.SenderName);
                    cmd.Parameters.AddWithValue("@SenderAddress", courier.SenderAddress);
                    cmd.Parameters.AddWithValue("@ReceiverName", courier.ReceiverName);
                    cmd.Parameters.AddWithValue("@ReceiverAddress", courier.ReceiverAddress);
                    cmd.Parameters.AddWithValue("@Weight", courier.Weight);
                    cmd.Parameters.AddWithValue("@Status", courier.Status);
                    cmd.Parameters.AddWithValue("@TrackingNumber", courier.TrackingNumber);
                    cmd.Parameters.AddWithValue("@DeliveryDate", courier.DeliveryDate);
                    cmd.Parameters.AddWithValue("@UserID", courier.UserID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inserting courier: " + e.Message);
                return false;
            }
        }

        // Method to update the status of an existing courier
        public bool UpdateCourierStatus(int trackingNumber, string newStatus)
        {
            try
            {
                string query = "UPDATE Courier SET Status = @Status WHERE TrackingNumber = @TrackingNumber";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@TrackingNumber", trackingNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error updating courier status: " + e.Message);
                return false;
            }
        }

        // Method to retrieve the delivery history of a specific parcel
        public Courier GetCourierByTrackingNumber(int trackingNumber)
        {
            try
            {
                string query = "SELECT * FROM Courier WHERE TrackingNumber = @TrackingNumber";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TrackingNumber", trackingNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Courier courier = new Courier
                            {
                                CourierID = (int)reader["CourierID"],
                                SenderName = reader["SenderName"].ToString(),
                                SenderAddress = reader["SenderAddress"].ToString(),
                                ReceiverName = reader["ReceiverName"].ToString(),
                                ReceiverAddress = reader["ReceiverAddress"].ToString(),
                                Weight = (double)reader["Weight"],
                                Status = reader["Status"].ToString(),
                                TrackingNumber = (int)reader["TrackingNumber"],
                                DeliveryDate = (DateTime)reader["DeliveryDate"],
                                UserID = (int)reader["UserID"]
                            };

                            return courier;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error retrieving courier: " + e.Message);
            }
            return null;
        }

        // Method to generate shipment status report
        public string GenerateShipmentStatusReport()
        {
            try
            {
                string query = "SELECT Status, COUNT(*) AS Total FROM Courier GROUP BY Status";
                string report = "";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string status = reader["Status"].ToString();
                            int count = (int)reader["Total"];
                            report += $"{status}: {count} orders\n";
                        }
                    }
                }

                return report;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error generating report: " + e.Message);
                return null;
            }
        }
    }
}
