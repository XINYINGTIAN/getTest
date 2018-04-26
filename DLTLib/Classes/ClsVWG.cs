using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DLTLib.Classes
{
    public class ClsVWG
    {
        //string bbURL = "GRBB/YgBBb.aspx?where =" +sWhere + "&xms="+ xms;
        //bbURL=
        //    ClsVWG.ExpandURL(bbURL);
        //    Link.Open(bbURL,paras);
        public static string ExpandURL(string sURL)
        {
           return System.IO.Path.Combine(HttpContext.Current.Request.ApplicationPath, sURL);
        }
    }
}
