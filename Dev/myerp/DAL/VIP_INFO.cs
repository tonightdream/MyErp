﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:VIP_INFO
	/// </summary>
	public partial class VIP_INFO
	{
		public VIP_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string VIP_CARD_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from VIP_INFO");
			strSql.Append(" where VIP_CARD_CODE=@VIP_CARD_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@VIP_CARD_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = VIP_CARD_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(MyERP.Model.VIP_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into VIP_INFO(");
			strSql.Append("COMPANY_CODE,USER_CODE,USER_NAME,VIP_CARD_CODE,PASSWORD,BEGIN_DATE,END_DATE,VIP_TYPE,TOTAL_SALES,salesno,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@COMPANY_CODE,@USER_CODE,@USER_NAME,@VIP_CARD_CODE,@PASSWORD,@BEGIN_DATE,@END_DATE,@VIP_TYPE,@TOTAL_SALES,@salesno,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@USER_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@VIP_CARD_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@PASSWORD", SqlDbType.VarChar,10),
					new SqlParameter("@BEGIN_DATE", SqlDbType.DateTime),
					new SqlParameter("@END_DATE", SqlDbType.DateTime),
					new SqlParameter("@VIP_TYPE", SqlDbType.VarChar,20),
					new SqlParameter("@TOTAL_SALES", SqlDbType.Decimal,17),
					new SqlParameter("@salesno", SqlDbType.VarChar,200),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@CREATE_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@UPDATE_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,100)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.USER_CODE;
			parameters[2].Value = model.USER_NAME;
			parameters[3].Value = model.VIP_CARD_CODE;
			parameters[4].Value = model.PASSWORD;
			parameters[5].Value = model.BEGIN_DATE;
			parameters[6].Value = model.END_DATE;
			parameters[7].Value = model.VIP_TYPE;
			parameters[8].Value = model.TOTAL_SALES;
			parameters[9].Value = model.salesno;
			parameters[10].Value = model.CREATE_NAME;
			parameters[11].Value = model.CREATE_DATE;
			parameters[12].Value = model.UPDATE_NAME;
			parameters[13].Value = model.UPDATE_DATE;
			parameters[14].Value = model.REMARK;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToDecimal(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MyERP.Model.VIP_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update VIP_INFO set ");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("USER_CODE=@USER_CODE,");
			strSql.Append("USER_NAME=@USER_NAME,");
			strSql.Append("PASSWORD=@PASSWORD,");
			strSql.Append("BEGIN_DATE=@BEGIN_DATE,");
			strSql.Append("END_DATE=@END_DATE,");
			strSql.Append("VIP_TYPE=@VIP_TYPE,");
			strSql.Append("TOTAL_SALES=@TOTAL_SALES,");
			strSql.Append("salesno=@salesno,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where VIP_TEMP_CARD_CODE=@VIP_TEMP_CARD_CODE");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@USER_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@PASSWORD", SqlDbType.VarChar,10),
					new SqlParameter("@BEGIN_DATE", SqlDbType.DateTime),
					new SqlParameter("@END_DATE", SqlDbType.DateTime),
					new SqlParameter("@VIP_TYPE", SqlDbType.VarChar,20),
					new SqlParameter("@TOTAL_SALES", SqlDbType.Decimal,17),
					new SqlParameter("@salesno", SqlDbType.VarChar,200),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@CREATE_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@UPDATE_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,100),
					new SqlParameter("@VIP_CARD_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@VIP_TEMP_CARD_CODE", SqlDbType.Decimal,9)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.USER_CODE;
			parameters[2].Value = model.USER_NAME;
			parameters[3].Value = model.PASSWORD;
			parameters[4].Value = model.BEGIN_DATE;
			parameters[5].Value = model.END_DATE;
			parameters[6].Value = model.VIP_TYPE;
			parameters[7].Value = model.TOTAL_SALES;
			parameters[8].Value = model.salesno;
			parameters[9].Value = model.CREATE_NAME;
			parameters[10].Value = model.CREATE_DATE;
			parameters[11].Value = model.UPDATE_NAME;
			parameters[12].Value = model.UPDATE_DATE;
			parameters[13].Value = model.REMARK;
			parameters[14].Value = model.VIP_CARD_CODE;
			parameters[15].Value = model.VIP_TEMP_CARD_CODE;

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
		public bool Delete(decimal VIP_TEMP_CARD_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from VIP_INFO ");
			strSql.Append(" where VIP_TEMP_CARD_CODE=@VIP_TEMP_CARD_CODE");
			SqlParameter[] parameters = {
					new SqlParameter("@VIP_TEMP_CARD_CODE", SqlDbType.Decimal)
			};
			parameters[0].Value = VIP_TEMP_CARD_CODE;

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
		public bool Delete(string VIP_CARD_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from VIP_INFO ");
			strSql.Append(" where VIP_CARD_CODE=@VIP_CARD_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@VIP_CARD_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = VIP_CARD_CODE;

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
		public bool DeleteList(string VIP_TEMP_CARD_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from VIP_INFO ");
			strSql.Append(" where VIP_TEMP_CARD_CODE in ("+VIP_TEMP_CARD_CODElist + ")  ");
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
		public MyERP.Model.VIP_INFO GetModel(decimal VIP_TEMP_CARD_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 COMPANY_CODE,USER_CODE,USER_NAME,VIP_CARD_CODE,VIP_TEMP_CARD_CODE,PASSWORD,BEGIN_DATE,END_DATE,VIP_TYPE,TOTAL_SALES,salesno,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from VIP_INFO ");
			strSql.Append(" where VIP_TEMP_CARD_CODE=@VIP_TEMP_CARD_CODE");
			SqlParameter[] parameters = {
					new SqlParameter("@VIP_TEMP_CARD_CODE", SqlDbType.Decimal)
			};
			parameters[0].Value = VIP_TEMP_CARD_CODE;

			MyERP.Model.VIP_INFO model=new MyERP.Model.VIP_INFO();
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
		public MyERP.Model.VIP_INFO DataRowToModel(DataRow row)
		{
			MyERP.Model.VIP_INFO model=new MyERP.Model.VIP_INFO();
			if (row != null)
			{
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
				}
				if(row["USER_CODE"]!=null)
				{
					model.USER_CODE=row["USER_CODE"].ToString();
				}
				if(row["USER_NAME"]!=null)
				{
					model.USER_NAME=row["USER_NAME"].ToString();
				}
				if(row["VIP_CARD_CODE"]!=null)
				{
					model.VIP_CARD_CODE=row["VIP_CARD_CODE"].ToString();
				}
				if(row["VIP_TEMP_CARD_CODE"]!=null && row["VIP_TEMP_CARD_CODE"].ToString()!="")
				{
					model.VIP_TEMP_CARD_CODE=decimal.Parse(row["VIP_TEMP_CARD_CODE"].ToString());
				}
				if(row["PASSWORD"]!=null)
				{
					model.PASSWORD=row["PASSWORD"].ToString();
				}
				if(row["BEGIN_DATE"]!=null && row["BEGIN_DATE"].ToString()!="")
				{
					model.BEGIN_DATE=DateTime.Parse(row["BEGIN_DATE"].ToString());
				}
				if(row["END_DATE"]!=null && row["END_DATE"].ToString()!="")
				{
					model.END_DATE=DateTime.Parse(row["END_DATE"].ToString());
				}
				if(row["VIP_TYPE"]!=null)
				{
					model.VIP_TYPE=row["VIP_TYPE"].ToString();
				}
				if(row["TOTAL_SALES"]!=null && row["TOTAL_SALES"].ToString()!="")
				{
					model.TOTAL_SALES=decimal.Parse(row["TOTAL_SALES"].ToString());
				}
				if(row["salesno"]!=null)
				{
					model.salesno=row["salesno"].ToString();
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
			strSql.Append("select COMPANY_CODE,USER_CODE,USER_NAME,VIP_CARD_CODE,VIP_TEMP_CARD_CODE,PASSWORD,BEGIN_DATE,END_DATE,VIP_TYPE,TOTAL_SALES,salesno,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM VIP_INFO ");
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
			strSql.Append(" COMPANY_CODE,USER_CODE,USER_NAME,VIP_CARD_CODE,VIP_TEMP_CARD_CODE,PASSWORD,BEGIN_DATE,END_DATE,VIP_TYPE,TOTAL_SALES,salesno,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM VIP_INFO ");
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
			strSql.Append("select count(1) FROM VIP_INFO ");
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
				strSql.Append("order by T.VIP_TEMP_CARD_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from VIP_INFO T ");
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
			parameters[0].Value = "VIP_INFO";
			parameters[1].Value = "VIP_TEMP_CARD_CODE";
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

