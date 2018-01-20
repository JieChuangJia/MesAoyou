using AYUIInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AYWCFServer;
using AYDataAccess;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MESInterface;

namespace AYUIPresenter
{
    public class AYWCFServPresenter
    {
        private WCFManager wcfManager = null;
        private palletBll bllPallet = new palletBll();
        private batteryBll bllBattery = new batteryBll();
        private IMES mesInteface = null;
        public AYWCFServPresenter(IMES mes)
        {
            this.mesInteface = mes;
            wcfManager = new WCFManager();
            wcfManager.AYServ.delegateGetStep += GetStep;
            wcfManager.AYServ.delegateUpdateStep += UpdateStep;
            wcfManager.AYServ.delegateGetTrayBindingCell += GetTrayBindingCell;
            wcfManager.AYServ.delegateGetTrayCellLotNO += GetTrayCellLotNO;
            wcfManager.AYServ.delegateUploadTrayCellInfo += UploadTrayCellInfo;

            //string cels = "{\"Cell1\":\"36AN\",\"Cell2\":\"36AN\",\"Cell3\":\"36AN\",\"Cell4\":\"36AN\"}";
            //string restr = "";
            //UploadTrayCellInfo("TP1234567", "CV", cels, ref restr);
            //string js="";
            //string restr="";
            //int step=0;
            ////GetTrayBindingCell("TP1234567", out js, ref restr);
            ////GetStep("TP1234567", out step, ref restr);
            //GetTrayCellLotNO("TP1234567", out js, ref restr);
        }
        public bool StartService()
        {    
            string restr="";
            Uri mesSerice = new Uri("http://localhost/MesSvc");//课做配置
            if( wcfManager.Start(mesSerice, ref restr)==true)
            {
                LogModel lo  = new LogModel("MES服务","MES服务启动成功!",EnumLoglevel.提示);

                this.mesInteface.WriteLog(lo);
                return true;
            }
            else
            {
                LogModel lo = new LogModel("MES服务", "MES服务启动失败:"+restr, EnumLoglevel.提示);

                this.mesInteface.WriteLog(lo);
               
                return false;
            }
        }

        public void StopService()
        {
            string restr = "";
            if (wcfManager.Stop(ref restr) == true)
            {
                LogModel lo = new LogModel("MES服务", "MES服务已停止！", EnumLoglevel.提示);

                this.mesInteface.WriteLog(lo);

            }
            else
            {
                LogModel lo = new LogModel("MES服务", "MES服务无法停止：" + restr, EnumLoglevel.提示);

                this.mesInteface.WriteLog(lo);


            }
        }
        public bool GetStep(string TrayNO, out int step, ref string reStr)
        {
            step = 0;
            if (CheckPalletNum(TrayNO,ref reStr) == false)
            {
                return false;
            }
            palletModel pallet = bllPallet.GetModel(TrayNO);
            if (pallet == null)
            {
                reStr = "不存在此托盘信息！";

                return false;
            }
            step = pallet.stepNO;
            reStr = "获取工步号成功！";
            return true;
        }
     
        public bool UpdateStep(int StepNow, string TrayNo, ref string reStr)
        {
            if (CheckPalletNum(TrayNo, ref reStr) == false)
            {
                return false;
            }
            palletModel pallet = bllPallet.GetModel(TrayNo);
            if (pallet == null)
            {
                reStr = "托盘不存在！";
                return false;
            }
            List<batteryModel> palletBindBatterys = bllBattery.GetModelList("palletID = '" + TrayNo + "'");
            if (palletBindBatterys == null || palletBindBatterys.Count == 0)
            {
                reStr = "此托盘从未绑定过电芯!";
                return false;
            }
            pallet.stepNO = StepNow;
            bllPallet.Update(pallet);
            reStr = "更新工步号成功！";
            return true;
        }

        public bool GetTrayBindingCell(string TrayNo, out string jsonCells, ref string reStr)
        {
            jsonCells = "";
            if (CheckPalletNum(TrayNo, ref reStr) == false)
            {
                return false;
            }
          
            palletModel pallet = bllPallet.GetModel(TrayNo);
            if (pallet == null)
            {
                reStr = "不存在次托盘!";
                return false;
            }
            List<batteryModel> palletBindBatterys = bllBattery.GetModelList("palletID = '" + TrayNo + "'");
            if (palletBindBatterys == null || palletBindBatterys.Count == 0)
            {
                reStr = "绑定电芯数据为空!";
                return false;
            }
           
            JObject jsonBatteryObj = new JObject();
            foreach (batteryModel battery in palletBindBatterys)
            {
                string cellName = "Cell" + battery.channel.ToString().Trim();
                jsonBatteryObj[cellName] = battery.batteryID;
            }

            string jsonStr = jsonBatteryObj.ToString();
            jsonCells = jsonStr;
     
            reStr = "获取绑定信息成功!";
            return true;
        }

        public bool GetTrayCellLotNO(string TrayNo, out string lot, ref string reStr)
        {
            lot = "";
            palletModel pallet = bllPallet.GetModel(TrayNo);
            if (pallet == null)
            {
                reStr = "托盘不存在！";
                return false;
            }
            //List<batteryModel> palletBindBatterys = bllBattery.GetModelList("palletID = '" + TrayNo + "'");
            //if (palletBindBatterys == null || palletBindBatterys.Count == 0)
            //{
            //    reStr = "此托盘从未绑定过电芯!";
            //    return false;
            //}
            lot = pallet.batchName;
            reStr = "获取托盘电芯批次号成功!";
            return true;
        }


        public bool UploadTrayCellInfo(string TrayNo, string opNO, string jsonCells, ref string reStr)
        {
            if (CheckPalletNum(TrayNo, ref reStr) == false)
            {
                reStr = "托盘编号不正确";
                return false;
            }
            palletModel pallet = bllPallet.GetModel(TrayNo);
            palletModel insertModel = new palletModel();
            insertModel.palletID = TrayNo;
            insertModel.stepNO = 1;// 装载工位1
            insertModel.bind = true;
            if (pallet == null)
            {
                //插入
                bllPallet.Add(insertModel);
            }
            else
            {
                bllPallet.Update(insertModel);
                //更新
            }
           
            JObject jsonCellObj = JObject.Parse(jsonCells);

            string[] objValue = jsonCellObj.Properties().Select(item => item.Name.ToString()).ToArray();
           
            List<batteryModel> palletBindBatterys = new List<batteryModel>();
            for (int i = 0; i < objValue.Length; i++)
            {

                string batteryId = jsonCellObj[objValue[1]].ToString();
                batteryModel insertBattery = new batteryModel();
                insertBattery.palletBinded = true;
                insertBattery.batteryID = batteryId;
                insertBattery.channel = (i + 1);
                insertBattery.palletID = pallet.palletID;
                batteryModel battery = bllBattery.GetModel(batteryId);
                if (battery == null)//插入
                {
                    bllBattery.Add(insertBattery);
                }
                else//更新
                {
                    bllBattery.Update(insertBattery);
                }
            }

            return true;
        }

        private bool CheckPalletNum(string TrayNO, ref string reStr)
        {
            if (TrayNO.Length < 3)
            {
                reStr = "托盘码长度错误！";
                return false;
            }
            string headStr = TrayNO.Substring(0, 3);
            if (headStr != "TP1" && headStr != "TP2")
            {
                reStr = "托盘号必须是TP1或TP2开头！";
                return false;
            }
            return true;
        }


    }
}
