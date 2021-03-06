﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintReport.aspx.cs" Inherits="PrintReport" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Web报表(B/S报表)演示, 用报表打印显示器插件(打印预览插件)展现报表 - <%=Request.QueryString["report"]%></title>
	<script src="../../CreateControl.js" type="text/javascript"></script>
    <style type="text/css">
        html,body {
            margin:0;
            height:100%;
        }
    </style>
</head>
<body style="margin:0">
	<script type="text/javascript"> 
	    var Report = "<%=Request.QueryString["report"]%>";
	    if (Report != "")
	        Report = "../../grf/" + Report;
	        
	    CreatePrintViewerEx("100%", "100%", Report, "", false, "");
	    
		var QuerySQL = ReportViewer.Report.DetailGrid.Recordset.QuerySQL;
		ReportViewer.DataURL = encodeURI("../../data/xmlSQLParam.aspx?QuerySQL=" + QuerySQL);
		
		ReportViewer.Start();
	</script>
</body>
</html>
 