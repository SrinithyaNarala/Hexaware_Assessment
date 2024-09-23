create database Car_Connect
use Car_Connect;
--Create Customer table
CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(15),
    Address VARCHAR(255),
    Username VARCHAR(50) UNIQUE,
    Password VARCHAR(255),
    RegistrationDate DATE
);

--Create Vehicle table
CREATE TABLE Vehicle (
    VehicleID INT PRIMARY KEY,
    Model VARCHAR(50),
    Make VARCHAR(50),
    Year INT,
    Color VARCHAR(30),
    RegistrationNumber VARCHAR(20) UNIQUE,
    Availability BIT,
    DailyRate DECIMAL(10, 2)
);

--Create Reservation table
CREATE TABLE Reservation (
    ReservationID INT PRIMARY KEY,
    CustomerID INT,
    VehicleID INT,
    StartDate DATE,
    EndDate DATE,
    TotalCost DECIMAL(10, 2),
    Status VARCHAR(20),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    FOREIGN KEY (VehicleID) REFERENCES Vehicle(VehicleID)
);

--Create Admin table
CREATE TABLE Admin (
    AdminID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(15),
    Username VARCHAR(50) UNIQUE,
    Password VARCHAR(255),
    Role VARCHAR(50),
    JoinDate DATE
);

--Insert records into Customer table
INSERT INTO Customer (CustomerID, FirstName, LastName, Email, PhoneNumber, Address, Username, Password, RegistrationDate)
VALUES
(001, 'John', 'Doe', 'john.doe@example.com', '1234567890', '123 Elm Street', 'johndoe', 'hashedpassword1', '2024-09-20'),
(002, 'Jane', 'Smith', 'jane.smith@example.com', '9876543210', '456 Oak Avenue', 'janesmith', 'hashedpassword2', '2024-09-18'),
(003, 'Robert', 'Johnson', 'robert.j@example.com', '5554443333', '789 Pine Road', 'robertjohnson', 'hashedpassword3', '2024-09-19');

-- Insert records into Vehicle table
INSERT INTO Vehicle (VehicleID, Model, Make, Year, Color, RegistrationNumber, Availability, DailyRate)
VALUES
(0001, 'Model S', 'Tesla', 2021, 'Red', 'ABC123', 1, 150.00),
(0002, 'Civic', 'Honda', 2020, 'Blue', 'XYZ789', 1, 80.00),
(0003, 'Mustang', 'Ford', 2019, 'Black', 'LMN456', 0, 120.00);

-- Insert records into Reservation table
INSERT INTO Reservation (ReservationID, CustomerID, VehicleID, StartDate, EndDate, TotalCost, Status)
VALUES
(101, 001, 0001, '2024-09-25', '2024-09-28', 450.00, 'confirmed'),
(102, 002, 0002, '2024-10-01', '2024-10-05', 320.00, 'pending'),
(103, 003, 0003, '2024-09-30', '2024-10-03', 360.00, 'completed');

-- Insert records into Admin table
INSERT INTO Admin (AdminID, FirstName, LastName, Email, PhoneNumber, Username, Password, Role, JoinDate)
VALUES
(1, 'Alice', 'Walker', 'alice.w@example.com', '1112223333', 'alicewalker', 'hashedpassword4', 'super admin', '2024-09-20'),
(2, 'Bob', 'Miller', 'bob.m@example.com', '4445556666', 'bobmiller', 'hashedpassword5', 'fleet manager', '2024-09-18'),
(3, 'Charlie', 'Davis', 'charlie.d@example.com', '7778889999', 'charliedavis', 'hashedpassword6', 'admin', '2024-09-19');