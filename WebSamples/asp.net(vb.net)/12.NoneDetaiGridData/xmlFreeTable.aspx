﻿<%@ Page Language="VB" %>
<script runat="server"> 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim QuerySQL As String = "select * from Employees where EmployeeID=5"
        OledbXMLReportData.GenOneRecordset(Me, QuerySQL)
    End Sub
</script>