﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select top 10 c.CustomerID, c.CompanyName, sum(o.Quantity*o.UnitPrice) As SumAmt "_
& "from OrderDetails o, Orders m, customers c "_
& "where o.OrderID=m.OrderID and m.CustomerID=c.CustomerID "_
& "group by c.CustomerID, c.CompanyName "_
& "order by sum(o.Quantity*o.UnitPrice) desc"
GenNodeXmlData(QuerySQL)
%>
 