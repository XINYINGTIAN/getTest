﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String QuerySQL = 
"select Year(m.OrderDate) As TheYear,Month(m.OrderDate) As TheMonth, sum(d.UnitPrice*d.Quantity) as Amount " +
"from Orders m inner join OrderDetails as d on m.OrderId=d.OrderId " +
"group by Year(m.OrderDate),Month(m.OrderDate) " +
"order by Year(m.OrderDate),Month(m.OrderDate) ";    
XML_GenOneRecordset(response, QuerySQL);
%> 
