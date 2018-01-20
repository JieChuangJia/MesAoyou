using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using AYUIInterface;
using AYUIPresenter;
using AYDataAccess;
using MESInterface;
using System.Configuration;

namespace AYUI
{
    public partial class BatteryView : BaseView,IBatteryView
    {
        #region 属性
        public BatteryPresenter batteryPres = null;
        private IMES mesInterface; 
        #endregion
        public BatteryView(IMES mes)//初始化接口
        {
            InitializeComponent();
            batteryPres = new BatteryPresenter(this);
            this.mesInterface = mes;
            CreateMenu();
            LoadCfg();
        }
       
        private void CreateMenu()
        {
            string restr = "";
            this.mesInterface.AddGroup("查询", ref restr);
            this.mesInterface.AddGroupItemArea("查询", "电芯查询", OnQueryBatteryEventhandler, ref restr);
           
            //this.mesInterface.RegistStartAction(StartServ);
        }
        private void LoadCfg()
        {
            string dbSrc = ConfigurationManager.AppSettings["DBSource"];
            //CtlDBAccess.DBUtility.PubConstant.ConnectionString = string.Format(@"{0}Initial Catalog=ACEcams;User ID=sa;Password=123456;", dbSrc);
            string dbConn1 = string.Format(@"{0}Initial Catalog=MesAoyou;User ID=sa;Password=123456;", dbSrc);
            AYDataAccess.PubConstant.ConnectionString = dbConn1;
        }
        private void OnQueryBatteryEventhandler(object sender, EventArgs e)
        {
            this.mesInterface.ShowTab(this);
        }
        private void sbtn_Search_Click(object sender, EventArgs e)
        {
            if(this.txtEdit_batteryID.Text == null || this.txtEdit_batteryID.Text == "")
            {
                ShowMessage("请输入电芯编码","信息提示");
                return;
            }
            Battery battery = new Battery();
            battery.BatteryID = this.txtEdit_batteryID.Text.ToString();
            batteryPres.GetBatteryInfo(battery);
            batteryPres.GetBattteryTraceInfo(battery);
            batteryPres.GetBatteryProbertyInfo(battery);


        }

        #region 实现方法
        /// <summary>
        /// 显示电芯信息
        /// </summary>
        /// <param name="model"></param>
        public void ShowBatteryInfo(batteryModel model)
        {
            if (model == null)
            {
                return;
            }
            ClearBatteryInfo();
            this.txtEdit_batchName.Text = model.batchName.ToString();
            this.txtEdit_batteryID1.Text = model.batteryID.ToString();
            this.txtEdit_Channel.Text = model.channel.ToString();
            this.txtEdit_OnlineTime.Text = model.onlineTime.ToString();
            this.txtEdit_PalletID.Text = model.palletID.ToString();
            this.txtEdit_productCata.Text = model.productCata.ToString();
            this.txtEdit_Binded.Text = model.palletBinded.ToString();
        }

        /// <summary>
        /// 显示电芯追溯信息
        /// </summary>
        /// <param name="dt"></param>
        public void ShowBatteryTraceInfo(DataTable dt)
        {
            this.gc_DataTrace.DataSource = dt;
        }

        /// <summary>
        /// 显示电池属性信息
        /// </summary>
        /// <param name="dt"></param>
        public void ShowBatteryPropertyInfo(DataTable dt)
        {
            this.gc_PropertyPara.DataSource = dt;

        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 清空电芯信息
        /// </summary>
        private void ClearBatteryInfo()
        {
            this.txtEdit_batteryID1.Text = "";
            this.txtEdit_Channel.Text = "";
            this.txtEdit_OnlineTime.Text = "";
            this.txtEdit_PalletID.Text = "";
            this.txtEdit_productCata.Text = "";
            this.txtEdit_batchName.Text = "";
        }
        #endregion


    }
}