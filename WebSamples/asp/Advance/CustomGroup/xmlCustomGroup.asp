﻿<!--#include file="../../data/GenXmlData.asp"-->
<%
QuerySQL = "select d.ProductID,p.ProductName,sum(d.UnitPrice*d.quantity) as amount " _
            & "from OrderDetails d inner join Products p on p.Productid=d.Productid " _
            & "group by d.ProductID,p.ProductName " _
            & "order by sum(d.UnitPrice*d.quantity) desc"
GenNodeXmlData(QuerySQL)
%>
 