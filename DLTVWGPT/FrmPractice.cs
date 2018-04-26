#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using DLTLib.Classes;
using System.Web;

#endregion

namespace DLTVWGPT
{
    public partial class FrmPractice : Form
    {
        public FrmPractice()
        {
            InitializeComponent();
        }

        private void dgv_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lst.Items.Add(ClsQ.Q1(txtA.Text));
            testGetDataTable();
            //    testMsgBox();
            testDBCon();
            
            testGetDataTableException();
            //testYgBB1();
            testYgBB1a();
            //testYgBBcsa();
            //testYgBBcs();
            //testYgBB1b();
            //testYgBB1c();
            //testYgBB1d();
        }
        #region 连接串的读取
        private void testDBCon()
        {
            lst.Items.Add(ClsDBCon.ConStrKj);

        }
        #endregion

        #region clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            lst.Items.Clear();
        }
        #endregion

        #region 弹窗
        private void testMsgBox()
        {
            ClsMsgBox.Ts(txtA.Text);
            ClsMsgBox.Jg(txtA.Text);
            ClsMsgBox.Cw(txtA.Text);
        }
        #endregion

        #region DataTable

        private void testGetDataTable()
        {
            string cmd = "SELECT * FROM tlogin";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            dgv.DataSource = dt;
            //实现在dgv中显示GetDataTable返回的数据表。
            tcA.SelectedTab = tpDgv;
            //将TabControl的活动页置为tpDgv。
        
        }
        #endregion

        #region 异常处理
        private void testGetDataTableException()
        {
            string cmd = "SELECT * FROM tlogin";
            try
            {
                DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
                dgv.DataSource = dt;
                tcA.SelectedTab = tpDgv;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw(ex.Message);
            }
        }
        #endregion
        #region YgBB1
        private void testYgBB1()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            Link.Open("/GRBB/YgBBData.aspx", paras);
        }
        #endregion

        #region YgBB1a
        private void testYgBB1a()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            Link.Open("/GRBB/YgBB.aspx", paras);
            //
        }

        private void testYgBB1b()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xb = 1 ORDER BY xm";
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere;
            Link.Open(bbURL, paras);
        }
        #endregion
        private void testYgBB1c()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xb = 男 ORDER BY xm";
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere;
            Link.Open(bbURL, paras);
        }
        private void testYgBB1d()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xb = 男 ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere;
            Link.Open(bbURL, paras);
        }
        private void testYgBBcs()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xb = 男 ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string xms = getXMs();
            //上面该行获取toptionxm表中lbdm为xl的选项的mc
            xms = HttpUtility.UrlEncode(xms);
            //将xms转换为可作为网址的串
            string bbURL = "/GRBB/YgBB.aspx?where=" + sWhere+"&xms="+xms;
            //&符号实现URL中的多参数传递
            Link.Open(bbURL, paras);
        }
        private void testYgBBcsa()
        {
            LinkParameters paras = new LinkParameters();
            paras.Target = "_blank";
            paras.FullScreen = false;
            paras.Resizable = true;
            paras.ScrollBars = true;
            paras.ShowToolBar = true;
            paras.ShowMenuBar = true;
            paras.ShowTitleBar = true;
            paras.ShowStatusBar = true;
            paras.WindowStyle = LinkWindowStyle.Normal;
            string sWhere = "WHERE xb = 男 ORDER BY xm";
            sWhere = HttpUtility.UrlEncode(sWhere);
            string xms = getXMs();
            //上面该行获取toptionxm表中lbdm为xl的选项的mc
            xms = HttpUtility.UrlEncode(xms);
            //将xms转换为可作为网址的串
            string bbURL = "/GRBB/YgBBa.aspx?where=" + sWhere + "&xmsa=" + xms;
            //&符号实现URL中的多参数传递
            Link.Open(bbURL, paras);
        }
        private string getXMs()
            //获取toptionxm表中lbdm为xl的选项的mc
        {
            string cmd = @"
                SELECT mc FROM toptionxm 
                WHERE lbdm='xl'
                ORDER BY dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            var a = from r in dt.AsEnumerable()
                    select r.Field<string>("mc");
            //LINQ技术
            //从DataTable对象变量dt中获取所有各行的mc字段的值
            string[] xma = a.ToArray();
            //将a转换为串数组
            string xms = string.Join(",", xma);
            //将串数组中的各字符串用逗号连成一个字符串
            return xms;
        }
        private void testExits1()
        {
            bool b;
            string cmd = string.Format("SELECT * FROM tlogin WHERE loginname LIKE '%{0}%'", txtA.Text);
            b = ClsMSSQL.Exists(cmd, ClsDBCon.ConStrKj);
            lst.Items.Add(b);
        }
        private void testExits2()
        {
            bool b;
            b = ClsMSSQL.Exists("tlogin", "loginname", txtA.Text, ClsDBCon.ConStrKj);
            lst.Items.Add(b);
        }

    }
}