﻿<%@ page import="java.lang.*, java.io.*, java.sql.*, java.util.*"%>
<%
    //因不熟悉java，暂时未能成功将二进制数据写入到数据库
    
    int DataLen = request.getContentLength();
    
//    //打开文件准备读取数据
//    String FileName = request.getRealPath("grf") + "\\1a.grf";
//    FileInputStream fis = new FileInputStream(FileName);
//    byte[] DataBuf = new byte[1024*50];
//    //读文件数据，并写入响应流中
//    int ReadBytes = fis.read(DataBuf);
//    DataLen = 100; //DataBuf.length();
    
    if (DataLen > 0)
    {
        //如下转换之后，中文参数才不会乱码
        String ReportName = new String(request.getParameter("report").getBytes("ISO-8859-1"));  
        
        //读出客户端发送的数据
        byte[] DataBuf = new byte[DataLen];   
        ServletInputStream sif = request.getInputStream();
        sif.read(DataBuf);
        
        //try
        //{
            //String url= "jdbc:mysql://localhost/gridreport?user=root&password=";
            //Class.forName("com.mysql.jdbc.Driver");         // Class.forName 装载驱动程序 
            //Connection con=DriverManager.getConnection(url); //用适当的驱动程序类与 DBMS 建立一个连接
            String url="jdbc:microsoft:sqlserver://localhost:1433;DatabaseName=gridreport";
            Class.forName("com.microsoft.jdbc.sqlserver.SQLServerDriver");// Class.forName 装载驱动程序 
            Connection con=DriverManager.getConnection(url, "sa", "");    //用适当的驱动程序类与 DBMS 建立一个连接
            
            Statement stmt = con.createStatement();            //用于发送简单的SQL语句
            String QuerySQL = "Select ReportData from Report where ReportName='" + ReportName + "'";
            ResultSet rs = stmt.executeQuery(QuerySQL);
            boolean Existed = rs.next();
            rs.close();
            stmt.close();

            Blob blob = con.createBlob(); //new Blob(con);
            //对CLOB对象赋值
            blob.setBytes(0,DataBuf);

            //报表模板数据写入表中
            String strSQL;
            if (Existed)
                strSQL = "UPDATE Report SET ReportData=@ReportData where ReportName=?";
            else
                strSQL = "INSERT INTO Report(ReportName,ReportData) VALUES(?, ?)";
                    
            PreparedStatement pstmt = con.prepareStatement(strSQL);
            int Index = 1;
            if ( !Existed )
            {
                pstmt.setString(1, ReportName);
                ++Index;
            }
            pstmt.setBlob(Index, blob);
            pstmt.executeUpdate();                    
            pstmt.close();
                    
            con.close();
//        }
//        catch(Exception e)
//        {
//            out.println(e.toString());
//        }
    }
            //out.println("finished");
%> 