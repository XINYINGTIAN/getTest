﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "EXEC [Employee Sales by Country] \"1/1/1997\", \"12/31/1997\"";
XML_GenOneRecordset(response, QuerySQL);
%> 