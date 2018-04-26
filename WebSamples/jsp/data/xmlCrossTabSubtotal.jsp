﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenXmlData.jsp" %>
<%
String QuerySQL = "select t.CategoryName, p.ProductName,c.City,c.CompanyName,d.Quantity " +
    "from (Orders m inner join  " +
    "(OrderDetails as d inner join (Products p inner join Categories t on p.CategoryID=t.CategoryID) " +
    "on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " +
    "left join Customers c on c.CustomerID=m.CustomerID " +
    "where m.OrderDate between '1997-1-1' and '1997-3-31' " +
    "order by t.CategoryName,p.ProductName,c.City,c.CompanyName ";
XML_GenOneRecordset(response, QuerySQL);
%> 