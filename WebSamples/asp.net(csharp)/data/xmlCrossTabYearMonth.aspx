﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //★特别提示★：
        //不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlXMLReportData，Oracle数据库用OracleXMLReportData
        //OledbXMLReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据

        string QuerySQL = "select Year(m.OrderDate) As TheYear,Month(m.OrderDate) As TheMonth, sum(d.UnitPrice*d.Quantity) as Amount " +
            "from Orders m inner join OrderDetails as d on m.OrderId=d.OrderId " +
            "group by Year(m.OrderDate),Month(m.OrderDate) " +
            "order by Year(m.OrderDate),Month(m.OrderDate) ";    
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 