using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLTLib.Classes
{
    public static class ClsMsgBox
    {
        public static void Ts(string mess)
        {
            MessageBox.Show(mess, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Jg(string mess)
        {
            MessageBox.Show(mess, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Cw(string mess)
        {
            MessageBox.Show(mess, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void YesNo(string mess, EventHandler hdl)
        {
            MessageBox.Show(mess, "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, hdl);
        }

        public static void OKCancel(string mess, EventHandler hdl)
        {
            MessageBox.Show(mess, "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, hdl);
        }

        public static void Cw(string mess, Exception ex)
        {
            Cw(mess + "\n错误类型：" + ex.GetType() + "\n错误信息：\n" + ex.Message);
        }
    }

}
