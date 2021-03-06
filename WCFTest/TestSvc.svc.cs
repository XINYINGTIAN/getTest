﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFTest.Classes;

namespace WCFTest
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“TestSvc”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 TestSvc.svc 或 TestSvc.svc.cs，然后开始调试。
    public class TestSvc : ITestSvc
    {
        public string GetData(int value)
        {
            //接受一个整形数
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        #region get string from Web.config
        public string GetAppSettings(string aKey)
        {
            return ConfigurationManager.AppSettings.Get(aKey);
        }
        #endregion

        #region WriteConfig的function
        public int WriteConfig(string aDm, string aNr)
        {
            return ClsMSSQL.SetConfigItem(aDm, aNr, ClsDBCon.ConStrKj);
        }


        #endregion
    }
}
