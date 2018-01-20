using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace AYDataAccess
{
	/// <summary>
	/// 数据访问类:batteryTraceDal
	/// </summary>
	public partial class batteryTraceDal
	{
        public batteryTraceDal()
		{}
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string batteryTraceID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from batteryTrace");
            strSql.Append(" where batteryTraceID=@batteryTraceID ");
            SqlParameter[] parameters = {
					new SqlParameter("@batteryTraceID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = batteryTraceID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(batteryTraceModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into batteryTrace(");
            strSql.Append("batteryTraceID,batteryID,eventCata,eventDesc,eventTime,tag1,tag2,tag3,tag4,tag5)");
            strSql.Append(" values (");
            strSql.Append("@batteryTraceID,@batteryID,@eventCata,@eventDesc,@eventTime,@tag1,@tag2,@tag3,@tag4,@tag5)");
            SqlParameter[] parameters = {
					new SqlParameter("@batteryTraceID", SqlDbType.NVarChar,50),
					new SqlParameter("@batteryID", SqlDbType.NVarChar,50),
					new SqlParameter("@eventCata", SqlDbType.NVarChar,50),
					new SqlParameter("@eventDesc", SqlDbType.NVarChar,255),
					new SqlParameter("@eventTime", SqlDbType.DateTime),
					new SqlParameter("@tag1", SqlDbType.NVarChar,50),
					new SqlParameter("@tag2", SqlDbType.NVarChar,50),
					new SqlParameter("@tag3", SqlDbType.NVarChar,50),
					new SqlParameter("@tag4", SqlDbType.NVarChar,50),
					new SqlParameter("@tag5", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.batteryTraceID;
            parameters[1].Value = model.batteryID;
            parameters[2].Value = model.eventCata;
            parameters[3].Value = model.eventDesc;
            parameters[4].Value = model.eventTime;
            parameters[5].Value = model.tag1;
            parameters[6].Value = model.tag2;
            parameters[7].Value = model.tag3;
            parameters[8].Value = model.tag4;
            parameters[9].Value = model.tag5;

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
        public bool Update(batteryTraceModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update batteryTrace set ");
            strSql.Append("batteryID=@batteryID,");
            strSql.Append("eventCata=@eventCata,");
            strSql.Append("eventDesc=@eventDesc,");
            strSql.Append("eventTime=@eventTime,");
            strSql.Append("tag1=@tag1,");
            strSql.Append("tag2=@tag2,");
            strSql.Append("tag3=@tag3,");
            strSql.Append("tag4=@tag4,");
            strSql.Append("tag5=@tag5");
            strSql.Append(" where batteryTraceID=@batteryTraceID ");
            SqlParameter[] parameters = {
					new SqlParameter("@batteryID", SqlDbType.NVarChar,50),
					new SqlParameter("@eventCata", SqlDbType.NVarChar,50),
					new SqlParameter("@eventDesc", SqlDbType.NVarChar,255),
					new SqlParameter("@eventTime", SqlDbType.DateTime),
					new SqlParameter("@tag1", SqlDbType.NVarChar,50),
					new SqlParameter("@tag2", SqlDbType.NVarChar,50),
					new SqlParameter("@tag3", SqlDbType.NVarChar,50),
					new SqlParameter("@tag4", SqlDbType.NVarChar,50),
					new SqlParameter("@tag5", SqlDbType.NVarChar,50),
					new SqlParameter("@batteryTraceID", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.batteryID;
            parameters[1].Value = model.eventCata;
            parameters[2].Value = model.eventDesc;
            parameters[3].Value = model.eventTime;
            parameters[4].Value = model.tag1;
            parameters[5].Value = model.tag2;
            parameters[6].Value = model.tag3;
            parameters[7].Value = model.tag4;
            parameters[8].Value = model.tag5;
            parameters[9].Value = model.batteryTraceID;

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
        public bool Delete(string batteryTraceID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from batteryTrace ");
            strSql.Append(" where batteryTraceID=@batteryTraceID ");
            SqlParameter[] parameters = {
					new SqlParameter("@batteryTraceID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = batteryTraceID;

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
        public bool DeleteList(string batteryTraceIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from batteryTrace ");
            strSql.Append(" where batteryTraceID in (" + batteryTraceIDlist + ")  ");
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
        public batteryTraceModel GetModel(string batteryTraceID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 batteryTraceID,batteryID,eventCata,eventDesc,eventTime,tag1,tag2,tag3,tag4,tag5 from batteryTrace ");
            strSql.Append(" where batteryTraceID=@batteryTraceID ");
            SqlParameter[] parameters = {
					new SqlParameter("@batteryTraceID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = batteryTraceID;

            batteryTraceModel model = new batteryTraceModel();
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
        public batteryTraceModel DataRowToModel(DataRow row)
        {
            batteryTraceModel model = new batteryTraceModel();
            if (row != null)
            {
                if (row["batteryTraceID"] != null)
                {
                    model.batteryTraceID = row["batteryTraceID"].ToString();
                }
                if (row["batteryID"] != null)
                {
                    model.batteryID = row["batteryID"].ToString();
                }
                if (row["eventCata"] != null)
                {
                    model.eventCata = row["eventCata"].ToString();
                }
                if (row["eventDesc"] != null)
                {
                    model.eventDesc = row["eventDesc"].ToString();
                }
                if (row["eventTime"] != null && row["eventTime"].ToString() != "")
                {
                    model.eventTime = DateTime.Parse(row["eventTime"].ToString());
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
            strSql.Append("select batteryTraceID,batteryID,eventCata,eventDesc,eventTime,tag1,tag2,tag3,tag4,tag5 ");
            strSql.Append(" FROM batteryTrace ");
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
            strSql.Append(" batteryTraceID,batteryID,eventCata,eventDesc,eventTime,tag1,tag2,tag3,tag4,tag5 ");
            strSql.Append(" FROM batteryTrace ");
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
            strSql.Append("select count(1) FROM batteryTrace ");
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
                strSql.Append("order by T.batteryTraceID desc");
            }
            strSql.Append(")AS Row, T.*  from batteryTrace T ");
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
            parameters[0].Value = "batteryTrace";
            parameters[1].Value = "batteryTraceID";
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

