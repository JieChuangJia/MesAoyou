using System;
using System.Data;
using System.Collections.Generic;
namespace AYDataAccess
{
	/// <summary>
	/// propertyValueBll
	/// </summary>
	public partial class propertyValueBll
	{
        private readonly propertyValueDal dal = new propertyValueDal();
        public propertyValueBll()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string propertyValueID)
		{
			return dal.Exists(propertyValueID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(propertyValueModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(propertyValueModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string propertyValueID)
		{
			
			return dal.Delete(propertyValueID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string propertyValueIDlist )
		{
			return dal.DeleteList(propertyValueIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public propertyValueModel GetModel(string propertyValueID)
		{
			
			return dal.GetModel(propertyValueID);
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
		public List<propertyValueModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<propertyValueModel> DataTableToList(DataTable dt)
		{
			List<propertyValueModel> modelList = new List<propertyValueModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				propertyValueModel model;
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

