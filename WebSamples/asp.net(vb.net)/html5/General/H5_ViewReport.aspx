<%@ Page Language="VB" %>

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Web报表(B/S报表)演示, 用报表查询显示器插件展现报表 - <%=Request.QueryString("report")%></title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
	<script src="../grhtml5-1.0.0beta-min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function window_onload() {
            var reportURL = "<%=Request.QueryString("report")%>";
            if (reportURL != "")
                reportURL = "../../grf/" + reportURL;

            var dataURL = "<%=Request.QueryString("data")%>";
            if (dataURL != "")
                dataURL = "../../" + dataURL;

            //创建报表显示器，参数指定其在网页中的占位标签的ID，关联的报表模板URL，关联的报表数据URL
            var reportViewer = window.rubylong.grhtml5.insertReportViewer("report_holder", reportURL, dataURL);

            reportViewer.start(); //启动报表运行，生成报表
        }
    </script>
</head>
<body onload="window_onload()">
    <div id="report_holder">
    </div>
</body>
</html>
