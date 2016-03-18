SELECT c.ContactName AS Person, 'Customer' AS Type,c.City AS City
FROM Northwind.Customers AS c
WHERE EXISTS (
              SELECT e.City 
              FROM Northwind.Employees AS e
              WHERE e.City=c.City
              )
UNION ALL
SELECT e.FirstName+' '+e.LastName AS Person, 'Seller' AS Type,e.City AS City
FROM Northwind.Employees AS e
WHERE EXISTS (
              SELECT c.City 
              FROM Northwind.Customers AS c
              WHERE e.City=c.City
              )