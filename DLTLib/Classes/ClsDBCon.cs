using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLTLib.Classes
{
    public static class ClsDBCon
    {
        static ClsDBCon()
        {
            ConStrKj = ConfigurationManager.ConnectionStrings["dltjckjaConnectionString"].ConnectionString;
            ConStrJxc = ConfigurationManager.ConnectionStrings["jxcConnectionString"].ConnectionString;
        }

        public static string ConStrKj { get; set; }
        public static string ConStrJxc { get; set; }
    }
}
