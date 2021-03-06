﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        //★特别提示★：
        //不同的数据库应该选用不同的报表XML数据生成类，SQL Server数据库用SqlXMLReportData，Oracle数据库用OracleXMLReportData
        //OledbXMLReportData适合于Access等本地数据库，为了演示方便，这里从Grid++Report的Access例子数据库中获取报表数据

        const string QuerySQL = "select EmployeeID,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate," +
            "Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes from Employees";
        
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 