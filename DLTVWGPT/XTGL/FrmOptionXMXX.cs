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
using DLTVWGPT.Datasets;
using DLTVWGPT.Datasets.DSJckjaTableAdapters;
using DLTLib.Classes;

#endregion

namespace DLTVWGPT.XTGL
{
    public partial class FrmOptionXMXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJckja dsJckja1;
        private toptionxmTableAdapter toptionxmTableAdapter1;
        private DataGridView dgv;
        #endregion


        public void Prepare(EnumNED aNED, BindingSource aBds, DSJckja aDSJckja,
            toptionxmTableAdapter atoptionxmTableAdapter1, DataGridView aDgv = null, string aLbdm = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJckja1 = aDSJckja;
            toptionxmTableAdapter1 = atoptionxmTableAdapter1;
            dgv = aDgv;

            ClsD.SetMaxLength(this, dsJckja1.toptionxm);
            if (NED == EnumNED.NEW)
            {
                DSJckja.toptionxmRow r = (DSJckja.toptionxmRow)((DataRowView)bds.AddNew()).Row;
                r.lbdm = aLbdm;

            }
            else if (NED == EnumNED.DETAIL)
            {
                this.btnSave.Visible = false;
            }

        }

        private void binding()
        {
            this.txtDm.DataBindings.Clear();
            this.txtDm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtMc.DataBindings.Clear();
            this.txtMc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true,
                DataSourceUpdateMode.OnPropertyChanged));

        }


        public FrmOptionXMXX()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            #region 空值判断
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtDm.Text))
            {
                ClsMsgBox.Jg("代码不可为空！");
                return;
            }
            if (!ClsReg.AlphaNumeric.IsMatch(txtDm.Text))
            {
                ClsMsgBox.Jg("代码包含非字母数字字符！");
                return;
            }
            if (string.IsNullOrEmpty(txtMc.Text))
            {
                ClsMsgBox.Jg("名称不可为空！");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                toptionxmTableAdapter1.Update(dsJckja1.toptionxm);
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);

                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存选项类别时遇到了错误：", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJckja1.toptionxm.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}