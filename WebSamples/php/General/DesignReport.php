<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>Web閹躲儴銆?B/S閹躲儴銆?濠曟梻銇氶敍灞芥躬缂冩垿銆夋稉顓炵安閻劍濮ょ悰銊啎鐠佲€虫珤鐠佹崘顓搁幎銉ㄣ€?- <?php echo $_GET['report'] ?></title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<script src="../CreateControl.js" type="text/javascript"></script>
    <script type="text/javascript">
function OnSaveReport()
{
  alert("娑撹桨绨℃穱婵囧Б閹躲儴銆冮惃鍕劀鐢憡绱ㄧ粈鐚寸礉鏉╂瑩鍣烽弨鎯х磾娴滃棗顕幎銉ㄣ€冪拋鎹愵吀閻ㄥ嫪绻氱€涙﹫绱?);
  //ReportDesigner.DefaultAction = false;
}
    </script>
    <style type="text/css">
      html,body {
      margin:0;
      height:100%;
      }
    </style>
</head>
<body style="margin:0">
  <script type="text/javascript">
    var Report = "<?php echo $_GET['report']?>";
    if (Report != "")
    Report = "../grf/" + Report;

    var Data = "<?php echo $_GET['data']?>";
    if (Data != "")
    Data = "../" + Data;

    //婵″倹鐏夐惄瀛樺复閹稿洤鐣綬eportURL娑撶rf閺傚洣娆㈤惃鍒凴L,娑撳秷鍏樻穱婵嗙摠閺佺増宓侀敍灞藉讲閼宠姤妲搁弬鍥︽鐞氼偅澧﹀鈧柨浣哥暰
    CreateDesignerEx("100%", "100%", Report, <?php echo "\"DesignReportSave.php?report=".$_GET['report']."\"" ?>, Data, "<param name=OnSaveReport value=OnSaveReport>");
  </script>
</body>
</html> 
