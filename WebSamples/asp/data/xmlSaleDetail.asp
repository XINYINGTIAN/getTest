﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,M.Freight, "
QuerySQL = QuerySQL & "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.Discount, " 
QuerySQL = QuerySQL & "d.UnitPrice*d.Quantity as Amount, d.UnitPrice*d.Quantity*d.Discount as DiscountAmt, "
QuerySQL = QuerySQL & "d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount "
QuerySQL = QuerySQL & "from (Orders m inner join "
QuerySQL = QuerySQL & "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) "
QuerySQL = QuerySQL & "left join Customers c on c.CustomerID=m.CustomerID "
QuerySQL = QuerySQL & "where m.OrderID<=10300 "
QuerySQL = QuerySQL & "order by m.OrderDate, m.OrderID"
GenNodeXmlData(QuerySQL)
%> 