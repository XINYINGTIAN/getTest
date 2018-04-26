using DLTLib.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DLTVWGPT.GRBB
{
    public partial class YgBBData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e )
        {
            string cmd = @"
                         SELECT [id],[jgid],[jgmc],[xh],[xm],[xb],[xbs],[gw],[gwmc]
                         FROM [dbo].[vyg]
                         ";
            string sWhere = Request.QueryString["where"];
            //Request.QueryString是JavaScript中获取网页链接地址中参数的方法
            sWhere = HttpUtility.UrlDecode(sWhere);
            cmd += sWhere;

            //
           // SqlReportData
            DLTSqlXMLReportData.GenOneRecordset(this, cmd, ClsDBCon.ConStrKj);
        }
    }
}                                               