﻿<!--#include file="GenXmlData.asp"-->
<%
Dim QuerySQL
dim objstream

'打开STREAM对象，写入上传数据，最后保存到文件
set objstream=server.CreateObject("ADODB.Stream") 'str为源数据流 
objstream.Mode=3 '设置打开模式，3为可读可写 
objstream.Type=1 '设置数据类型，1为二进制数据 2为文本格式
objstream.Open 
objstream.Write Request.BinaryRead(Request.TotalBytes)
objstream.Position = 0
objstream.Type = 2
objstream.Charset = "utf-8"
QuerySQL = objstream.ReadText
objstream.Close
Set objstream=nothing

//GenNodeXmlData(QuerySQL)
//QuerySQL = Request.QueryString("QuerySQL") 
GenNodeXmlData(QuerySQL)
%>
 