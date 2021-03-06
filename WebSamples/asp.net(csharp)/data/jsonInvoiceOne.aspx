﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //★特别提示★：
        //不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlXMLReportData，Oracle数据库用OracleXMLReportData
        //OledbXMLReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据

        //第一个查询SQL串指定报表明细数据的查询SQL
        //第二个查询SQL串指定报表参数数据的查询SQL
        const string DetailQuerySQL = "select d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.UnitPrice*d.Quantity as Amount "
            + "from OrderDetails as d inner join Products p on P.ProductID=D.ProductID "
            + "where d.OrderID=10255";
        const string ParameterQuerySQL = "select m.OrderID,m.CustomerId,c.CompanyName,C.Address,m.OrderDate,c.ContactName+c.Phone as Remark "
            + "from Orders m left join Customers c on c.CustomerID=m.CustomerID "
            + "where m.OrderID=10255";
        
        ArrayList QueryList = new ArrayList();
        QueryList.Add(new ReportQueryItem(DetailQuerySQL, "Detail"));
        QueryList.Add(new ReportQueryItem(ParameterQuerySQL, "Master"));
        
        OledbJsonReportData.GenMultiRecordset(this, QueryList);
    }
</script> 