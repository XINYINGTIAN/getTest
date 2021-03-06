<? include '../../data/mysql_GenXmlData.php'; ?>
<?php
//这个例子程序可以分别眼演示MYSQL、MSSQL与ODBC这几种数据访问方式，
//将上面的include包含文件改为mysql_GenXmlData，就是采用MYSQL数据
//将上面的include包含文件改为mssql_GenXmlData，就是采用MSSQL数据
//将上面的include包含文件改为odbc_GenXmlData，就是采用ODBC数据
$QuerySQL = <<<QuerySQL
select d.ProductID,p.ProductName,sum(d.UnitPrice*d.quantity) as amount 
from OrderDetails d inner join Products p on p.Productid=d.Productid 
group by d.ProductID,p.ProductName 
order by sum(d.UnitPrice*d.quantity) desc
QuerySQL;
XML_GenOneRecordset($QuerySQL);
?> 