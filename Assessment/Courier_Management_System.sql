create database Courier_Management_Systems
USE Courier_Management_Systems;

--create user table
CREATE TABLE [User] (
    UserID INT PRIMARY KEY not null,
    Name VARCHAR(255) NOT NULL,
    Email VARCHAR(255) UNIQUE NOT NULL,
    Password VARCHAR(255) NOT NULL,
    ContactNumber VARCHAR(20) NOT NULL,
    Address TEXT
);
--insert values to user table
INSERT INTO [User] (UserID, Name, Email, Password, ContactNumber, Address)
VALUES 
(1, 'Sri', 'sri@gmail.com', 'password123', '1234567890', '4/34 Bng'),
(2, 'Nithya', 'nithya@gmail.com', 'password456', '0987654321', '456 Rama St'),
(3, 'Narala', 'narala@gmail.com', 'pass789', '1122334455', '23 Lotus St'),
(4, 'Ravi', 'ravi@gmail.com', 'pass123', '6677889900', '10 Park Ave'),
(5, 'Priya', 'priya@gmail.com', 'pass321', '5544332211', '78 Oak Rd'),
(6, 'Arun', 'arun@gmail.com', 'pass654', '1123581321', '12 Crescent St'),
(7, 'Deepa', 'deepa@gmail.com', 'deepa123', '1029384756', '14 Rose St'),
(8, 'Kiran', 'kiran@gmail.com', 'kiran123', '9988776655', '55 Pine Rd'),
(9, 'Vimal', 'vimal@gmail.com', 'vimal456', '8877665544', '99 Maple Ln'),
(10, 'Meera', 'meera@gmail.com', 'meera789', '7766554433', '123 Oak St');


--create courierservices table
CREATE TABLE CourierServices (
    ServiceID INT PRIMARY KEY ,
    ServiceName VARCHAR(100) ,
    Cost DECIMAL(8, 2) 
);
--insert values to courierservices table
INSERT INTO CourierServices (ServiceID, ServiceName, Cost)
VALUES 
(1, 'Standard Shipping', 50.00),
(2, 'Express Shipping', 100.00),
(3, 'Same Day Shipping', 150.00),
(4, 'Next Day Shipping', 120.00),
(5, 'International Shipping', 200.00),
(6, 'Two-Day Shipping', 80.00),
(7, 'Economy Shipping', 40.00),
(8, 'Priority Shipping', 130.00),
(9, 'Local Delivery', 30.00),
(10, 'Premium Shipping', 180.00);


--create employee table
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY NOT NULL,
    Name VARCHAR(255) NOT NULL,
    Email VARCHAR(255) UNIQUE NOT NULL,
    ContactNumber VARCHAR(20) NOT NULL,
    Role VARCHAR(50) NOT NULL,
    Salary DECIMAL(10, 2) NOT NULL
);
--insert values to employee table
INSERT INTO Employee (EmployeeID, Name, Email, ContactNumber, Role, Salary)
VALUES 
(1, 'Ram', 'ram@gmail.com', '1234567890', 'Manager', 50000.00),
(2, 'Sita', 'sita@gmail.com', '0987654321', 'Agent', 30000.00),
(3, 'Lakshman', 'lakshman@gmail.com', '9876543210', 'Driver', 25000.00),
(4, 'Ravi', 'ravi@gmail.com', '9998887776', 'Clerk', 22000.00),
(5, 'Priya', 'priya@gmail.com', '5566778899', 'Agent', 28000.00),
(6, 'Nisha', 'nisha@gmail.com', '9988776655', 'Driver', 26000.00),
(7, 'Amit', 'amit@gmail.com', '8877665544', 'Manager', 52000.00),
(8, 'Kiran', 'kiran@gmail.com', '7766554433', 'Dispatcher', 24000.00),
(9, 'Meera', 'meera@gmail.com', '6677889900', 'Supervisor', 46000.00),
(10, 'Raj', 'raj@gmail.com', '5566774455', 'Driver', 25000.00);


--create location table
CREATE TABLE Location (
    LocationID INT PRIMARY KEY,
    LocationName VARCHAR(100) NOT NULL,
    Address TEXT NOT NULL
);
--insert values to location table
INSERT INTO Location (LocationID, LocationName, Address)
VALUES 
(1, 'Pulivendula', 'Rama Street'),
(2, 'Kadapa', 'Gandhi Street'),
(3, 'Hyderabad', 'Banjara Hills'),
(4, 'Chennai', 'T. Nagar'),
(5, 'Bangalore', 'Indira Nagar'),
(6, 'Mumbai', 'Andheri West'),
(7, 'Delhi', 'Connaught Place'),
(8, 'Kolkata', 'Salt Lake City'),
(9, 'Pune', 'Koregaon Park'),
(10, 'Ahmedabad', 'Satellite Road');


--create courier table
CREATE TABLE Courier
	(CourierID INT PRIMARY KEY,
	UserID INT NOT NULL,
	ServiceID INT,
	EmployeeID INT NOT NULL,
	ReceiverName VARCHAR(255) NOT NULL,
	SenderName VARCHAR(255),
	SenderAddress TEXT,
	ReceiverAddress TEXT,
	LocationID INT NOT NULL,
	Weight DECIMAL(5, 2),
	Status VARCHAR(50),
	TrackingNumber VARCHAR(20) UNIQUE,
	OrderedDate DATE,
	DeliveryDate DATE,
	FOREIGN KEY (UserID) REFERENCES [User](UserID),
	FOREIGN KEY (ServiceID) REFERENCES CourierServices(ServiceId),
	FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeId)
);
--insert values to courier table
INSERT INTO Courier (CourierID, UserID, ServiceID, EmployeeID, ReceiverName, SenderName, SenderAddress, ReceiverAddress, LocationID, Weight, Status, TrackingNumber, OrderedDate, DeliveryDate)
VALUES
(1, 1, 1, 1, 'Sita', 'Ram', '123 Main St', '4 Gandhi St', 1, 5.00, 'On Progress', 'T001', '2024-09-01', '2024-09-05'),
(2, 2, 2, 2, 'Krishna', 'Radha', '456 Main St', '3 Patel St', 2, 10.00, 'Delivered', 'T002', '2023-09-18', '2023-09-20'),
(3, 3, 3, 3, 'Lakshmi', 'Mohan', '789 Temple St', '5 Lakshmi St', 3, 2.50, 'In Transit', 'T003', '2024-09-15', '2024-09-20'),
(4, 1, 2, 2, 'Geetha', 'Shyam', '101 Broadway', '6 College Rd', 4, 3.00, 'Delivered', 'T004', '2023-09-10', '2023-09-15'),
(5, 2, 1, 1, 'Ravi', 'Hari', '234 High St', '7 River Rd', 5, 4.20, 'On Progress', 'T005', '2024-09-18', '2024-09-22'),
(6, 3, 3, 3, 'Maya', 'Gopal', '567 Oak St', '8 Park Ave', 6, 8.00, 'Delivered', 'T006', '2023-08-15', '2023-08-18'),
(7, 1, 1, 1, 'Surya', 'Anil', '890 Maple St', '9 Spring St', 7, 1.50, 'In Transit', 'T007', '2024-09-17', '2024-09-21'),
(8, 2, 2, 2, 'Manju', 'Ravi', '111 Cedar St', '10 Hill Rd', 8, 7.00, 'Delivered', 'T008', '2023-07-20', '2023-07-25'),
(9, 1, 1, 1, 'Raj', 'Bala', '222 Elm St', '11 Lake Rd', 9, 9.50, 'On Progress', 'T009', '2024-09-19', '2024-09-24'),
(10, 3, 3, 3, 'Pooja', 'Raj', '333 Pine St', '12 Ocean Dr', 10, 6.00, 'In Transit', 'T010', '2024-09-16', '2024-09-20');


--create payment table
CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY NOT NULL,
    CourierID INT,
    LocationID INT,
    Amount DECIMAL(10, 2) ,
    PaymentDate DATE NOT NULL,
    FOREIGN KEY (CourierID) REFERENCES Courier(CourierID),
    FOREIGN KEY (LocationID) REFERENCES Location(LocationID)
);
--insert values to payment table
INSERT INTO Payment (PaymentID, CourierID, LocationID, Amount, PaymentDate)
VALUES 
(1, 1, 1, 500.00, '2024-09-05'),  
(2, 2, 1, 1000.00, '2024-09-06'), 
(3, 3, 2, 750.00, '2024-09-07'),  
(4, 4, 3, 850.00, '2024-09-08'),  
(5, 5, 2, 1200.00, '2024-09-09'), 
(6, 6, 4, 650.00, '2024-09-10'),  
(7, 7, 5, 500.00, '2024-09-11'),  
(8, 8, 1, 1100.00, '2024-09-12'), 
(9, 9, 4, 900.00, '2024-09-13'),  
(10, 10, 5, 1300.00, '2024-09-14');


select * from [User];
select * from Employee;
select * from Location;
select * from CourierServices;
select * from Courier;
select * from Payment;

--Task 2:

--1. List all customers:
select * from [user]
--2. List all orders for a specific customer:
select * from Courier where SenderName='Ram';
--3. List all couriers:
select * from Courier
--4. List all packages for a specific receiver:
select * from Courier where ReceiverName='maya';
--5. List all deliveries for a specific courier:
SELECT * FROM Courier
WHERE CourierID = 1;
--6. List all undelivered packages:
update courier
set status='not delivered' where CourierID=3 or CourierID=5
select * from Courier where Status='not Delivered'
--7. List all packages that are scheduled for delivery today: 
update courier
set DeliveryDate='2024-09-23' where CourierID=3
SELECT * FROM Courier
WHERE DeliveryDate = CAST(GETDATE() AS DATE);
--8. List all packages with a specific status: 
SELECT * FROM Courier
WHERE Status = 'delivered';

--9. Calculate the total number of packages for each courier.
SELECT CourierID, COUNT(*) AS TotalPackages
FROM Courier
GROUP BY CourierID;

--10. Find the average delivery time for each courier
select SenderName,avg(datediff (day, OrderedDate, DeliveryDate)) as AverageDeliveryTime from Courier group By SenderName;


--11. List all packages with a specific weight range: 
SELECT * FROM Courier
WHERE Weight BETWEEN 1 AND 9;

--12. Retrieve employees whose names contain 'John' 

update Employee 
set Name='john',email='john@gmail.com' where EmployeeID = 10;

SELECT * FROM Employee
WHERE Name LIKE '%John%';

--13. Retrieve all courier records with payments greater than $50.
SELECT C.*
FROM Courier C
JOIN Payment P ON C.CourierID = P.CourierID
WHERE P.Amount > 50;

--Task 3: GroupBy, Aggregate Functions, Having, Order By, where

--14. Find the total number of couriers handled by each employee.
select 
	e.EmployeeID, 
	e.Name, 
	count(c.UserID) as Total_Couriers
from 
	Courier as c right join Employee as e
	on c.EmployeeID = e.EmployeeID
group by
	e.EmployeeID,
	e.Name;
	select * from Employee;

--15. Calculate the total revenue generated by each location
select 
	l.LocationID, 
	l.LocationName, 
	sum(p.Amount) as Total_Revenue
from 
	Payment as p right join Location as l
	on p.LocationID = l.LocationID
group by
	l.LocationName,
	l.LocationID;


--16. Find the total number of couriers delivered to each location.
select 
	l.LocationID, 
	l.LocationName, 
	count(CourierID) as Courier_Counts
from 
	Courier right join Location as l
	on Courier.LocationID = l.LocationID
group by
	l.LocationID,
	l.LocationName;


--17. Find the courier with the highest average delivery time:
select 
	top 1 CourierID, 
	avg(datediff(day, OrderedDate, DeliveryDate)) as AvgDeliveryTime
from 
	Courier
group by 
	CourierID
order by
	AvgDeliveryTime desc;


--18. Find Locations with Total Payments Less Than a Certain Amount
select 
	l.LocationID, 
	l.LocationName, 
	sum(p.Amount) as Total_Revenue
from 
	Payment as p join Location as l
	on p.LocationID = l.LocationID
group by
	l.LocationName,
	l.LocationID
having 
	sum(p.Amount) < 2000;


--19. Calculate Total Payments per Location
select 
	l.LocationID, 
	l.LocationName, 
	count(p.PaymentID) as Total_Payments
from 
	Payment as p right join Location as l
	on p.LocationID = l.LocationID
group by
	l.LocationName,
	l.LocationID;


--20. Retrieve couriers who have received payments totaling more than $1000 in a specific location (LocationID = X)
select 
	CourierID
from 
	Payment
where (Amount > 1000) and LocationID = 2


--21. Retrieve couriers who have received payments totaling more than $1000 after a certain date (PaymentDate > 'YYYY-MM-DD')
select 
	CourierID
from 
	Payment
where (Amount > 1000) and PaymentDate > '2024-09-08'


--22. Retrieve locations where the total amount received is more than $5000 before a certain date (PaymentDate > 'YYYY-MM-DD')
select 
	l.LocationName, 
	l.LocationID, 
	sum(Amount) as Total_Amount
from 
	Payment join Location as l
	on l.LocationID = Payment.LocationID
where
	PaymentDate > '2024-09-07'
group by
	l.LocationID,
	l.LocationName
having
	sum(Amount) > 1000 

--Task 4: Inner Join,Full Outer Join, Cross Join, Left Outer Join,Right Outer Join

--23. Retrieve Payments with Courier Information
select
	Payment.PaymentID, 
	Payment.Amount, 
	Payment.PaymentDate, 
	Courier.*
from 
	Payment join Courier
	on Payment.CourierID = Courier.CourierID


--24. Retrieve Payments with Location Information
select
	Payment.PaymentID, 
	Payment.Amount, 
	Payment.PaymentDate, 
	Location.*
from 
	Payment join Location
	on Payment.LocationID = Location.LocationID


--25. Retrieve Payments with Courier and Location Information
select
	Payment.PaymentID, 
	Payment.Amount, 
	Payment.PaymentDate, 
	Courier.*, 
	Location.LocationName, 
	Location.Address
from
	Payment join Courier
	on Payment.CourierID = Courier.CourierID
	join Location
	on Location.LocationID = Payment.LocationID


--26. List all payments with courier details
select
	Payment.PaymentID, 
	Payment.Amount, 
	Payment.PaymentDate, 
	Courier.*
from 
	Payment join Courier
	on Payment.CourierID = Courier.CourierID


--27. Total payments received for each courier
select 
	c.CourierID, 
	sum(p.Amount) as Total_Payments
from
	Courier as c join Payment as p
	on c.CourierID = p.CourierID
group by
	c.CourierID


--28. List payments made on a specific date
select
	p.PaymentID, 
	p.Amount
from
	Payment as p
where 
	PaymentDate = '2024-09-07'


--29. Get Courier Information for Each Payment
select
	p.PaymentID, 
	p.Amount, 
	p.PaymentDate, 
	c.*
from 
	Courier as c join Payment as p
	on c.CourierID = p.CourierID


--30. Get Payment Details with Location
select
	p.PaymentID, 
	p.Amount, 
	p.PaymentDate, 
	l.*
from
	Location as l join Payment as p
	on l.LocationID = p.LocationID


--31. Calculating Total Payments for Each Courier
select
	c.*, 
	p.Amount
from 
	Courier as c left join Payment as p
	on c.CourierID = p.CourierID

--32. List Payments Within a Date Range
select * from Payment 
where 
	PaymentDate between '2024-09-05' and '2024-09-11'


--33. Retrieve a list of all users and their corresponding courier records, including cases where there are no matches on either side 
select 
    u.UserID, 
    u.Name as UserName, 
    u.Email, 
    u.ContactNumber, 
    c.*
from 
    [User] as u full outer join Courier as c 
	on u.UserID = c.UserID;


--34. Retrieve a list of all couriers and their corresponding services, including cases where there are no matches on either side
select 
	cs.Cost,
	cs.ServiceID,
	cs.ServiceName,
    c.*
from 
    Courier as c full outer join CourierServices as cs
	on c.ServiceID = cs.ServiceID


--35. Retrieve a list of all employees and their corresponding payments, including cases where there are no matches on either side
select
	e.*,
	p.PaymentID,
	p.PaymentDate,
	p.Amount
from 
	Employee as e full outer join Courier as c
	on e.EmployeeID = c.EmployeeID
	full outer join Payment as p
	on p.CourierID = c.CourierID


--36. List all users and all courier services, showing all possible combinations.
select * from [User] 
cross join CourierServices 


--37. List all employees and all locations, showing all possible combinations:
select * from Employee
cross join Location


--38. Retrieve a list of couriers and their corresponding sender information (if available)
select 
    Courier.CourierID, 
    Courier.TrackingNumber, 
    Courier.Status, 
    Courier.OrderedDate, 
    Courier.DeliveryDate, 
    Courier.SenderName, 
    Courier.SenderAddress
from 
    Courier
where 
    Courier.SenderName is not null and Courier.SenderAddress is not null



--39. Retrieve a list of couriers and their corresponding receiver information (if available):
select 
    Courier.CourierID, 
    Courier.TrackingNumber, 
    Courier.Status, 
    Courier.OrderedDate, 
    Courier.DeliveryDate, 
    Courier.ReceiverName, 
    Courier.ReceiverAddress
from 
    Courier
where 
    Courier.ReceiverName is not null and Courier.ReceiverAddress is not null



--40. Retrieve a list of couriers along with the courier service details (if available):
select 
	c.CourierID,
	cs.*
from 
	Courier as c left join CourierServices as cs
	on cs.ServiceID = c.ServiceID


--41. Retrieve a list of employees and the number of couriers assigned to each employee:
select
	e.EmployeeID,
	e.Name as EmpName,
	count(c.CourierID) as Total_Couriers
from 
	Employee as e left join Courier as c
	on e.EmployeeID = c.EmployeeId
group by
	e.EmployeeID,
	e.Name


--42. Retrieve a list of locations and the total payment amount received at each location:
select
	l.LocationID,
	l.LocationName,
	sum(p.Amount) as Total_Payment
from 
	Location as l left join Payment as p
	on l.LocationID = p.LocationID
group by
	l.LocationID,
	l.LocationName


--43. Retrieve all couriers sent by the same sender (based on SenderName).
select
	c.CourierID,
	c.OrderedDate,
	c.DeliveryDate,
	c.ReceiverName,
	u.UserID as SenderID,
	u.Name as SenderName
from 
	Courier as c join [User] as u
	on c.UserID = u.UserID
where 
	u.Name = 'Narala'


--44. List all employees who share the same role.
select * from Employee as e
where 
    e.role IN (select role from Employee
        group by role
        having count(*) > 1)
order by e.role;


--45. Retrieve all payments made for couriers sent from the same location.
select
	l.LocationID,
	l.LocationName,
	sum(p.Amount) as Total_Amount
from 
	Payment as p join Location as l
	on p.LocationID = l.LocationID
group by
	l.LocationID,
	l.LocationName

--46. Retrieve all couriers sent from the same location (based on SenderAddress).
select c.* from Courier c 
join Payment p on c.CourierID = p.CourierID 
join Location l on l.LocationID = p.LocationID
where cast(c.SenderAddress as varchar (50)) = '123 Main St' 


--47. List employees and the number of couriers they have delivered:
select e.EmployeeID, e.Name AS EmployeeName, COUNT(c.CourierID) AS DeliveredCouriers
from Employee e
left join Courier c ON e.EmployeeID = c.CourierID
WHERE c.Status = 'Delivered'
GROUP BY e.EmployeeID, e.Name;


--48. Find couriers that were paid an amount greater than the cost of their respective courier services 
select c.*, cs.*
from Courier c
join CourierServices cs on c.CourierID = cs.ServiceID
join Payment p on c.CourierID = p.CourierID
where p.Amount > cs.Cost;


--Scope: Inner Queries, Non Equi Joins, Equi joins,Exist,Any,All

--49. Find couriers that have a weight greater than the average weight of all couriers
select * from Courier where weight >(select avg(weight) from Courier)


--50. Find the names of all employees who have a salary greater than the average salary:
select * from Employee where Salary >(select avg(Salary) from Employee)


--51. Find the total cost of all courier services where the cost is less than the maximum cost
select sum(Amount) as TotalCost 
from Payment 
where Amount <(select max(Amount) as total from Payment)
	 


--52. Find all couriers that have been paid for
select c.* from Courier c where CourierID in (
select p.CourierID 
from Payment p )


--53. Find the locations where the maximum payment amount was made
select l.LocationName,p.Amount from Location l join Payment p on 
l.LocationID = p.LocationID where p.amount=
(select max(Amount) from Payment)


--54. Find all couriers whose weight is greater than the weight of all couriers sent by a specific sender (e.g., 'SenderName'):
select * from Courier where weight>(
	select sum(weight) from Courier where SenderName='Ram')