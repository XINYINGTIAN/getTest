﻿<!--#include file="../../data/GenXmlData.asp"-->
<%
QuerySQL = "select * from Suppliers where City='" & Request.QueryString("City") & "'"
GenNodeXmlData(QuerySQL)
%>
 