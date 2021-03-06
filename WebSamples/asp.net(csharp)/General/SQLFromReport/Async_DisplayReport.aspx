﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Async_DisplayReport.aspx.cs" Inherits="DisplayReport" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Web报表(B/S报表)演示, 用报表查询显示器插件展现报表 - <%=Request.QueryString["report"]%></title>
	<script src="../../CreateControl.js" type="text/javascript"></script>
    <style type="text/css">
        html,body {
            margin:0;
            height:100%;
        }
    </style>
	<script type="text/javascript">
function window_onload() 
{
    ReportViewer.Report.AsyncHttpRequest = true;  //设定报表按异步数据方式运行
    ReportViewer.Report.OnAsyncMethodFinished = OnAsyncMethodFinished;  ////设定异步函数的完成事件函数
    
    var url_Report = "<%=Request.QueryString["report"]%>";
    if (url_Report != "")
        url_Report = "../../grf/" + url_Report;
    ReportViewer.Report.LoadFromURL(url_Report);
}

function OnAsyncMethodFinished(Result) 
{
    if (Result.MethodName == "LoadFromURL")
    {
	    var QuerySQL = ReportViewer.Report.DetailGrid.Recordset.QuerySQL;
	    
	    //ReportViewer.Report.LoadDataFromURL( encodeURI("../../data/xmlSQLParam.aspx?QuerySQL=" + QuerySQL) ); //这样不行，URL过长，只有部分数据传递到服务器
	    
        ReportViewer.DataURL = "../../data/xmlSQLDataParam.aspx";
        ReportViewer.DataParam = QuerySQL;
	    //ReportViewer.Report.LoadDataFromURLEx("../../data/xmlSQLDataParam.aspx", QuerySQL); //这样也可以
	    
        ReportViewer.Start();
    }
}
	</script>
</head>
<body style="margin:0" onload="window_onload()">
	<script type="text/javascript"> 
	    CreateDisplayViewerEx("100%", "100%", "", "", false, "");
	</script>
</body>
</html> 
