﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string QuerySQL = "select CategoryID,CategoryName,Description,Picture,PictureFile "
            + "From Categories "
            + "Order by CategoryID";
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 