﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String ParameterQuerySQL = 
	"select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate, "
	+ "p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount "
	+ "from (Orders m inner join "
	+ "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) "
	+ "left join Customers c on c.CustomerID=m.CustomerID "
	+ "where m.OrderID=10252 and d.ProductID=20 "
	+ "order by m.OrderDate, m.OrderID";
XML_GenOneRecordset(response, ParameterQuerySQL, DefaultReportDataType);
%> 