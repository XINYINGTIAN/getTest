using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace JXC
{
    partial class FrmJhmxXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJhmxXX));
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
            this.label17 = new Gizmox.WebGUI.Forms.Label();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.txtPm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtBm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDw = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDj = new Gizmox.WebGUI.Forms.TextBox();
            this.txtSl = new Gizmox.WebGUI.Forms.TextBox();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.lblJe = new Gizmox.WebGUI.Forms.Label();
            this.label9.SuspendLayout();
            this.label8.SuspendLayout();
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
            this.label2.Text = "品名(*)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(219, 189);
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
            this.btnClose.Location = new System.Drawing.Point(409, 189);
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
            this.label4.Location = new System.Drawing.Point(61, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "序号(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "编码(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "数量(*)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "单价(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Controls.Add(this.label1);
            this.label9.Location = new System.Drawing.Point(91, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "id";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(327, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "单位(*)";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtXh
            // 
            this.txtXh.Location = new System.Drawing.Point(128, 56);
            this.txtXh.Name = "txtXh";
            this.txtXh.Size = new System.Drawing.Size(100, 20);
            this.txtXh.TabIndex = 1;
            this.txtXh.TextChanged += new System.EventHandler(this.txtXh_TextChanged);
            // 
            // txtPm
            // 
            this.txtPm.Location = new System.Drawing.Point(128, 84);
            this.txtPm.Name = "txtPm";
            this.txtPm.Size = new System.Drawing.Size(100, 20);
            this.txtPm.TabIndex = 3;
            // 
            // txtBm
            // 
            this.txtBm.Location = new System.Drawing.Point(128, 111);
            this.txtBm.Name = "txtBm";
            this.txtBm.Size = new System.Drawing.Size(100, 20);
            this.txtBm.TabIndex = 4;
            // 
            // txtDw
            // 
            this.txtDw.Location = new System.Drawing.Point(394, 58);
            this.txtDw.Name = "txtDw";
            this.txtDw.Size = new System.Drawing.Size(100, 20);
            this.txtDw.TabIndex = 5;
            // 
            // txtDj
            // 
            this.txtDj.Location = new System.Drawing.Point(394, 84);
            this.txtDj.Name = "txtDj";
            this.txtDj.Size = new System.Drawing.Size(100, 20);
            this.txtDj.TabIndex = 11;
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(394, 112);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(100, 20);
            this.txtSl.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 34);
            this.label1.Name = "label9";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "id";
            this.label3.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Controls.Add(this.label3);
            this.label8.Location = new System.Drawing.Point(341, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "金额";
            // 
            // lblJe
            // 
            this.lblJe.AutoSize = true;
            this.lblJe.ForeColor = System.Drawing.Color.DarkRed;
            this.lblJe.Location = new System.Drawing.Point(391, 158);
            this.lblJe.Name = "lblJe";
            this.lblJe.Size = new System.Drawing.Size(35, 13);
            this.lblJe.TabIndex = 0;
            this.lblJe.Text = "je";
            // 
            // FrmJhmxXX
            // 
            this.AcceptButton = this.btnSave;
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.btnClose;
            this.CloseBox = false;
            this.Controls.Add(this.lblJe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.txtDj);
            this.Controls.Add(this.txtDw);
            this.Controls.Add(this.txtBm);
            this.Controls.Add(this.txtPm);
            this.Controls.Add(this.txtXh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
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
            this.Text = "进货明细详细信息细信息";
            this.Load += new System.EventHandler(this.FrmJhmxXX_Load);
            this.label9.ResumeLayout(false);
            this.label8.ResumeLayout(false);
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
        private Label label17;
        private TextBox txtXh;
        private TextBox txtPm;
        private TextBox txtBm;
        private TextBox txtDw;
        private TextBox txtDj;
        private TextBox txtSl;
        private ImageList imgLst;
        private Label label1;
        private Label label3;
        private Label label8;
        private Label lblJe;
    }
}