using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace DLTVWGPT.XTGL
{
    partial class FrmOptionLBLB
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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptionLBLB));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.grpDgv = new Gizmox.WebGUI.Forms.GroupBox();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.mnuDgv = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNew = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEdit = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetail = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dsJckja1 = new DLTVWGPT.Datasets.DSJckja();
            this.toptionlbTableAdapter1 = new DLTVWGPT.Datasets.DSJckjaTableAdapters.toptionlbTableAdapter();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.pnlLB = new Gizmox.WebGUI.Forms.Panel();
            this.grpXM = new Gizmox.WebGUI.Forms.GroupBox();
            this.dgvXM = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.bdsXM = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.toptionxmTableAdapter1 = new DLTVWGPT.Datasets.DSJckjaTableAdapters.toptionxmTableAdapter();
            this.pnlXM = new Gizmox.WebGUI.Forms.Panel();
            this.btnDetailXM = new Gizmox.WebGUI.Forms.Button();
            this.btnEditXM = new Gizmox.WebGUI.Forms.Button();
            this.btnNewXM = new Gizmox.WebGUI.Forms.Button();
            this.btnDelXM = new Gizmox.WebGUI.Forms.Button();
            this.mnuXM = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNewXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEditXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetailXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDelXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.grpDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJckja1)).BeginInit();
            this.pnlLB.SuspendLayout();
            this.grpXM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXM)).BeginInit();
            this.pnlXM.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDgv
            // 
            this.grpDgv.Controls.Add(this.dgv);
            this.grpDgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpDgv.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpDgv.Location = new System.Drawing.Point(10, 10);
            this.grpDgv.Name = "grpDgv";
            this.grpDgv.Size = new System.Drawing.Size(200, 446);
            this.grpDgv.TabIndex = 0;
            this.grpDgv.TabStop = false;
            this.grpDgv.Text = "选项类别列表”";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv.ContextMenuStrip = this.mnuDgv;
            this.dgv.DataSource = this.bds;
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.EditMode = Gizmox.WebGUI.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.IsSelectionChangeCritical = true;
            this.dgv.Location = new System.Drawing.Point(3, 17);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.SelectOnRightClick = true;
            this.dgv.Size = new System.Drawing.Size(194, 426);
            this.dgv.TabIndex = 1;
            this.dgv.ReadOnlyChanged += new System.EventHandler(this.True);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            this.dgv.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dm";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // bds
            // 
            this.bds.DataMember = "toptionlb";
            this.bds.DataSource = this.dsJckja1;
            // 
            // dsJckja1
            // 
            this.dsJckja1.DataSetName = "DSJckja";
            this.dsJckja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toptionlbTableAdapter1
            // 
            this.toptionlbTableAdapter1.ClearBeforeFill = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNew.Image"));
            this.btnNew.Location = new System.Drawing.Point(13, 179);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "新增";
            this.btnNew.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEdit.Image"));
            this.btnEdit.Location = new System.Drawing.Point(13, 223);
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
            this.btnDetail.Location = new System.Drawing.Point(13, 266);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "详细";
            this.btnDetail.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDel.Image"));
            this.btnDel.Location = new System.Drawing.Point(13, 308);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pnlLB
            // 
            this.pnlLB.Controls.Add(this.btnDel);
            this.pnlLB.Controls.Add(this.btnNew);
            this.pnlLB.Controls.Add(this.btnEdit);
            this.pnlLB.Controls.Add(this.btnDetail);
            this.pnlLB.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlLB.Location = new System.Drawing.Point(210, 10);
            this.pnlLB.Name = "pnlLB";
            this.pnlLB.Size = new System.Drawing.Size(132, 446);
            this.pnlLB.TabIndex = 6;
            this.pnlLB.Click += new System.EventHandler(this.pnlLB_Click);
            // 
            // grpXM
            // 
            this.grpXM.Controls.Add(this.dgvXM);
            this.grpXM.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpXM.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpXM.Location = new System.Drawing.Point(342, 10);
            this.grpXM.Name = "grpXM";
            this.grpXM.Size = new System.Drawing.Size(200, 446);
            this.grpXM.TabIndex = 7;
            this.grpXM.TabStop = false;
            this.grpXM.Text = "选项项目列表";
            // 
            // dgvXM
            // 
            this.dgvXM.AllowUserToAddRows = false;
            this.dgvXM.AllowUserToDeleteRows = false;
            this.dgvXM.AutoGenerateColumns = false;
            this.dgvXM.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvXM.ContextMenuStrip = this.mnuDgv;
            this.dgvXM.DataSource = this.bdsXM;
            this.dgvXM.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgvXM.EditMode = Gizmox.WebGUI.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvXM.Location = new System.Drawing.Point(3, 17);
            this.dgvXM.MultiSelect = false;
            this.dgvXM.Name = "dgvXM";
            this.dgvXM.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXM.SelectOnRightClick = true;
            this.dgvXM.Size = new System.Drawing.Size(194, 426);
            this.dgvXM.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.CanGroupBy = false;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dm";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn3.HeaderText = "代码";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.HeaderText = "名称";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // bdsXM
            // 
            this.bdsXM.DataMember = "toptionxm";
            this.bdsXM.DataSource = this.dsJckja1;
            // 
            // toptionxmTableAdapter1
            // 
            this.toptionxmTableAdapter1.ClearBeforeFill = true;
            // 
            // pnlXM
            // 
            this.pnlXM.Controls.Add(this.btnDetailXM);
            this.pnlXM.Controls.Add(this.btnEditXM);
            this.pnlXM.Controls.Add(this.btnNewXM);
            this.pnlXM.Controls.Add(this.btnDelXM);
            this.pnlXM.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlXM.Location = new System.Drawing.Point(542, 10);
            this.pnlXM.Name = "pnlXM";
            this.pnlXM.Size = new System.Drawing.Size(132, 446);
            this.pnlXM.TabIndex = 8;
            // 
            // btnDetailXM
            // 
            this.btnDetailXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDetailXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDetailXM.Image"));
            this.btnDetailXM.Location = new System.Drawing.Point(29, 266);
            this.btnDetailXM.Name = "btnDetailXM";
            this.btnDetailXM.Size = new System.Drawing.Size(75, 23);
            this.btnDetailXM.TabIndex = 4;
            this.btnDetailXM.Text = "详细";
            this.btnDetailXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetailXM.Click += new System.EventHandler(this.btnDetailXM_Click);
            // 
            // btnEditXM
            // 
            this.btnEditXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnEditXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEditXM.Image"));
            this.btnEditXM.Location = new System.Drawing.Point(29, 223);
            this.btnEditXM.Name = "btnEditXM";
            this.btnEditXM.Size = new System.Drawing.Size(75, 23);
            this.btnEditXM.TabIndex = 3;
            this.btnEditXM.Text = "编辑";
            this.btnEditXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditXM.Click += new System.EventHandler(this.btnEditXM_Click);
            // 
            // btnNewXM
            // 
            this.btnNewXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnNewXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNewXM.Image"));
            this.btnNewXM.Location = new System.Drawing.Point(29, 179);
            this.btnNewXM.Name = "btnNewXM";
            this.btnNewXM.Size = new System.Drawing.Size(75, 23);
            this.btnNewXM.TabIndex = 2;
            this.btnNewXM.Text = "新增";
            this.btnNewXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewXM.Click += new System.EventHandler(this.btnNewXM_Click);
            // 
            // btnDelXM
            // 
            this.btnDelXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDelXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDelXM.Image"));
            this.btnDelXM.Location = new System.Drawing.Point(29, 308);
            this.btnDelXM.Name = "btnDelXM";
            this.btnDelXM.Size = new System.Drawing.Size(75, 23);
            this.btnDelXM.TabIndex = 5;
            this.btnDelXM.Text = "删除";
            this.btnDelXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelXM.Click += new System.EventHandler(this.btnDelXM_Click);
            // 
            // mnuXM
            // 
            this.mnuXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuXM.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuXM.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuXM.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuXM.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNewXM,
            this.mnuEditXM,
            this.mnuDetailXM,
            this.mnuDelXM});
            this.mnuXM.Name = "mnuXM";
            this.mnuXM.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNewXM
            // 
            this.mnuNewXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewXM.Image"));
            this.mnuNewXM.Name = "mnuNewXM";
            this.mnuNewXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewXM.Size = new System.Drawing.Size(99, 20);
            this.mnuNewXM.Text = "新增";
            this.mnuNewXM.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // mnuEditXM
            // 
            this.mnuEditXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuEditXM.Image"));
            this.mnuEditXM.Name = "mnuEditXM";
            this.mnuEditXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuEditXM.Size = new System.Drawing.Size(99, 20);
            this.mnuEditXM.Text = "编辑";
            // 
            // mnuDetailXM
            // 
            this.mnuDetailXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDetailXM.Image"));
            this.mnuDetailXM.Name = "mnuDetailXM";
            this.mnuDetailXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDetailXM.Size = new System.Drawing.Size(99, 20);
            this.mnuDetailXM.Text = "详细";
            // 
            // mnuDelXM
            // 
            this.mnuDelXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDelXM.Image"));
            this.mnuDelXM.Name = "mnuDelXM";
            this.mnuDelXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDelXM.Size = new System.Drawing.Size(99, 20);
            this.mnuDelXM.Text = "删除";
            // 
            // FrmOptionLBLB
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.pnlXM);
            this.Controls.Add(this.grpXM);
            this.Controls.Add(this.pnlLB);
            this.Controls.Add(this.grpDgv);
            this.DockPadding.All = 10;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(10);
            this.Size = new System.Drawing.Size(698, 466);
            this.Text = "选项类别列表";
            this.Load += new System.EventHandler(this.FrmOptionLBLB_Load);
            this.grpDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJckja1)).EndInit();
            this.pnlLB.ResumeLayout(false);
            this.grpXM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXM)).EndInit();
            this.pnlXM.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private GroupBox grpDgv;
        private DataGridView dgv;
        private BindingSource bds;
        private Datasets.DSJckja dsJckja1;
        private Datasets.DSJckjaTableAdapters.toptionlbTableAdapter toptionlbTableAdapter1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDetail;
        private Button btnDel;
        private ContextMenuStrip mnuDgv;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDetail;
        private ToolStripMenuItem mnuDel;
        private Panel pnlLB;
        private GroupBox grpXM;
        private DataGridView dgvXM;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BindingSource bdsXM;
        private Datasets.DSJckjaTableAdapters.toptionxmTableAdapter toptionxmTableAdapter1;
        private Panel pnlXM;
        private Button btnDetailXM;
        private Button btnEditXM;
        private Button btnNewXM;
        private Button btnDelXM;
        private ContextMenuStrip mnuXM;
        private ToolStripMenuItem mnuNewXM;
        private ToolStripMenuItem mnuEditXM;
        private ToolStripMenuItem mnuDetailXM;
        private ToolStripMenuItem mnuDelXM;
    }
}