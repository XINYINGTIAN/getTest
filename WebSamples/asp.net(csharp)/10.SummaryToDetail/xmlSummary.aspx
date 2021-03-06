﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //string QuerySQL = "select d.Productid,p.ProductName,sum(d.Quantity) as Quantity," +
        //    "sum(d.UnitPrice*d.Quantity) as Amount " +
        //    "from orders m inner join (OrderDetails d inner join Products p " +
        //    "on d.ProductID=p.ProductID) on m.orderid=d.orderid " +
        //    "where m.OrderDate between '" + Request.QueryString["BeginDate"] + "' And '" + Request.QueryString["EndDate"] + "'" +
        //    "group by d.Productid,p.ProductName " +
        //    "order by d.Productid";
        string QuerySQL = string.Format("select d.Productid,p.ProductName,sum(d.Quantity) as Quantity," +
            "sum(d.UnitPrice*d.Quantity) as Amount " +
            "from orders m inner join (OrderDetails d inner join Products p " +
            "on d.ProductID=p.ProductID) on m.orderid=d.orderid " +
            "where m.OrderDate between {2}{0}{2} And {2}{1}{2}" +
            "group by d.Productid,p.ProductName " +
            "order by d.Productid", Request.QueryString["BeginDate"], Request.QueryString["EndDate"], OledbReportData.DateSqlBracketChar);
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 