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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txtJhdh = new Gizmox.WebGUI.Forms.TextBox();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.txtGhsh = new Gizmox.WebGUI.Forms.TextBox();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label16 = new Gizmox.WebGUI.Forms.Label();
            this.label17 = new Gizmox.WebGUI.Forms.Label();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.txtLxr = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLxdh = new Gizmox.WebGUI.Forms.TextBox();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.grpMaster = new Gizmox.WebGUI.Forms.GroupBox();
            this.lblHj = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.pnlBottom = new Gizmox.WebGUI.Forms.Panel();
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
            this.mnuDgv = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNew = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEdit = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetail = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuFuncs = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.grpDetail = new Gizmox.WebGUI.Forms.GroupBox();
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.tjhmxTableAdapter1 = new JXC.Datasets.DSJxcTableAdapters.tjhmxTableAdapter();
            this.bdsMX = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new JXC.Datasets.DSJxcTableAdapters.TableAdapterManager();
            this.tjhdTableAdapter2 = new JXC.Datasets.DSJxcTableAdapters.tjhdTableAdapter();
            this.grpMaster.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "单号(*)";
            // 
            // txtJhdh
            // 
            this.txtJhdh.Location = new System.Drawing.Point(98, 53);
            this.txtJhdh.Name = "txtJhdh";
            this.txtJhdh.Size = new System.Drawing.Size(100, 20);
            this.txtJhdh.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.Location = new System.Drawing.Point(393, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Tag = "0";
            this.btnSave.Text = "保存";
            this.btnSave.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.Location = new System.Drawing.Point(489, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "关闭";
            this.btnClose.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtGhsh
            // 
            this.txtGhsh.Location = new System.Drawing.Point(98, 92);
            this.txtGhsh.Name = "txtGhsh";
            this.txtGhsh.Size = new System.Drawing.Size(100, 20);
            this.txtGhsh.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "供货商(*)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(231, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "联系电话";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(243, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "联系人";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(105, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // txtLxr
            // 
            this.txtLxr.Location = new System.Drawing.Point(302, 53);
            this.txtLxr.Name = "txtLxr";
            this.txtLxr.Size = new System.Drawing.Size(116, 20);
            this.txtLxr.TabIndex = 12;
            // 
            // txtLxdh
            // 
            this.txtLxdh.Location = new System.Drawing.Point(302, 92);
            this.txtLxdh.Name = "txtLxdh";
            this.txtLxdh.Size = new System.Drawing.Size(116, 20);
            this.txtLxdh.TabIndex = 13;
            // 
            // imgLst
            // 
            this.imgLst.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images1"))});
            this.imgLst.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLst.Images.SetKeyName(0, "Folders.Folders.Folder_yellow_open_16.ico");
            this.imgLst.Images.SetKeyName(1, "Folders.Folders.Folder_yellow_close_16.ico");
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.lblHj);
            this.grpMaster.Controls.Add(this.label3);
            this.grpMaster.Controls.Add(this.txtLxdh);
            this.grpMaster.Controls.Add(this.label1);
            this.grpMaster.Controls.Add(this.txtLxr);
            this.grpMaster.Controls.Add(this.label2);
            this.grpMaster.Controls.Add(this.lblId);
            this.grpMaster.Controls.Add(this.txtJhdh);
            this.grpMaster.Controls.Add(this.label17);
            this.grpMaster.Controls.Add(this.txtGhsh);
            this.grpMaster.Controls.Add(this.label16);
            this.grpMaster.Controls.Add(this.label9);
            this.grpMaster.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.grpMaster.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpMaster.Location = new System.Drawing.Point(10, 10);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(607, 147);
            this.grpMaster.TabIndex = 23;
            this.grpMaster.TabStop = false;
            this.grpMaster.Text = "进货单";
            // 
            // lblHj
            // 
            this.lblHj.AutoSize = true;
            this.lblHj.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHj.Location = new System.Drawing.Point(486, 60);
            this.lblHj.Name = "lblHj";
            this.lblHj.Size = new System.Drawing.Size(17, 13);
            this.lblHj.TabIndex = 0;
            this.lblHj.Text = "hj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "合计";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(10, 596);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(607, 74);
            this.pnlBottom.TabIndex = 24;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            dataGridViewCellStyle11.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            this.dgv.Location = new System.Drawing.Point(3, 73);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.SelectOnRightClick = true;
            this.dgv.Size = new System.Drawing.Size(601, 363);
            this.dgv.TabIndex = 0;
            this.dgv.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // colId
            // 
            this.colId.DefaultCellStyle = dataGridViewCellStyle12;
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colXh
            // 
            this.colXh.DefaultCellStyle = dataGridViewCellStyle13;
            this.colXh.HeaderText = "序号";
            this.colXh.Name = "colXh";
            this.colXh.ReadOnly = true;
            this.colXh.Width = 40;
            // 
            // colPm
            // 
            this.colPm.DefaultCellStyle = dataGridViewCellStyle14;
            this.colPm.HeaderText = "品名";
            this.colPm.Name = "colPm";
            this.colPm.ReadOnly = true;
            // 
            // colBm
            // 
            this.colBm.DefaultCellStyle = dataGridViewCellStyle15;
            this.colBm.HeaderText = "编码";
            this.colBm.Name = "colBm";
            this.colBm.ReadOnly = true;
            this.colBm.Width = 80;
            // 
            // colDw
            // 
            this.colDw.DefaultCellStyle = dataGridViewCellStyle16;
            this.colDw.HeaderText = "单位";
            this.colDw.Name = "colDw";
            this.colDw.ReadOnly = true;
            this.colDw.Width = 40;
            // 
            // colSl
            // 
            this.colSl.DefaultCellStyle = dataGridViewCellStyle17;
            this.colSl.HeaderText = "数量";
            this.colSl.Name = "colSl";
            this.colSl.ReadOnly = true;
            this.colSl.Width = 40;
            // 
            // colDj
            // 
            this.colDj.DefaultCellStyle = dataGridViewCellStyle18;
            this.colDj.HeaderText = "单价";
            this.colDj.Name = "colDj";
            this.colDj.ReadOnly = true;
            this.colDj.Width = 70;
            // 
            // colJhdId
            // 
            this.colJhdId.DefaultCellStyle = dataGridViewCellStyle19;
            this.colJhdId.HeaderText = "JhdId";
            this.colJhdId.Name = "colJhdId";
            this.colJhdId.ReadOnly = true;
            this.colJhdId.Width = 50;
            // 
            // colJe
            // 
            this.colJe.DefaultCellStyle = dataGridViewCellStyle20;
            this.colJe.HeaderText = "金额";
            this.colJe.Name = "colJe";
            this.colJe.ReadOnly = true;
            this.colJe.Width = 80;
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
            this.mnuDel,
            this.mnuFuncs});
            this.mnuDgv.Name = "mnuDgv";
            this.mnuDgv.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNew
            // 
            this.mnuNew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNew.Image"));
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNew.Size = new System.Drawing.Size(97, 20);
            this.mnuNew.Text = "新增";
            this.mnuNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuEdit.Image"));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuEdit.Size = new System.Drawing.Size(97, 20);
            this.mnuEdit.Text = "编辑";
            this.mnuEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // mnuDetail
            // 
            this.mnuDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDetail.Image"));
            this.mnuDetail.Name = "mnuDetail";
            this.mnuDetail.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDetail.Size = new System.Drawing.Size(97, 20);
            this.mnuDetail.Text = "详细";
            this.mnuDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(97, 20);
            this.mnuDel.Text = "删除";
            this.mnuDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // mnuFuncs
            // 
            this.mnuFuncs.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFuncs.Name = "mnuFuncs";
            this.mnuFuncs.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuFuncs.Size = new System.Drawing.Size(121, 20);
            this.mnuFuncs.Text = "功能模块";
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.dgv);
            this.grpDetail.Controls.Add(this.pnlTop);
            this.grpDetail.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpDetail.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetail.Location = new System.Drawing.Point(10, 157);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(607, 439);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "进货明细";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.btnDel);
            this.pnlTop.Controls.Add(this.btnDetail);
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 17);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(601, 56);
            this.pnlTop.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEdit.Image"));
            this.btnEdit.Location = new System.Drawing.Point(120, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "编辑";
            this.btnEdit.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDel.Image"));
            this.btnDel.Location = new System.Drawing.Point(312, 20);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDetail.Image"));
            this.btnDetail.Location = new System.Drawing.Point(222, 20);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "详细";
            this.btnDetail.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNew.Image"));
            this.btnNew.Location = new System.Drawing.Point(25, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Tag = "0";
            this.btnNew.Text = "新增";
            this.btnNew.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tjhmxTableAdapter1
            // 
            this.tjhmxTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tjhdTableAdapter = this.tjhdTableAdapter2;
            this.tableAdapterManager1.tjhmxTableAdapter = this.tjhmxTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = JXC.Datasets.DSJxcTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tjhdTableAdapter2
            // 
            this.tjhdTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmJhdXX
            // 
            this.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Wheat);
            this.CloseBox = false;
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.grpMaster);
            this.DockPadding.All = 10;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(10);
            this.Size = new System.Drawing.Size(627, 680);
            this.Text = "进货单详细信息";
            this.grpMaster.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsMX)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtJhdh;
        private Button btnSave;
        private Button btnClose;
        private TextBox txtGhsh;
        private Label label9;
        private Label label16;
        private Label label17;
        private Label lblId;
        private TextBox txtLxr;
        private TextBox txtLxdh;
        private ImageList imgLst;
        private GroupBox grpMaster;
        private Panel pnlBottom;
        private DataGridView dgv;
        private GroupBox grpDetail;
        private Panel pnlTop;
        private Button btnEdit;
        private Button btnDel;
        private Button btnDetail;
        private Button btnNew;
        private ContextMenuStrip mnuDgv;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDetail;
        private ToolStripMenuItem mnuDel;
        private ToolStripMenuItem mnuFuncs;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colXh;
        private DataGridViewTextBoxColumn colPm;
        private DataGridViewTextBoxColumn colBm;
        private DataGridViewTextBoxColumn colDw;
        private DataGridViewTextBoxColumn colSl;
        private DataGridViewTextBoxColumn colDj;
        private DataGridViewTextBoxColumn colJhdId;
        private Datasets.DSJxcTableAdapters.tjhmxTableAdapter tjhmxTableAdapter1;
        private BindingSource bdsMX;
        private Datasets.DSJxcTableAdapters.TableAdapterManager tableAdapterManager1;
        private Label lblHj;
        private Label label3;
        private DataGridViewTextBoxColumn colJe;
        private Datasets.DSJxcTableAdapters.tjhdTableAdapter tjhdTableAdapter2;
    }
}