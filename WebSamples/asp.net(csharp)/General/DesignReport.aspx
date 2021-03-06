﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DesignReport.aspx.cs" Inherits="DesignReport" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Web报表(B/S报表)演示, 在网页中应用报表设计器设计报表 - <%=Request.QueryString["report"]%></title>
	<script src="../CreateControl.js" type="text/javascript"></script>
	<script type="text/javascript">
function OnSaveReport()
{
	//alert("为了保护报表的正常演示，这里放弃了对报表设计的保存！");
	//ReportDesigner.DefaultAction = false;
}
	</script>
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
	        Report = "../grf/" + Report;
	        
	    var Data = "<%=Request.QueryString["data"]%>";
	    if (Data != "")
	        Data = "../" + Data;
	        
	    CreateDesignerEx("100%", "100%", Report, "DesignReportSave.aspx?report=<%=Request.QueryString["report"]%>", Data, 
	        "<param name=OnSaveReport value=OnSaveReport>");
	</script>
</body>
</html> 
