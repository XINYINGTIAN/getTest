﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select m.OrderId, m.OrderDate, d.Productid,p.ProductName,d.Quantity, " _
            & "d.UnitPrice*d.Quantity as Amount " _
            & "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " _
            & "on m.orderid=d.orderid " _
            & "where (m.OrderDate between '" & Request.QueryString("BeginDate") & "' And '" & Request.QueryString("EndDate") & "') " _
            & "and d.Productid=" & Request.QueryString("ProductID") & " " _
            & "order by m.OrderDate "
GenNodeXmlData(QuerySQL)
%> 