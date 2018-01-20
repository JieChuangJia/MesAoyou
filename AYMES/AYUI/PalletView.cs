using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AYUIPresenter;
using AYUIInterface;
using AYDataAccess;
using MESInterface;

namespace AYUI
{
    public partial class PalletView : BaseView,IPalletView
    {
        #region 属性
        public PalletPresenter palletPres = null;
        AYWCFServPresenter servPresenter = null;
        private IMES mesInterface;
        #endregion
        public PalletView(IMES mes)
        {
            InitializeComponent();
            palletPres = new PalletPresenter(this);
            servPresenter = new AYWCFServPresenter(mes);

            this.mesInterface = mes;
            CreateMenu();

        }
        private void CreateMenu()
        {
            string restr = "";
            this.mesInterface.AddGroup("查询", ref restr);
            this.mesInterface.AddGroupItemArea("查询", "托盘查询", OnQueryBatteryEventhandler, ref restr);
            this.mesInterface.RegistStartAction(StartServ);
            this.mesInterface.RegistStopAction(StopServ);
        }
        private void StartServ()
        {
            servPresenter.StartService();
        }
        private void StopServ()
        {
            servPresenter.StopService();
        }

        private void OnQueryBatteryEventhandler(object sender, EventArgs e)
        {
            this.mesInterface.ShowTab(this);
        }
        private void sbtn_Search_Click(object sender, EventArgs e)
        {
            if (this.txtEdit_PalletID.Text == null || this.txtEdit_PalletID.Text == "")
            {
                ShowMessage("请输入托盘编码", "信息提示");
                return;
            }
            Pallet pallet = new Pallet();
            pallet.PalletID = this.txtEdit_PalletID.Text.ToString();
            palletPres.GetPalletInfo(pallet);
            palletPres.GetPalletTraceInfo(pallet);
            palletPres.GetPalletProcessInfo(pallet);
        }

        #region 实现方法
        /// <summary>
        /// 显示托盘信息
        /// </summary>
        public void ShowPalletInfo(palletModel model)
        {
            if (model == null)
            {
                return;
            }
            ClearPalletInfo();
            this.txtEdit_PalletID2.Text = model.palletID.ToString();
            this.txtEdit_StepN.Text = model.stepNO.ToString();
            this.txtEdit_palletCata.Text = model.palletCata.ToString();
            this.txtEdit_bind.Text = model.bind.ToString();
            this.txtEdit_BatchName.Text = model.batchName.ToString();
        }

        /// <summary>
        ///显示托盘数据追溯信息
        /// </summary>
        public void ShowPalletTraceInfo(DataTable dt)
        {
            this.gc_dataTrace.DataSource = dt;
        }

        /// <summary>
        ///  显示工序信息
        /// </summary>
        public void ShowProcessInfo(DataTable dt)
        {
            this.gc_stepDesc.DataSource = dt;
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 清空托盘信息信息
        /// </summary>
        private void ClearPalletInfo()
        {
            this.txtEdit_BatchName.Text = "";
            this.txtEdit_bind.Text = "";
            this.txtEdit_palletCata.Text = "";
            this.txtEdit_PalletID2.Text = "";
            this.txtEdit_StepN.Text = "";
        }
        #endregion
    }
}