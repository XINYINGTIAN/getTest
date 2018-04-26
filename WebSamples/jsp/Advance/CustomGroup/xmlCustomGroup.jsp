﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select d.ProductID,p.ProductName,sum(d.UnitPrice*d.quantity) as amount "
            + "from OrderDetails d inner join Products p on p.Productid=d.Productid "
            + "group by d.ProductID,p.ProductName "
            + "order by sum(d.UnitPrice*d.quantity) desc";
XML_GenOneRecordset(response, QuerySQL);
%> 