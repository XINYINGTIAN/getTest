﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select * from OrderDetails where OrderID=" + request.getParameter("OrderID");
XML_GenOneRecordset(response, QuerySQL);
%>
 