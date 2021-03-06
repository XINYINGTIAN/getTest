﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //★特别提示★：
        //不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlXMLReportData，Oracle数据库用OracleXMLReportData
        //OledbXMLReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据
        string QuerySQL = string.Format(                
            "select d.Productid,p.ProductName,sum(d.Quantity) as Quantity, " +
            "sum(d.UnitPrice*d.Quantity*(1-d.Discount)) as Amount " +
            "from orders m inner join (OrderDetails d inner join Products p " +
            "on d.ProductID=p.ProductID) " +
            "on m.orderid=d.orderid " +
            "where m.OrderDate between {0}1997-1-1{0} and {0}1997-12-31{0} " +
            "group by d.Productid,p.ProductName " +
            "order by d.Productid", OledbReportData.DateSqlBracketChar);

        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 