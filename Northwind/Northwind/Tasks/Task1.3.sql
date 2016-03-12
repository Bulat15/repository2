
SELECT OrderID as 'Order Number','Shipped Date'= 
case
 WHEN ShippedDate IS NULL THEN 'Not Shipped'
 else cast(ShippedDate as varchar)
END
 FROM Northwind.Orders WHERE ShippedDate >= cast (CONVERT(DATETIME, '1998-05-06 00:00:00.000',101) as varchar)
