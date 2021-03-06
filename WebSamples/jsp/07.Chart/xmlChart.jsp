﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select p.ProductName,Month(m.OrderDate) As MonthData,sum(d.UnitPrice*d.Quantity) as Amount " +
            "from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) " +
            "where m.OrderDate between '" + request.getParameter("BeginDate") + "' And '" + request.getParameter("EndDate") + "' and p.ProductID < 5 " +
            "group by p.ProductName,Month(m.OrderDate) " +
            "order by p.ProductName,Month(m.OrderDate)";
XML_GenOneRecordset(response, QuerySQL);
%> 