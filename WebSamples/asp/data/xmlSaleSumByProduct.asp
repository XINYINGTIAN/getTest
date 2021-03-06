﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = "select d.Productid,p.ProductName,sum(d.Quantity) as Quantity, " &_
    "sum(d.UnitPrice*d.Quantity*(1-d.Discount)) as Amount " &_
    "from orders m inner join (OrderDetails d inner join Products p " &_
    "on d.ProductID=p.ProductID) " &_
    "on m.orderid=d.orderid " &_
    "where m.OrderDate between '1997-1-1' and '1997-12-31' " &_
    "group by d.Productid,p.ProductName " &_
    "order by d.Productid"
GenNodeXmlData(QuerySQL)
%> 