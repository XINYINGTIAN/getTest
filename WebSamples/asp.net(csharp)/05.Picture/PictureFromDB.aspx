﻿<%@ Page Language="C#" %>
<%@ import Namespace="System.Data" %>
<%@ import Namespace="System.Data.OleDb" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string QuerySQL = "select Picture From Categories where CategoryID=1";

        OleDbConnection ReportConn = new OleDbConnection(OledbReportData.OleDbConnStr);
        OleDbCommand ocmd = new OleDbCommand(QuerySQL, ReportConn);
        ReportConn.Open();
        OleDbDataReader odr = ocmd.ExecuteReader(CommandBehavior.CloseConnection);

        odr.Read();
        long DataSize = odr.GetBytes(0, 0, null, 0, int.MaxValue);
        byte[] buffer = new byte[DataSize];
        odr.GetBytes(0, 0, buffer, 0, (int)DataSize);
        Response.BinaryWrite(buffer);
        
        odr.Close();
    }
</script> 