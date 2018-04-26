#region Using

using System;
using Gizmox.WebGUI.Forms;
using DLTLib.Classes;
using System.Data;

#endregion

namespace JXC.JH
{
    public partial class FrmJhdLB : UserControl
    {
        private DataTable dtJhdHj;
        public FrmJhdLB()
        {
            InitializeComponent();
        }
        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }

        #region Prepare()
        public void Prepare()
        {
            createTableAndRelation();
            //tjhd表的新增记录时添加事件函数tjhd_TableNewRow：
            dsJxc1.tjhd.TableNewRow += tjhd_TableNewRow;
            dsJxc1.tjhd.ColumnChanged += tjhd_ColumnChanged;
            tjhdTableAdapter1.Fill(dsJxc1.tjhd);
        }
        #endregion

        #region createTableAndRelation() 创建数据表，建立约束，动态为hja列创建Expression表达式
        private void createTableAndRelation()
        {
            string cmd;
            cmd = "SELECT id AS jhdid,hj FROM vjhdhj ORDER BY jhdid";
            dtJhdHj = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrJxc);
            //为dtJhdHj赋值一个表名
            dtJhdHj.TableName = "vjhdhj";
            dsJxc1.Tables.Add(dtJhdHj);
            DataRelation rel;
            rel = new DataRelation("jhdhj", dtJhdHj.Columns["jhdid"], dsJxc1.tjhd.idColumn);
            dsJxc1.Relations.Add(rel);
            dsJxc1.tjhd.hjaColumn.Expression = "Parent(jhdhj).hj";
        }
        #endregion

        #region tjhd_ColumnChanged() 判断当新增记录的id变化时，将dtJhdHj表中是否对应记录的id同步修改。
        private void tjhd_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName.Equals("id", StringComparison.CurrentCultureIgnoreCase)
                && e.Row.HasVersion(DataRowVersion.Original)
                && Convert.ToInt32(e.Row["id", DataRowVersion.Original]) < 0)
            {
                int id = Convert.ToInt32(e.Row["id", DataRowVersion.Original]);
                DataRow[] r = dtJhdHj.Select(string.Format("jhdid = {0}", id));
                if (r.Length > 0)
                    r[0]["jhdid"] = e.Row["id"];
            }
        }
        #endregion

        #region tjhd_TableNewRow()
        private void tjhd_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            //获取新增记录的id
            int id = Convert.ToInt32(e.Row["id"]);
            //dtJhdHj中不存在对应的记录,增加一条记录使jhdid的值为tjhd表新增记录的id，hj值为0
            if (dtJhdHj.Select(string.Format("jhdid = {0}", id)).Length == 0)
                dtJhdHj.Rows.Add(new object[] {id,0});
        }
        #endregion

        #region 按钮组和右键菜单
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
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        #region deleting() 删除时的回调函数
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

        #endregion
    }
}