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
            //tjhd���������¼ʱ����¼�����tjhd_TableNewRow��
            dsJxc1.tjhd.TableNewRow += tjhd_TableNewRow;
            dsJxc1.tjhd.ColumnChanged += tjhd_ColumnChanged;
            tjhdTableAdapter1.Fill(dsJxc1.tjhd);
        }
        #endregion

        #region createTableAndRelation() �������ݱ�����Լ������̬Ϊhja�д���Expression���ʽ
        private void createTableAndRelation()
        {
            string cmd;
            cmd = "SELECT id AS jhdid,hj FROM vjhdhj ORDER BY jhdid";
            dtJhdHj = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrJxc);
            //ΪdtJhdHj��ֵһ������
            dtJhdHj.TableName = "vjhdhj";
            dsJxc1.Tables.Add(dtJhdHj);
            DataRelation rel;
            rel = new DataRelation("jhdhj", dtJhdHj.Columns["jhdid"], dsJxc1.tjhd.idColumn);
            dsJxc1.Relations.Add(rel);
            dsJxc1.tjhd.hjaColumn.Expression = "Parent(jhdhj).hj";
        }
        #endregion

        #region tjhd_ColumnChanged() �жϵ�������¼��id�仯ʱ����dtJhdHj�����Ƿ��Ӧ��¼��idͬ���޸ġ�
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
            //��ȡ������¼��id
            int id = Convert.ToInt32(e.Row["id"]);
            //dtJhdHj�в����ڶ�Ӧ�ļ�¼,����һ����¼ʹjhdid��ֵΪtjhd��������¼��id��hjֵΪ0
            if (dtJhdHj.Select(string.Format("jhdid = {0}", id)).Length == 0)
                dtJhdHj.Rows.Add(new object[] {id,0});
        }
        #endregion

        #region ��ť����Ҽ��˵�
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
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deleting);
        }
        #region deleting() ɾ��ʱ�Ļص�����
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