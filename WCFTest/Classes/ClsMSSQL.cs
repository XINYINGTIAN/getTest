using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFTest.Classes
{
    public static class ClsMSSQL
    {
        #region GetDataTable
 
        public static DataTable GetDataTable(string aSelectCmd, string aCntStr)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(aCntStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(aSelectCmd, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                try
                {
                }
                catch (Exception ex)
                {
                }
                finally
                {
                }
            }
            return dt;
        }

        //public static bool Exists(string v1, string v2, object text, string conStrKj)
        //{
        //    throw new NotImplementedException();
        //}

        //public static bool Exists(string cmd, string conStrKj)
        //{
        //    throw new NotImplementedException();
        //}

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
                    rows = -1;
                }
                finally
                {
                    conn.Close();
                }
            }
            return rows;
        }
            
        #endregion



        #region Exists
        public static bool Exists(string aTable, string aQueryField, string aQueryValue, string acntStr)
        {
            string cmdText = string.Format("SELECT * FROM {0} WHERE {1}='{2}'",
                aTable, aQueryField, aQueryValue);
            return Exists(cmdText, acntStr);
        }
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

                }
                catch (Exception ex)
                {
                }
                finally
                {
                }
            }
            return b;
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
                }
                catch (Exception ex)
                {
                }
                finally
                {
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
        public static int SetValue(string tbn, string keyFldn, string keyFldv, string valueFldn, object valueFldv, string acntStr)
        {
            return ExecuteCmd(string.Format("update {0} set {1}='{2}' where {3} = '{4}'",
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
        public static int SetConfigItem(string aItemDm, object aItemValue, string aConStr)
        {
            return SetValue("tconfig", "dm", aItemDm, "nr", aItemValue.ToString(), aConStr);
        }

        #endregion
    }


}

