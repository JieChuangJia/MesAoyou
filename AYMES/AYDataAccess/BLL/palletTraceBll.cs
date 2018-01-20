using System;
using System.Data;
using System.Collections.Generic;
namespace AYDataAccess
{
	/// <summary>
	/// palletTraceBll
	/// </summary>
	public partial class palletTraceBll
	{
        private readonly palletTraceDal dal = new palletTraceDal();
        public palletTraceBll()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string palletTraceID)
		{
			return dal.Exists(palletTraceID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(palletTraceModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(palletTraceModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string palletTraceID)
		{
			
			return dal.Delete(palletTraceID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string palletTraceIDlist )
		{
			return dal.DeleteList(palletTraceIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public palletTraceModel GetModel(string palletTraceID)
		{
			
			return dal.GetModel(palletTraceID);
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
		public List<palletTraceModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<palletTraceModel> DataTableToList(DataTable dt)
		{
			List<palletTraceModel> modelList = new List<palletTraceModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				palletTraceModel model;
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
        public List<palletTraceModel> GetModelListBasePalletID(string palletID)
        {
            string strWhere = "palletID = '" + palletID + "'";
            return GetModelList(strWhere);
        }
		#endregion  ExtensionMethod
	}
}

