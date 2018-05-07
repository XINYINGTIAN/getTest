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
using DLTVWGPT.Datasets;

#endregion

namespace DLTVWGPT.Controls
{
    public partial class UCFuncsTree : UserControl
    {
        public UCFuncsTree()
        {
            InitializeComponent();
        }



        #region 功能树用户创建
        public void prepare()
        {
            createFuncTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
        }
        private void createFuncTree()
        {   //@符号表示用原始字符定义字符串
            //“string cmd = @"”语句设计了一个从vfuncsa视图中选择建立功能树所需要信息的SELECT语句
            string cmd = @"
       SELECT id, mc, bm, jb,
       id0, mc0, bm0, id1, mc1, bm1, id2, mc2, bm2,
       id3, mc3, bm3, id4, mc4, bm4, id5, mc5, bm5 
       FROM vfuncsa 
       WHERE jb > 0
       ORDER BY xh0, xh1, xh2, xh3, xh4, xh5
";
            DSJckja.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSJckja.vusersRow;
            if (userRow.qx >= 1024)
            {
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                cmds[4] = string.Format(@"WHERE id IN 
(SELECT funcid FROM trolefuncs WHERE roleid = {0})", userRow.roleid);
                cmd = string.Join(Environment.NewLine, cmds);
            }
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //从数据库中读取记录保存到dt表变量中
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            foreach (DataRow r in dt.Rows)
                //对dt中的行进行遍历
            {
                jb = Convert.ToInt32(r["jb"].ToString());
                //获取当前功能级别数值
                tp = null;
                for (int i = 1; i <= jb; i++)
                    //循环依次判断当前功能模块的

                {
                    id = "id" + i;
                    //按照以r[id].ToString()为名查找具有指定键的树节点，可以选择搜索子节点，返回一个list[]。
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    //从trV的所有结点中搜索Name为当前级别模块的id的结点
                    //由于可能存在多个Name相同的结点,返回结果是一个元素类型为TreeNode的数据
                    if (tns.Length > 0)
                        tp = tns[0];
                    //如果tns有结点,赋值到tp
                    else
                    {
                        tn = createANode(r, i);
                        //创建r(模块信息行，包括一个功能模块及其各上级模块的信息)中第i级的模块结点
                        if (tp == null)
                            trV.Nodes.Add(tn);//向trV控件添加节点
                        else
                            tp.Nodes.Add(tn);//向父节点tp中添加节点
                        tp = tn;
                    }
                }
            }
        }

        private TreeNode createANode(DataRow r, int jb)
        {
            //前三行构造第i级的id mc 和bm对应的视图字段名
            string id = "id" + jb;
            string mc = "mc" + jb;
            string bm = "bm" + jb;
            //使用指定的文本初始化 TreeNode 类的新实例。
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
            return tn;
        }
        #endregion

        #region 功能调用
        private ClsFuncs funcs;
        public void Prepare(ClsFuncs aFuncs)
        {
            funcs = aFuncs;
            createFuncTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
        }
        #endregion

        #region AfterSelect事件
        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!e.Node.HasNodes)
                //没有下级子节点的功能,才能进行功能调用
                funcs.Call(Int32.Parse(e.Node.Name), e.Node.Tag.ToString(), e.Node.Text);
            //int32.Parse是一种将串转换为int的办法
        }
        #endregion

        #region 为结点增加双击功能
        private void trV_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        { 
            if (e.Node.HasNodes)
                if (e.Node.IsExpanded)
                    e.Node.Collapse();
                else
                    e.Node.Expand();
        }
        #endregion
    }
}