﻿<%@ Page Language="C#" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.IO" %>
<script runat="server"> 

    protected void Page_Load(object sender, EventArgs e)
    {
        //将报表模板文件数据发送给请求者。供报表插件读取模板数据
        string strPathFile = Server.MapPath("") + @"\" + Request.QueryString["report"];
        Response.WriteFile(strPathFile);
    }
</script> 