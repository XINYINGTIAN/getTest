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
    public partial class FrmYuanGongLB : UserControl
    {
        public FrmYuanGongLB()
        {
            InitializeComponent();
            Prepare();
        }
        public void Prepare()
        {
            tjigouTableAdapter1.Fill(dsJckja1.tjigou);
            trolesTableAdapter1.Fill(dsJckja1.troles);
            tygTableAdapter1.Fill(dsJckja1.tyg);
            createTableAndRelation();


        }

        public void createTableAndRelation()
        {
            string cmd;
            cmd = "SELECT dm,mc FROM toptionxm WHERE lbdm='gw' ORDER BY dm";
            DataTable dtGw = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            cmd = "SELECT dm,mc FROM toptionxm WHERE lbdm='xl' ORDER BY dm";
            DataTable dtxl = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            dsJckja1.Tables.Add(dtGw);
            dsJckja1.Tables.Add(dtxl);
            DataRelation rel;
            rel = new DataRelation("yg_gw", dtGw.Columns["dm"], dsJckja1.tyg.gwColumn);
            dsJckja1.Relations.Add(rel);
            rel = new DataRelation("yg_xl", dtxl.Columns["dm"], dsJckja1.tyg.xlColumn);
            dsJckja1.Relations.Add(rel);
            dsJckja1.tyg.gwsColumn.Expression = "Parent(yg_gw).mc";
            dsJckja1.tyg.xlsColumn.Expression = "Parent(yg_xl).mc";
        }

        private void dgv_Click(object sender, EventArgs e)
        {

        }
        #region 4Button 
        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.NEW, bds, dsJckja1, tygTableAdapter1, dgv);
            f.ShowDialog();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.EDIT, bds, dsJckja1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.DETAIL, bds, dsJckja1, tygTableAdapter1, dgv);
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
                tygTableAdapter1.Update(dsJckja1.tyg);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }
        #endregion 
    

        private void True(object sender, EventArgs e)
        {

        }


    }
}