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
using JXC.Datasets;
using JXC.Datasets.DSJxc1TableAdapters;
using DLTLib.Classes;

#endregion

namespace JXC
{
    public partial class FrmJhmxXX : Form
    {


        public FrmJhmxXX()
        {
            InitializeComponent();

        }

        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJxc1 dsJxc1;
        private tjhmxTableAdapter tjhmxTableAdapter1;
        private DataGridView dgv;
        #endregion


        public void Prepare(EnumNED aNED, BindingSource aBds, DSJxc1 aDSJxc1,
           tjhmxTableAdapter atjhmxTableAdapter1, int aJhdId = 0, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJxc1 = aDSJxc1;
            tjhmxTableAdapter1 = atjhmxTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJxc1.tjhmx);
            if (NED == EnumNED.NEW)
            {
                DSJxc1.tjhmxRow r = (DSJxc1.tjhmxRow)((DataRowView)bds.AddNew()).Row;
                r.jhdid = aJhdId;
            }
            else if (NED == EnumNED.DETAIL)
            {
                this.btnSave.Visible = false;
            }
        }

        #region binding
        private void binding()
        {
            this.lblJe.DataBindings.Clear();
            this.lblJe.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "je", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.lblId.DataBindings.Clear();
            this.lblId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "id", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtXh.DataBindings.Clear();
            this.txtXh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "xh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtPm.DataBindings.Clear();
            this.txtPm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "pm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtBm.DataBindings.Clear();
            this.txtBm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "bm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtDw.DataBindings.Clear();
            this.txtDw.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dw", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtDj.DataBindings.Clear();
            this.txtDj.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dj", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtSl.DataBindings.Clear();
            this.txtSl.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "sl", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }

        #endregion
        #region leave 事件
        private void txtDj_Leave(object sender, EventArgs e)
            //当光标离开空间时触发leave事件,事件中判断
        {
            if (ClsReg.RMB.IsMatch(txtDj.Text) && ClsReg.NaturalNum.IsMatch(txtSl.Text))
                bds.EndEdit();
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            #region 空值判断及数据验证
            ClsD.TextBoxTrim(this);
            if (!ClsReg.NaturalNum.IsMatch(txtXh.Text))
            {
                ClsMsgBox.Jg("序号必须为整数！");
                return;
            }
            if (string.IsNullOrEmpty(txtPm.Text))
            {
                ClsMsgBox.Jg("品名不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtBm.Text))
            {
                ClsMsgBox.Jg("编码不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtDw.Text))
            {
                ClsMsgBox.Jg("单位不可为空！");
                return;
            }
            if (!ClsReg.RMB.IsMatch(txtDj.Text))
            {
                ClsMsgBox.Jg("单价数据不正确！");
                return;
            }
            if (!ClsReg.NaturalNum.IsMatch(txtSl.Text))
            {
                ClsMsgBox.Jg("数量必须为整数！");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存进货明细时遇到了错误：", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJxc1.tjhmx.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }





        #region jgTree
        private void fillCmbJgTree(TreeView trV)
        {
            string cmd = @"SELECT id,mc,jb,
                         id0,mc0,id1,mc1,id2,mc2,
                         id3,mc3,id4,mc4,id5,mc5
                         FROM vjigoua
                         WHERE jb>0
                         ORDER BY xh0,xh1,xh2,xh3,xh4,xh5";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string idFld, mcFld;
            foreach (DataRow r in dt.Rows)
            {
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                for (int i = 1; i <= jb; i++)
                {
                    idFld = "id" + i;
                    tns = trV.Nodes.Find(r[idFld].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        mcFld = "mc" + i;
                        tn = new TreeNode(r[idFld].ToString() + ";" + r[mcFld].ToString());
                        tn.Name = r[idFld].ToString();
                        tn.ImageIndex = 0;
                        tn.ImageIndex = 0;
                        tn.SelectedImageIndex = 1;
                        if (tp == null)
                            trV.Nodes.Add(tn);
                        else tp.Nodes.Add(tn);
                        tp = tn;
                    }
                }
            }
        }
        #endregion




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJigou_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmJhmxXX_Load(object sender, EventArgs e)
        {

        }

        private void txtXh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}