<? include '../../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$QuerySQL = <<<QuerySQL
select m.OrderID,m.CustomerId,m.OrderDate,d.ProductID,p.ProductName,d.UnitPrice,d.Quantity, 
d.UnitPrice*d.Quantity as Amount 
from (Orders m inner join OrderDetails as d on m.OrderID=d.OrderID) 
left outer join Products p on p.ProductID=d.ProductID
where m.OrderID<=10300 
order by m.OrderDate, m.OrderID
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?> 