﻿<!--#include file="../../data/GenXmlData.asp"-->
<%
QuerySQL = "select d.Productid,sum(d.Quantity) as Quantity,sum(d.UnitPrice*d.Quantity) as Amount " _
   & "from orders m inner join OrderDetails d on m.orderid=d.orderid " _
   & "where (m.OrderDate between '1/1/1997' And '3/31/1997') " _
   & "group by d.ProductID " _
   & "order by d.ProductID "
GenNodeXmlData(QuerySQL)
%> 