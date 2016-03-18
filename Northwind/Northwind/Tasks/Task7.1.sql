select distinct t.TerritoryDescription,e.LastName from
Northwind.Employees e inner join Northwind.EmployeeTerritories et
on e.EmployeeID=et.EmployeeID 
inner join
Northwind.Territories t on t.TerritoryID=et.TerritoryID
inner join 
Northwind.Region r on t.RegionID=r.RegionID where r.RegionID=2