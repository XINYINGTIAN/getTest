﻿<!--#include file="GenXmlData.asp"-->
<%
//第一个查询SQL串指定报表明细数据的查询SQL
//第二个查询SQL串指定报表参数数据的查询SQL
RecordsetQuerySQL = "select * from Employees where EmployeeID<8"
ParameterQuerySQL = "select * from Employees where EmployeeID=8"
GenEntireReportData RecordsetQuerySQL, ParameterQuerySQL
%> 