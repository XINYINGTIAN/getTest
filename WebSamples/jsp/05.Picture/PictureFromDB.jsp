﻿<%@ page import="java.lang.*, java.io.*, java.sql.*, java.util.*"%>
<%
    try
    {
        String url= "jdbc:mysql://localhost/gridreport?user=root&password=";
        Class.forName("com.mysql.jdbc.Driver");         // Class.forName 装载驱动程序 
        Connection con=DriverManager.getConnection(url); //用适当的驱动程序类与 DBMS 建立一个连接
        Statement stmt=con.createStatement();            //用于发送简单的SQL语句
        ResultSet rs=stmt.executeQuery("select Picture From Categories where CategoryID=1");

        rs.next();
        
        response.resetBuffer();
        ServletOutputStream sos = response.getOutputStream();
        sos.write(rs.getBytes(1));
        sos.flush();
    
        rs.close();
        stmt.close();
        con.close();
    }
    catch(Exception e)
    {
        //out.println(e.toString());
    }
%> 