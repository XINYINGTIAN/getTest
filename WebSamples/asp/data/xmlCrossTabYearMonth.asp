﻿<!--#include file="GenXmlData.asp"-->
<%
QuerySQL = " "
QuerySQL = QuerySQL & "select Year(m.OrderDate) As TheYear,Month(m.OrderDate) As TheMonth, sum(d.UnitPrice*d.Quantity) as Amount "
QuerySQL = QuerySQL & "from Orders m inner join OrderDetails as d on m.OrderId=d.OrderId "
QuerySQL = QuerySQL & "group by Year(m.OrderDate),Month(m.OrderDate) "
QuerySQL = QuerySQL & "order by Year(m.OrderDate),Month(m.OrderDate)"

GenNodeXmlData(QuerySQL)
%> 