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
using DLTVWGPT.Datasets;
using DLTVWGPT.Controls;

#endregion

namespace DLTVWGPT.XTGL
{
    public partial class FrmRolesLB : UserControl
    {
        public FrmRolesLB()
        {
            InitializeComponent();
            Prepare();
        }
        public void Prepare()
        {
            trolesTableAdapter1.Fill(dsJckja1.troles);
        }

        private void dgv_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.NEW, bds, dsJckja1, trolesTableAdapter1, dgv);
            f.ShowDialog();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.EDIT, bds, dsJckja1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.DETAIL, bds, dsJckja1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            Datasets.DSJckja.trolesRow r = (Datasets.DSJckja.trolesRow)
                (((DataRowView)bds.Current).Row);
            string cmd = "SELECT *FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.dm);
            if (ClsMSSQL.Exists(cmd, ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("该类别下存在项目无法删除");
                return;
            }
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bds.RemoveCurrent();
                trolesTableAdapter1.Update(dsJckja1.troles);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }

        private void True(object sender, EventArgs e)
        {

        }

        private void btnFuncs_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            DSJckja.trolesRow r = (DSJckja.trolesRow)(((DataRowView)bds.Current).Row);
            if (r.qx < 1024)
            {
                ClsMsgBox.Jg("该角色为系统管理类角色，不需要设置可访问的功能模块。");
                return;
            }
            FrmRoleFuncs f = new FrmRoleFuncs();
            f.Prepare(r.id, r.mc);
            f.ShowDialog();
        }

   

        private void mnuDgv_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}