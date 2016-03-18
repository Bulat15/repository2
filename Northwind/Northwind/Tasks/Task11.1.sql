SELECT ContactName
FROM Northwind.Customers
WHERE NOT EXISTS 
  (SELECT CustomerID  
   FROM Northwind.Orders 
   WHERE Customers.CustomerID = Orders.CustomerID
  )