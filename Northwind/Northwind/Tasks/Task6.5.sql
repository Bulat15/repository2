SELECT distinct c1.CustomerID,c1.City
FROM Northwind.Customers as c1 , Northwind.Customers as c2 
where (c1.City = c2.City and c1.CustomerID!=c2.CustomerID)

Select City
from Northwind.Customers group by City having count(City) > 1


