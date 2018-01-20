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
    public class PalletPresenter : BasePresenter<IPalletView>
    {
        #region 属性
        private readonly palletBll bllPallet = new palletBll();
        private readonly palletTraceBll bllPalletTrace = new palletTraceBll();
        private readonly processStepBll bllProcessStep = new processStepBll();
        #endregion
        public PalletPresenter(IPalletView view) :
            base(view)
        {
        }

        public void GetPalletInfo(Pallet pallet)
        {
            palletModel model = bllPallet.GetModel(pallet.PalletID);
            if (model == null)
            {
                this.View.ShowMessage("未找到该编号的托盘", "信息提示");
                return;
            }
            this.View.ShowPalletInfo(model);
        }

        public void GetPalletTraceInfo(Pallet pallet)
        {
            List<palletTraceModel> modelList = bllPalletTrace.GetModelListBasePalletID(pallet.PalletID);
            if (modelList == null || modelList.Count == 0)
            {
                //this.View.ShowMessage("未找到该托盘编码的数据追溯", "信息提示");
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("PalletID"));
            dt.Columns.Add(new DataColumn("EventCata"));
            dt.Columns.Add(new DataColumn("EventDes"));
            dt.Columns.Add(new DataColumn("EventTime"));
            for (int i = 0; i < modelList.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["ID"] = modelList[i].palletTraceID;
                row["PalletID"] = modelList[i].palletID;
                row["EventCata"] = modelList[i].eventCata;
                row["EventDes"] = modelList[i].eventDesc;
                row["EventTime"] = modelList[i].eventTime.ToString();
                dt.Rows.Add(row);
            }
            this.View.ShowPalletTraceInfo(dt);
        }

        public void GetPalletProcessInfo(Pallet pallet)
        {
            palletModel model = bllPallet.GetModel(pallet.PalletID);
            if (model == null)
            {
                this.View.ShowMessage("未找到该编号的托盘", "信息提示");
                return;
            }
            processStepModel stepModel = bllProcessStep.GetModelByStepNo(model.stepNO);
            if(stepModel == null)
            {
                this.View.ShowMessage("未找到编号为" + model.stepNO.ToString() + "托盘的工序信息", "信息提示");
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("PalletID"));
            dt.Columns.Add(new DataColumn("StepNo"));
            dt.Columns.Add(new DataColumn("ProcessName"));

            DataRow row = dt.NewRow();
            row["PalletID"] = model.palletID;
            row["StepNo"] = stepModel.stepNO.ToString();
            row["ProcessName"] = stepModel.processStepName;
            dt.Rows.Add(row);
            this.View.ShowProcessInfo(dt);
            
        }
    }
}
