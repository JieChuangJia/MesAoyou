using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYDataAccess
{
    /// <summary>
    /// View_batteryPropertyBll
    /// </summary>
    public partial class View_batteryPropertyBll
    {
        private readonly View_batteryPropertyDal dal = new View_batteryPropertyDal();
        public View_batteryPropertyBll()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string batteryID, string propertyName, string propertyCata, string batteryPropertyValueID, string propertyID, string propertyValue)
        {
            return dal.Exists(batteryID, propertyName, propertyCata, batteryPropertyValueID, propertyID, propertyValue);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(View_batteryPropertyModel model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(View_batteryPropertyModel model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string batteryID, string propertyName, string propertyCata, string batteryPropertyValueID, string propertyID, string propertyValue)
        {

            return dal.Delete(batteryID, propertyName, propertyCata, batteryPropertyValueID, propertyID, propertyValue);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public View_batteryPropertyModel GetModel(string batteryID, string propertyName, string propertyCata, string batteryPropertyValueID, string propertyID, string propertyValue)
        {

            return dal.GetModel(batteryID, propertyName, propertyCata, batteryPropertyValueID, propertyID, propertyValue);
        }

       
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<View_batteryPropertyModel> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<View_batteryPropertyModel> DataTableToList(DataTable dt)
        {
            List<View_batteryPropertyModel> modelList = new List<View_batteryPropertyModel>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                View_batteryPropertyModel model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        public List<View_batteryPropertyModel> GetViewModelListBaseBatteryID(string batteryID)
        {
            string strWhere = "batteryID = '" + batteryID + "'";
            return GetModelList(strWhere);
        }
        #endregion  ExtensionMethod
    }
}
