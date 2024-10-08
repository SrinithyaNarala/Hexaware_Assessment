using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using CourierManagementSystem.ConnectionUtil;
using CourierManagementSystem.Model;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("===== Courier Management System =====");
            Console.WriteLine("1. Insert New Courier Order");
            Console.WriteLine("2. Update Courier Status");
            Console.WriteLine("3. View All Courier Orders");
            Console.WriteLine("4. View Delivery History");
            Console.WriteLine("5. Generate Shipment Status Report");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    InsertOrder();
                    break;
                case "2":
                    UpdateStatus();
                    break;
                case "3":
                    ViewAllOrders();
                    break;
                case "4":
                    ViewDeliveryHistory();
                    break;
                case "5":
                    GenerateReport();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    static void InsertOrder()
    {
        Courier newOrder = new Courier();

        // Take user inputs for the new courier
        Console.WriteLine("\n===== Insert New Courier Order =====");
        //Console.Write("Enter Courier ID: ");
        //newOrder.CourierID = int.Parse(Console.ReadLine());

        Console.Write("Enter User ID: ");
        newOrder.UserID = int.Parse(Console.ReadLine());

        Console.Write("Enter Service ID: ");
        newOrder.ServiceID = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee ID: ");
        newOrder.EmployeeID = int.Parse(Console.ReadLine());

        Console.Write("Enter Location ID: ");
        newOrder.LocationID = int.Parse(Console.ReadLine());

        Console.Write("Enter Sender Name: ");
        newOrder.SenderName = Console.ReadLine();

        Console.Write("Enter Sender Address: ");
        newOrder.SenderAddress = Console.ReadLine();

        Console.Write("Enter Receiver Name: ");
        newOrder.ReceiverName = Console.ReadLine();

        Console.Write("Enter Receiver Address: ");
        newOrder.ReceiverAddress = Console.ReadLine();

        Console.Write("Enter Weight: ");
        newOrder.Weight = float.Parse(Console.ReadLine());

        Console.Write("Enter Status: ");
        newOrder.Status = Console.ReadLine();

        Console.Write("Enter Tracking Number: ");
        newOrder.TrackingNumber = int.Parse(Console.ReadLine());

        newOrder.OrderedDate = DateTime.Now;
        newOrder.DeliveryDate = newOrder.OrderedDate.AddDays(3);

        // Insert into database
        InsertOrderToDatabase(newOrder);
    }

    static void UpdateStatus()
    {
        Console.WriteLine("\n===== Update Courier Status =====");
        Console.Write("Enter Courier ID: ");
        int courierId = int.Parse(Console.ReadLine());

        Console.Write("Enter New Status: ");
        string status = Console.ReadLine();

        UpdateCourierStatus(courierId, status);
    }

    static void ViewAllOrders()
    {
        Console.WriteLine("\n===== All Courier Orders =====");
        List<string> orderDetails = GetCourier();
        foreach (var order in orderDetails)
        {
            Console.WriteLine(order);
        }
    }

    static void ViewDeliveryHistory()
    {
        Console.WriteLine("\n===== Delivery History =====");
        Console.Write("Enter Courier ID to view history: ");
        int courierId = int.Parse(Console.ReadLine());

        List<string> deliveryHistory = GetDeliveryHistory(courierId);
        foreach (var history in deliveryHistory)
        {
            Console.WriteLine(history);
        }
    }

    static void GenerateReport()
    {
        Console.WriteLine("\n===== Shipment Status Report =====");
        var shipmentReport = GenerateShipmentStatusReport();
        foreach (var report in shipmentReport)
        {
            Console.WriteLine(report);
        }
    }

    static void InsertOrderToDatabase(Courier newOrder)
    {
        using (SqlConnection connection = DBConnection.GetConnection())
        {
            try
            {
                connection.Open();
                StringBuilder queryBuilder = new StringBuilder();
                queryBuilder.Append("INSERT INTO Courier ");
                queryBuilder.Append("(CourierID, UserID, ServiceID, EmployeeID, ReceiverName, SenderName, SenderAddress, ");
                queryBuilder.Append("ReceiverAddress, LocationID, Weight, Status, TrackingNumber, OrderedDate, DeliveryDate) ");
                queryBuilder.Append("VALUES (@CourierID, @UserID, @ServiceID, @EmployeeID, @ReceiverName, @SenderName, ");
                queryBuilder.Append("@SenderAddress, @ReceiverAddress, @LocationID, @Weight, @Status, @TrackingNumber, @OrderedDate, @DeliveryDate)");

                using (SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection))
                {
                    command.Parameters.AddWithValue("@CourierID", newOrder.CourierID);
                    command.Parameters.AddWithValue("@UserID", newOrder.UserID);
                    command.Parameters.AddWithValue("@ServiceID", newOrder.ServiceID);
                    command.Parameters.AddWithValue("@EmployeeID", newOrder.EmployeeID);
                    command.Parameters.AddWithValue("@ReceiverName", newOrder.ReceiverName);
                    command.Parameters.AddWithValue("@SenderName", newOrder.SenderName);
                    command.Parameters.AddWithValue("@SenderAddress", newOrder.SenderAddress);
                    command.Parameters.AddWithValue("@ReceiverAddress", newOrder.ReceiverAddress);
                    command.Parameters.AddWithValue("@LocationID", newOrder.LocationID);
                    command.Parameters.AddWithValue("@Weight", newOrder.Weight);
                    command.Parameters.AddWithValue("@Status", newOrder.Status);
                    command.Parameters.AddWithValue("@TrackingNumber", newOrder.TrackingNumber);
                    command.Parameters.AddWithValue("@OrderedDate", newOrder.OrderedDate);
                    command.Parameters.AddWithValue("@DeliveryDate", newOrder.DeliveryDate);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"Order inserted successfully, affected rows: {rowsAffected}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while inserting the order: " + ex.Message);
            }
        }
    }

    static void UpdateCourierStatus(int courierId, string status)
    {
        using (SqlConnection connection = DBConnection.GetConnection())
        {
            try
            {
                connection.Open();
                string query = "UPDATE Courier SET Status = @Status WHERE CourierID = @CourierID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourierID", courierId);
                    command.Parameters.AddWithValue("@Status", status);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} order(s) updated.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the status: " + ex.Message);
            }
        }
    }

    static List<string> GetCourier()
    {
        List<string> orders = new List<string>();
        using (SqlConnection connection = DBConnection.GetConnection())
        {
            try
            {
                connection.Open();
                string query = "SELECT CourierID, SenderName, ReceiverName FROM Courier";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int courierID = reader.GetInt32(0);
                        string senderName = reader.GetString(1);
                        string receiverName = reader.GetString(2);
                        orders.Add($"CourierID: {courierID}, Sender: {senderName}, Receiver: {receiverName}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        return orders;
    }

    static List<string> GetDeliveryHistory(int courierId)
    {
        List<string> history = new List<string>();
        using (SqlConnection connection = DBConnection.GetConnection())
        {
            try
            {
                connection.Open();
                string query = "SELECT DeliveryDate, Status FROM Courier WHERE CourierID = @CourierID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourierID", courierId);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime deliveryDate = reader.GetDateTime(0);
                        string status = reader.GetString(1);
                        history.Add($"Delivery Date: {deliveryDate}, Status: {status}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving delivery history: " + ex.Message);
            }
        }
        return history;
    }

    static IEnumerable<string> GenerateShipmentStatusReport()
    {
        List<string> report = new List<string>();
        using (SqlConnection connection = DBConnection.GetConnection())
        {
            try
            {
                connection.Open();
                string query = "SELECT Status, COUNT(*) AS Count FROM Courier GROUP BY Status";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string status = reader.GetString(0);
                        int count = reader.GetInt32(1);
                        report.Add($"Status: {status}, Count: {count}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while generating the report: " + ex.Message);
            }
        }
        return report;
    }
}
