using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFTest
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ITestSvc”。
    [ServiceContract]
    public interface ITestSvc
    {
        //服务契约以接口interface ITestSvc方式实现
        //包括两个方法:GetData/GetDataUsingDataContract
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: 在此添加您的服务操作
        [OperationContract]
        //服务契约接口的方法称为[OperationContract]—操作契约
        //用于说明其后的成员函数是WCF公开的服务功能定义
        string GetAppSettings(string aKey);
        [OperationContract]
        int WriteConfig(string aDm, string aNr);
    }


    // 使用下面示例中说明的数据约定将复合类型添加到服务操作。
    [DataContract]
    //DataContract用于说明其后的类CompositeType的实例是服务契约传递的对象
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        //数据成员契约:用于说明其后的类成员是WCF公开的类成员
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
