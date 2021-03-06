﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //const string QuerySQL = "select p.ProductName,Month(m.OrderDate)-1 As MonthData,sum(d.UnitPrice*d.Quantity) as Amount " +
        //    "from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) " +
        //    "where m.OrderDate between '1997-1-1' and '1997-12-31' and p.ProductID < 5 " +
        //    "group by p.ProductName,Month(m.OrderDate)-1 " +
        //    "order by p.ProductName,Month(m.OrderDate)-1";
        string QuerySQL = string.Format("select p.ProductName,Month(m.OrderDate)-1 As MonthData,sum(d.UnitPrice*d.Quantity) as Amount " +
            "from (Orders m inner join (OrderDetails as d left join Products p on p.ProductID=d.ProductID) on m.OrderId=d.OrderId) " +
            "where m.OrderDate between {2}{0}{2} and {2}{1}{2} and p.ProductID < 5 " +
            "group by p.ProductName,Month(m.OrderDate)-1 " +
            "order by p.ProductName,Month(m.OrderDate)-1", 
            Request.QueryString["BeginDate"], Request.QueryString["EndDate"], OledbReportData.DateSqlBracketChar);
        OledbReportData.FullGenNodeXmlData(this, QuerySQL, false);
    }
</script> 