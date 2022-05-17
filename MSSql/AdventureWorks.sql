--FirstName, LastName, BirthDate
select p.FirstName, p.LastName, hr.BirthDate
from Person.Person as p
    inner join HumanResources.Employee as hr on hr.BusinessEntityID=p.BusinessEntityID
    inner join HumanResources.EmployeeDepartmentHistory as hed on hed.BusinessEntityID=p.BusinessEntityID
where hed.EndDate is  null

--Employee FirstName, LastName, Phone Type, Phone number
select p.FirstName, p.LastName, type.Name, phone.PhoneNumber
from Person.Person as p
    inner join Person.PersonPhone as phone on phone.BusinessEntityID=p.BusinessEntityID
    inner join Person.PhoneNumberType as type on type.PhoneNumberTypeID=phone.PhoneNumberTypeID
    inner join HumanResources.EmployeeDepartmentHistory as hed on hed.BusinessEntityID=p.BusinessEntityID
where hed.EndDate is null

--employee FirstName, LastName, department
select p.FirstName, p.LastName, hdep.Name
from person.Person as p
    inner join HumanResources.EmployeeDepartmentHistory as hed on hed.BusinessEntityID=p.BusinessEntityID
    inner join HumanResources.Department as hdep on hdep.DepartmentID=hed.DepartmentID
where hed.EndDate is null

---- Finance departmanında kaç adet çalışan var?
select COUNT(*)
from Person.Person as p
    inner join HumanResources.EmployeeDepartmentHistory as hed on hed.BusinessEntityID=p.BusinessEntityID
    inner join HumanResources.Department as hdep on hdep.DepartmentID=hed.DepartmentID
where  LOWER(hdep.Name)='finance' and hed.EndDate is null

--Employee firstName, LastName and home phone
select p.FirstName, p.LastName, PhoneType.Name, Phone.PhoneNumber
from Person.Person as p
    inner join Person.PersonPhone as Phone on Phone.BusinessEntityID=p.BusinessEntityID
    inner join HumanResources.EmployeeDepartmentHistory as hed on hed.BusinessEntityID=p.BusinessEntityID
    inner join Person.PhoneNumberType as PhoneType on  PhoneType.PhoneNumberTypeID=Phone.PhoneNumberTypeID
WHERE LOWER(PhoneType.Name)='home' and hed.EndDate is null

--CustomerID with highest order number
select top 1
    CustomerID, COUNT(CustomerID)
from Sales.SalesOrderHeader as soh
where soh.Status=5
group by soh.CustomerID
order by COUNT(soh.CustomerID) desc

--The most expensive sale
select top 1
    *
from Sales.SalesOrderHeader as sod
order by sod.TotalDue desc

--Which terrotory spends more money
select soh.TerritoryID
from Sales.SalesOrderHeader as soh
group by soh.TerritoryID
order by max(soh.TotalDue) desc

--How many order are overdue
select count(*)
from Sales.SalesOrderHeader as soh
where soh.ShipDate>soh.DueDate

--Which region's orders are most delayed
select top 1
    soh.TerritoryID
from Sales.SalesOrderHeader as soh
where soh.ShipDate>soh.DueDate
group by soh.TerritoryID

--How many orders have been done with Vista creditcard
select *
from Sales.SalesOrderHeader as soh
    inner join Sales.CreditCard as sc on sc.CreditCardID=soh.CreditCardID
where lower(sc.CardType)='vista'


--Shipment price less than 50
select *
from Sales.SalesOrderHeader as soh
where soh.Freight<50
