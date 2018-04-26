﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select t.CategoryName, p.ProductName,c.City,c.CompanyName,d.Quantity " &_
    "from (Orders m inner join  " &_
    "(OrderDetails as d inner join (Products p inner join Categories t on p.CategoryID=t.CategoryID) " &_
    "on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " &_
    "left join Customers c on c.CustomerID=m.CustomerID " &_
    "where m.OrderDate between '1997-1-1' and '1997-3-31' " &_
    "order by t.CategoryName,p.ProductName,c.City,c.CompanyName "
GenNodeXmlData(QuerySQL)
%> 