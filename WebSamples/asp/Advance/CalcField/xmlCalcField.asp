﻿<!--#include file="../../data/GenXmlData.asp"-->
<%
QuerySQL = "select m.OrderID,m.CustomerId,m.OrderDate,d.ProductID,d.UnitPrice,d.Quantity, " _
    & "d.UnitPrice*d.Quantity as Amount " _
    & "from Orders m inner join OrderDetails as d on m.OrderID=d.OrderID " _
    & "where m.OrderID<=10300 " _
    & "order by m.OrderDate, m.OrderID"
GenNodeXmlData(QuerySQL)
%>
 