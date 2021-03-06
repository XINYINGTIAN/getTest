﻿<%@ Page Language="C#" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.IO" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.SqlClient" %>
<script runat="server"> 

    //将提交的报表模板数据保存到数据库表中
    protected void Page_Load(object sender, EventArgs e)
    {
        string ReportName = Request.QueryString["report"];    //报表名称
        byte[] FormData = Request.BinaryRead(Request.TotalBytes); //报表模板数据

        //数据库连接
        SqlConnection ReportConn = new SqlConnection(SqlReportData.SqlConnStr);
        ReportConn.Open();

        //首先判断是否存在同名报表
        SqlCommand cmd = new SqlCommand("Select ReportName from Report where ReportName='" + ReportName + "'", ReportConn);
        SqlDataReader dr = cmd.ExecuteReader();
        bool Existed = dr.HasRows;
        dr.Close();

        //报表模板数据写入表中
        string strSQL;
        if (Existed)
            strSQL = "UPDATE Report SET ReportData=@ReportData where ReportName=@ReportName";
        else
            strSQL = "INSERT INTO Report(ReportName,ReportData) VALUES(@ReportName, @ReportData)";
        SqlCommand cmdSave = new SqlCommand(strSQL, ReportConn);
        cmdSave.Parameters.Add(new SqlParameter("@ReportName", SqlDbType.VarChar)).Value = ReportName;
        cmdSave.Parameters.Add(new SqlParameter("@ReportData", SqlDbType.Image)).Value = FormData;
        cmdSave.ExecuteNonQuery();
    }
</script> 