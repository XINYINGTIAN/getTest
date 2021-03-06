﻿<%@ Page Language="C#" %>
<script runat="server"> 
    protected void Page_Load(object sender, EventArgs e)
    {
        const string QuerySQL =
"select D.OrderID,D.ProductID,P.ProductName,D.UnitPrice,D.Quantity,"
+ "O.CustomerID,C.CompanyName,O.EmployeeID,E.LastName+E.FirstName as EmployeeName, "
+ "D.Quantity*D.UnitPrice as Amount, "
+ "O.OrderDate "
+ "from OrderDetails D,Orders O,Products P,Employees E,Customers C "
+ "where D.OrderID=O.OrderID and D.ProductID=P.ProductID and O.EmployeeID=E.EmployeeID and C.CustomerID=O.CustomerID "
+ "and O.OrderDate between #1/1/1997# And #1/31/1997# ";
        OledbXMLReportData.GenOneRecordset(this, QuerySQL);
    }
</script> 