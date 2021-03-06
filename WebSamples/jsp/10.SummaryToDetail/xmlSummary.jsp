﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String QuerySQL = 
    "select d.Productid,p.ProductName,sum(d.Quantity) as Quantity," +
    "sum(d.UnitPrice*d.Quantity) as Amount " + 
    "from orders m inner join (OrderDetails d inner join Products p " +
    "on d.ProductID=p.ProductID) on m.orderid=d.orderid " +
    "where m.OrderDate between '" + request.getParameter("BeginDate") + "' And '" + request.getParameter("EndDate") + "'" +
    "group by d.Productid,p.ProductName " +
    "order by d.Productid";
XML_GenOneRecordset(response, QuerySQL);
%> 