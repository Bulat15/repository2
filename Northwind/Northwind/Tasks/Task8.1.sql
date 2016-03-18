SELECT c.CompanyName,count(o.OrderID) as  'KOL Orders'
FROM Northwind.Customers c
LEFT OUTER JOIN Northwind.Orders o ON c.CustomerID = o.CustomerID group by c.CompanyName order by 'KOL Orders' 