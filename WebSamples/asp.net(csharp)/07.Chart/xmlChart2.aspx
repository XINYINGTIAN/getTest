﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = string.Format(
            "select Month(m.OrderDate)-1, " +
            "sum(d.Quantity) as Qty, " +
            "sum(d.UnitPrice*d.Quantity) as Amt," +
            "sum(d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount) as NetAmt " +
            "from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) " +
            "where m.OrderDate between {2}{0}{2} and {2}{1}{2} and p.ProductID < 5 " +
            "group by Month(m.OrderDate)", Request.QueryString["BeginDate"], Request.QueryString["EndDate"], OledbReportData.DateSqlBracketChar);
        OledbReportData.FullGenNodeXmlData(this, QuerySQL, false);
    }
</script> 