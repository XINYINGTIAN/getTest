using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLTLib.Classes
{
    public class ClsD
    {
        #region 消除TextBox中首位的空格

        public static void TextBoxTrim(Control ctrl)
        //TextBoxTrim接受一个类型为Control的参数，实际传入的应该是窗体Form(或其子类)
        //UserControl(或其子类)、GroupBox以及Panel等容器类的对象。

        //TextBoxTrim能够将传入的容器对象及其所包括的各下级容器对象中所有的TextBox中的内容
        //全部进行去收尾空格操作
        {
            foreach (Control c in ctrl.Controls)
                //for each循环遍历ctrl的Controls对象集合
            {
                if (c is GroupBox)
                    TextBoxTrim(c);
                //若有GroupBox则进行递归
                else if (c is TextBox)
                {
                    //若有TextBox类的控件.则对Text施行Trim()操作
                    TextBox t = (TextBox)c;
                    t.Text = t.Text.Trim();
                }
            }
        }
        #endregion

        //public static void TextBoxTrim(GroupBox grpMain)
        //{
        //    throw new NotImplementedException();
        //}

        #region SetMaxLength设置最大长度
        public static void SetMaxLength(Control ctrl, DataTable tbl)
        {
            foreach(Control c in ctrl.Controls)
            {
                if (c is GroupBox)
                    SetMaxLength(c, tbl);
                else if(c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    if(t.Enabled && !t.ReadOnly)
                    if(t.DataBindings["Text"] != null)
                        {
                            string fld = t.DataBindings["text"].BindingMemberInfo.BindingField;
                            if (String.Compare(tbl.Columns[fld].DataType.ToString()
                                , "System.String", true) == 0)
                            {
                                t.MaxLength = tbl.Columns[fld].MaxLength;
                            }
                        }
                }
            }
        }
        #endregion

        #region TurnDgvToBdsCurrRecdgv在新增记录时如果页数大于1则可以跳转到新增的记录的所在页
        public static void TurnDgvToBdsCurrRec(DataGridView dgv)
        {
            BindingSource bds = (BindingSource)dgv.DataSource;
            if (bds.Position == -1)
                return;
            int page = (int)Math.Ceiling(bds.Position / (decimal)dgv.ItemsPerPage);
            dgv.CurrentPage = page;
            //将当前记录显示在可见的DataGridView区域内
            dgv.FirstDisplayedScrollingRowIndex = bds.Position;
        }
        #endregion

    }
}
