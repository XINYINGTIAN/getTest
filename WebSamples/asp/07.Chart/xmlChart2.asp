﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select Month(m.OrderDate), " _
            & "sum(d.Quantity) as Qty, " _
            & "sum(d.UnitPrice*d.Quantity) as Amt," _
            & "sum(d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount) as NetAmt " _
            & "from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) " _
            & "where m.OrderDate between '" & Request.QueryString("BeginDate") & "' and '" & Request.QueryString("EndDate") & "' and p.ProductID<5 " _
            & "group by Month(m.OrderDate)"
GenNodeXmlData(QuerySQL)
%> 