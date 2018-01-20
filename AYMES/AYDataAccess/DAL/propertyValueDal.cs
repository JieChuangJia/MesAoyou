using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace AYDataAccess
{
	/// <summary>
	/// 数据访问类:propertyValueDal
	/// </summary>
	public partial class propertyValueDal
	{
        public propertyValueDal()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string propertyValueID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from propertyValue");
            strSql.Append(" where propertyValueID=@propertyValueID ");
            SqlParameter[] parameters = {
					new SqlParameter("@propertyValueID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = propertyValueID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(propertyValueModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into propertyValue(");
            strSql.Append("propertyValueID,propertyID,propertyValue,tag1,tag2,tag3,tag4,tag5)");
            strSql.Append(" values (");
            strSql.Append("@propertyValueID,@propertyID,@propertyValue,@tag1,@tag2,@tag3,@tag4,@tag5)");
            SqlParameter[] parameters = {
					new SqlParameter("@propertyValueID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyValue", SqlDbType.NVarChar,50),
					new SqlParameter("@tag1", SqlDbType.NVarChar,50),
					new SqlParameter("@tag2", SqlDbType.NVarChar,50),
					new SqlParameter("@tag3", SqlDbType.NVarChar,50),
					new SqlParameter("@tag4", SqlDbType.NVarChar,50),
					new SqlParameter("@tag5", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.propertyValueID;
            parameters[1].Value = model.propertyID;
            parameters[2].Value = model.propertyValue;
            parameters[3].Value = model.tag1;
            parameters[4].Value = model.tag2;
            parameters[5].Value = model.tag3;
            parameters[6].Value = model.tag4;
            parameters[7].Value = model.tag5;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(propertyValueModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update propertyValue set ");
            strSql.Append("propertyID=@propertyID,");
            strSql.Append("propertyValue=@propertyValue,");
            strSql.Append("tag1=@tag1,");
            strSql.Append("tag2=@tag2,");
            strSql.Append("tag3=@tag3,");
            strSql.Append("tag4=@tag4,");
            strSql.Append("tag5=@tag5");
            strSql.Append(" where propertyValueID=@propertyValueID ");
            SqlParameter[] parameters = {
					new SqlParameter("@propertyID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyValue", SqlDbType.NVarChar,50),
					new SqlParameter("@tag1", SqlDbType.NVarChar,50),
					new SqlParameter("@tag2", SqlDbType.NVarChar,50),
					new SqlParameter("@tag3", SqlDbType.NVarChar,50),
					new SqlParameter("@tag4", SqlDbType.NVarChar,50),
					new SqlParameter("@tag5", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyValueID", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.propertyID;
            parameters[1].Value = model.propertyValue;
            parameters[2].Value = model.tag1;
            parameters[3].Value = model.tag2;
            parameters[4].Value = model.tag3;
            parameters[5].Value = model.tag4;
            parameters[6].Value = model.tag5;
            parameters[7].Value = model.propertyValueID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string propertyValueID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from propertyValue ");
            strSql.Append(" where propertyValueID=@propertyValueID ");
            SqlParameter[] parameters = {
					new SqlParameter("@propertyValueID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = propertyValueID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string propertyValueIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from propertyValue ");
            strSql.Append(" where propertyValueID in (" + propertyValueIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public propertyValueModel GetModel(string propertyValueID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 propertyValueID,propertyID,propertyValue,tag1,tag2,tag3,tag4,tag5 from propertyValue ");
            strSql.Append(" where propertyValueID=@propertyValueID ");
            SqlParameter[] parameters = {
					new SqlParameter("@propertyValueID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = propertyValueID;

            propertyValueModel model = new propertyValueModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public propertyValueModel DataRowToModel(DataRow row)
        {
            propertyValueModel model = new propertyValueModel();
            if (row != null)
            {
                if (row["propertyValueID"] != null)
                {
                    model.propertyValueID = row["propertyValueID"].ToString();
                }
                if (row["propertyID"] != null)
                {
                    model.propertyID = row["propertyID"].ToString();
                }
                if (row["propertyValue"] != null)
                {
                    model.propertyValue = row["propertyValue"].ToString();
                }
                if (row["tag1"] != null)
                {
                    model.tag1 = row["tag1"].ToString();
                }
                if (row["tag2"] != null)
                {
                    model.tag2 = row["tag2"].ToString();
                }
                if (row["tag3"] != null)
                {
                    model.tag3 = row["tag3"].ToString();
                }
                if (row["tag4"] != null)
                {
                    model.tag4 = row["tag4"].ToString();
                }
                if (row["tag5"] != null)
                {
                    model.tag5 = row["tag5"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select propertyValueID,propertyID,propertyValue,tag1,tag2,tag3,tag4,tag5 ");
            strSql.Append(" FROM propertyValue ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" propertyValueID,propertyID,propertyValue,tag1,tag2,tag3,tag4,tag5 ");
            strSql.Append(" FROM propertyValue ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM propertyValue ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.propertyValueID desc");
            }
            strSql.Append(")AS Row, T.*  from propertyValue T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "propertyValue";
            parameters[1].Value = "propertyValueID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

