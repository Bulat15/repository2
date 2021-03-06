﻿SELECT 
CASE 
  WHEN EmployeeID is null THEN 'All'
  ELSE (SELECT LastName + ' ' + FirstName FROM Northwind.Employees AS emp WHERE emp.EmployeeID = ord.EmployeeID) 
END AS 'Seller',
CASE 
  WHEN CustomerID is null THEN 'All'
  ELSE (SELECT CompanyName FROM Northwind.Customers AS cust WHERE cust.CustomerID = ord.CustomerID) 
END AS 'Customer', Amount FROM 
(SELECT EmployeeID, CustomerID, COUNT(*) AS Amount, GROUPING(EmployeeID) AS [Grouping]
 FROM Northwind.Orders 
 GROUP BY EmployeeID, CustomerID WITH CUBE) ord
ORDER BY Seller, Customer, Amount DESC