﻿<%@ Page Language="C#"%>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.OleDb" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
	<head>
        <title>Web报表插件(B/S报表插件)演示 - 根据服务端参数动态设定表格列的可见性</title>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <script src="../../CreateControl.js" type="text/javascript"></script>
		<script type="text/javascript">
//在网页初始加载时向报表提供数据
function window_onload() 
{
    var arrayColumns = new Array();
    var obj;
    
    <%
    //下面参数在实际应用中，应该根据配置结果动态获得
    String[] arrName = new String[9];
    bool[] arrVisible = new bool[9];
    arrName[0] = "ContactName";
    arrVisible[0] = true;
    arrName[1] = "ContactTitle";
    arrVisible[1] = true;
    arrName[2] = "Address";
    arrVisible[2] = true;
    arrName[3] = "City";
    arrVisible[3] = true;
    arrName[4] = "Region";
    arrVisible[4] = true;
    arrName[5] = "PostalCode";
    arrVisible[5] = true;
    arrName[6] = "Country";
    arrVisible[6] = false;
    arrName[7] = "Phone";
    arrVisible[7] = true;
    arrName[8] = "Fax";
    arrVisible[8] = false;
	%>
    
    <%
    for (int i=0; i<arrName.Length; ++i)
    {
	%>
        obj = new Object();
        obj.ColumnName = "<%=arrName[i]%>";
        obj.Visible = <%=arrVisible[i]? "true":"false"%>;
        arrayColumns[<%=i%>] = obj;
    <%
    }
	%>
	
	//注意查看运行结果“国家(Country)”与“传真(Fax)”这两列被隐藏掉
	var Report = ReportViewer.Report;
	for(i=0; i<arrayColumns.length; ++i)
        Report.ColumnByName(arrayColumns[i].ColumnName).Visible = arrayColumns[i].Visible;
        
    //ReportViewer.QuickRefresh();
    ReportViewer.Start();
}

// ]]>
        </script>
	</head>
    <body style="margin:0"  onload="return window_onload()">
        <script type="text/javascript"> 
            //第5个参数为false，指定不自动运行，在 window_onload() 中启动运行
            CreateDisplayViewerEx("100%", "100%", "../../grf/1c.grf", "../../data/xmlCustomer.aspx", false, "");
        </script>
    </body>
</html>
 