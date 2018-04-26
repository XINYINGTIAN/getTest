﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String RelateCustomerQuerySQL =
    "select o.OrderID, o.ShipCity, c.* from Customers c, Orders o " +
    "where OrderID<=10260 and c.City=o.ShipCity " +
    "order by o.OrderID";
        
ArrayList<ReportQueryItem> QueryItems = new ArrayList<ReportQueryItem>();
QueryItems.add( new ReportQueryItem("select * from Orders where OrderID<=10260 order by OrderID", "Master") );
QueryItems.add( new ReportQueryItem("select * from OrderDetails where OrderID<=10260", "Detail1") );
QueryItems.add( new ReportQueryItem(RelateCustomerQuerySQL, "Detail2") );
XML_GenMultiRecordset(response, QueryItems);
%>
 