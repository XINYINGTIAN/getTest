﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select d.Productid,p.ProductName,m.OrderId, m.OrderDate,d.Quantity, "
			+ "d.UnitPrice*d.Quantity as Amount "
			+ "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) "
			+ "on m.orderid=d.orderid "
			+ "where (m.OrderDate between '1997-4-1' And '1997-6-30') "
			+ "order by d.ProductID,m.OrderDate";
XML_GenOneRecordset(response, QuerySQL);
%> 