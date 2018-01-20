using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AYWCFServer
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IAYServ
    {
        [OperationContract]
        bool GetStep(string TrayNO, out int step, ref string reStr);

        [OperationContract]
        bool UpdateStep(int StepNow, string TrayNo, ref string reStr);

        [OperationContract]
        bool GetTrayBindingCell(string TrayNo, out string jsonCells, ref string reStr);

        [OperationContract]
        bool GetTrayCellLotNO(string TrayNo, out string lot, ref string reStr);

        [OperationContract]
        bool UploadTrayCellInfo(string TrayNo, string opNO, string jsonCells, ref string reStr);

    }

    // 使用下面示例中说明的数据约定将复合类型添加到服务操作。
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
