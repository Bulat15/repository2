﻿select ContactName,Country from Northwind.Customers where Country not in ('usa','Canada') order by ContactName