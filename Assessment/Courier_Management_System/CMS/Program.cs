using CMS.task2;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace CMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 1
            //// Check the order status using if-else statements
            //Console.WriteLine("Enter the order status (Processing, Delivered, Cancelled): ");
            //string orderStatus = Console.ReadLine();

            //if (orderStatus == "Delivered")
            //{
            //    Console.WriteLine("The order has been delivered.");
            //}
            //else if (orderStatus == "Processing")
            //{
            //    Console.WriteLine("The order is still processing.");
            //}
            //else if (orderStatus == "Cancelled")
            //{
            //    Console.WriteLine("The order has been cancelled.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid status entered.");
            //}
            #endregion

            #region Task1 2
            //// Categorize parcel using switch-case
            //Console.WriteLine("Enter the parcel weight (in kg): ");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //switch (weight)
            //{
            //    case <= 2:
            //        Console.WriteLine("The parcel is categorized as: Light");
            //        break;
            //    case > 2 and <= 5:
            //        Console.WriteLine("The parcel is categorized as: Medium");
            //        break;
            //    case > 10:
            //        Console.WriteLine("The parcel is categorized as: Heavy");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid weight entered.");
            //        break;
            //}
            #endregion

            #region Task1 3
            ////login for customer and employee
            //string employeeUsername = "Sri";
            //string employeePassword = "12Pass";

            //string customerUsername = "nithya";
            //string customerPassword = "34Pass";

            //Console.WriteLine("Are you logging in as an Employee or Customer? (Enter 'Employee' or 'Customer')");
            //string userType = Console.ReadLine();

            //switch (userType.ToLower())
            //{
            //    case "employee":
            //        Console.WriteLine("Enter Employee Username: ");
            //        string enteredEmployeeUsername = Console.ReadLine();

            //        Console.WriteLine("Enter Employee Password: ");
            //        string enteredEmployeePassword = Console.ReadLine();

            //        if (enteredEmployeeUsername == employeeUsername && enteredEmployeePassword == employeePassword)
            //        {
            //            Console.WriteLine("Employee login successful!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Employee username or password.");
            //        }
            //        break;

            //    case "customer":

            //        Console.WriteLine("Enter Customer Username: ");
            //        string enteredCustomerUsername = Console.ReadLine();

            //        Console.WriteLine("Enter Customer Password: ");
            //        string enteredCustomerPassword = Console.ReadLine();

            //        if (enteredCustomerUsername == customerUsername && enteredCustomerPassword == customerPassword)
            //        {
            //            Console.WriteLine("Customer login successful!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Customer username or password.");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid user type entered. Please enter 'Employee' or 'Customer'.");
            //        break;
            //}
            #endregion

            #region Task1 4
            //string choice;
            //do
            //{
            //    AssignShipment();

            //    Console.WriteLine("Do you want to continue? (y/n)");
            //    choice = Console.ReadLine();
            //}
            //while (choice.Equals("y", StringComparison.OrdinalIgnoreCase));

            //static void AssignShipment()
            //{
            //    Console.WriteLine("Enter courier ID: ");
            //    int courierId = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter courier weight: ");
            //    int weight = int.Parse(Console.ReadLine());

            //    switch (weight)
            //    {
            //        case int n when (n > 0 && n <= 5):
            //            Console.WriteLine($"CourierID {courierId} is assigned to shipment 1");
            //            break;

            //        case int n when (n > 5 && n <= 10):
            //            Console.WriteLine($"CourierID {courierId} is assigned to shipment 2");
            //            break;

            //        case int n when (n > 10 && n < 15):
            //            Console.WriteLine($"CourierID {courierId} is assigned to shipment 3");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid Input");
            //            break;
            //    }
            //}
            #endregion

            #region task2 5

            //List<Order> orders = new List<Order>()
            //{
            //    new Order { OrderID = 1, CustomerName = "John", OrderDetails = "Laptop" },
            //    new Order { OrderID = 2, CustomerName = "Nithya", OrderDetails = "Smartphone" },
            //    new Order { OrderID = 3, CustomerName = "John", OrderDetails = "Headphones" },
            //    new Order { OrderID = 4, CustomerName = "Sri", OrderDetails = "Tablet" }
            //};

            //Console.WriteLine("Enter the customer's name to display their orders: ");
            //string customerName = Console.ReadLine();

            //Console.WriteLine($"Orders for {customerName}:");
            //bool foundOrder = false;
            //for (int i = 0; i < orders.Count; i++)
            //{
            //    if (orders[i].CustomerName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
            //    {
            //        Console.WriteLine($"Order ID: {orders[i].OrderID}, Details: {orders[i].OrderDetails}");
            //        foundOrder = true;
            //    }
            //}

            //if (!foundOrder)
            //{
            //    Console.WriteLine("No orders found for this customer.");
            //}
            #endregion

            #region Task2 6
            //int currentLocation = 0;
            //int destination = 100;  
            //Console.WriteLine("Tracking courier's real-time location...");

            //while (currentLocation < destination)
            //{

            //    Console.WriteLine($"Courier is at location {currentLocation}.");

            //    Console.WriteLine("Enter the distance traveled by the courier (e.g., 10, 20, etc.): ");
            //    int distanceTraveled = int.Parse(Console.ReadLine());

            //    // Update current location
            //    currentLocation += distanceTraveled;

            //    // Check if courier has reached or passed the destination
            //    if (currentLocation >= destination)
            //    {
            //        Console.WriteLine("Courier has reached the destination!");
            //        break;
            //    }
            //}

            #endregion

            #region Task3 7
            //string[] trackingHistory = new string[10];
            //int locationIndex = 0;
            //string locationUpdate;
            //do
            //{
            //    if (locationIndex >= trackingHistory.Length)
            //    {
            //        Console.WriteLine("Tracking history is full.");
            //        break;
            //    }

            //    Console.WriteLine("Enter parcel location update (or type 'done' to finish): ");
            //    locationUpdate = Console.ReadLine();

            //    if (locationUpdate.ToLower() != "done")
            //    {
            //        trackingHistory[locationIndex] = locationUpdate;
            //        locationIndex++;
            //    }

            //} while (locationUpdate.ToLower() != "done");

            //// Display the tracking history
            //Console.WriteLine("\nTracking History:");
            //for (int i = 0; i < locationIndex; i++)
            //{
            //    Console.WriteLine($"Update {i + 1}: {trackingHistory[i]}");
            //}
            #endregion

            #region Task3 8
            //    Courier[] couriers = new Courier[]
            //    {
            //        new Courier("Courier 1", true, 15),
            //        new Courier("Courier 2", false, 20),
            //        new Courier("Courier 3", true, 10),
            //        new Courier("Courier 4", true, 25)
            //    };

            //    Courier nearestCourier = FindNearestAvailableCourier(couriers);

            //    if (nearestCourier != null)
            //    {
            //        Console.WriteLine($"The nearest available courier is {nearestCourier.Name}, located {nearestCourier.DistanceFromOrder} km away.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No available couriers found.");
            //    }
            //}
            //static Courier FindNearestAvailableCourier(Courier[] couriers)
            //{
            //    Courier nearestCourier = null;
            //    int nearestDistance = int.MaxValue;

            //    for (int i = 0; i < couriers.Length; i++)
            //    {
            //        if (couriers[i].IsAvailable && couriers[i].DistanceFromOrder < nearestDistance)
            //        {
            //            nearestDistance = couriers[i].DistanceFromOrder;
            //            nearestCourier = couriers[i];
            //        }
            //    }

            //    return nearestCourier;

            #endregion

            #region Task4 9
            //string[,] parcelTracking = new string[,]
            //{
            //    { "ABC123", "In Transit" },
            //    { "XYZ456", "Out for Delivery" },
            //    { "LMN789", "Delivered" }
            //};

            //Console.Write("Enter your parcel tracking number: ");
            //string trackingNumber = Console.ReadLine();

            //bool found = false;

            //// Check the status of the parcel by searching the 2D array
            //for (int i = 0; i < parcelTracking.GetLength(0); i++)
            //{
            //    if (parcelTracking[i, 0] == trackingNumber)
            //    {
            //        Console.WriteLine($"Tracking Status: {parcelTracking[i, 1]}");
            //        found = true;
            //        break;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("Tracking number not found.");
            //}
            #endregion

            #region Task4 10
            //    ValidateData("John", "name");
            //    ValidateData("123 Fake Street", "address");
            //    ValidateData("123-456-7890", "phone");
            //}
            //static void ValidateData(string data, string detail)
            //{
            //    switch (detail.ToLower())
            //    {
            //        case "name":
            //            if (Regex.IsMatch(data, @"^[A-Za-z]+$"))
            //                Console.WriteLine("Name is valid.");
            //            else
            //                Console.WriteLine("Invalid name. Names should only contain letters.");
            //            break;

            //        case "address":
            //            if (Regex.IsMatch(data, @"^[A-Za-z0-9\s]+$"))
            //                Console.WriteLine("Address is valid.");
            //            else
            //                Console.WriteLine("Invalid address. Special characters are not allowed.");
            //            break;

            //        case "phone":
            //            if (Regex.IsMatch(data, @"^\d{3}-\d{3}-\d{4}$"))
            //                Console.WriteLine("Phone number is valid.");
            //            else
            //                Console.WriteLine("Invalid phone number. It should be in the format ###-###-####.");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid detail type.");
            //            break;
            //    }
            #endregion

            #region Task4 11
            //    string formattedAddress = FormatAddress("123 main street", "new york", "ny", "10001");
            //    Console.WriteLine(formattedAddress);
            //}

            //static string FormatAddress(string street, string city, string state, string zipCode)
            //{
            //    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            //    street = textInfo.ToTitleCase(street.ToLower());
            //    city = textInfo.ToTitleCase(city.ToLower());
            //    state = state.ToUpper();

            //    return $"{street}, {city}, {state} {zipCode}";
            #endregion

            #region Task4 12
            //    string customerName = "John";
            //    string orderNumber = "ORD123456";
            //    string deliveryAddress = "123 Main Street, New York, NY 10001";
            //    string expectedDeliveryDate = DateTime.Now.AddDays(3).ToShortDateString();

            //    GenerateOrderConfirmationEmail(customerName, orderNumber, deliveryAddress, expectedDeliveryDate);
            //}

            //static void GenerateOrderConfirmationEmail(string name, string orderNumber, string address, string deliveryDate)
            //{
            //    string email = $@"
            //    Dear {name},

            //    Thank you for your order #{orderNumber}. 

            //    Your order will be delivered to the following address:
            //    {address}

            //    Expected delivery date: {deliveryDate}

            //    Best regards,
            //    The Courier Team";

            //    Console.WriteLine(email);
            #endregion

            #region Task4 13
            //    double cost = CalculateShippingCost("New York", "Los Angeles", 5.0);
            //    Console.WriteLine($"Shipping Cost: ${cost}");
            //}

            //static double CalculateShippingCost(string source, string destination, double weight)
            //{
            //    double distance = GetDistanceBetweenLocations(source, destination);
            //    double costPerKm = 0.5;
            //    return distance * costPerKm * weight;
            //}

            //static double GetDistanceBetweenLocations(string source, string destination)
            //{
            //    // In real applications, you'd calculate or retrieve real distances
            //    // For this example, let's assume a dummy distance
            //    return 4000;
            #endregion

            #region Task4 14
            //    string password = GenerateSecurePassword(12);
            //    Console.WriteLine($"Generated Password: {password}");
            //}

            //static string GenerateSecurePassword(int length)
            //{
            //    const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //    const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            //    const string numberChars = "0123456789";
            //    const string specialChars = "!@#$%^&*";

            //    string allChars = upperChars + lowerChars + numberChars + specialChars;
            //    Random random = new Random();
            //    StringBuilder password = new StringBuilder();

            //    for (int i = 0; i < length; i++)
            //    {
            //        password.Append(allChars[random.Next(allChars.Length)]);
            //    }

            //    return password.ToString();
            #endregion

            #region Task4 15
            //    List<string> addresses = new List<string>
            //    {
            //        "123 Main Street",
            //        "123 Main St.",
            //        "456 Elm Street",
            //        "123 Main Street"
            //    };
            //    FindSimilarAddresses(addresses);
            //}
            //static void FindSimilarAddresses(List<string> addresses)
            //{
            //    var duplicateAddresses = addresses.GroupBy(a => a.ToLower())
            //                                      .Where(g => g.Count() > 1)
            //                                      .Select(g => g.Key)
            //                                      .ToList();

            //    if (duplicateAddresses.Count > 0)
            //    {
            //        Console.WriteLine("Similar Addresses Found:");
            //        foreach (var address in duplicateAddresses)
            //        {
            //            Console.WriteLine(address);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("No similar addresses found.");
            //    }
            #endregion

            #region Task4 14
        //    List<string> addresses = new List<string>
        //    {
        //        "123 Main Street",
        //        "123 Main St.",
        //        "456 Elm Street",
        //        "123 Main Street"
        //    };
        //    FindSimilarAddresses(addresses);
        //}
        //static void FindSimilarAddresses(List<string> addresses)
        //{
        //    var duplicateAddresses = addresses.GroupBy(a => a.ToLower())
        //                                      .Where(g => g.Count() > 1)
        //                                      .Select(g => g.Key)
        //                                      .ToList();

        //    if (duplicateAddresses.Count > 0)
        //    {
        //        Console.WriteLine("Similar Addresses Found:");
        //        foreach (var address in duplicateAddresses)
        //        {
        //            Console.WriteLine(address);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("No similar addresses found.");
        //    }
            #endregion
        }
    }
}

