﻿<!--#include file="../data/GenXmlData.asp"-->
<%
Dim WantRows
Dim StartNo
Dim OrderID
WantRows = Request.QueryString("WantRecords")
StartNo =  Request.QueryString("StartNo")
OrderID =  Request.QueryString("OrderID")

'说明：设置Http头"gr_batch_total"并不是必须的
'如果是第一次取数，在Http头中指定记录数，以便客户端在开始时就产生准确的分页信息
If (StartNo = 0) Then
    Dim Total
	CountQuerySQL = "select count(*) " &_
            "from (Orders m inner join (OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " &_
            "left join Customers c on c.CustomerID=m.CustomerID "
    Total = BatchGetDataCount(CountQuerySQL)
    Response.AddHeader "gr_batch_total", Total
End If

//QuerySQL = "select * from Products where ProductID>" & StartNo & " and ProductID<=" & EndNo & " order by ProductID"
QuerySQL = "select top " & WantRows & " m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,M.Freight," &_
            "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.Discount, " &_
            "d.UnitPrice*d.Quantity as Amount,d.UnitPrice*d.Quantity*d.Discount as DiscountAmt, " &_
            "d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount " &_
            "from (Orders m inner join " &_
            "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " &_
            "left join Customers c on c.CustomerID=m.CustomerID " &_
            "where m.OrderID>" & OrderID &_
            "order by m.OrderID"
GenNodeXmlData(QuerySQL)
%> 