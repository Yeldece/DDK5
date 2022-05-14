CREATE TABLE Users
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(255) NOT NULL,
    LastName NVARCHAR(255) NOT NULL,
    EMail NVARCHAR(255) UNIQUE NOT NULL,
    Password NVARCHAR(MAX) NOT NULL,
    Registration DATE NOT NULL,
    Phone NVARCHAR(MAX) NOT NULL,
    Address NVARCHAR(MAX) NOT NULL,
    City NVARCHAR(MAX) NOT NULL,
    Town NVARCHAR(MAX) NOT NULL
)

CREATE TABLE Products
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(MAX) NOT NULL,
    UnitPrice MONEY
)

CREATE TABLE Failures
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT NOT NULL,
    Received DATE NOT NULL,
    FailureDescriptionUser NVARCHAR(MAX),
    ServiceInfo NVARCHAR(MAX) NOT NULL,
    FailureCategoryID INT NOT NULL,
    Cost MONEY NOT NULL,
    DeliveryDate DATE,
    Status INT NOT NULL,
    ResponsibleEmployeeID int,
    CustomerID INT NOT NULL,
)

CREATE TABLE Employee
(
    ID INT PRIMARY KEY IDENTITY(1, 1),
    FirstName NVARCHAR(MAX) NOT NULL,
    LastName NVARCHAR(MAX) NOT NULL,
    PhoneInternal NVARCHAR(MAX) NOT NULL,
    PhonePersonal NVARCHAR(MAX) NOT NULL
)

CREATE TABLE FailureCategories
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(MAX) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL
)

CREATE TABLE Statuses
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(MAX) NOT NULL,
)


INSERT into Users
VALUES('hamza', 'yavas', 'yavashamza@hotmail.com', 'pwpw1111', '1999-05-04', '5324567574', 'gurbuz sokak yavas cad no 32 daire 55', 'istanbul', 'cihangir')
--Baska veriler diger tablolara girilmistir.

CREATE PROCEDURE SP_AddCustomer(@FirstName NVARCHAR(255),
    @LastName NVARCHAR(255),
    @EMail NVARCHAR(255),
    @pw NVARCHAR(MAX),
    @registration DATE,
    @phone NVARCHAR(MAX),
    @Address NVARCHAR(MAX),
    @City NVARCHAR(max),
    @Town NVARCHAR(MAX))
as
begin
    INSERT INTO Users
    VALUES(@FirstName, @LastName, @EMail, @pw, @registration, @phone, @Address, @City, @Town)
END
EXEC SP_AddCustomer 'hakki', 'tapiyor', 'tapanhakki@hakki.com','tapmayadevam', '2014-06-10','5320121212', 'tapan caddesi hakka sokak no nill daire null', 'swift','c#'


CREATE PROCEDURE SP_CheckStatus(@ID int)
AS
BEGIN
    SELECT s.Name
    FROM Faliure as f
        INNER JOIN Statuses as s on s.ID=f.[Status]
END

CREATE PROCEDURE SP_FindUserFromItem(@ID int)
AS
BEGIN
    SELECT *
    FROM Failures as f
        INNER JOIN Users as u on u.ID=f.CustomerID
END

CREATE PROCEDURE SP_ItemsByUser(@ID int)
AS
BEGIN
SELECT (p.Name) ProductName,  (s.Name) Status  FROM Failures as f
INNER JOIN Products as p on p.ID=f.ProductID
INNER JOIN Statuses as s on f.[Status]=s.ID
WHERE f.CustomerID=@ID
    END

EXEC SP_ItemsByUser 1

