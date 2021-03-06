﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string QuerySQL = "select top 10 p.ProductID, p.ProductName, sum(o.Quantity*o.UnitPrice) As SumQty " +
            "from OrderDetails o, Products p " +
            "where o.ProductID=p.ProductID " +
            "group by p.ProductID, p.ProductName " +
            "order by sum(Quantity*o.UnitPrice) desc";
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 