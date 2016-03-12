SELECT OrderID,ShippedDate=
CASE 
 WHEN ShippedDate IS NULL THEN 'Not Shipped'
END
 FROM Northwind.Orders where ShippedDate IS NULL