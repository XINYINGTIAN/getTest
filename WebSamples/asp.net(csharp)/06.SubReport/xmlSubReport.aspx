﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //★特别提示★：
        //不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlXMLReportData，Oracle数据库用OracleXMLReportData
        //OledbXMLReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据

        const string Top10CustomerQuerySQL = 
            "select top 10 c.CustomerID, c.CompanyName, sum(o.Quantity*o.UnitPrice) As SumAmt " +
            "from OrderDetails o, Orders m, customers c " +
            "where o.OrderID=m.OrderID and m.CustomerID=c.CustomerID " +
            "group by c.CustomerID, c.CompanyName " +
            "order by sum(o.Quantity*o.UnitPrice) desc";
        const string Top10ProductQuerySQL = 
            "select top 10 p.ProductID, p.ProductName, sum(o.Quantity*o.UnitPrice) As SumQty " +
            "from OrderDetails o, Products p " +
            "where o.ProductID=p.ProductID " +
            "group by p.ProductID, p.ProductName " +
            "order by sum(Quantity*o.UnitPrice) desc";
        
        ArrayList QueryList = new ArrayList();
        QueryList.Add(new ReportQueryItem("select * from Customers order by CustomerID", "Customer"));
        QueryList.Add(new ReportQueryItem("select * from Products order by ProductName", "Product"));
        QueryList.Add(new ReportQueryItem(Top10CustomerQuerySQL, "Top10Customer"));
        QueryList.Add(new ReportQueryItem(Top10ProductQuerySQL, "Top10Product"));
        OledbXMLReportData.GenMultiRecordset(this, QueryList);
        //OledbJsonReportData.GenMultiRecordset(this, QueryList);
    }
</script> 