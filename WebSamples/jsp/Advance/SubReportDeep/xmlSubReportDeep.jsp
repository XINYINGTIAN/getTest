﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../../data/GenXmlData.jsp" %>
<%
String CustomerQuerySQL = "select * from Customers where CustomerID>='B' and CustomerID<'C' order by CustomerID";
String OrderQuerySQL = "select * from Orders where CustomerID>='B' and CustomerID<'C' and OrderID<10600 order by OrderID";
String OrderDetailQuerySQL = "select d.* from Orders m, OrderDetails d " +
    "where m.OrderID=d.OrderID and m.CustomerID>='B' and m.CustomerID<'C'and m.OrderID<10600 " +
    "order by d.OrderID";

ArrayList<ReportQueryItem> QueryItems = new ArrayList<ReportQueryItem>();
QueryItems.add(new ReportQueryItem(CustomerQuerySQL, "Customer"));
QueryItems.add(new ReportQueryItem(OrderQuerySQL, "Order"));
QueryItems.add(new ReportQueryItem(OrderDetailQuerySQL, "OrderDetail"));
XML_GenMultiRecordset(response, QueryItems);
%>
 