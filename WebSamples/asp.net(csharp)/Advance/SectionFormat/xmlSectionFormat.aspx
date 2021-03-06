﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        string QuerySQL = string.Format(
            "select d.Productid,p.ProductName,sum(d.Quantity) as Quantity, "
            + "sum(d.UnitPrice*d.Quantity) as Amount "
            + "from orders m inner join (OrderDetails d inner join Products p on d.ProductID=p.ProductID) "
            + "on m.orderid=d.orderid "
            + "where m.OrderDate between {0}1997-1-1{0} And {0}1997-12-31{0} "
            + "group by d.Productid,p.ProductName "
            + "order by d.Productid", OledbReportData.DateSqlBracketChar);
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 