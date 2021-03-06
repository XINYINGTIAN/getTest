﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = string.Format("select m.OrderId, m.OrderDate, d.Productid,p.ProductName,d.Quantity, " +
            "d.UnitPrice*d.Quantity as Amount " +
            "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) " +
            "on m.orderid=d.orderid " +
            "where (m.OrderDate between {3}{0}{3} And {3}{1}{3}) and d.Productid={2} " +
            "order by m.OrderDate ",
            Request.QueryString["BeginDate"], Request.QueryString["EndDate"], Request.QueryString["ProductID"], OledbReportData.DateSqlBracketChar);
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 