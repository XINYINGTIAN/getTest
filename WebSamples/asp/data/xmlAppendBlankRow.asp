﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select m.OrderId, m.OrderDate, d.Productid,p.ProductName,d.Quantity,"
QuerySQL = QuerySQL & "d.UnitPrice*d.Quantity as Amount "
QuerySQL = QuerySQL & "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) "
QuerySQL = QuerySQL & "on m.orderid=d.orderid "
QuerySQL = QuerySQL & "where (m.OrderDate between '1/1/1996' And '9/30/1997') and d.Productid<10 "
QuerySQL = QuerySQL & "order by d.ProductID"
GenNodeXmlData(QuerySQL)
%> 