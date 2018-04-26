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

#endregion

namespace DLTVWGPT.XTGL
{
    public partial class FrmOptionLBLB : UserControl
    {
        private Datasets.DSJckja.toptionlbRow lbRow;
        public FrmOptionLBLB()
        {
            InitializeComponent();
            Prepare();
        }
        public void Prepare()
        {
            toptionlbTableAdapter1.Fill(dsJckja1.toptionlb);
        }

        private void dgv_Click(object sender, EventArgs e)
        {

        }
        private void dgv_SelectionChanged(object sender,EventArgs e)
        {
            //if(bds.Current == null)
            //{
                if(bds.Current == null)
                {
                    lbRow = null;
                    return;
                }
                lbRow = (Datasets.DSJckja.toptionlbRow)(((DataRowView)bds.Current).Row);
                if (lbRow.RowState == DataRowState.Unchanged)
                {
                    toptionxmTableAdapter1.FillByLbdm(dsJckja1.toptionxm, lbRow.dm);

                }
                else
                    dsJckja1.toptionxm.Clear();
            //}
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.NEW, bds, dsJckja1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.EDIT, bds, dsJckja1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.DETAIL, bds, dsJckja1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            Datasets.DSJckja.toptionlbRow r = (Datasets.DSJckja.toptionlbRow)
                (((DataRowView)bds.Current).Row);
            string cmd = "SELECT *FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.dm);
            if(ClsMSSQL.Exists(cmd,ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("该类别下存在项目无法删除");
                return;
            }
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr==DialogResult.Yes)
            {
                bds.RemoveCurrent();
                toptionlbTableAdapter1.Update(dsJckja1.toptionlb);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }

        private void True(object sender, EventArgs e)
        {

        }

        private void pnlLB_Click(object sender, EventArgs e)
        {

        }

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {

        }

        private void btnNewXM_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.NEW, bdsXM, dsJckja1, toptionxmTableAdapter1, dgvXM,lbRow.dm);
            f.ShowDialog();

        }

        private void btnEditXM_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.EDIT, bdsXM, dsJckja1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnDetailXM_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.DETAIL, bdsXM, dsJckja1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnDelXM_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            if (bdsXM.Current == null)
                return;
            ClsMsgBox.YesNo("确定要删除该记录吗？", deletingXM);

        }

        private void deletingXM(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bdsXM.RemoveCurrent();
                toptionxmTableAdapter1.Update(dsJckja1.toptionxm);
                ClsD.TurnDgvToBdsCurrRec(dgvXM);
            }
        }

     
    }
}