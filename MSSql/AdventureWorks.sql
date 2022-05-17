--soru1 FirstName, LastName, BirthDate
select p.FirstName, p.LastName, hr.BirthDate
from Person.Person as p
    inner join HumanResources.Employee as hr on hr.BusinessEntityID=p.BusinessEntityID

--soru2 FirstName, LastName, Phone Type, Phone number
select p.FirstName, p.LastName, type.Name, phone.PhoneNumber
from Person.Person as p
    inner join Person.PersonPhone as phone on phone.BusinessEntityID=p.BusinessEntityID
    inner join Person.PhoneNumberType as type on type.PhoneNumberTypeID=phone.PhoneNumberTypeID

--soru3 FirstName, LastName, department
select p.FirstName, p.LastName, hdep.Name
from person.Person as p
    inner join HumanResources.EmployeeDepartmentHistory as hed on hed.BusinessEntityID=p.BusinessEntityID
    inner join HumanResources.Department as hdep on hdep.DepartmentID=hed.DepartmentID
where hed.EndDate is null

--soru4 -- Finance departmanında kaç adet çalışan var?
select COUNT(*)
from Person.Person as p
    inner join HumanResources.EmployeeDepartmentHistory as hed on hed.BusinessEntityID=p.BusinessEntityID
    inner join HumanResources.Department as hdep on hdep.DepartmentID=hed.DepartmentID
where  LOWER(hdep.Name)='finance' and hed.EndDate is null

