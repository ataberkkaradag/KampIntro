
--select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10



--select * from Products inner join Categories on  Products.CategoryID=Categories.CategoryID

--select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryID,Categories.CategoryName 
--from Products inner join Categories on  Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10


--Select * from Products p left join [Order Details] od on p.ProductID=od.ProductID

--Select * from Customers


--Select * from Customers c left join Orders o on  c.CustomerID=o.CustomerID where o.CustomerID is null


--Select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID inner join Orders o on o.OrderID=od.OrderID