﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        OledbXMLReportData.GenOneRecordset(this, "select * from Orders where OrderID<=10255 order by OrderID");
    }
</script> 