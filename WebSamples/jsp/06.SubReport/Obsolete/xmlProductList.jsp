﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
String QuerySQL = "select * from Products order by ProductName";
XML_GenOneRecordset(response, QuerySQL);
%> 