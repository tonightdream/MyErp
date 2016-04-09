﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_PAYMENT_TYPE
	/// </summary>
	public partial class PUB_PAYMENT_TYPE
	{
		public PUB_PAYMENT_TYPE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PAYMENT_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PUB_PAYMENT_TYPE");
			strSql.Append(" where PAYMENT_CODE=@PAYMENT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@PAYMENT_CODE", SqlDbType.NVarChar,30)			};
			parameters[0].Value = PAYMENT_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_PAYMENT_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_PAYMENT_TYPE(");
			strSql.Append("COMPANY_CODE,PAYMENT_CODE,PAYMENT_NAME,DESC,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@COMPANY_CODE,@PAYMENT_CODE,@PAYMENT_NAME,@DESC,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,30),
					new SqlParameter("@PAYMENT_CODE", SqlDbType.NVarChar,30),
					new SqlParameter("@PAYMENT_NAME", SqlDbType.NVarChar,30),
					new SqlParameter("@DESC", SqlDbType.NVarChar,40),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,20),
					new SqlParameter("@CREATE_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NVarChar,20),
					new SqlParameter("@UPDATE_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.PAYMENT_CODE;
			parameters[2].Value = model.PAYMENT_NAME;
			parameters[3].Value = model.DESC;
			parameters[4].Value = model.CREATE_NAME;
			parameters[5].Value = model.CREATE_DATE;
			parameters[6].Value = model.UPDATE_NAME;
			parameters[7].Value = model.UPDATE_DATE;
			parameters[8].Value = model.REMARK;

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
		public bool Update(MyERP.Model.PUB_PAYMENT_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_PAYMENT_TYPE set ");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("PAYMENT_NAME=@PAYMENT_NAME,");
			strSql.Append("DESC=@DESC,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where PAYMENT_CODE=@PAYMENT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,30),
					new SqlParameter("@PAYMENT_NAME", SqlDbType.NVarChar,30),
					new SqlParameter("@DESC", SqlDbType.NVarChar,40),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,20),
					new SqlParameter("@CREATE_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NVarChar,20),
					new SqlParameter("@UPDATE_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50),
					new SqlParameter("@PAYMENT_CODE", SqlDbType.NVarChar,30)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.PAYMENT_NAME;
			parameters[2].Value = model.DESC;
			parameters[3].Value = model.CREATE_NAME;
			parameters[4].Value = model.CREATE_DATE;
			parameters[5].Value = model.UPDATE_NAME;
			parameters[6].Value = model.UPDATE_DATE;
			parameters[7].Value = model.REMARK;
			parameters[8].Value = model.PAYMENT_CODE;

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
		public bool Delete(string PAYMENT_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_PAYMENT_TYPE ");
			strSql.Append(" where PAYMENT_CODE=@PAYMENT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@PAYMENT_CODE", SqlDbType.NVarChar,30)			};
			parameters[0].Value = PAYMENT_CODE;

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
		public bool DeleteList(string PAYMENT_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_PAYMENT_TYPE ");
			strSql.Append(" where PAYMENT_CODE in ("+PAYMENT_CODElist + ")  ");
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
		public MyERP.Model.PUB_PAYMENT_TYPE GetModel(string PAYMENT_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 COMPANY_CODE,PAYMENT_CODE,PAYMENT_NAME,DESC,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from PUB_PAYMENT_TYPE ");
			strSql.Append(" where PAYMENT_CODE=@PAYMENT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@PAYMENT_CODE", SqlDbType.NVarChar,30)			};
			parameters[0].Value = PAYMENT_CODE;

			MyERP.Model.PUB_PAYMENT_TYPE model=new MyERP.Model.PUB_PAYMENT_TYPE();
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
		public MyERP.Model.PUB_PAYMENT_TYPE DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_PAYMENT_TYPE model=new MyERP.Model.PUB_PAYMENT_TYPE();
			if (row != null)
			{
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
				}
				if(row["PAYMENT_CODE"]!=null)
				{
					model.PAYMENT_CODE=row["PAYMENT_CODE"].ToString();
				}
				if(row["PAYMENT_NAME"]!=null)
				{
					model.PAYMENT_NAME=row["PAYMENT_NAME"].ToString();
				}
				if(row["DESC"]!=null)
				{
					model.DESC=row["DESC"].ToString();
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
				if(row["REMARK"]!=null)
				{
					model.REMARK=row["REMARK"].ToString();
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
			strSql.Append("select COMPANY_CODE,PAYMENT_CODE,PAYMENT_NAME,DESC,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_PAYMENT_TYPE ");
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
			strSql.Append(" COMPANY_CODE,PAYMENT_CODE,PAYMENT_NAME,DESC,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_PAYMENT_TYPE ");
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
			strSql.Append("select count(1) FROM PUB_PAYMENT_TYPE ");
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
				strSql.Append("order by T.PAYMENT_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUB_PAYMENT_TYPE T ");
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
			parameters[0].Value = "PUB_PAYMENT_TYPE";
			parameters[1].Value = "PAYMENT_CODE";
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

