<?php
// connect to mysql server with a user and password
mysql_connect("localhost", "root", "") or die("couldn't connect: ".mysql_error());
mysql_select_db("gridreport");
//mysql_query("set names 'gbk'");
$result = mysql_query("select Picture From Categories where CategoryID=1");
$row = mysql_fetch_array($result);
mysql_free_result($result);
//目前还未搞成功，本来数据是10656直接，但PHP加多了3个字节(10659)
echo $row[0];
?> 