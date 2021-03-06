﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        int StartNo = Convert.ToInt32(Request.QueryString["StartNo"]);
        int WantRows = Convert.ToInt32(Request.QueryString["WantRecords"]);
        string OrderID = Request.QueryString["OrderID"];

        //说明：设置Http头"gr_batch_total"并不是必须的
        //如果是第一次取数，在Http头中指定记录数，以便客户端在开始时就产生准确的分页信息
        if (StartNo == 0) // StartNo == 0 表示是第一次取数
        {
            string CountQuerySQL = "select count(*) " +
            "from (Orders m inner join (OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " +
            "left join Customers c on c.CustomerID=m.CustomerID ";
            int Total = OledbReportData.BatchGetDataCount(CountQuerySQL);
            Response.AppendHeader("gr_batch_total", Total.ToString());
        }

        string QuerySQL = string.Format("select top {0} m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,M.Freight," +
            "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.Discount, " +
            "d.UnitPrice*d.Quantity as Amount,d.UnitPrice*d.Quantity*d.Discount as DiscountAmt, " +
            "d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount " +
            "from (Orders m inner join " +
            "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " +
            "left join Customers c on c.CustomerID=m.CustomerID " +
            "where m.OrderID>{1} " +
            "order by m.OrderDate, m.OrderID", WantRows, OrderID);

        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 