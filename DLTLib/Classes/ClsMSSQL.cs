using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLTLib.Classes
{
    public static class ClsMSSQL
    {
        #region GetDataTable
 
        public static DataTable GetDataTable(string aSelectCmd, string aCntStr)
        //函数功能以连接串aCntStr打开数据库，返回aSelectCmd中SELECT语句的输出内容为C#中的DataTable

        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(aCntStr))
            //语句的功能是确保在数据库连接对象conn用完后将数据库关闭
            //其中的conn对象用连接串aCntStr建立。
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(aSelectCmd, conn);
                //将aSelectCmd中的SELECT语句建立为conn中的一个命令
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //将cmd构造为一个可以进行数据读写操作的适配器(adapter)对象da
                try
                {
                    da.Fill(dt);
                    //将数据库中的数据填入到C#的数据表对象dt中
                }
                catch (Exception ex)
                //ex的Message成员返回异常的描述信息
                {
                    ClsMsgBox.Cw("GetDataTable遇到了错误。", ex);
                    throw ex;
                    //中断上层的调用程序，避免其使用不正确的GetDataTable返回结果运行后面的程序代码
                }
                finally
                //finally不管try中的语句执行是否正确都会执行
                {
                    conn.Close();
                }
            }
            return dt;
        }

        #endregion


        #region Exists
        /// <summary>
        /// <para>判断表中是否存在给定字段取给定值的记录,即：</para>
        /// <para>SELECT * FROM t WHERE f=v</para>
        /// <para>是否返回记录。</para>
        /// </summary>
        /// <param name="aTable"></param>
        /// <param name="aQueryField"></param>
        /// <param name="aQueryValue"></param>
        /// <param name="acntStr"></param>
        /// <returns></returns>
        public static bool Exists(string aTable, string aQueryField, string aQueryValue, string acntStr)
        {
            string cmdText = string.Format("SELECT * FROM {0} WHERE {1}='{2}'",
                aTable, aQueryField, aQueryValue);
            return Exists(cmdText, acntStr);
        }



        /// <summary>
        /// <para>根据一个SELECT语句判断数据表中是否存在记录.</para>
        /// <para>cmdText参数的形式应该形如：SELECT * FROM t1 WHERE id=5.</para>
        /// <para>函数通过将它转换为如下形式而达致功能实现：</para>
        /// <para>SELECT CASE WHEN EXISTS(SELECT * FROM t1 WHERE id=5) THEN 1 ELSE 0 END.</para>
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="acntStr"></param>
        /// <returns></returns>
        public static bool Exists(string cmdText, string acntStr)
        {
            bool b = false;
            using (SqlConnection conn = new SqlConnection(acntStr))
            {
                conn.Open();
                string cmdTextA = "EXISTS" + ClsQ.Q0(cmdText, '(');
                cmdTextA = "SELECT CASE WHEN " + cmdTextA + " THEN 1 ELSE 0 END";
                SqlCommand cmd = new SqlCommand(cmdTextA, conn);
                try
                {
                    b = Convert.ToBoolean(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    ClsMsgBox.Cw("Exists遇到了错误。", ex);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return b;
        }
        #endregion


        #region ExecuteCmd：执行SQL语句或存储过程，返回影响的行数
        public static int ExecuteCmd(string aSQLCmd, string aConStr,
            ArrayList arrLstParams = null,bool isStProc = false)
        {
            int rows = 0;
            using (SqlConnection conn = new SqlConnection(aConStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(aSQLCmd, conn);
                if (arrLstParams != null) //如果是null不能AddRange
                {
                    cmd.Parameters.AddRange(arrLstParams.ToArray(typeof(SqlParameter)));
                }
                if (isStProc)
                    cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    rows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ClsMsgBox.Cw("ExecuteCmd遇到了错误：", ex);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return rows;
        }
            
        #endregion



      

        #region GET VALUE

        /// <summary>
        /// <para>执行SQL语句或存储过程，返回结果集第一行第一列的值。</para>
        /// <para>可以使用ArrayList arrLstParams传入参数，参数可以是输入型也可以是输出型，</para>
        /// <para>调用者可使用arrLstParams的实参检查输出型参数的返回值。</para>
        /// <para>如果是存储过程，则需要设置isStProc为true。</para>
        /// </summary>
        /// <param name="aSQLCmd"></param>
        /// <param name="aConStr"></param>
        /// <param name="arrLstParams"></param>
        /// <param name="isStProc"></param>
        public static Object GetValue(string aSQLCmd, string aConStr,
            ArrayList arrLstParams = null, bool isStProc = false)
        //函数接受aSQLCmd参数,它可以是一个SELECT SQL语句,也可以是一个储存过程的名字,如果是储存过程,则isStProc的值必须为true
        //函数使用了默认形式参数(默认参数)机制，即可以用两个或三个参数调用函数
        //调用时没有提供实在参数值的参数取值为定义函数时说明的默认参数值
        {
            Object ret = null;
            using (SqlConnection conn = new SqlConnection(aConStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(aSQLCmd, conn);
                if (arrLstParams != null)
                //如果是null不能AddRange
                {
                    //cmd.Parameters.AddRange向SqlParameterCollection的末尾添加值数组，
                    //arrLstParams.ToArray将arraylist的元素复制到一个指定元素类型的新数组
                    cmd.Parameters.AddRange(arrLstParams.ToArray(typeof(SqlParameter)));
                }
                if (isStProc)
                    //如果为储存过程,则isStProc的值必须为true
                    cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    ret = cmd.ExecuteScalar();
                    //执行aSQLCmd中的命令,并返回结果集第一行第一列的值
                }
                catch (Exception ex)
                {
                    ClsMsgBox.Cw("GetValue遇到了错误。", ex);
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return ret;
        }
        #endregion

        #region GET VALUE
        public static Object GetValue(string aOutField, string aTable, string aWhere, string aConStr)
        {
            string cmdText = string.Format("SELECT {0} FROM {1} WHERE {2}",
                aOutField, aTable, aWhere);
            return GetValue(cmdText, aConStr);
        }

        public static Object GetValue(string aOutField, string aTable, string aQueryField, string aQueryValue, string aConStr)
        {
            string aWhere = string.Format("{0}='{1}'", aQueryField, aQueryValue);
            return
                GetValue(aOutField, aTable, aWhere, aConStr);
        }
        #endregion

        #region GetStr
        public static string GetStr(string aSQLCmd,string aConStr, ArrayList arrLstParams = null, bool isStProc = false)
        {
            object o = GetValue(aSQLCmd, aConStr, arrLstParams, isStProc);
            return
                Convert.ToString(o);
        }
        public static string GetStr(string aOutField,string aTable, string aWhere, string aConStr)
        {
            object o = GetValue(aOutField, aTable, aWhere, aConStr);
            return
            Convert.ToString(o);
        }
        public static string GetStr(string aOutField,string aTable,string aQueryField, string aQueryValue, string aConStr)
        {
            object o = GetValue(aOutField, aTable, aQueryField, aQueryValue, aConStr);
            return
                Convert.ToString(o);
        }
        #endregion

        #region GetInt
        public static int GetInt(string aOutField,string aTable,string aQueryField,string aQueryValue,string aConStr)
        {
            object o = GetStr(aOutField, aTable, aQueryField, aQueryValue, aConStr);
            return
                Convert.ToInt32(o);
        }

        #endregion


        #region setValue
        public static void SetValue(string tbn, string keyFldn, string keyFldv, string valueFldn, object valueFldv, string acntStr)
        {
            ExecuteCmd(string.Format("update {0} set {1}='{2}' where {3}='{4}'",
                tbn, valueFldn, valueFldv.ToString(), keyFldn, keyFldv), acntStr);
        }

        #endregion

        #region tconfig表的读写操作
        public static string GetConfigStr(string aItemDm, string aConStr)
        {
            return GetStr("nr", "tconfig", "dm", aItemDm, aConStr);
        }
        public static int GetConfigInt(string aItemDm, string aConStr)
        {
            return Convert.ToInt32(GetConfigStr(aItemDm, aConStr));
        }
        public static void SetConfigItem(string aItemDm, object aItemValue, string aConStr)
        {
            SetValue("tconfig", "dm", aItemDm, "nr", aItemValue.ToString(), aConStr);
        }

        #endregion
    }


}

