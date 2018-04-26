#region Using

using System;
using System.Data;
using Gizmox.WebGUI.Forms;
using DLTLib.Classes;
using JXC.Datasets.DSJxcTableAdapters;
using JXC.Datasets;

#endregion

namespace JXC.JH
{
    public partial class FrmJhmxXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DataGridView dgv;
        private DSJxc dsJxc1;
        private tjhmxTableAdapter tjhmxTableAdapter1;
        #endregion
        public FrmJhmxXX()
        {
            InitializeComponent();
        }

        #region Prepare()
        public void Prepare(EnumNED aNED, BindingSource aBds, DSJxc aDSJxc,
             tjhmxTableAdapter atjhmxTableAdapter1, int aJhdId = 0, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJxc1 = aDSJxc;
            tjhmxTableAdapter1 = atjhmxTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsJxc1.tjhmx);
            if (NED == EnumNED.NEW)
            {
                DSJxc.tjhmxRow r = (DSJxc.tjhmxRow)((DataRowView)bds.AddNew()).Row;
                r.jhdid = aJhdId;
            }
            else if (NED == EnumNED.DETAIL)
            {
                this.btnSave.Visible = false;
            }
        }
        #endregion

        #region binding()控件绑定函数
        private void binding()
        {
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
            this.lblJe.DataBindings.Clear();
            this.lblJe.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "je", true,
                DataSourceUpdateMode.OnValidation));
        }
        #endregion

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
        private void txtDj_Leave(object sender, EventArgs e)
        {
            if (ClsReg.RMB.IsMatch(txtDj.Text) && ClsReg.NaturalNum.IsMatch(txtSl.Text))
                bds.EndEdit();
        }
    }
}