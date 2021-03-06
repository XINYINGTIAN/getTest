﻿<%@ page contentType="text/html; charset=utf-8"%>
<%@ include file = "../../data/GenXmlData.jsp" %>
<%
//如下转换之后，中文参数才不会乱码，但 mysql 例子还是未转换成功
//JSP的乱码问题很难处理，请根据具体引用环境调整参数转换
//String City = new String(request.getParameter("City").getBytes(), "utf-8");  
String RawCity = request.getParameter("City"); 
String City = new String(RawCity.getBytes("ISO-8859-1"), "UTF-8");  

String CustomerQuerySQL = "select * from Customers where City='" + City + "'";
String SupplierQuerySQL = "select * from Suppliers where City='" + City + "'";

ArrayList<ReportQueryItem> QueryItems = new ArrayList<ReportQueryItem>();
QueryItems.add(new ReportQueryItem(CustomerQuerySQL, "Customer"));
QueryItems.add(new ReportQueryItem(SupplierQuerySQL, "Supplier"));

XML_GenMultiRecordset(response, QueryItems);
%> 