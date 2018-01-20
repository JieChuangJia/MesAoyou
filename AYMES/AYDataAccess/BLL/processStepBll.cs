using System;
using System.Data;
using System.Collections.Generic;
namespace AYDataAccess
{
	/// <summary>
	/// processStepBll
	/// </summary>
	public partial class processStepBll
	{
		private readonly processStepDal dal=new processStepDal();
		public processStepBll()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int stepNO)
		{
			return dal.Exists(stepNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(processStepModel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(processStepModel model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int stepNO)
		{
			
			return dal.Delete(stepNO);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string stepNOlist )
		{
			return dal.DeleteList(stepNOlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public processStepModel GetModel(int stepNO)
		{
			
			return dal.GetModel(stepNO);
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
		public List<processStepModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<processStepModel> DataTableToList(DataTable dt)
		{
			List<processStepModel> modelList = new List<processStepModel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				processStepModel model;
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
        public processStepModel GetModelByStepNo(int stepNo)
        {
            string strWhere = "stepNO = " + stepNo;
            List<processStepModel> modelList = GetModelList(strWhere);
            if(modelList == null || modelList.Count == 0)
            {
                return null;
            }
            return modelList[0];
        }
		#endregion  ExtensionMethod
	}
}

