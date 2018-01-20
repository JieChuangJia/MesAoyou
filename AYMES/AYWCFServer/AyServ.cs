using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AYWCFServer
{

    public delegate bool DelegateGetStep(string TrayNO, out int step, ref string reStr);
    public delegate bool DelegateUpdateStep(int StepNow, string TrayNo, ref string reStr);
    public delegate bool DelegateGetTrayBindingCell(string TrayNo, out string jsonCells, ref string reStr);
    public delegate bool DelegateGetTrayCellLotNO(string TrayNo, out string lot, ref string reStr);
    public delegate bool DelegateUploadTrayCellInfo(string TrayNo, string opNO, string jsonCells, ref string reStr);
      

    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class AYServ : IAYServ
    {
        public DelegateGetStep delegateGetStep = null;
        public DelegateUpdateStep delegateUpdateStep = null;

        public DelegateGetTrayBindingCell delegateGetTrayBindingCell = null;
        public DelegateGetTrayCellLotNO delegateGetTrayCellLotNO = null;
        public DelegateUploadTrayCellInfo delegateUploadTrayCellInfo = null;
        public bool GetStep(string TrayNO, out int step, ref string reStr)
        {
            if (this.delegateGetStep == null)
            {
                step = 0;
                return false;
            }
            return this.delegateGetStep.Invoke(TrayNO, out step, ref reStr);
        }

        public bool UpdateStep(int StepNow, string TrayNo, ref string reStr)
        {
            if (this.delegateUpdateStep == null)
            {
                return false;
            }
            return this.delegateUpdateStep.Invoke(StepNow, TrayNo, ref reStr);
        }


        public bool GetTrayBindingCell(string TrayNo, out string jsonCells, ref string reStr)
        {
            if (this.delegateGetTrayBindingCell == null)
            {
                jsonCells = "";
                return false;
            }
            return this.delegateGetTrayBindingCell.Invoke(TrayNo, out jsonCells, ref reStr);

        }

        public bool GetTrayCellLotNO(string TrayNo, out string lot, ref string reStr)
        {
            if (this.delegateGetTrayCellLotNO == null)
            {
                lot = "";
                return false;
            }
            return this.delegateGetTrayCellLotNO.Invoke(TrayNo, out lot, ref reStr);
        }


        public bool UploadTrayCellInfo(string TrayNo, string opNO, string jsonCells, ref string reStr)
        {
            if (this.delegateUploadTrayCellInfo == null)
            {
                return false;
            }
            return this.delegateUploadTrayCellInfo.Invoke(TrayNo, opNO, jsonCells, ref reStr);
        }


        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
