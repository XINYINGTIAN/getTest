<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>Web报表(B/S报表)演示, 打印支票，向报表传递参数数据</title>
	<meta http-equiv="Content-Type" content="text/html; charset=gbk"/>
    <script src="../CreateControl.js" type="text/javascript"></script>
	<script type="text/javascript">
//charset=utf-8：此网页在IE8下无法显示，看不出有任何问题，也找不到原因	
//不得已将 charset=gbk 且将文件编码设为 gb2312
	
//在网页初始加载时设置参数并启动报表的运行显示
function window_onload() 
{
	document.getElementById("txtProductID").value = <%=Request.QueryString("ProductID")%>;
	document.getElementById("txtBeginDate").value = <%=Request.QueryString("BeginDate")%>;
	document.getElementById("txtEndDate").value = <%=Request.QueryString("EndDate")%>;
	
	btnRefresh_onclick();
}

//打印预览报表
function btnPreview_onclick() 
{
    ReportViewer.Report.PrintPreview(true);
}

//根据数据过滤参数重新显示报表
function btnRefresh_onclick() 
{
    ReportViewer.Stop();
    
    var ProductID = document.getElementById("txtProductID").value;
    var BeginDate = document.getElementById("txtBeginDate").value;
    var EndDate = document.getElementById("txtEndDate").value;

    //更新查询参数更新报表付标题，设置对应静态框的“Text”属性
    ReportViewer.Report.ControlByName("SubTitle").AsStaticBox.Text = "日期范围: " + BeginDate + "至" + EndDate + " 产品编号: " + ProductID;

    var DataURL = encodeURI("xmlDetail.asp?ProductID=" + ProductID + "&BeginDate=" + BeginDate + "&EndDate=" + EndDate);
    ReportViewer.DataURL = DataURL;
    
    ReportViewer.Start();
}
	</script>
    <style type="text/css">
        html,body {
            margin:0;
            height:100%;
        }
    </style>
</head>
<body style="margin:0; background-color: #f0ffff;"  onload="window_onload()">
	<table border="0" width="100%" height="100%">
		<tr>
			<td style="width: 584px; height: 10px">产品:<input id="txtProductID" type="text" size="3" value="1" name="txtProductID"/>
                开始日期：<input id="txtBeginDate" type="text" size="11" value="1997-1-1" name="txtBeginDate"/>
                结束日期:<input id="txtEndDate" type="text" size="11" value="1997-12-31" name="txtEndDate"/>&nbsp;
                <input id="btnRefresh" onclick="return btnRefresh_onclick()" type="button" value="更新显示"
					name="btnRefresh"/></td>
			<td style="height: 10px">
                <input id="btnPreview" onclick="return btnPreview_onclick()" type="button" value="打印预览"
					name="btnPreview"/></td>
		</tr>
        <tr height="100%">
            <td colspan="7" height="100%">
                <script type="text/javascript"> 
                    CreateDisplayViewerEx("100%", "100%", "Detail.grf", "", false, "<param name=BorderStyle value=1>");
                </script>
            </td>
        </tr>
	</table>
</body>
</html>
 