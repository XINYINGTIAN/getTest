﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenJsonData.jsp" %>
<%
String QuerySQL = "select * from Customers where CustmerID='A' order by Region,City";
JSON_GenOneRecordset(response, QuerySQL);
%> 