﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select * from Employees where EmployeeID=5";
XML_GenOneRecordset(response, QuerySQL);
%> 