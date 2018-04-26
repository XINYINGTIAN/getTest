#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

using DLTVWGPT.Datasets.DSJckjaTableAdapters;

using DLTLib.Classes;
using System.Linq;

#endregion

namespace DLTVWGPT.Controls
{
    public partial class FrmRoleFuncs : Form
    {
        private int roleId;
        private List<int> funcsLst;
        public FrmRoleFuncs()
        {
            InitializeComponent();
        }



        public void Prepare(int aRoleId, string aRoleMc)
        {
            roleId = aRoleId;
            this.Text += "-" + aRoleMc;
            funcsLst = getFuncsList(roleId);
            createFuncTree();
            trV.ExpandAll();
        }

        private List<int>getFuncsList(int aRoleId)
        {
            string cmd = "SELECT funcid FROM trolefuncs WHERE roleid =" + roleId;
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            List<int> lst = (from r in dt.AsEnumerable() select r.Field<int>("funcid")).ToList<int>();
         
           
            return lst;
        }

        #region creatFuncTree
        private void createFuncTree()
        {
            string cmd = @"select id, mc, bm, jb, id0, mc0, bm0, id1, mc1, bm1, id2, mc2, bm2,
            id3, mc3, bm3, id4, mc4, bm4, id5, mc5, bm5
            FROM vfuncsa 
            WHERE jb > 0
            ORDER BY xh0, xh1, xh2, xh3, xh4, xh5";

            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            foreach (DataRow r in dt.Rows)
            {
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                for (int i = 1; i <= jb; i++)
                {
                    id = "id" + i;
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        tn = createANode(r, i);
                        if (tp == null)
                            trV.Nodes.Add(tn);//向trV控件添加节点
                        else
                            tp.Nodes.Add(tn);//向父节点tp中添加节点
                    }
                }
            }
        }
        #endregion

        #region createANode
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            string bm = "bm" + jb;
            //使用指定的文本初始化 TreeNode 类的新实例。
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
            tn.CheckBox = CheckBoxVisibility.True;
            tn.Checked = funcsLst.Contains(Convert.ToInt32(r[id]));
            return tn;
        }
        #endregion

        #region NodeMouseDoubleClick
        private void trV_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.HasNodes)
                if (e.Node.IsExpanded)
                    e.Node.Collapse();
                else
                    e.Node.Expand();
        }
        #endregion

        #region getAllCheckedIds
        private void getAllCheckedIds(TreeNode pNode)
        {
            foreach (TreeNode node in pNode.Nodes)
            {
                if (!node.HasNodes && node.Checked)
                {
                    funcsLst.Add(Convert.ToInt32(node.Name));
                }
                getAllCheckedIds(node);
            }
        }
        #endregion



        private void trV_AfterCheck(object sender,TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            foreach(TreeNode item in node.Nodes)
            {
                item.Checked = e.Node.Checked;
            }

        }




        private void btnSave_Click(object sender,EventArgs e)
        {
            funcsLst.Clear();
            foreach (TreeNode node in trV.Nodes)
                getAllCheckedIds(node);
            trolefuncsTableAdapter trolefuncsTableAdapter1 = new trolefuncsTableAdapter();
            trolefuncsTableAdapter1.DeleteByRoleId(roleId);
            if(funcsLst.Count >0)
            {
                string[] insLst = funcsLst.ConvertAll(delegate
                    (int n)
                {
                    string s = roleId + "," + n;
                    return ClsQ.Q0(s, '(');
                }).ToArray();
                string str = string.Join(",", insLst);
                string sql = "INSERT INTO trolefuncs(roleid, funcid) VALUES" + str;
                ClsMSSQL.ExecuteCmd(sql, ClsDBCon.ConStrKj);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}