using System;
using System.Data;
using System.Collections.Generic;
namespace AYDataAccess
{
	/// <summary>
	/// batteryTraceBll
	/// </summary>
	public partial class batteryTraceBll
	{
        private readonly batteryTraceDal dal = new batteryTraceDal();
        public batteryTraceBll()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string batteryTraceID)
		{
			return dal.Exists(batteryTraceID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(batteryTraceModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(batteryTraceModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string batteryTraceID)
		{
			
			return dal.Delete(batteryTraceID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string batteryTraceIDlist )
		{
			return dal.DeleteList(batteryTraceIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public batteryTraceModel GetModel(string batteryTraceID)
		{
			
			return dal.GetModel(batteryTraceID);
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<batteryTraceModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<batteryTraceModel> DataTableToList(DataTable dt)
		{
			List<batteryTraceModel> modelList = new List<batteryTraceModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				batteryTraceModel model;
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
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
        public List<batteryTraceModel> GetModelListBaseBatteryID(string batteryID)
        {
            string strWhere = "batteryID = '" + batteryID + "'";
            return GetModelList(strWhere);
        }
		#endregion  ExtensionMethod
	}
}

