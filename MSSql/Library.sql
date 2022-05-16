CREATE TABLE User
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(155) NOT NULL,
    LastName NVARCHAR(55) NOT NULL,
    EMail NVARCHAR(255) NOT NULL UNIQUE,
    Phone VARCHAR(50) NOT NULL
)

CREATE TABLE Book
(
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(MAX) NOT NULL,
    PublishOn DATE NOT NULL
)


CREATE TABLE Borrow
(
    UserID INT NOT NULL,
    Due DATE NOT NULL,
    Return DATE
    )