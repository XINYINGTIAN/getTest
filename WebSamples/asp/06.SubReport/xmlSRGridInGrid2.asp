﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select * from Customers where City='" & Request.QueryString("City") & "'"
GenNodeXmlData(QuerySQL)
%>
 