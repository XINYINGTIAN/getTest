<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YgBBb.aspx.cs" Inherits="DLTVWGPT.GRBB.YgBBb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="js/CreateControl.js" type="text/javascript"></script>
    <script src="js/GRInstall.js" type="text/javascript"></script>
    <script src="js/GRBB.js" type="text/javascript"></script>
    <script src="js/test.js" type="text/javascript"></script>
        <script type="text/javascript">
        function showBB() {
            var Installed = Install_Detect();
            if (Installed) {
                var where = getQVarObj().where;
                //获取getQVarObj()函数返回对象的where成员值
                var dataPage = "YgBBData.aspx?where=" + encodeURIComponent(where);
                //实现了向Y个BBData.aspx仅传递需要的where参数，
                //且参数的值用js函数encodeURIComponent（where）实现了向aspx仅传递需要的where参数
                //且参数的值用js函数
                CreatePrintViewerEx("100%", "100%", "/GRBB/grf/ygbb2.grf",
                    dataPage, true, "");
            }
        }
        showBB();
        testLiteralObject();
    </script>



      <script type="text/javascript">

        function window_onload() {
            var report = ReportViewer.Report;
            //必须的
            ReportViewer.Stop();
            //必须的
            var xms = getQVarObj().xms;
            var xma = xms.split(',');
            var i = 0;
            for (var i = 0; i < xma.length; i++) {
                if (i >= 4)
                    break;
                var xmi = "xm" + (i + 1);
                //构造名字参数变量名xm1~xm4
                //js允许直接用+号连接字符串和其他类型的数据获得连接起来的字符串
                //但如果这里不加括号，当i=2时，将得到xm21，而不是xm3
                console.log(xmi, xma[i]);
                report.ParameterByName(xmi).AsString = xma[i];
                //关键代码！实现了向报表中的参数变量xmi传递数值xma[i]
            }
            ReportViewer.Start();
            //必须的
        }
    </script>
    <script type="text/javascript">Install_InsertReport();</script>
    <style type ="text/css">html,body{margin:0; height:100%;}</style>
</head>
    
<body onload="window_onload()">
    <!--onload事件中调用，即在网页的页面加载到浏览器后执行-->
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
    <script type="text/javascript">var Installed = Install_Detect();
        if (Installed) {
            var urlSearch = window.location.search;
            console.log("urlSearch", urlSearch);
            var dataPage = "YgBBData.aspx" + urlSearch;
            CreatePrintViewerEx("100%",
                "100%", "/GRBB/grf/ygbb1.grf",
                dataPage, true, "");
        }
    </script>
</body>
</html>
