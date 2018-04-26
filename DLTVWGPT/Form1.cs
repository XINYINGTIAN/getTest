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

#endregion

namespace DLTVWGPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 例子
            //FrmMain f = new FrmMain();
            // f.prepare("111");    //FrmMain就是一个类，如果要用到里面的方法必须先new一下，在不用static的前提下
            FrmMain.prepare("");//在方法写着static可以直接提取
            #endregion
        }

    }
}