using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:SYS_USER_GROUP
	/// </summary>
	public partial class SYS_USER_GROUP
	{
		public SYS_USER_GROUP()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.SYS_USER_GROUP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SYS_USER_GROUP(");
			strSql.Append("CompanyCode,UserGroupNo,UserGroupName,Description,AllowUsed)");
			strSql.Append(" values (");
			strSql.Append("@CompanyCode,@UserGroupNo,@UserGroupName,@Description,@AllowUsed)");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,10),
					new SqlParameter("@UserGroupNo", SqlDbType.NVarChar,12),
					new SqlParameter("@UserGroupName", SqlDbType.NVarChar,20),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@AllowUsed", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.CompanyCode;
			parameters[1].Value = model.UserGroupNo;
			parameters[2].Value = model.UserGroupName;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.AllowUsed;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(MyERP.Model.SYS_USER_GROUP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SYS_USER_GROUP set ");
			strSql.Append("CompanyCode=@CompanyCode,");
			strSql.Append("UserGroupNo=@UserGroupNo,");
			strSql.Append("UserGroupName=@UserGroupName,");
			strSql.Append("Description=@Description,");
			strSql.Append("AllowUsed=@AllowUsed");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,10),
					new SqlParameter("@UserGroupNo", SqlDbType.NVarChar,12),
					new SqlParameter("@UserGroupName", SqlDbType.NVarChar,20),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@AllowUsed", SqlDbType.NVarChar,1)};
			parameters[0].Value = model.CompanyCode;
			parameters[1].Value = model.UserGroupNo;
			parameters[2].Value = model.UserGroupName;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.AllowUsed;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SYS_USER_GROUP ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public MyERP.Model.SYS_USER_GROUP GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CompanyCode,UserGroupNo,UserGroupName,Description,AllowUsed from SYS_USER_GROUP ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.SYS_USER_GROUP model=new MyERP.Model.SYS_USER_GROUP();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public MyERP.Model.SYS_USER_GROUP DataRowToModel(DataRow row)
		{
			MyERP.Model.SYS_USER_GROUP model=new MyERP.Model.SYS_USER_GROUP();
			if (row != null)
			{
				if(row["CompanyCode"]!=null)
				{
					model.CompanyCode=row["CompanyCode"].ToString();
				}
				if(row["UserGroupNo"]!=null)
				{
					model.UserGroupNo=row["UserGroupNo"].ToString();
				}
				if(row["UserGroupName"]!=null)
				{
					model.UserGroupName=row["UserGroupName"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["AllowUsed"]!=null)
				{
					model.AllowUsed=row["AllowUsed"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CompanyCode,UserGroupNo,UserGroupName,Description,AllowUsed ");
			strSql.Append(" FROM SYS_USER_GROUP ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" CompanyCode,UserGroupNo,UserGroupName,Description,AllowUsed ");
			strSql.Append(" FROM SYS_USER_GROUP ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM SYS_USER_GROUP ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.tempid desc");
			}
			strSql.Append(")AS Row, T.*  from SYS_USER_GROUP T ");
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
			parameters[0].Value = "SYS_USER_GROUP";
			parameters[1].Value = "tempid";
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

