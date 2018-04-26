#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using DLTLib.Classes;
using DLTVWGPT.Classes;
using System.Reflection;
using System.Text.RegularExpressions;

#endregion

namespace DLTVWGPT
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }
        public static void prepare(string a)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = !pnlTop.Visible;
            lblTop.Text = pnlTop.Visible ? "∧" : "∨";
        }

        private void lblLeft_Click(object sender, EventArgs e)
        {
            pnlLeft.Visible = !pnlLeft.Visible;
            splitter1.Visible = pnlLeft.Visible;
            lblLeft.Text = pnlLeft.Visible ? "<" : ">";
        }

        private void tsMTools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void tsBtnLogout_Click(object sender, EventArgs e)
        { 
            //VWGContext.Current.Session.IsLoggedOn = false;
            //VWGContext.Current.HttpContext.Session.Abandon();

            ClsMsgBox.YesNo("确实要退出系统吗？",logout);
        }
        private void logout(object sender,EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if(dr==DialogResult.Yes)
            {
                VWGContext.Current.Session.IsLoggedOn = false;
                VWGContext.Current.HttpContext.Session.Abandon();
            }
        }

        private void pnlLeft_Click(object sender, EventArgs e)
        {

        }

        private void funcsTree_Load(object sender, EventArgs e)
        {
     

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            showStat();

            ClsFuncsA funcs = new ClsFuncsA(tpMain);

            FuncTree.Prepare(funcs);
        }
        private void showStat()
        {
            DataRow userRow = VWGContext.Current.Session["UserRow"] as DataRow;
            tssLblUser.Text = "用户：" + userRow["xm"].ToString();
            #region 现实版本和版权信息
            //当前系统的版本号
            Assembly a = Assembly.GetExecutingAssembly();
            //获取当前执行代码的程序集

            AssemblyName an = a.GetName();
            //获取次程序集的AssemblyName

            tssLblVer.Text = "版本:" + an.Version.ToString();

            String s = Gizmox.WebGUI.WGConst.Version;
            Regex r = new Regex("[0-9]?[0-9]+:");
            //匹配“04：”针对指定的正则表达式初始化Regex类的新实例

            Match m = r.Match(s);
            //单个正则表达式匹配的结果
            // 从此实力检索子字符串，子字符串从指定的字符位置开始并具有指定的长度

            tssLblVWGVer.Text = "VWG:" + s.Substring(0, m.Index);

            //版权信息
            tssLblCopyRight.Text = a.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            #endregion
        }

        private void tsBtnRefresh_Click(object sender, EventArgs e)
        {
            string ids = FuncTree.trV.SelectedNode.Name;
            FuncTree.trV.Nodes.Clear();
            ClsFuncsA funcs = new ClsFuncsA(tpMain);
            FuncTree.Prepare(funcs);
            FuncTree.trV.ExpandAll();
            TreeNode[] tns = FuncTree.trV.Nodes.Find(ids, true);
            if (tns.Length > 0)
            {
                FuncTree.trV.SelectedNode = tns[0];
            }
            else
                FuncTree.trV.SelectedNode = FuncTree.trV.Nodes[0];
        }
    }
    }
