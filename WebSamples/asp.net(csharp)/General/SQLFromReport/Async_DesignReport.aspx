﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Async_DesignReport.aspx.cs" Inherits="DesignReport" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Web报表(B/S报表)演示, 在网页中应用报表设计器设计报表 - <%=Request.QueryString["report"]%></title>
	<script src="../../CreateControl.js" type="text/javascript"></script>
	<script type="text/javascript">
function window_onload() 
{
    ReportDesigner.Report.AsyncHttpRequest = true;  //设定报表按异步数据方式运行
    ReportDesigner.Report.OnAsyncMethodFinished = OnAsyncMethodFinished;  //设定异步函数的完成事件函数
    
    var url_Report = "<%=Request.QueryString["report"]%>";
    if (url_Report != "")
        url_Report = "../../grf/" + url_Report;
    ReportDesigner.Report.LoadFromURL(url_Report);
}

function OnAsyncMethodFinished(Result) 
{
    if (Result.MethodName == "LoadFromURL")
    {
	    var QuerySQL = ReportDesigner.Report.DetailGrid.Recordset.QuerySQL;
	    
	    //TDD...感觉ReportDesigner上也要增加一个DataParam属性，用来存储参数，处理URL过长不能发送到服务器的问题
	    //ReportDesigner.Report.LoadDataFromURLEx("../../data/xmlSQLDataParam.aspx", QuerySQL);
	    ReportDesigner.DataURL = "../../data/xmlSQLParam.aspx?QuerySQL=" + QuerySQL; //这样不行，URL过长，只有部分数据传递到服务器
	    
        ReportDesigner.Reload();
    }
}

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
<body style="margin:0" onload="window_onload()">
	<script type="text/javascript"> 
	    CreateDesignerEx("100%", "100%", "", "../DesignReportSave.aspx?report=<%=Request.QueryString["report"]%>", "", 
	        "<param name=OnSaveReport value=OnSaveReport>");
	</script>
</body>
</html> 
