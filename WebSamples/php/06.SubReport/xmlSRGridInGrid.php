<? include '../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$RelateCustomerQuerySQL = <<<QuerySQL
select o.OrderID, o.ShipCity, c.* from Customers c, Orders o 
where OrderID<=10260 and c.City=o.ShipCity
order by o.OrderID
QuerySQL;
        
$QueryList = array (
    "master" => "select * from Orders where OrderID<=10260 order by OrderID",
    "Detail1" => "select * from OrderDetails where OrderID<=10260",
    "detail2" => $RelateCustomerQuerySQL
);
XML_GenMultiRecordset($QueryList);
?>
 