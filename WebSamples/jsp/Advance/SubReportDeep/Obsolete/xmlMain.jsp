﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../../../data/GenXmlData.jsp" %>
<%
XML_GenOneRecordset(response, "select * from Customers where CustomerID>='B' and CustomerID<'C' order by CustomerID");
%>
 