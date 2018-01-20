using System;
using System.Data;
using System.Collections.Generic;
namespace AYDataAccess
{
	/// <summary>
	/// batteryPropertyValueBll
	/// </summary>
	public partial class batteryPropertyValueBll
	{
		private readonly batteryPropertyValueDal dal=new batteryPropertyValueDal();
        public batteryPropertyValueBll()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string batteryPropertyValueID)
		{
			return dal.Exists(batteryPropertyValueID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(batteryPropertyValueModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(batteryPropertyValueModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string batteryPropertyValueID)
		{
			
			return dal.Delete(batteryPropertyValueID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string batteryPropertyValueIDlist )
		{
			return dal.DeleteList(batteryPropertyValueIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public batteryPropertyValueModel GetModel(string batteryPropertyValueID)
		{
			
			return dal.GetModel(batteryPropertyValueID);
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
		public List<batteryPropertyValueModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<batteryPropertyValueModel> DataTableToList(DataTable dt)
		{
			List<batteryPropertyValueModel> modelList = new List<batteryPropertyValueModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				batteryPropertyValueModel model;
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

		#endregion  ExtensionMethod
	}
}

