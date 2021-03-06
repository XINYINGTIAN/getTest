﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = string.Format("select p.ProductName,Month(m.OrderDate) As MonthData,sum(d.UnitPrice*d.Quantity) as Amount " +
            "from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) " +
            "where m.OrderDate between {2}{0}{2} and {2}{1}{2} and p.ProductID < 5 " +
            "group by Month(m.OrderDate),p.ProductName " +
            "order by Month(m.OrderDate),p.ProductName", 
            Request.QueryString["BeginDate"], Request.QueryString["EndDate"], OledbReportData.DateSqlBracketChar);
        OledbReportData.FullGenNodeXmlData(this, QuerySQL, false);
    }
</script> 