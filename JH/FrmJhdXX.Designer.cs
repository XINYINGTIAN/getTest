using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace JXC.JH
{
    partial class FrmJhdXX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJhdXX));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.clientStorage1 = new Gizmox.WebGUI.Forms.Client.ClientStorage();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label17 = new Gizmox.WebGUI.Forms.Label();
            this.txtJhdh = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLxr = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLxdh = new Gizmox.WebGUI.Forms.TextBox();
            this.txtGhsh = new Gizmox.WebGUI.Forms.TextBox();
            this.pnlBottom = new Gizmox.WebGUI.Forms.Panel();
            this.mnuDgv = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNew = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEdit = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetail = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.grpMaster = new Gizmox.WebGUI.Forms.GroupBox();
            this.lblHj = new Gizmox.WebGUI.Forms.Label();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.colId = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colXh = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colPm = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colBm = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colDw = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colSl = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colDj = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colJhdId = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.colJe = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.grpDetail = new Gizmox.WebGUI.Forms.GroupBox();
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.tableAdapterManager1 = new JXC.Datasets.DSJxc1TableAdapters.TableAdapterManager();
            this.bdsMX = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.tjhmxTableAdapter1 = new JXC.Datasets.DSJxc1TableAdapters.tjhmxTableAdapter();
            this.tableAdapterManager2 = new JXC.Datasets.DSJxc1TableAdapters.TableAdapterManager();
            this.pnlBottom.SuspendLayout();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(124, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "供货商(*)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(198, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(352, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // clientStorage1
            // 
            this.clientStorage1.Description = "";
            this.clientStorage1.MajorVersion = ((ushort)(1));
            this.clientStorage1.MinorVersion = ((ushort)(0));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "单号(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "联系人";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "id";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(283, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "联系电话";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtJhdh
            // 
            this.txtJhdh.Location = new System.Drawing.Point(124, 63);
            this.txtJhdh.Name = "txtJhdh";
            this.txtJhdh.Size = new System.Drawing.Size(83, 20);
            this.txtJhdh.TabIndex = 1;
            // 
            // txtLxr
            // 
            this.txtLxr.Location = new System.Drawing.Point(352, 63);
            this.txtLxr.Name = "txtLxr";
            this.txtLxr.Size = new System.Drawing.Size(81, 20);
            this.txtLxr.TabIndex = 3;
            this.txtLxr.TextChanged += new System.EventHandler(this.txtLxr_TextChanged);
            // 
            // txtLxdh
            // 
            this.txtLxdh.Location = new System.Drawing.Point(352, 102);
            this.txtLxdh.Name = "txtLxdh";
            this.txtLxdh.Size = new System.Drawing.Size(117, 20);
            this.txtLxdh.TabIndex = 4;
            // 
            // txtGhsh
            // 
            this.txtGhsh.Location = new System.Drawing.Point(124, 102);
            this.txtGhsh.Name = "txtGhsh";
            this.txtGhsh.Size = new System.Drawing.Size(122, 20);
            this.txtGhsh.TabIndex = 5;
            // 
            // pnlBottom
            // 
            this.pnlBottom.ContextMenuStrip = this.mnuDgv;
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(10, 392);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(645, 100);
            this.pnlBottom.TabIndex = 6;
            // 
            // mnuDgv
            // 
            this.mnuDgv.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuDgv.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuDgv.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuDgv.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuDgv.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuEdit,
            this.mnuDetail,
            this.mnuDel});
            this.mnuDgv.Name = "mnuDgv";
            this.mnuDgv.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNew
            // 
            this.mnuNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNew.Image"));
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNew.Size = new System.Drawing.Size(99, 20);
            this.mnuNew.Text = "新增";
            this.mnuNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuEdit.Image"));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuEdit.Size = new System.Drawing.Size(99, 20);
            this.mnuEdit.Text = "编辑";
            // 
            // mnuDetail
            // 
            this.mnuDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDetail.Image"));
            this.mnuDetail.Name = "mnuDetail";
            this.mnuDetail.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDetail.Size = new System.Drawing.Size(99, 20);
            this.mnuDetail.Text = "详细";
            // 
            // mnuDel
            // 
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(99, 20);
            this.mnuDel.Text = "删除";
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.lblHj);
            this.grpMaster.Controls.Add(this.label1);
            this.grpMaster.Controls.Add(this.txtGhsh);
            this.grpMaster.Controls.Add(this.txtLxr);
            this.grpMaster.Controls.Add(this.lblId);
            this.grpMaster.Controls.Add(this.label9);
            this.grpMaster.Controls.Add(this.txtJhdh);
            this.grpMaster.Controls.Add(this.label4);
            this.grpMaster.Controls.Add(this.txtLxdh);
            this.grpMaster.Controls.Add(this.label2);
            this.grpMaster.Controls.Add(this.label17);
            this.grpMaster.Controls.Add(this.label5);
            this.grpMaster.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.grpMaster.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpMaster.Location = new System.Drawing.Point(10, 10);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(645, 150);
            this.grpMaster.TabIndex = 7;
            this.grpMaster.TabStop = false;
            this.grpMaster.Text = "进货单";
            // 
            // lblHj
            // 
            this.lblHj.AutoSize = true;
            this.lblHj.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHj.Location = new System.Drawing.Point(557, 66);
            this.lblHj.Name = "lblHj";
            this.lblHj.Size = new System.Drawing.Size(17, 13);
            this.lblHj.TabIndex = 0;
            this.lblHj.Text = "hj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "合计";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.colId,
            this.colXh,
            this.colPm,
            this.colBm,
            this.colDw,
            this.colSl,
            this.colDj,
            this.colJhdId,
            this.colJe});
            this.dgv.ContextMenuStrip = this.mnuDgv;
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.EditMode = Gizmox.WebGUI.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.IsSelectionChangeCritical = true;
            this.dgv.Location = new System.Drawing.Point(3, 65);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.SelectOnRightClick = true;
            this.dgv.Size = new System.Drawing.Size(639, 164);
            this.dgv.TabIndex = 1;
            this.dgv.ReadOnlyChanged += new System.EventHandler(this.True);
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            this.dgv.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // colId
            // 
            this.colId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colXh
            // 
            this.colXh.DefaultCellStyle = dataGridViewCellStyle2;
            this.colXh.HeaderText = "序号";
            this.colXh.Name = "colXh";
            this.colXh.ReadOnly = true;
            this.colXh.Width = 40;
            // 
            // colPm
            // 
            this.colPm.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPm.HeaderText = "品名";
            this.colPm.Name = "colPm";
            this.colPm.ReadOnly = true;
            // 
            // colBm
            // 
            this.colBm.DefaultCellStyle = dataGridViewCellStyle4;
            this.colBm.HeaderText = "编码";
            this.colBm.Name = "colBm";
            this.colBm.ReadOnly = true;
            this.colBm.Width = 80;
            // 
            // colDw
            // 
            this.colDw.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDw.HeaderText = "单位";
            this.colDw.Name = "colDw";
            this.colDw.ReadOnly = true;
            this.colDw.Width = 40;
            // 
            // colSl
            // 
            this.colSl.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSl.HeaderText = "数量";
            this.colSl.Name = "colSl";
            this.colSl.ReadOnly = true;
            this.colSl.Width = 40;
            // 
            // colDj
            // 
            this.colDj.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDj.HeaderText = "单价";
            this.colDj.Name = "colDj";
            this.colDj.ReadOnly = true;
            this.colDj.Width = 70;
            // 
            // colJhdId
            // 
            this.colJhdId.DefaultCellStyle = dataGridViewCellStyle8;
            this.colJhdId.HeaderText = "JhdId";
            this.colJhdId.Name = "colJhdId";
            this.colJhdId.ReadOnly = true;
            this.colJhdId.Width = 50;
            // 
            // colJe
            // 
            dataGridViewCellStyle9.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            this.colJe.DefaultCellStyle = dataGridViewCellStyle9;
            this.colJe.HeaderText = "金额";
            this.colJe.Name = "colJe";
            this.colJe.ReadOnly = true;
            this.colJe.Width = 80;
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.dgv);
            this.grpDetail.Controls.Add(this.pnlTop);
            this.grpDetail.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpDetail.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpDetail.Location = new System.Drawing.Point(10, 160);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(645, 232);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "进货明细";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Controls.Add(this.btnDel);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.btnDetail);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 17);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(639, 48);
            this.pnlTop.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNew.Image"));
            this.btnNew.Location = new System.Drawing.Point(186, 21);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "新增";
            this.btnNew.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDel.Image"));
            this.btnDel.Location = new System.Drawing.Point(498, 21);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEdit.Image"));
            this.btnEdit.Location = new System.Drawing.Point(291, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "编辑";
            this.btnEdit.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDetail.Image"));
            this.btnDetail.Location = new System.Drawing.Point(392, 21);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "详细";
            this.btnDetail.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tjhdTableAdapter = null;
            this.tableAdapterManager1.tjhmxTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = JXC.Datasets.DSJxc1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tjhmxTableAdapter1
            // 
            this.tjhmxTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.tjhdTableAdapter = null;
            this.tableAdapterManager2.tjhmxTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = JXC.Datasets.DSJxc1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmJhdXX
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.CloseBox = false;
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.grpMaster);
            this.Controls.Add(this.pnlBottom);
            this.DockPadding.All = 10;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(10);
            this.Size = new System.Drawing.Size(665, 502);
            this.Text = "进货单详细信息细信息";
            this.Load += new System.EventHandler(this.FrmJhdXX_Load);
            this.pnlBottom.ResumeLayout(false);
            this.grpMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMX)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Label lblId;
        private Label label2;
        private Button btnSave;
        private Button btnClose;
        private Gizmox.WebGUI.Forms.Client.ClientStorage clientStorage1;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label label17;
        private TextBox txtJhdh;
        private TextBox txtLxr;
        private TextBox txtLxdh;
        private TextBox txtGhsh;
        private Panel pnlBottom;
        private GroupBox grpMaster;
        private DataGridView dgv;
        private GroupBox grpDetail;
        private Panel pnlTop;
        private Button btnNew;
        private Button btnDel;
        private Button btnEdit;
        private Button btnDetail;
        private ContextMenuStrip mnuDgv;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDetail;
        private ToolStripMenuItem mnuDel;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colXh;
        private DataGridViewTextBoxColumn colPm;
        private DataGridViewTextBoxColumn colBm;
        private DataGridViewTextBoxColumn colDw;
        private DataGridViewTextBoxColumn colSl;
        private DataGridViewTextBoxColumn colDj;
        private DataGridViewTextBoxColumn colJhdId;
        private Datasets.DSJxc1TableAdapters.TableAdapterManager tableAdapterManager1;
        private BindingSource bdsMX;
        private Datasets.DSJxc1TableAdapters.tjhmxTableAdapter tjhmxTableAdapter1;
        private Label lblHj;
        private Label label1;
        private DataGridViewTextBoxColumn colJe;
        private Datasets.DSJxc1TableAdapters.TableAdapterManager tableAdapterManager2;
    }
}