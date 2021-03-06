﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string CustomerQuerySQL = "select * from Customers where City='" + Request.QueryString["City"] + "'";
        string SupplierQuerySQL = "select * from Suppliers where City='" + Request.QueryString["City"] + "'";
        
        ArrayList QueryList = new ArrayList();
        QueryList.Add(new ReportQueryItem(CustomerQuerySQL, "Top10Customer"));
        QueryList.Add(new ReportQueryItem(SupplierQuerySQL, "Top10Product"));
        //OledbXMLReportData.GenMultiRecordset(this, QueryList);
        OledbJsonReportData.GenMultiRecordset(this, QueryList);
    }
</script> 