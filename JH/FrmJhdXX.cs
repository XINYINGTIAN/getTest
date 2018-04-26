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

namespace JXC.JH
{
    public partial class FrmJhdXX : Form
    {


        public FrmJhdXX()
        {
            InitializeComponent();

        }

        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSJxc1 dsJxc1;
        private tjhdTableAdapter tjhdTableAdapter1;
        private DataGridView dgvMaster;
        #endregion

        #region prepare
        public void Prepare(EnumNED aNED, BindingSource aBds, DSJxc1 aDSJxc,
            tjhdTableAdapter atjhdTableAdapter1, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsJxc1 = aDSJxc;
            dgvMaster = aDgv;
            initMX();
            bindDgv();
            //initMX和bindDgv函数的调用应在dsJxc1赋值之后


            ClsD.SetMaxLength(this, dsJxc1.tjhd);
            if (NED == EnumNED.NEW)
            {
                bds.AddNew();
            }
            else if (NED == EnumNED.DETAIL)
            {
                this.btnSave.Visible = false;
            }
        }
        #endregion

        #region binding
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

        #region initMX
        private void initMX()
        {
            bdsMX.DataSource = bds;
            //实现从表bdsMX与主表bds的关联
            bdsMX.DataMember = "FK_tjhmx_tjhd";
            tableAdapterManager1.tjhdTableAdapter = new tjhdTableAdapter();
            tableAdapterManager1.tjhmxTableAdapter = new tjhmxTableAdapter();
            //为tableAdapterManager1的tjhdTableAdapter和tjhmx属性创建相应的对象
            if(NED!=EnumNED.NEW)
                //即值为EnumNED.DETAIL和EDIT时,调用tjhmxTableAdapter1的
                //FillByJhdId方法从数据库中读取当前进货单对应的明细值填入到tjhmx表中
            {
                tjhmxTableAdapter1.FillByJhdId(dsJxc1.tjhmx, Int32.Parse(lblId.Text));
            }
        }
        #endregion


        #region bindDgv
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
            if (string.IsNullOrEmpty(txtJhdh.Text))
            {
                ClsMsgBox.Jg("进货单号不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtGhsh.Text))
            {
                ClsMsgBox.Jg("供应商不可为空！");
                return;
            }
            


            #endregion
            try
            {
                bds.EndEdit();
                tableAdapterManager1.UpdateAll(dsJxc1);
                //tableAdapterManager1.UpdateAll(dsJxc1)最终实现主表明细表数据的一次保存操作
                DataTable dt = dsJxc1.Tables["vjhdhj"];
                //获取为dsJxc1添加的名字为vjhdhj的表
                DataRow[] r = dt.Select(string.Format("jhdid={0}", lblId.Text));
                //获取与当前编辑的jhd对应的vjhdhj表中的记录
                if (r.Length > 0)
                     r[0]["hj"] = string.IsNullOrEmpty(lblHj.Text) ? "0" : lblHj.Text;
                //同步合计字段(hj)的值
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

        private void txtLxr_TextChanged(object sender, EventArgs e)
        {

        }

        private void True(object sender, EventArgs e)
        {

        }

        private void dgv_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bdsMX.Current == null)
                return;
            FrmJhmxXX f = new FrmJhmxXX();
            f.Prepare(EnumNED.EDIT, bdsMX, dsJxc1, tjhmxTableAdapter1);
            f.ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bds.EndEdit();
            //调用bds.EndEdit()可以避免保存新增进货单的明细记录
            FrmJhmxXX f = new FrmJhmxXX();
            f.Prepare(EnumNED.NEW, bdsMX, dsJxc1, tjhmxTableAdapter1, Convert.ToInt32(lblId.Text), dgv);
            //向FrmJhmxXX的Prepare传递当前进货单的id数值Convert.ToInt32(lblId.Text)
            f.ShowDialog();

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (bdsMX.Current == null)
                return;
            FrmJhmxXX f = new FrmJhmxXX();
            f.Prepare(EnumNED.DETAIL, bdsMX, dsJxc1, tjhmxTableAdapter1);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bdsMX.Current == null)
                return;
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }

        #region deleting 
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                bdsMX.RemoveCurrent();
                tjhmxTableAdapter1.Update(dsJxc1.tjhmx);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }
        #endregion




        private void FrmJhdXX_Load(object sender, EventArgs e)
        {

        }
    }
}