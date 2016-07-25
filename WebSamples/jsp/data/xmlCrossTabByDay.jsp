﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String QuerySQL = "select c.CompanyName,m.OrderDate,d.UnitPrice*d.Quantity as Amount "
+ "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) "
+ "left join Customers c on c.CustomerID=m.CustomerID "
+ "where m.OrderDate between '1997-7-1' and '1997-7-10' "
+ "order by c.CompanyName, m.OrderDate";
XML_GenOneRecordset(response, QuerySQL);
%> 