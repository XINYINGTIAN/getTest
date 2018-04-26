using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Configuration;

namespace DLTLib.Classes
{
    public class ClsQ
    {
        public static string Q1(string s)
        {
            return Q0(s, '\'');
        }
        public static string Q2(string s)
        {
            return Q0(s, '\"');
        }
        public static string Q0(string s, char quoter)
        {
            char[] quoters = { '"', '\'', '(', '[', '‘', '“' };
            if (!quoters.Contains(quoter))
                return s;
            else
                switch (quoter)
                {
                    case '"':
                        return '"' + s + '"';
                    case '\'':
                        return '\'' + s + '\'';
                    case '(':
                        return '(' + s + ')';
                    case '[':
                        return '[' + s + ']';
                    case '‘':
                        return '‘' + s + '’';
                    case '“':
                        return '“' + s + '”';
                    default:
                        return s;
                }

        }

        public static object Q1(object text)
        {
            throw new NotImplementedException();
        }
    }

    //public static class ClsDBCon
    //{
    //    static ClsDBCon()
    //    {
    //        ConStrKj = ConfigurationManager.ConnectionStrings["lsjckjConnectionString"].ConnectionString;
    //    }
        
    //    public static string ConStrKj { get; set; }
    //}

    //public static class ClsMsgBox

    //{
    //    public static void Ts(string mess)
    //    {
    //        MessageBox.Show(mess, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //    }
    //    public static void Jg(string mess)
    //    {
    //        MessageBox.Show(mess, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //    }
    //    public static void Cw(string mess)
    //    {
    //        MessageBox.Show(mess, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //    public static void YesNo(string mess,EventHandler hd1)
    //    {
    //        MessageBox.Show(mess, "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question, hd1);
    //    }
    //    public static void OKCancel(string mess, EventHandler hdl)
    //    {
    //        MessageBox.Show(mess, "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, hdl);
    //    }
    //    public static void Cw(string mess,Exception ex)
    //    {
    //        Cw(mess + "\n错误类型：" + ex.GetType() + "\n错误信息：\n" + ex.Message);
    //    }

    //    public static void Ts(object text)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

   // public class ClsMSSQL
   //{
   //     #region GetDataTable
   //     public static DataTable GetDataTable(string aSelectCmd, string aCntStr)
   //     {

   //         DataTable dt = new DataTable();
   //         using (SqlConnection conn = new SqlConnection(aCntStr))
   //             //确保在数据库连接对象conn用完后将数据库关闭。
   //             //其中的conn对象用连接串aCntStr建立。
   //         {
   //             conn.Open();//打开数据库
   //             SqlCommand cmd = new SqlCommand(aSelectCmd, conn);
   //             //将aSelectCmd中的SELECT语句建立为conn中的一个命令。
   //             SqlDataAdapter da = new SqlDataAdapter(cmd);
   //             //将cmd构造为一个可以进行数据读写操作的适配器(adapter)对象da
   //             try
   //             {
   //                 da.Fill(dt);
   //                 //将数据库中的数据填入到C#的数据表对象dt中
   //             }
   //             catch (Exception ex)
   //             //将发生的异常声明为一个Exception类的对象ex
   //             //ex的Message成员返回异常的描述信息。
   //            // MessageBox.Show(ex.Message); 将异常的描述信息显示在对话框中。 
   //             {
   //                 ClsMsgBox.Cw("GetDataTable遇到了错误", ex);
   //                 throw ex;
   //                 //重新引发异常，这是为了中断上层的调用程序，
   //                 //避免其使用不正确的GetDataTable返回结果运行后面的程序代码。
   //             }
   //             finally
   //             {
   //                 conn.Close();
   //             }
   //             return dt;
   //         }
   //     }
   //     #endregion
   //}
}
