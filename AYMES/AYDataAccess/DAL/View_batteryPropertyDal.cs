using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYDataAccess
{
    /// <summary>
    /// 数据访问类:View_batteryPropertyDal
    /// </summary>
    public partial class View_batteryPropertyDal
    {
        public View_batteryPropertyDal()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string batteryID, string propertyName, string propertyCata, string batteryPropertyValueID, string propertyID, string propertyValue)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from View_batteryProperty");
            strSql.Append(" where batteryID=@batteryID and propertyName=@propertyName and propertyCata=@propertyCata and batteryPropertyValueID=@batteryPropertyValueID and propertyID=@propertyID and propertyValue=@propertyValue ");
            SqlParameter[] parameters = {
					new SqlParameter("@batteryID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyName", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyCata", SqlDbType.NVarChar,50),
					new SqlParameter("@batteryPropertyValueID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyValue", SqlDbType.NVarChar,50)			};
            parameters[0].Value = batteryID;
            parameters[1].Value = propertyName;
            parameters[2].Value = propertyCata;
            parameters[3].Value = batteryPropertyValueID;
            parameters[4].Value = propertyID;
            parameters[5].Value = propertyValue;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(View_batteryPropertyModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into View_batteryProperty(");
            strSql.Append("batteryID,propertyName,propertyCata,batteryPropertyValueID,propertyID,propertyValue)");
            strSql.Append(" values (");
            strSql.Append("@batteryID,@propertyName,@propertyCata,@batteryPropertyValueID,@propertyID,@propertyValue)");
            SqlParameter[] parameters = {
					new SqlParameter("@batteryID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyName", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyCata", SqlDbType.NVarChar,50),
					new SqlParameter("@batteryPropertyValueID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyValue", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.batteryID;
            parameters[1].Value = model.propertyName;
            parameters[2].Value = model.propertyCata;
            parameters[3].Value = model.batteryPropertyValueID;
            parameters[4].Value = model.propertyID;
            parameters[5].Value = model.propertyValue;

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
        public bool Update(View_batteryPropertyModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update View_batteryProperty set ");
            strSql.Append("batteryID=@batteryID,");
            strSql.Append("propertyName=@propertyName,");
            strSql.Append("propertyCata=@propertyCata,");
            strSql.Append("batteryPropertyValueID=@batteryPropertyValueID,");
            strSql.Append("propertyID=@propertyID,");
            strSql.Append("propertyValue=@propertyValue");
            strSql.Append(" where batteryID=@batteryID and propertyName=@propertyName and propertyCata=@propertyCata and batteryPropertyValueID=@batteryPropertyValueID and propertyID=@propertyID and propertyValue=@propertyValue ");
            SqlParameter[] parameters = {
					new SqlParameter("@batteryID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyName", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyCata", SqlDbType.NVarChar,50),
					new SqlParameter("@batteryPropertyValueID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyValue", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.batteryID;
            parameters[1].Value = model.propertyName;
            parameters[2].Value = model.propertyCata;
            parameters[3].Value = model.batteryPropertyValueID;
            parameters[4].Value = model.propertyID;
            parameters[5].Value = model.propertyValue;

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
        public bool Delete(string batteryID, string propertyName, string propertyCata, string batteryPropertyValueID, string propertyID, string propertyValue)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from View_batteryProperty ");
            strSql.Append(" where batteryID=@batteryID and propertyName=@propertyName and propertyCata=@propertyCata and batteryPropertyValueID=@batteryPropertyValueID and propertyID=@propertyID and propertyValue=@propertyValue ");
            SqlParameter[] parameters = {
					new SqlParameter("@batteryID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyName", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyCata", SqlDbType.NVarChar,50),
					new SqlParameter("@batteryPropertyValueID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyValue", SqlDbType.NVarChar,50)			};
            parameters[0].Value = batteryID;
            parameters[1].Value = propertyName;
            parameters[2].Value = propertyCata;
            parameters[3].Value = batteryPropertyValueID;
            parameters[4].Value = propertyID;
            parameters[5].Value = propertyValue;

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
        /// 得到一个对象实体
        /// </summary>
        public View_batteryPropertyModel GetModel(string batteryID, string propertyName, string propertyCata, string batteryPropertyValueID, string propertyID, string propertyValue)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 batteryID,propertyName,propertyCata,batteryPropertyValueID,propertyID,propertyValue from View_batteryProperty ");
            strSql.Append(" where batteryID=@batteryID and propertyName=@propertyName and propertyCata=@propertyCata and batteryPropertyValueID=@batteryPropertyValueID and propertyID=@propertyID and propertyValue=@propertyValue ");
            SqlParameter[] parameters = {
					new SqlParameter("@batteryID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyName", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyCata", SqlDbType.NVarChar,50),
					new SqlParameter("@batteryPropertyValueID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyID", SqlDbType.NVarChar,50),
					new SqlParameter("@propertyValue", SqlDbType.NVarChar,50)			};
            parameters[0].Value = batteryID;
            parameters[1].Value = propertyName;
            parameters[2].Value = propertyCata;
            parameters[3].Value = batteryPropertyValueID;
            parameters[4].Value = propertyID;
            parameters[5].Value = propertyValue;

            View_batteryPropertyModel model = new View_batteryPropertyModel();
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
        public View_batteryPropertyModel DataRowToModel(DataRow row)
        {
            View_batteryPropertyModel model = new View_batteryPropertyModel();
            if (row != null)
            {
                if (row["batteryID"] != null)
                {
                    model.batteryID = row["batteryID"].ToString();
                }
                if (row["propertyName"] != null)
                {
                    model.propertyName = row["propertyName"].ToString();
                }
                if (row["propertyCata"] != null)
                {
                    model.propertyCata = row["propertyCata"].ToString();
                }
                if (row["batteryPropertyValueID"] != null)
                {
                    model.batteryPropertyValueID = row["batteryPropertyValueID"].ToString();
                }
                if (row["propertyID"] != null)
                {
                    model.propertyID = row["propertyID"].ToString();
                }
                if (row["propertyValue"] != null)
                {
                    model.propertyValue = row["propertyValue"].ToString();
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
            strSql.Append("select batteryID,propertyName,propertyCata,batteryPropertyValueID,propertyID,propertyValue ");
            strSql.Append(" FROM View_batteryProperty ");
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
            strSql.Append(" batteryID,propertyName,propertyCata,batteryPropertyValueID,propertyID,propertyValue ");
            strSql.Append(" FROM View_batteryProperty ");
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
            strSql.Append("select count(1) FROM View_batteryProperty ");
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
                strSql.Append("order by T.propertyValue desc");
            }
            strSql.Append(")AS Row, T.*  from View_batteryProperty T ");
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
            parameters[0].Value = "View_batteryProperty";
            parameters[1].Value = "propertyValue";
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
