﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "GenJsonData.jsp" %>
<%
JSON_GenOneRecordset(response, "select * from Employees where EmployeeID=5");
%> 