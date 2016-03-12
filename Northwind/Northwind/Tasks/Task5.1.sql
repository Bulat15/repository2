select round(cast(sum(UnitPrice-(UnitPrice*Discount)/100) as money ),2) as Totals  from  Northwind.[Order Details]
 