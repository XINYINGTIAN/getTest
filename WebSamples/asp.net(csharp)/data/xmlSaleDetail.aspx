﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //★特别提示★：
        //不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlXMLReportData，Oracle数据库用OracleXMLReportData
        //OledbXMLReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据

        const string QuerySQL = "select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,M.Freight," +
            "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.Discount, " +
            "d.UnitPrice*d.Quantity as Amount, d.UnitPrice*d.Quantity*d.Discount as DiscountAmt, " +
            "d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount " +
            "from (Orders m inner join " +
            "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " +
            "left join Customers c on c.CustomerID=m.CustomerID " +
            "where m.OrderID<=10300 " +
            "order by m.OrderDate, m.OrderID";
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 