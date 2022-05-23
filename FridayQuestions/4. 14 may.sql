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

--Veri ekleme ornegi
INSERT into Users
VALUES('hamza', 'yavas', 'yavashamza@hotmail.com', 'pwpw1111', '1999-05-04', '5324567574', 'gurbuz sokak yavas cad no 32 daire 55', 'istanbul', 'cihangir')

--Kullanici ekleyen procedure
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

--Aldigi ID'li Kullanicinin telefon numarasini degistiren procedure
CREATE PROCEDURE SP_UpdateUserPhone(@ID int,
    @Phone NVARCHAR(255))
AS
BEGIN
    UPDATE Users
SET Phone=@phone
WHERE ID=@ID
END
EXEC SP_UpdateUserPhone 5, '5070100102'

--Verilen ID'ye sahip kullaniciyi silen procedure
CREATE PROCEDURE SP_DeleteUserByID(@ID int)
AS
BEGIN
    DELETE Users WHERE ID=@ID
END

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
    SELECT (p.Name) ProductName, (s.Name) Status
    FROM Failures as f
        INNER JOIN Products as p on p.ID=f.ProductID
        INNER JOIN Statuses as s on f.[Status]=s.ID
    WHERE f.CustomerID=@ID
END

EXEC SP_ItemsByUser 1

--Kategoriye gore yillik ariza kaydi
CREATE PROCEDURE SP_YearlyFailureRecord(@Year int)
AS
BEGIN
    SELECT fc.Name, (COUNT(f.ID)) as FailureCount
    FROM Failures as f
        INNER JOIN FailureCategories as fc on fc.ID=f.FailureCategoryID
        INNER JOIN Products as p on f.ProductID=p.ID
    WHERE YEAR(f.Received)=@Year
    GROUP BY fc.Name
END

EXEC SP_YearlyFailureRecord 2010

--Girilen aya ait kayitlar
CREATE PROCEDURE SP_MonthlyFailureRecords(@month int)
AS
BEGIN
    SELECT fc.Name, (COUNT(f.ID)) as FailureCount
    FROM Failures as f
        INNER JOIN FailureCategories as fc on fc.ID=f.FailureCategoryID
        INNER JOIN Products as p on f.ProductID=p.ID
    WHERE MONTH(f.Received)=@month
    GROUP BY fc.Name
END

--girilen gune ait sayilar
CREATE PROCEDURE DaylyRecords(@Day int)
AS
BEGIN
    SELECT fc.Name, (COUNT(f.ID)) as FailureCount
    FROM Failures as f
        INNER JOIN FailureCategories as fc on fc.ID=f.FailureCategoryID
        INNER JOIN Products as p on f.ProductID=p.ID
    WHERE DAY(f.Received)=@Day
    GROUP BY fc.Name
END

--Girilen tarihe ait toplam kazanc
CREATE PROCEDURE SP_EarningOnDay(@DateOn date)
AS
BEGIN
    SELECT SUM(f.Cost)
    FROM Failures as f
    WHERE f.Received=@DateOn
END

--Aylik personal performansi
CREATE VIEW VW_MonthlyEmployeePerformance
AS
    SELECT f.ResponsibleEmployeeID, COUNT(f.ID) Finished, MONTH(f.DeliveryDate) MonthOnDelivery
    FROM Failures as f
    GROUP BY f.ResponsibleEmployeeID, MONTH(f.DeliveryDate)

