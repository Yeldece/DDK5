CREATE TABLE Product
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    UnitPrice MONEY NOT NULL,
    Stock INT NOT NULL,
    PublishDate DATETIME NOT NULL
)

CREATE TABLE Customer
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(255) NOT NULL,
    LastName NVARCHAR(255) NOT null,
    Nick NVARCHAR(50) NOT null UNIQUE,
)


CREATE TABLE Order
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT null,
    OrderDate DATETIME NOT NULL,
    ShipDate DATETIME,
    ShipVia INT,
    ShipAddress NVARCHAR(1000),
    ShipCity INT,
    ShipTown INT,
    ShipCountry INT
)

CREATE TABLE OrderDetail
(
    ID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    Discount REAL NOT NULL
)

CREATE TABLE Category
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(150) NOT NULL,
    Description NVARCHAR(500) NOT NULL,
    ParentCategory INT
)

CREATE TABLE Favori
(
    CustomerID INT NOT NULL,
    ProductID NOT NULL
)

CREATE TABLE City
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(400) NOT NULL,
    CountryID INT NOT NULL
)

CREATE TABLE CityTown
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(500) NOT NULL,
    CityID INT NOT NULL
)
