using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace JXC.JH
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
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.txtBm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.txtPm = new Gizmox.WebGUI.Forms.TextBox();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label16 = new Gizmox.WebGUI.Forms.Label();
            this.label17 = new Gizmox.WebGUI.Forms.Label();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.txtSl = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDw = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDj = new Gizmox.WebGUI.Forms.TextBox();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.lblJe = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "序号";
            // 
            // txtBm
            // 
            this.txtBm.Location = new System.Drawing.Point(97, 129);
            this.txtBm.Name = "txtBm";
            this.txtBm.Size = new System.Drawing.Size(122, 20);
            this.txtBm.TabIndex = 4;
            // 
            // txtXh
            // 
            this.txtXh.Location = new System.Drawing.Point(96, 56);
            this.txtXh.Name = "txtXh";
            this.txtXh.Size = new System.Drawing.Size(123, 20);
            this.txtXh.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.Location = new System.Drawing.Point(265, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "保存";
            this.btnSave.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.Location = new System.Drawing.Point(358, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "关闭";
            this.btnClose.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPm
            // 
            this.txtPm.Location = new System.Drawing.Point(97, 89);
            this.txtPm.Name = "txtPm";
            this.txtPm.Size = new System.Drawing.Size(123, 20);
            this.txtPm.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "编码(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "品名(*)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "数量(*)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(262, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "单价(*)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(262, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "单位(*)";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(93, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(312, 133);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(134, 20);
            this.txtSl.TabIndex = 14;
            this.txtSl.Leave += new System.EventHandler(this.txtDj_Leave);
            // 
            // txtDw
            // 
            this.txtDw.Location = new System.Drawing.Point(312, 51);
            this.txtDw.Name = "txtDw";
            this.txtDw.Size = new System.Drawing.Size(134, 20);
            this.txtDw.TabIndex = 12;
            // 
            // txtDj
            // 
            this.txtDj.Location = new System.Drawing.Point(312, 92);
            this.txtDj.Name = "txtDj";
            this.txtDj.Size = new System.Drawing.Size(134, 20);
            this.txtDj.TabIndex = 13;
            this.txtDj.Leave += new System.EventHandler(this.txtDj_Leave);
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
            // lblJe
            // 
            this.lblJe.AutoSize = true;
            this.lblJe.ForeColor = System.Drawing.Color.DarkRed;
            this.lblJe.Location = new System.Drawing.Point(309, 168);
            this.lblJe.Name = "lblJe";
            this.lblJe.Size = new System.Drawing.Size(35, 13);
            this.lblJe.TabIndex = 0;
            this.lblJe.Text = "je";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "金额";
            // 
            // FrmJhmxXX
            // 
            this.AcceptButton = this.btnSave;
            this.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Wheat);
            this.CancelButton = this.btnClose;
            this.CloseBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblJe);
            this.Controls.Add(this.txtDj);
            this.Controls.Add(this.txtDw);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtXh);
            this.Controls.Add(this.txtBm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(464, 265);
            this.Text = "进货明细详细信息";
            this.ResumeLayout(false);

        }


        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBm;
        private TextBox txtXh;
        private Button btnSave;
        private Button btnClose;
        private TextBox txtPm;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label16;
        private Label label17;
        private Label lblId;
        private TextBox txtSl;
        private TextBox txtDw;
        private TextBox txtDj;
        private ImageList imgLst;
        private Label lblJe;
        private Label label4;
    }
}