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
using JXC.Datasets;

#endregion

namespace JXC.JH
{
    public partial class FrmJhdLB : UserControl
    {
        public FrmJhdLB()
        {
            InitializeComponent();
            Prepare();
        }
        private DataTable dtJhdHj;

        public void Prepare()
        {
            createTableAndRelation();
            dsJxc1.tjhd.TableNewRow += tjhd_TableNewRow;
            //为tjhd表的新增记录添加事件函数
            dsJxc1.tjhd.ColumnChanged += tjhd_ColumnChanged;
            //为tjhd表添加columnchanged事件函数tjhd_ColumnCHanged
            tjhdTableAdapter1.Fill(dsJxc1.tjhd);
        }

        #region ColumnChanged使两个表的id与jhdid match
        //column changed事件,在tjhd表中判断当新增记录的id变化时,将dtJhdHj表中是否对应记录的id同步修改
        private void tjhd_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName.Equals("id", StringComparison.CurrentCultureIgnoreCase)
                //判断发生变化的列为id列
                && e.Row.HasVersion(DataRowVersion.Original)
                //判断当前记录存在original(原始)版本
                && Convert.ToInt32(e.Row["id", DataRowVersion.Original]) < 0)
                //判断original版本中的id为负值,即是新增记录的id发生了变化
            {
                int id = Convert.ToInt32(e.Row["id", DataRowVersion.Original]);
                //获取原始版本中的id
                //访问一条记录的不同版本中的字段值使用e.Row["id", DataRowVersion.Original]语法
                DataRow[] r = dtJhdHj.Select(string.Format("jhdid = {0}", id));
                //获取dyJhdHj中与原始版本中id值对应的记录
                //对dtJhdHj表使用select查询,如果不存在对应的记录,则为其增加一条记录,
                //使jhdid的值为tjhd表新增记录的id,hj值为0
                if (r.Length > 0)
                    r[0]["jhdid"] = e.Row["id"];
                //e.Row["id"]访问的是当前版本(Current)
                //将其中的jhdid值替换为tjhd表新增记录当前版本的id值e.Row["id"]
            }
        }
        #endregion


        #region TableNewRow 
        private void tjhd_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            int id = Convert.ToInt32(e.Row["id"]);
            if (dtJhdHj.Select(string.Format("jhdid = {0}", id)).Length == 0)
                dtJhdHj.Rows.Add(new object[] { id, 0 });
        }
        //TableNewRole事件函数,每当新增一条记录时,检查dtJhdHj表中是否有对应的键值记录,如果没有则添加
        #endregion


        #region createTableAndRelation建立外表联系
        private void createTableAndRelation()
        {
            string cmd;
            cmd = "SELECT id AS jhdid, hj FROM vjhdhj ORDER BY jhdid";
            dtJhdHj = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrJxc);
            dtJhdHj.TableName = "vjhdhj";
            //为dtJhdHj赋值一个表名,以便在其他窗口找到该表
            dsJxc1.Tables.Add(dtJhdHj);
            DataRelation rel;
            rel = new DataRelation("jhdhj", dtJhdHj.Columns["jhdid"], dsJxc1.tjhd.idColumn);
            dsJxc1.Relations.Add(rel);
            dsJxc1.tjhd.hjaColumn.Expression = "Parent(jhdhj).hj";
        }

        #endregion



        private void dgv_Click(object sender, EventArgs e)
        {

        }
        #region 4Button 
        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmJhdXX f = new FrmJhdXX();
            f.Prepare(EnumNED.NEW, bds, dsJxc1, tjhdTableAdapter1, dgv);
            f.ShowDialog();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmJhdXX f = new FrmJhdXX();
            f.Prepare(EnumNED.EDIT, bds, dsJxc1, tjhdTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmJhdXX f = new FrmJhdXX();
            f.Prepare(EnumNED.DETAIL, bds, dsJxc1, tjhdTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        #endregion 


        #region deleting 
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bds.RemoveCurrent();
                tjhdTableAdapter1.Update(dsJxc1.tjhd);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }
        #endregion


        private void True(object sender, EventArgs e)
        {

        }


    }
}