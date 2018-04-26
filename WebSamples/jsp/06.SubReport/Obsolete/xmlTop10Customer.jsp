﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select c.CustomerID, c.CompanyName, sum(o.Quantity*o.UnitPrice) As SumAmt "
+ "from OrderDetails o, Orders m, customers c "
+ "where o.OrderID=m.OrderID and m.CustomerID=c.CustomerID and c.CustomerID<'BS' "
+ "group by c.CustomerID, c.CompanyName "
+ "order by sum(o.Quantity*o.UnitPrice) desc";
XML_GenOneRecordset(response, QuerySQL);
%> 