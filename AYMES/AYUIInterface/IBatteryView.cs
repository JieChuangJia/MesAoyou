using AYDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYUIInterface
{

    public class Battery
    {
        /// <summary>
        /// 电芯编码
        /// </summary>
        public string BatteryID;
    }


    public interface IBatteryView:IBaseView
    {

        #region 方法
        /// <summary>
        /// 显示电芯信息
        /// </summary>
        /// <param name="model"></param>
        void ShowBatteryInfo(batteryModel model);

        /// <summary>
        /// 显示电芯追溯信息
        /// </summary>
        /// <param name="dt"></param>
        void ShowBatteryTraceInfo(DataTable dt);

        /// <summary>
        /// 显示电池属性信息
        /// </summary>
        /// <param name="dt"></param>
        void ShowBatteryPropertyInfo(DataTable dt);

        #endregion
    }
}
