﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string QuerySQL = "EXEC \"Employee Sales by Country\" \"1/1/1997\", \"12/31/1997\"";
        
        //包含图像数据的报表一般不要采用压缩方式，图像数据本身已压缩，再压缩反而有可能增大数据量
        SqlXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 