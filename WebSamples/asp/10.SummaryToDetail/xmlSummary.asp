﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select d.Productid,p.ProductName,sum(d.Quantity) as Quantity," _
            & "sum(d.UnitPrice*d.Quantity) as Amount " _
            & "from orders m inner join (OrderDetails d inner join Products p " _
            & "on d.ProductID=p.ProductID) on m.orderid=d.orderid " _
            & "where m.OrderDate between '" & Request.QueryString("BeginDate") & "' And '" & Request.QueryString("EndDate") & "'" _
            & "group by d.Productid,p.ProductName " _
            & "order by d.Productid"
GenNodeXmlData(QuerySQL)
%> 