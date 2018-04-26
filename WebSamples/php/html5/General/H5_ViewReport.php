<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
    <title>
      Web报表(B/S报表)演示, 用HTML5展现报表 - <?php echo $_GET['report'] ?>
    </title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <script src="../grhtml5-1.0.0beta-min.js" type="text/javascript"></script>
    <script type="text/javascript">
      function window_onload() {
        var reportURL  = "<?php echo $_GET['report']?>";
        if (reportURL  != "")
        reportURL  = "../../grf/" + reportURL ;

        var dataURL = "<?php echo $_GET['data']?>";
        if (dataURL != "")
        dataURL = "../../" + dataURL;

        //创建报表显示器，参数指定其在网页中的占位标签的ID，关联的报表模板URL，关联的报表数据URL
        var reportViewer = window.rubylong.grhtml5.insertReportViewer("report_holder", reportURL, dataURL);

        reportViewer.start(); //启动报表运行，生成报表
      }
    </script>
  </head>
  <body onload="window_onload()">
    <div id="report_holder">
    </div>
  </body>
</html>
