﻿<!--#include file="../../data/GenXmlData.asp"-->
<%
QuerySQL = "select d.Productid,p.ProductName,m.OrderId, m.OrderDate,d.Quantity, " _
   & "d.UnitPrice*d.Quantity as Amount " _
   & "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " _
   & "on m.orderid=d.orderid " _
   & "where (m.OrderDate between '4/1/1997' And '6/30/1997') " _
   & "order by d.ProductID,m.OrderDate"
GenNodeXmlData(QuerySQL)
%> 