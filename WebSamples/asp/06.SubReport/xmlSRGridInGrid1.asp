﻿<!--#include file="../data/GenXmlData.asp"-->
<%
QuerySQL = "select * from OrderDetails where OrderID=" & Request.QueryString("OrderID")
GenNodeXmlData(QuerySQL)
%>
 