﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../data/GenXmlData.jsp" %>
<%
int StartNo = Integer.parseInt( request.getParameter("StartNo") );
int WantRows = Integer.parseInt( request.getParameter("WantRecords") );
int OrderID = Integer.parseInt( request.getParameter("OrderID") );
if (OrderID==0)
	OrderID = 10247;
int EndOrderID = OrderID + WantRows;

//说明：设置Http头"gr_batch_total"并不是必须的
//如果是第一次取数，在Http头中指定记录数，以便客户端在开始时就产生准确的分页信息
if (StartNo == 0)
{
    String CountQuerySQL = "select count(*) " +
    "from (Orders m inner join (OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " +
    "left join Customers c on c.CustomerID=m.CustomerID ";
	int Total = BatchGetDataCount(CountQuerySQL);
    response.addIntHeader("gr_batch_total", Total); //gr_batch_total指定数据总行数
}

//mysql 不支持top关键字，所以这里避免用
String QuerySQL = "select m.OrderID,m.CustomerId,c.CompanyName,m.OrderDate,M.Freight," +
    "d.ProductID,p.ProductName,d.UnitPrice,d.Quantity,d.Discount, " +
    "d.UnitPrice*d.Quantity as Amount,d.UnitPrice*d.Quantity*d.Discount as DiscountAmt, " +
    "d.UnitPrice*d.Quantity-d.UnitPrice*d.Quantity*d.Discount as NetAmount " +
    "from (Orders m inner join " +
    "(OrderDetails as d inner join Products p on P.ProductID=D.ProductID) on m.OrderId=d.OrderId) " +
    "left join Customers c on c.CustomerID=m.CustomerID " +
    "where m.OrderID>" + OrderID + " and m.OrderID<=" + EndOrderID + 
    " order by m.OrderID";
XML_GenOneRecordset(response, QuerySQL);
%> 