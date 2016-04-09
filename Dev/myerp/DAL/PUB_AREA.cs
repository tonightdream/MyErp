using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_AREA
	/// </summary>
	public partial class PUB_AREA
	{
		public PUB_AREA()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string AREA_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PUB_AREA");
			strSql.Append(" where AREA_CODE=@AREA_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@AREA_CODE", SqlDbType.VarChar,12)			};
			parameters[0].Value = AREA_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_AREA model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_AREA(");
			strSql.Append("COMPANY_CODE,AREA_CODE,AREA_NAME,PARENT_AREA_CODE,MANAGER,ALLOW_USERED,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE)");
			strSql.Append(" values (");
			strSql.Append("@COMPANY_CODE,@AREA_CODE,@AREA_NAME,@PARENT_AREA_CODE,@MANAGER,@ALLOW_USERED,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE)");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.VarChar,10),
					new SqlParameter("@AREA_CODE", SqlDbType.VarChar,12),
					new SqlParameter("@AREA_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@PARENT_AREA_CODE", SqlDbType.VarChar,12),
					new SqlParameter("@MANAGER", SqlDbType.VarChar,12),
					new SqlParameter("@ALLOW_USERED", SqlDbType.VarChar,1),
					new SqlParameter("@CREATE_NAME", SqlDbType.NChar,10),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NChar,10),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.AREA_CODE;
			parameters[2].Value = model.AREA_NAME;
			parameters[3].Value = model.PARENT_AREA_CODE;
			parameters[4].Value = model.MANAGER;
			parameters[5].Value = model.ALLOW_USERED;
			parameters[6].Value = model.CREATE_NAME;
			parameters[7].Value = model.CREATE_DATE;
			parameters[8].Value = model.UPDATE_NAME;
			parameters[9].Value = model.UPDATE_DATE;

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
		public bool Update(MyERP.Model.PUB_AREA model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_AREA set ");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("AREA_NAME=@AREA_NAME,");
			strSql.Append("PARENT_AREA_CODE=@PARENT_AREA_CODE,");
			strSql.Append("MANAGER=@MANAGER,");
			strSql.Append("ALLOW_USERED=@ALLOW_USERED,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE");
			strSql.Append(" where AREA_CODE=@AREA_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.VarChar,10),
					new SqlParameter("@AREA_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@PARENT_AREA_CODE", SqlDbType.VarChar,12),
					new SqlParameter("@MANAGER", SqlDbType.VarChar,12),
					new SqlParameter("@ALLOW_USERED", SqlDbType.VarChar,1),
					new SqlParameter("@CREATE_NAME", SqlDbType.NChar,10),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NChar,10),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@AREA_CODE", SqlDbType.VarChar,12)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.AREA_NAME;
			parameters[2].Value = model.PARENT_AREA_CODE;
			parameters[3].Value = model.MANAGER;
			parameters[4].Value = model.ALLOW_USERED;
			parameters[5].Value = model.CREATE_NAME;
			parameters[6].Value = model.CREATE_DATE;
			parameters[7].Value = model.UPDATE_NAME;
			parameters[8].Value = model.UPDATE_DATE;
			parameters[9].Value = model.AREA_CODE;

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
		public bool Delete(string AREA_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_AREA ");
			strSql.Append(" where AREA_CODE=@AREA_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@AREA_CODE", SqlDbType.VarChar,12)			};
			parameters[0].Value = AREA_CODE;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string AREA_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_AREA ");
			strSql.Append(" where AREA_CODE in ("+AREA_CODElist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public MyERP.Model.PUB_AREA GetModel(string AREA_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 COMPANY_CODE,AREA_CODE,AREA_NAME,PARENT_AREA_CODE,MANAGER,ALLOW_USERED,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE from PUB_AREA ");
			strSql.Append(" where AREA_CODE=@AREA_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@AREA_CODE", SqlDbType.VarChar,12)			};
			parameters[0].Value = AREA_CODE;

			MyERP.Model.PUB_AREA model=new MyERP.Model.PUB_AREA();
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
		public MyERP.Model.PUB_AREA DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_AREA model=new MyERP.Model.PUB_AREA();
			if (row != null)
			{
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
				}
				if(row["AREA_CODE"]!=null)
				{
					model.AREA_CODE=row["AREA_CODE"].ToString();
				}
				if(row["AREA_NAME"]!=null)
				{
					model.AREA_NAME=row["AREA_NAME"].ToString();
				}
				if(row["PARENT_AREA_CODE"]!=null)
				{
					model.PARENT_AREA_CODE=row["PARENT_AREA_CODE"].ToString();
				}
				if(row["MANAGER"]!=null)
				{
					model.MANAGER=row["MANAGER"].ToString();
				}
				if(row["ALLOW_USERED"]!=null)
				{
					model.ALLOW_USERED=row["ALLOW_USERED"].ToString();
				}
				if(row["CREATE_NAME"]!=null)
				{
					model.CREATE_NAME=row["CREATE_NAME"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["UPDATE_NAME"]!=null)
				{
					model.UPDATE_NAME=row["UPDATE_NAME"].ToString();
				}
				if(row["UPDATE_DATE"]!=null && row["UPDATE_DATE"].ToString()!="")
				{
					model.UPDATE_DATE=DateTime.Parse(row["UPDATE_DATE"].ToString());
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
			strSql.Append("select COMPANY_CODE,AREA_CODE,AREA_NAME,PARENT_AREA_CODE,MANAGER,ALLOW_USERED,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE ");
			strSql.Append(" FROM PUB_AREA ");
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
			strSql.Append(" COMPANY_CODE,AREA_CODE,AREA_NAME,PARENT_AREA_CODE,MANAGER,ALLOW_USERED,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE ");
			strSql.Append(" FROM PUB_AREA ");
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
			strSql.Append("select count(1) FROM PUB_AREA ");
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
				strSql.Append("order by T.AREA_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUB_AREA T ");
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
			parameters[0].Value = "PUB_AREA";
			parameters[1].Value = "AREA_CODE";
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

