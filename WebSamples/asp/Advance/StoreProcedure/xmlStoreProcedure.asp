﻿<!--#include file="../../data/GenXmlData.asp"-->
<%
QuerySQL = "EXEC ""Employee Sales by Country"" ""1/1/1997"", ""12/31/1997"""
GenNodeXmlData(QuerySQL)
%> 