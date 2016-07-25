﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select d.ProductID,p.ProductName,m.OrderDate,d.UnitPrice*d.Quantity as Amount " _
            & "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) " _
            & "left join Products p on d.ProductID=p.ProductID " _
            & "where m.OrderDate between '1997-1-1' and '1997-12-31' " _
            & "order by p.ProductName, m.OrderDate"
            
GenNodeXmlData(QuerySQL)
%> 