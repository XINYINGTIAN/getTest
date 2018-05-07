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
using DLTLib.Classes;
using Gizmox.WebGUI.Forms.Authentication;
using DLTVWGPT.Datasets.DSJckjaTableAdapters;
using DLTVWGPT.Datasets;

#endregion

namespace DLTVWGPT.Login
{
    public partial class FrmLogin : LogonForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            readCookie();
        }

        private void readCookie()
        {
            //Context.Cookies与VWGContext.Current.Cookies是同一个东西
            string cookieAccount = Context.Cookies["Account"];
            string cookiePassword = Context.Cookies["Password"];
            //判断cookies的值是否有值
            if (cookieAccount != ""&& cookiePassword !="")
            {
                txtLoginName.Text = cookieAccount;
                txtPassword.Text = cookiePassword;
                chkAutoSave.Checked = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            #region 账户或账户口令为空判断
            txtLoginName.Text = txtLoginName.Text.Trim();
            //Trim可以去除字符串前后的空格
            if(string.IsNullOrEmpty(txtLoginName.Text))
                //string.IsNullOrEmpty函数可以判断一个字符串是否为空值
            {
                ClsMsgBox.Jg("账户不能为空");
                return;
            }
            txtPassword.Text = txtPassword.Text.Trim();
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
                ClsMsgBox.Jg("口令不能为空");
                return;

            }
            #endregion


            //获取用户信息
            vusersTableAdapter uta = new vusersTableAdapter();
            DSJckja.vusersDataTable u = uta.GetDataByLoginName(txtLoginName.Text);
            DSJckja.vusersRow userRow = u.Rows.Count == 0 ? null : (DSJckja.vusersRow)u.Rows[0];
        

           
            #region  账户、口令有效性判断
            if (userRow == null)
            {
                ClsMsgBox.Jg("账户不存在！");
                return;
            }
            //判断口令
            if (string.Compare(txtPassword.Text, userRow.password, false) != 0)
            {
                ClsMsgBox.Jg("口令不正确！");
                return;
            }
            //判断活动状态
            if (!userRow.active)
            {
                ClsMsgBox.Jg("此用户为非活动用户，不允许登录系统！");
                return;
            }
            #endregion
            #region 是否保存到cookie
            if (chkAutoSave.Checked)
            {
                Context.Cookies["Account"] = txtLoginName.Text;
                Context.Cookies["Password"] = txtPassword.Text;
            }
            else
            {
                Context.Cookies["Account"] = "";
                Context.Cookies["Password"] = "";
            }
            #endregion
            //将登录用户信息保存到Session
           VWGContext.Current.Session["userRow"] = userRow;
            this.Context.Session.IsLoggedOn = true;//允许打开实际的窗体

        }
    }
}