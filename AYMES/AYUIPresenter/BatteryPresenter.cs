using AYDataAccess;
using AYUIInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYUIPresenter
{
    public class BatteryPresenter : BasePresenter<IBatteryView>
    {
        #region 属性
        private readonly batteryBll bllBattery = new batteryBll();

        private readonly batteryTraceBll bllBatteryTrace = new batteryTraceBll();

        private readonly View_batteryPropertyBll bllBatteryProperty = new View_batteryPropertyBll();

        #endregion
        public BatteryPresenter(IBatteryView view) :
            base(view)
        {

        }

        public void GetBatteryInfo(Battery battery)
        {

            batteryModel model = bllBattery.GetModel(battery.BatteryID);
            if(model == null)
            {
                //this.View.ShowMessage("未找到该编号的电芯", "信息提示");
                return;
            }
            this.View.ShowBatteryInfo(model);
        }

        public void GetBattteryTraceInfo(Battery battery)
        {
            List<batteryTraceModel> modelList = bllBatteryTrace.GetModelListBaseBatteryID(battery.BatteryID);
            if (modelList == null || modelList.Count == 0)
            {
                //this.View.ShowMessage("未找到该电芯编码的数据追溯", "信息提示");
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("BatteryID"));
            dt.Columns.Add(new DataColumn("EventCata"));
            dt.Columns.Add(new DataColumn("EventDes"));
            dt.Columns.Add(new DataColumn("EventTime"));
            for (int i = 0; i < modelList.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["ID"] = modelList[i].batteryTraceID;
                row["BatteryID"] = modelList[i].batteryID;
                row["EventCata"] = modelList[i].eventCata;
                row["EventDes"] = modelList[i].eventDesc;
                row["EventTime"] = modelList[i].eventTime.ToString();
                dt.Rows.Add(row);
            }
            this.View.ShowBatteryTraceInfo(dt);
        }

        public void GetBatteryProbertyInfo(Battery battery)
        {
            List<View_batteryPropertyModel> modelList = bllBatteryProperty.GetViewModelListBaseBatteryID(battery.BatteryID);
            if (modelList == null || modelList.Count == 0)
            {
                this.View.ShowMessage("未找到该电芯编码的属性信息", "信息提示");
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("BatteryID"));
            dt.Columns.Add(new DataColumn("PropertyID"));
            dt.Columns.Add(new DataColumn("PropertyValID"));
            dt.Columns.Add(new DataColumn("PropertyName"));
            dt.Columns.Add(new DataColumn("PropertyCata"));
            dt.Columns.Add(new DataColumn("PropertyValue"));

            for (int i = 0; i < modelList.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["BatteryID"] = modelList[i].batteryID;
                row["PropertyID"] = modelList[i].propertyID;
                row["PropertyValID"] = modelList[i].batteryPropertyValueID;
                row["PropertyName"] = modelList[i].propertyName;
                row["PropertyCata"] = modelList[i].propertyCata;
                row["PropertyValue"] = modelList[i].propertyValue;
                dt.Rows.Add(row);

            }
            this.View.ShowBatteryPropertyInfo(dt);
        }
    }
}
