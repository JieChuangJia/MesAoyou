/******************************************************************************
 * 版权所有: Copyright (C) 沈阳新松机器人自动化股份有限公司
 * 文件名称:
 * 内容摘要: view基类接口
 * 其它说明: 
 * 作    者:peng na
 * 完成日期:2016年9月2日
 * 修改记录:
 * ******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AYUIInterface
{
    public interface IBaseView
    {
        /// <summary>
        /// 内容：显示消息
        /// </summary>
        /// <param name="mess">消息内容</param>
        /// <param name="title">标题</param>
        void ShowMessage(string mess, string title);

        /// <summary>
        /// 内容：询问窗体接口
        /// </summary>
        /// <param name="strCont">内容</param>
        /// <returns>0是，其他否</returns>
        int AskMessage(string strCont);
   
    }
}
