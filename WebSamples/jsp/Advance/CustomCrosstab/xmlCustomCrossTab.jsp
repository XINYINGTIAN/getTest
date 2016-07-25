﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select d.Productid,p.ProductName,Month(m.OrderDate) as MonthNo,d.Quantity,d.UnitPrice*d.Quantity as Amount "
				+ "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) "
				+ "on m.orderid=d.orderid "
				+ "where m.OrderDate between '1997-1-1' And '1997-12-31' "
				+ "order by d.Productid,m.OrderDate";
XML_GenOneRecordset(response, QuerySQL);
%> 