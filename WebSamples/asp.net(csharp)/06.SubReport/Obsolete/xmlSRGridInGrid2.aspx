﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string City = Request.QueryString["City"];
        //string City = HttpUtility.HtmlDecode(RawCity);
        //string City = Global.decodeURI(RawCity);
        //string City = RawCity;
        string QuerySQL = "select * from Customers where City='" + City + "'";
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 