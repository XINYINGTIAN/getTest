using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace DLTVWGPT.XTGL
{
    partial class FrmYuanGongXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYuanGongXX));
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.clientStorage1 = new Gizmox.WebGUI.Forms.Client.ClientStorage();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label12 = new Gizmox.WebGUI.Forms.Label();
            this.label13 = new Gizmox.WebGUI.Forms.Label();
            this.label14 = new Gizmox.WebGUI.Forms.Label();
            this.label15 = new Gizmox.WebGUI.Forms.Label();
            this.label16 = new Gizmox.WebGUI.Forms.Label();
            this.label17 = new Gizmox.WebGUI.Forms.Label();
            this.label18 = new Gizmox.WebGUI.Forms.Label();
            this.label19 = new Gizmox.WebGUI.Forms.Label();
            this.label20 = new Gizmox.WebGUI.Forms.Label();
            this.label21 = new Gizmox.WebGUI.Forms.Label();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.txtXm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLoginName = new Gizmox.WebGUI.Forms.TextBox();
            this.txtPassword = new Gizmox.WebGUI.Forms.TextBox();
            this.txtOTel = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMTel = new Gizmox.WebGUI.Forms.TextBox();
            this.txtFax = new Gizmox.WebGUI.Forms.TextBox();
            this.txtEmail = new Gizmox.WebGUI.Forms.TextBox();
            this.txtQQ = new Gizmox.WebGUI.Forms.TextBox();
            this.txtWx = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbJigou = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbXb = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbRole = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbGw = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbXl = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbZt = new Gizmox.WebGUI.Forms.ComboBox();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.dtpRzrq = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.dtpLzrq = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.btnPassword = new Gizmox.WebGUI.Forms.Button();
            this.cmbJgTree = new DLTLib.Controls.TreeViewComboBox.TreeViewComboBox();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(125, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "机构(*)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(353, 309);
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
            this.btnClose.Location = new System.Drawing.Point(478, 309);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
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
            this.label4.Location = new System.Drawing.Point(75, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "序号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "姓名(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "角色";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "性别";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "id";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "微信";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "QQ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "入职日期";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "离职日期";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(297, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Email";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(303, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Fax";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(75, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "岗位";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "账户(*)";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(297, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "状态";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(75, 283);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "学历";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(297, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "手机";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(297, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "市话";
            // 
            // txtXh
            // 
            this.txtXh.Enabled = false;
            this.txtXh.Location = new System.Drawing.Point(128, 56);
            this.txtXh.Name = "txtXh";
            this.txtXh.Size = new System.Drawing.Size(100, 20);
            this.txtXh.TabIndex = 1;
            this.txtXh.Text = "12";
            // 
            // txtXm
            // 
            this.txtXm.Location = new System.Drawing.Point(128, 108);
            this.txtXm.Name = "txtXm";
            this.txtXm.Size = new System.Drawing.Size(100, 20);
            this.txtXm.TabIndex = 3;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(128, 134);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(100, 20);
            this.txtLoginName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtOTel
            // 
            this.txtOTel.Location = new System.Drawing.Point(353, 54);
            this.txtOTel.Name = "txtOTel";
            this.txtOTel.Size = new System.Drawing.Size(100, 20);
            this.txtOTel.TabIndex = 11;
            // 
            // txtMTel
            // 
            this.txtMTel.Location = new System.Drawing.Point(353, 81);
            this.txtMTel.Name = "txtMTel";
            this.txtMTel.Size = new System.Drawing.Size(100, 20);
            this.txtMTel.TabIndex = 12;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(353, 108);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(353, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtQQ
            // 
            this.txtQQ.Location = new System.Drawing.Point(353, 162);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(100, 20);
            this.txtQQ.TabIndex = 15;
            // 
            // txtWx
            // 
            this.txtWx.Location = new System.Drawing.Point(353, 190);
            this.txtWx.Name = "txtWx";
            this.txtWx.Size = new System.Drawing.Size(100, 20);
            this.txtWx.TabIndex = 16;
            // 
            // cmbJigou
            // 
            this.cmbJigou.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbJigou.FormattingEnabled = true;
            this.cmbJigou.Location = new System.Drawing.Point(166, 9);
            this.cmbJigou.Name = "cmbJigou";
            this.cmbJigou.Size = new System.Drawing.Size(121, 21);
            this.cmbJigou.TabIndex = 2;
            this.cmbJigou.SelectedIndexChanged += new System.EventHandler(this.cmbJigou_SelectedIndexChanged);
            // 
            // cmbXb
            // 
            this.cmbXb.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbXb.FormattingEnabled = true;
            this.cmbXb.Location = new System.Drawing.Point(128, 190);
            this.cmbXb.Name = "cmbXb";
            this.cmbXb.Size = new System.Drawing.Size(121, 21);
            this.cmbXb.TabIndex = 6;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(128, 217);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 21);
            this.cmbRole.TabIndex = 7;
            // 
            // cmbGw
            // 
            this.cmbGw.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbGw.FormattingEnabled = true;
            this.cmbGw.Location = new System.Drawing.Point(128, 249);
            this.cmbGw.Name = "cmbGw";
            this.cmbGw.Size = new System.Drawing.Size(121, 21);
            this.cmbGw.TabIndex = 8;
            // 
            // cmbXl
            // 
            this.cmbXl.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbXl.FormattingEnabled = true;
            this.cmbXl.Location = new System.Drawing.Point(128, 279);
            this.cmbXl.Name = "cmbXl";
            this.cmbXl.Size = new System.Drawing.Size(121, 21);
            this.cmbXl.TabIndex = 9;
            // 
            // cmbZt
            // 
            this.cmbZt.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbZt.FormattingEnabled = true;
            this.cmbZt.Location = new System.Drawing.Point(353, 26);
            this.cmbZt.Name = "cmbZt";
            this.cmbZt.Size = new System.Drawing.Size(121, 21);
            this.cmbZt.TabIndex = 10;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(128, 313);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(50, 17);
            this.chkActive.TabIndex = 19;
            this.chkActive.Text = "活动";
            // 
            // dtpRzrq
            // 
            this.dtpRzrq.CustomFormat = "";
            this.dtpRzrq.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtpRzrq.Location = new System.Drawing.Point(353, 217);
            this.dtpRzrq.Name = "dtpRzrq";
            this.dtpRzrq.Size = new System.Drawing.Size(200, 21);
            this.dtpRzrq.TabIndex = 17;
            // 
            // dtpLzrq
            // 
            this.dtpLzrq.CustomFormat = "";
            this.dtpLzrq.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtpLzrq.Location = new System.Drawing.Point(353, 252);
            this.dtpLzrq.Name = "dtpLzrq";
            this.dtpLzrq.Size = new System.Drawing.Size(200, 21);
            this.dtpLzrq.TabIndex = 18;
            // 
            // btnPassword
            // 
            this.btnPassword.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnPassword.Image"));
            this.btnPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassword.Location = new System.Drawing.Point(27, 157);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(79, 23);
            this.btnPassword.TabIndex = 4;
            this.btnPassword.Text = "口令(*)";
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // cmbJgTree
            // 
            this.cmbJgTree.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbJgTree.FormattingEnabled = true;
            this.cmbJgTree.ImageList = this.imgLst;
            this.cmbJgTree.IsNonLeafNodeSelectable = true;
            this.cmbJgTree.Location = new System.Drawing.Point(128, 81);
            this.cmbJgTree.Name = "cmbJgTree";
            this.cmbJgTree.Size = new System.Drawing.Size(121, 21);
            this.cmbJgTree.TabIndex = 20;
            this.cmbJgTree.TreeHeight = 200;
            this.cmbJgTree.TreeWidth = 120;
            // 
            // imgLst
            // 
            this.imgLst.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images1"))});
            this.imgLst.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLst.Images.SetKeyName(0, "Folder_yellow_close_16.ico");
            this.imgLst.Images.SetKeyName(1, "Folder_yellow_open_16.ico");
            // 
            // FrmYuanGongXX
            // 
            this.AcceptButton = this.btnSave;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.btnClose;
            this.CloseBox = false;
            this.Controls.Add(this.cmbJgTree);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.dtpLzrq);
            this.Controls.Add(this.dtpRzrq);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.cmbZt);
            this.Controls.Add(this.cmbXl);
            this.Controls.Add(this.cmbGw);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbXb);
            this.Controls.Add(this.cmbJigou);
            this.Controls.Add(this.txtWx);
            this.Controls.Add(this.txtQQ);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtMTel);
            this.Controls.Add(this.txtOTel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.txtXm);
            this.Controls.Add(this.txtXh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(599, 466);
            this.Text = "员工详细信息细信息";
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
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox txtXh;
        private TextBox txtXm;
        private TextBox txtLoginName;
        private TextBox txtPassword;
        private TextBox txtOTel;
        private TextBox txtMTel;
        private TextBox txtFax;
        private TextBox txtEmail;
        private TextBox txtQQ;
        private TextBox txtWx;
        private ComboBox cmbJigou;
        private ComboBox cmbXb;
        private ComboBox cmbRole;
        private ComboBox cmbGw;
        private ComboBox cmbXl;
        private ComboBox cmbZt;
        private CheckBox chkActive;
        private DateTimePicker dtpRzrq;
        private DateTimePicker dtpLzrq;
        private Button btnPassword;
        private DLTLib.Controls.TreeViewComboBox.TreeViewComboBox cmbJgTree;
        private ImageList imgLst;
    }
}