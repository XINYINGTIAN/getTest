﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select * from Products order by ProductName" 
GenNodeXmlData(QuerySQL)
%>
 