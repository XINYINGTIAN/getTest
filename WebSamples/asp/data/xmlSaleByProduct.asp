﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select m.OrderID,m.OrderDate, " &_
    "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount  " &_
    "from Orders m inner join  " &_
    "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId " &_
    "where m.OrderDate between '1997-6-1' and '1997-12-31' " &_
    "order by d.ProductID, m.OrderDate"
GenNodeXmlData(QuerySQL)
%> 