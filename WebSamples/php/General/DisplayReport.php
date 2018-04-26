<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<title>Web鎶ヨ〃(B/S鎶ヨ〃)婕旂ず, 鐢ㄦ姤琛ㄦ煡璇㈡樉绀哄櫒鎻掍欢灞曠幇鎶ヨ〃 - <?php echo $_GET['report'] ?></title>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
		<script src="../CreateControl.js" type="text/javascript"></script>
	</head>
	<body style="margin:0">
	<script type="text/javascript">
    var Report = "<?php echo $_GET['report']?>";
    if (Report != "")
    Report = "../grf/" + Report;

    var Data = "<?php echo $_GET['data']?>";
    if (Data != "")
    Data = "../" + Data;

    CreateDisplayViewerEx("100%", "100%", Report, Data, true, "");
  </script>
	</body>
</html>
 