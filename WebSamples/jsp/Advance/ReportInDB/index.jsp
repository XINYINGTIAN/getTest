﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ page import="javax.servlet.jsp.JspWriter"%>
<%@ page import="javax.servlet.http.HttpServletResponse"%>
<%@ page import="java.util.zip.DeflaterOutputStream"%>
<%@ page import="java.lang.*, java.io.*, java.sql.*, java.util.*"%>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title>Web报表(B/S报表)演示　－ 服务端生成加载报表数据脚本代码</title>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
		<script src="../../CreateControl.js" type="text/javascript"></script>
		<script type="text/javascript">
// <!CDATA[

function window_onload() 
{
    //将数据库表中的各个报表名称加入到下拉选择框中
    var oOption;
    
    <%
    try
    {
        String url="jdbc:microsoft:sqlserver://localhost;DatabaseName=gridreport";
        Class.forName("com.microsoft.jdbc.sqlserver.SQLServerDriver");// Class.forName 装载驱动程序 
        Connection con=DriverManager.getConnection(url, "sa", "");    //用适当的驱动程序类与 DBMS 建立一个连接
        
        Statement stmt=con.createStatement();                         //用于发送简单的SQL语句
        ResultSet rs=stmt.executeQuery("select ReportName from Report order by ReportName");
        while( rs.next() ) 
	    {
	%>
            oOption = document.createElement("OPTION");
            oOption.text="<%=rs.getString(1)%>";
            selOpenName.add(oOption);	
    <%
        } 
        rs.close();
        stmt.close();
        con.close();
    }
    catch(Exception e)
    {
        //out.println(e.toString());
    }
    %>
    
    selOpenName_onchange()
}

//根据选择的报表项目从服务器端载入报表模板
function selOpenName_onchange() {
    var ReportName = selOpenName.all(selOpenName.selectedIndex).text;
    
    var LoadURL = "ReportLoadFromDB.jsp?report=" + ReportName;
    var success = ReportDesigner.Report.LoadFromURL(LoadURL);
    
    if (success == true)
    {
        ReportDesigner.Reload();
        
        txtSaveName.value = ReportName;
    }
    else
    {
        alert("载入报表失败!");
    }
}

//将当前设计的报表模板保存到服务器上
function btnSave_onclick() {
    var ReportName = txtSaveName.value;
    if (ReportName == "")
    {
        alert("没有指定报表的名称，不能进行保存！");
        return;
    }

    ReportDesigner.Post();
    var SaveURL = "ReportSaveToDB.jsp?report=" + ReportName;
    var success = ReportDesigner.Report.SaveToURL(SaveURL);
    
    if (success == true)
        alert("保存报表成功!");
    else
        alert("保存报表失败!");
}

//显示打开文件对话框选择一个文件，从客户端本地文件中载入报表模板
function btnLoadLocalFile_onclick() {
     var fd = new ActiveXObject("MSComDlg.CommonDialog");
    fd.Filter = "Grid++Report(*.grf)|*.grf";
    //fd.Filter = "*.*";
    fd.FilterIndex = 2;
    // must setting
    fd.MaxFileSize = 128;
    fd.ShowOpen(); //fd.ShowSave();
    var FileName = fd.FileName;
    if (FileName != "")
    {
        var fso = new ActiveXObject("Scripting.FileSystemObject");
        FileName = fso.GetFileName(FileName);
        
        txtSaveName.value = FileName.substr(0, FileName.length-4);
      
        ReportDesigner.Report.LoadFromFile(FileName);
        ReportDesigner.Reload();
    }
}

// ]]>
        </script>

</head>
	<body style="margin:0" onload="return window_onload()">
        <table height="100%" width="100%" border="1">
            <tr>
                <td atomicselection="true" style="font-size: 11pt; height: 29px">
                    服务器上的报表:<select id="selOpenName" name="selOpenName" style="width: 118px" type="text/javascript" onchange="return selOpenName_onchange()">
                    </select>
                    报表名称：<input id="txtSaveName" style="width: 129px" type="text" />
                    <input id="btnSave" name="btnSave" type="button" value="保存到服务器" type="text/javascript" onclick="return btnSave_onclick()" />&nbsp;
                    <input id="btnLoadLocalFile" name="btnLoadLocalFile" onclick="return btnLoadLocalFile_onclick()" style="width: 135px"
                        type="button" value="载入本地文件..." /><br />
                    <a href="ViewReport.htm" target="_blank">在插件中显示报表</a>&nbsp; <a href="PrintDirect.htm" target="_blank">直接打印报表</a>
                </td>
            </tr>
            <tr height="100%">
                <td atomicselection="true">
                    <script type="text/javascript"> 
                        CreateDesigner("", "", "");
                    </script>
                </td>
            </tr>
        </table>
	</body>
</html> 