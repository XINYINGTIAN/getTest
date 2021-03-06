﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //★特别提示★：
        //不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlXMLReportData，Oracle数据库用OracleXMLReportData
        //OledbXMLReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据

        string QuerySQL = string.Format(
            "select m.OrderDate,sum(d.Quantity) as Qty,sum(d.UnitPrice*d.Quantity) as Amount " +
            "from (Orders m inner join OrderDetails as d on m.OrderId=d.OrderId) " +
            "where m.OrderDate between {0}1997-1-1{0} and {0}1997-12-31{0} " +
            "group by m.OrderDate " +
            "order by m.OrderDate", OledbReportData.DateSqlBracketChar);
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 