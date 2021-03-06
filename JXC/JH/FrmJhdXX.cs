#region Using

using System;
using System.Collections.Generic;
using System.Data;
using Gizmox.WebGUI.Forms;
using DLTLib.Classes;
using JXC.Datasets;
using JXC.Datasets.DSJxcTableAdapters;

#endregion

namespace JXC.JH
{
    public partial class FrmJhdXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJxc dsJxc1;
        private tjhdTableAdapter tjhdTableAdapter1;
        private DataGridView dgvMaster;
        private bool _sk;
        #endregion
        public FrmJhdXX()
        {
            InitializeComponent();
        }

        #region Prepare()
        public void Prepare(EnumNED aNED, BindingSource aBds, DSJxc aDSJxc,
             tjhdTableAdapter atjhdTableAdapter1, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJxc1 = aDSJxc;
            tjhdTableAdapter1 = atjhdTableAdapter1;
            dgvMaster = aDgv;
            initMx();
            bindDgv();
            ClsD.SetMaxLength(this, dsJxc1.tjhd);
            if (NED == EnumNED.NEW)
                bds.AddNew();
            else if (NED == EnumNED.DETAIL)
            {
                this.btnSave.Visible = false;
            }
        }
        #endregion

        #region initMX()填充bdsMX

        private void initMx()
        {
            bdsMX.DataSource = bds;
            bdsMX.DataMember = "FK_tjhmx_tjhd";
            tableAdapterManager1.tjhdTableAdapter = new tjhdTableAdapter();
            tableAdapterManager1.tjhmxTableAdapter = new tjhmxTableAdapter();
            if (NED != EnumNED.NEW)
            {
                tjhmxTableAdapter1.FillByJhdid(dsJxc1.tjhmx, Int32.Parse(lblId.Text));
            }
        }
        #endregion

        #region bindDgv()实现dgv各列数据的字段绑定。
        private void bindDgv()
        {
            dgv.DataSource = bdsMX;
            colId.DataPropertyName = "id";
            colXh.DataPropertyName = "xh";
            colPm.DataPropertyName = "pm";
            colBm.DataPropertyName = "bm";
            colDw.DataPropertyName = "dw";
            colSl.DataPropertyName = "sl";
            colDj.DataPropertyName = "dj";
            colJhdId.DataPropertyName = "jhdid";
            colJe.DataPropertyName = "je";
        }
        #endregion

        #region binding()
        private void binding()
        {
            this.lblId.DataBindings.Clear();
            this.lblId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "id", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtJhdh.DataBindings.Clear();
            this.txtJhdh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jhdh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtGhsh.DataBindings.Clear();
            this.txtGhsh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "ghsh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtLxr.DataBindings.Clear();
            this.txtLxr.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "lxr", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtLxdh.DataBindings.Clear();
            this.txtLxdh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "lxdh", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.lblHj.DataBindings.Clear();
            this.lblHj.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "hj", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断及数据验证
            if (string.IsNullOrEmpty(txtJhdh.Text))
            {
                ClsMsgBox.Jg("进货单号不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtGhsh.Text))
            {
                ClsMsgBox.Jg("供货商不可为空！");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                tableAdapterManager1.UpdateAll(dsJxc1);
                DataTable dt = dsJxc1.Tables["vjhdhj"];
                DataRow[] r = dt.Select(string.Format("jhdid = {0}", lblId.Text));
                //判断明细表是否为空
                if (r.Length > 0)
                    r[0]["hj"] = string.IsNullOrEmpty(lblHj.Text) ? "0" : lblHj.Text;
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgvMaster);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存进货单时遇到了错误：", ex);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsJxc1.tjhd.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }

        #region 右键菜单   
        private void btnNew_Click(object sender, EventArgs e)
        {
            _sk = true;
            bds.EndEdit();
            FrmJhmxXX f = new FrmJhmxXX();
            f.Prepare(EnumNED.NEW, bdsMX, dsJxc1, tjhmxTableAdapter1, Convert.ToInt32(lblId.Text), dgv);
            f.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bdsMX.Current == null)
                return;
            FrmJhmxXX f = new FrmJhmxXX();
            f.Prepare(EnumNED.EDIT, bdsMX, dsJxc1, tjhmxTableAdapter1, Convert.ToInt32(lblId.Text), dgv);
            f.ShowDialog();
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bdsMX.Current == null)
                return;
            FrmJhmxXX f = new FrmJhmxXX();
            f.Prepare(EnumNED.DETAIL, bdsMX, dsJxc1, tjhmxTableAdapter1, Convert.ToInt32(lblId.Text), dgv);
            f.ShowDialog();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bdsMX.Current == null)
                return;
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        #region deleting() 删除时的回调函数
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bdsMX.RemoveCurrent();
                tjhdTableAdapter1.Update(dsJxc1.tjhd);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }
        #endregion
        #endregion
    }
}