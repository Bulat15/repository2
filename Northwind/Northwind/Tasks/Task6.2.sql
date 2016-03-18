SELECT COUNT(ord.OrderID) AS Amount, ord.EmployeeID, (SELECT CONCAT(emp.FirstName, ' ', emp.LastName)  from Northwind.Employees emp where emp.EmployeeID = ord.EmployeeID ) as 'Seller'
FROM Northwind.Orders ord
GROUP BY ord.EmployeeID
ORDER BY COUNT(ord.OrderID) DESC