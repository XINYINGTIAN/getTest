﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select * from Orders where OrderID<=10255 order by OrderID";
XML_GenOneRecordset(response, QuerySQL);
%>
 