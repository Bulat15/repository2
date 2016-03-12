select count(OrderId) as 'TotaL',YEAR(OrderDate) AS 'YEAR' from Northwind.Orders GROUP BY YEAR(OrderDate)
SELECT COUNT(ORDERID) FROM Northwind.Orders