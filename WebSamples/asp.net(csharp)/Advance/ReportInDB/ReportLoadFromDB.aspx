﻿<%@ Page Language="C#" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.IO" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.SqlClient" %>
<script runat="server"> 
    
    //根据报表名称，从数据库表中读出报表模板
    protected void Page_Load(object sender, EventArgs e)
    {
        string ReportName = Request.QueryString["report"];

        SqlConnection ReportConn = new SqlConnection(SqlReportData.SqlConnStr);
        ReportConn.Open();

        SqlCommand cmd = new SqlCommand("Select ReportData from Report where ReportName='" + ReportName + "'", ReportConn);
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        Response.BinaryWrite(dr.GetSqlBinary(0).Value);
        dr.Close();
    }
</script> 