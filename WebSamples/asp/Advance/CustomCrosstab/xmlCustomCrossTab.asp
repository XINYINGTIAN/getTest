﻿<!--#include file="../../data/GenXmlData.asp"-->
<%
QuerySQL = "select d.Productid,p.ProductName,Month(m.OrderDate) as MonthNo,d.Quantity,d.UnitPrice*d.Quantity as Amount " _
    & "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " _
    & "on m.orderid=d.orderid " _
    & "where m.OrderDate between '1/1/1997' And '12/31/1997' " _
    & "order by d.Productid,m.OrderDate"
GenNodeXmlData(QuerySQL)
%>
 