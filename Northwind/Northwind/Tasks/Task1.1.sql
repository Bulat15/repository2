﻿SELECT OrderID, ShippedDate,ShipVia FROM Northwind.Orders WHERE ShipVia >= 2 AND  ShippedDate >= CONVERT(DATETIME, '1998-05-06 00:00:00.000',101) 
--заказы с NULL не попали ,потому что колонка должна иметь значения,чтобы удовлетворять условиям 