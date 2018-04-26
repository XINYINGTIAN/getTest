using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace DLTVWGPT.XTGL
{
    partial class FrmJGGL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJGGL));
            this.grpLeft = new Gizmox.WebGUI.Forms.GroupBox();
            this.trV = new Gizmox.WebGUI.Forms.TreeView();
            this.grpMain = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dsJckja1 = new DLTVWGPT.Datasets.DSJckja();
            this.txtJb = new Gizmox.WebGUI.Forms.TextBox();
            this.txtJc = new Gizmox.WebGUI.Forms.TextBox();
            this.txtFzrId = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCity = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMc = new Gizmox.WebGUI.Forms.TextBox();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.tjigouTableAdapter1 = new DLTVWGPT.Datasets.DSJckjaTableAdapters.tjigouTableAdapter();
            this.mnuTrV = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNewBrother = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuNewChild = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.cmbBmlx = new Gizmox.WebGUI.Forms.ComboBox();
            this.txtProvince = new Gizmox.WebGUI.Forms.TextBox();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.txtDz = new Gizmox.WebGUI.Forms.TextBox();
            this.txtYb = new Gizmox.WebGUI.Forms.TextBox();
            this.txtWzbz = new Gizmox.WebGUI.Forms.TextBox();
            this.grpLeft.SuspendLayout();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJckja1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.trV);
            this.grpLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpLeft.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpLeft.Location = new System.Drawing.Point(10, 10);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(200, 612);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "机构树";
            this.grpLeft.Click += new System.EventHandler(this.grpLeft_Click);
            // 
            // trV
            // 
            this.trV.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.trV.Location = new System.Drawing.Point(3, 17);
            this.trV.Name = "trV";
            this.trV.Size = new System.Drawing.Size(194, 592);
            this.trV.TabIndex = 0;
            this.trV.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.trV_AfterSelect);
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.txtWzbz);
            this.grpMain.Controls.Add(this.txtYb);
            this.grpMain.Controls.Add(this.txtDz);
            this.grpMain.Controls.Add(this.label11);
            this.grpMain.Controls.Add(this.label10);
            this.grpMain.Controls.Add(this.label9);
            this.grpMain.Controls.Add(this.label8);
            this.grpMain.Controls.Add(this.label7);
            this.grpMain.Controls.Add(this.txtProvince);
            this.grpMain.Controls.Add(this.cmbBmlx);
            this.grpMain.Controls.Add(this.btnCancel);
            this.grpMain.Controls.Add(this.btnSave);
            this.grpMain.Controls.Add(this.chkActive);
            this.grpMain.Controls.Add(this.txtJb);
            this.grpMain.Controls.Add(this.txtJc);
            this.grpMain.Controls.Add(this.txtFzrId);
            this.grpMain.Controls.Add(this.txtCity);
            this.grpMain.Controls.Add(this.txtMc);
            this.grpMain.Controls.Add(this.lblId);
            this.grpMain.Controls.Add(this.label6);
            this.grpMain.Controls.Add(this.label5);
            this.grpMain.Controls.Add(this.label4);
            this.grpMain.Controls.Add(this.label3);
            this.grpMain.Controls.Add(this.label2);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpMain.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpMain.Location = new System.Drawing.Point(210, 10);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(466, 612);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "机构信息";
            this.grpMain.Click += new System.EventHandler(this.groupBox2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnCancel.Image"));
            this.btnCancel.Location = new System.Drawing.Point(174, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.Location = new System.Drawing.Point(33, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "active", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.chkActive.Location = new System.Drawing.Point(116, 232);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(50, 17);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "活动";
            // 
            // bds
            // 
            this.bds.DataMember = "tjigou";
            this.bds.DataSource = this.dsJckja1;
            // 
            // dsJckja1
            // 
            this.dsJckja1.DataSetName = "DSJckja";
            this.dsJckja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtJb
            // 
            this.txtJb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jb", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtJb.Enabled = false;
            this.txtJb.Location = new System.Drawing.Point(99, 189);
            this.txtJb.Name = "txtJb";
            this.txtJb.Size = new System.Drawing.Size(100, 20);
            this.txtJb.TabIndex = 5;
            // 
            // txtJc
            // 
            this.txtJc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jc", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtJc.Location = new System.Drawing.Point(99, 108);
            this.txtJc.Name = "txtJc";
            this.txtJc.Size = new System.Drawing.Size(100, 20);
            this.txtJc.TabIndex = 2;
            this.txtJc.TextChanged += new System.EventHandler(this.txtJb_TextChanged);
            // 
            // txtFzrId
            // 
            this.txtFzrId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "fzrid", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtFzrId.Location = new System.Drawing.Point(99, 136);
            this.txtFzrId.Name = "txtFzrId";
            this.txtFzrId.Size = new System.Drawing.Size(100, 20);
            this.txtFzrId.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "city", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtCity.Location = new System.Drawing.Point(315, 108);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 7;
            this.txtCity.TextChanged += new System.EventHandler(this.txtMc_TextChanged);
            // 
            // txtMc
            // 
            this.txtMc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtMc.Location = new System.Drawing.Point(99, 82);
            this.txtMc.Name = "txtMc";
            this.txtMc.Size = new System.Drawing.Size(100, 20);
            this.txtMc.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "id", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(113, 57);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "lblId";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "级别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "部门类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "编码负责人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "简称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称(*)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imgLst
            // 
            this.imgLst.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images1"))});
            this.imgLst.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLst.Images.SetKeyName(0, "Folder_yellow_open_16.ico");
            this.imgLst.Images.SetKeyName(1, "Folder_yellow_close_16.ico");
            // 
            // tjigouTableAdapter1
            // 
            this.tjigouTableAdapter1.ClearBeforeFill = true;
            // 
            // mnuTrV
            // 
            this.mnuTrV.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuTrV.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuTrV.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuTrV.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuTrV.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNewBrother,
            this.mnuNewChild,
            this.mnuDel});
            this.mnuTrV.Name = "mnuTrV";
            this.mnuTrV.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNewBrother
            // 
            this.mnuNewBrother.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewBrother.Image"));
            this.mnuNewBrother.Name = "mnuNewBrother";
            this.mnuNewBrother.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewBrother.Size = new System.Drawing.Size(147, 20);
            this.mnuNewBrother.Text = "新增同级机构";
            this.mnuNewBrother.Click += new System.EventHandler(this.mnuNewBrother_Click);
            // 
            // mnuNewChild
            // 
            this.mnuNewChild.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewChild.Image"));
            this.mnuNewChild.Name = "mnuNewChild";
            this.mnuNewChild.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewChild.Size = new System.Drawing.Size(147, 20);
            this.mnuNewChild.Text = "新增下级机构";
            this.mnuNewChild.Click += new System.EventHandler(this.mnuNewChild_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(147, 20);
            this.mnuDel.Text = "删除当前机构";
            this.mnuDel.Click += new System.EventHandler(this.mnuDel_Click);
            // 
            // cmbBmlx
            // 
            this.cmbBmlx.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "bmlx", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.cmbBmlx.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("SelectedValue", this.bds, "bmlx", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.cmbBmlx.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbBmlx.FormattingEnabled = true;
            this.cmbBmlx.Location = new System.Drawing.Point(99, 163);
            this.cmbBmlx.Name = "cmbBmlx";
            this.cmbBmlx.Size = new System.Drawing.Size(121, 21);
            this.cmbBmlx.TabIndex = 4;
            this.cmbBmlx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtProvince
            // 
            this.txtProvince.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "province", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtProvince.Location = new System.Drawing.Point(315, 83);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 6;
            this.txtProvince.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "位置标志";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "邮编";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "地址";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "城市";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "省份";
            // 
            // txtDz
            // 
            this.txtDz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dz", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtDz.Location = new System.Drawing.Point(315, 136);
            this.txtDz.Name = "txtDz";
            this.txtDz.Size = new System.Drawing.Size(100, 20);
            this.txtDz.TabIndex = 8;
            this.txtDz.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtYb
            // 
            this.txtYb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "yb", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtYb.Location = new System.Drawing.Point(315, 163);
            this.txtYb.Name = "txtYb";
            this.txtYb.Size = new System.Drawing.Size(100, 20);
            this.txtYb.TabIndex = 9;
            this.txtYb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtWzbz
            // 
            this.txtWzbz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "wzbz", true, Gizmox.WebGUI.Forms.DataSourceUpdateMode.OnValidation));
            this.txtWzbz.Location = new System.Drawing.Point(315, 190);
            this.txtWzbz.Name = "txtWzbz";
            this.txtWzbz.Size = new System.Drawing.Size(100, 20);
            this.txtWzbz.TabIndex = 10;
            this.txtWzbz.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FrmJGGL
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpLeft);
            this.DockPadding.All = 10;
            this.Padding = new Gizmox.WebGUI.Forms.Padding(10);
            this.Size = new System.Drawing.Size(686, 632);
            this.Text = "机构管理";
            this.grpLeft.ResumeLayout(false);
            this.grpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJckja1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private GroupBox grpLeft;
        private GroupBox grpMain;
        private TreeView trV;
        private ImageList imgLst;
        private TextBox txtJc;
        private TextBox txtFzrId;
        private TextBox txtCity;
        private TextBox txtMc;
        private Label lblId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Datasets.DSJckja dsJckja1;
        private Datasets.DSJckjaTableAdapters.tjigouTableAdapter tjigouTableAdapter1;
        private BindingSource bds;
        private CheckBox chkActive;
        private TextBox txtJb;
        private Button btnCancel;
        private Button btnSave;
        private ContextMenuStrip mnuTrV;
        private ToolStripMenuItem mnuNewBrother;
        private ToolStripMenuItem mnuNewChild;
        private ToolStripMenuItem mnuDel;
        private ComboBox cmbBmlx;
        private TextBox txtWzbz;
        private TextBox txtYb;
        private TextBox txtDz;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtProvince;
    }
}