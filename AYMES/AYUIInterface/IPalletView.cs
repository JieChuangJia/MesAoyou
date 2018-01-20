using AYDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYUIInterface
{
    public class Pallet
    {
        /// <summary>
        /// 托盘编码
        /// </summary>
        public string PalletID;
    }


    public interface IPalletView:IBaseView
    {
        #region 方法
        /// <summary>
        /// 显示托盘信息
        /// </summary>
        void ShowPalletInfo(palletModel model);

        /// <summary>
        ///显示托盘数据追溯信息
        /// </summary>
        void ShowPalletTraceInfo(DataTable dt);

        /// <summary>
        ///  显示工序信息
        /// </summary>
       void ShowProcessInfo(DataTable dt);
        #endregion
    }
}
