using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_CUSTOM
	/// </summary>
	public partial class PUB_CUSTOM
	{
		public PUB_CUSTOM()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string CUSTOM_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PUB_CUSTOM");
			strSql.Append(" where CUSTOM_CODE=@CUSTOM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@CUSTOM_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = CUSTOM_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_CUSTOM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_CUSTOM(");
			strSql.Append("CUSTOM_CODE,CUSTOM_NAME,CREDIT_LIMIT,ORG_CODE,PARENT_CUSTOM_CODE,CREDIT_AMOUNT,CUSTOM_TYPE_CODE,FULL_NAME,SALE_MAN,FAX,MANAGER,ADDRESS,TELPHIONE,ZIP,EMAIL,HTTP,VIPCARD_CODE,VIPCARD_NAME,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@CUSTOM_CODE,@CUSTOM_NAME,@CREDIT_LIMIT,@ORG_CODE,@PARENT_CUSTOM_CODE,@CREDIT_AMOUNT,@CUSTOM_TYPE_CODE,@FULL_NAME,@SALE_MAN,@FAX,@MANAGER,@ADDRESS,@TELPHIONE,@ZIP,@EMAIL,@HTTP,@VIPCARD_CODE,@VIPCARD_NAME,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@CUSTOM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREDIT_LIMIT", SqlDbType.NChar,10),
					new SqlParameter("@ORG_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_CUSTOM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@CREDIT_AMOUNT", SqlDbType.Float,8),
					new SqlParameter("@CUSTOM_TYPE_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@FULL_NAME", SqlDbType.NVarChar,80),
					new SqlParameter("@SALE_MAN", SqlDbType.NVarChar,20),
					new SqlParameter("@FAX", SqlDbType.NVarChar,30),
					new SqlParameter("@MANAGER", SqlDbType.NVarChar,50),
					new SqlParameter("@ADDRESS", SqlDbType.NVarChar,50),
					new SqlParameter("@TELPHIONE", SqlDbType.NVarChar,50),
					new SqlParameter("@ZIP", SqlDbType.NVarChar,50),
					new SqlParameter("@EMAIL", SqlDbType.NVarChar,50),
					new SqlParameter("@HTTP", SqlDbType.NVarChar,50),
					new SqlParameter("@VIPCARD_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@VIPCARD_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.NVarChar,50),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.NVarChar,50),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.CUSTOM_CODE;
			parameters[1].Value = model.CUSTOM_NAME;
			parameters[2].Value = model.CREDIT_LIMIT;
			parameters[3].Value = model.ORG_CODE;
			parameters[4].Value = model.PARENT_CUSTOM_CODE;
			parameters[5].Value = model.CREDIT_AMOUNT;
			parameters[6].Value = model.CUSTOM_TYPE_CODE;
			parameters[7].Value = model.FULL_NAME;
			parameters[8].Value = model.SALE_MAN;
			parameters[9].Value = model.FAX;
			parameters[10].Value = model.MANAGER;
			parameters[11].Value = model.ADDRESS;
			parameters[12].Value = model.TELPHIONE;
			parameters[13].Value = model.ZIP;
			parameters[14].Value = model.EMAIL;
			parameters[15].Value = model.HTTP;
			parameters[16].Value = model.VIPCARD_CODE;
			parameters[17].Value = model.VIPCARD_NAME;
			parameters[18].Value = model.CREATE_NAME;
			parameters[19].Value = model.CREATE_DATE;
			parameters[20].Value = model.UPDATE_NAME;
			parameters[21].Value = model.UPDATE_DATE;
			parameters[22].Value = model.REMARK;

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
		public bool Update(MyERP.Model.PUB_CUSTOM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_CUSTOM set ");
			strSql.Append("CUSTOM_NAME=@CUSTOM_NAME,");
			strSql.Append("CREDIT_LIMIT=@CREDIT_LIMIT,");
			strSql.Append("ORG_CODE=@ORG_CODE,");
			strSql.Append("PARENT_CUSTOM_CODE=@PARENT_CUSTOM_CODE,");
			strSql.Append("CREDIT_AMOUNT=@CREDIT_AMOUNT,");
			strSql.Append("CUSTOM_TYPE_CODE=@CUSTOM_TYPE_CODE,");
			strSql.Append("FULL_NAME=@FULL_NAME,");
			strSql.Append("SALE_MAN=@SALE_MAN,");
			strSql.Append("FAX=@FAX,");
			strSql.Append("MANAGER=@MANAGER,");
			strSql.Append("ADDRESS=@ADDRESS,");
			strSql.Append("TELPHIONE=@TELPHIONE,");
			strSql.Append("ZIP=@ZIP,");
			strSql.Append("EMAIL=@EMAIL,");
			strSql.Append("HTTP=@HTTP,");
			strSql.Append("VIPCARD_CODE=@VIPCARD_CODE,");
			strSql.Append("VIPCARD_NAME=@VIPCARD_NAME,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where CUSTOM_CODE=@CUSTOM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@CUSTOM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREDIT_LIMIT", SqlDbType.NChar,10),
					new SqlParameter("@ORG_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_CUSTOM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@CREDIT_AMOUNT", SqlDbType.Float,8),
					new SqlParameter("@CUSTOM_TYPE_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@FULL_NAME", SqlDbType.NVarChar,80),
					new SqlParameter("@SALE_MAN", SqlDbType.NVarChar,20),
					new SqlParameter("@FAX", SqlDbType.NVarChar,30),
					new SqlParameter("@MANAGER", SqlDbType.NVarChar,50),
					new SqlParameter("@ADDRESS", SqlDbType.NVarChar,50),
					new SqlParameter("@TELPHIONE", SqlDbType.NVarChar,50),
					new SqlParameter("@ZIP", SqlDbType.NVarChar,50),
					new SqlParameter("@EMAIL", SqlDbType.NVarChar,50),
					new SqlParameter("@HTTP", SqlDbType.NVarChar,50),
					new SqlParameter("@VIPCARD_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@VIPCARD_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.NVarChar,50),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.NVarChar,50),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.CUSTOM_NAME;
			parameters[1].Value = model.CREDIT_LIMIT;
			parameters[2].Value = model.ORG_CODE;
			parameters[3].Value = model.PARENT_CUSTOM_CODE;
			parameters[4].Value = model.CREDIT_AMOUNT;
			parameters[5].Value = model.CUSTOM_TYPE_CODE;
			parameters[6].Value = model.FULL_NAME;
			parameters[7].Value = model.SALE_MAN;
			parameters[8].Value = model.FAX;
			parameters[9].Value = model.MANAGER;
			parameters[10].Value = model.ADDRESS;
			parameters[11].Value = model.TELPHIONE;
			parameters[12].Value = model.ZIP;
			parameters[13].Value = model.EMAIL;
			parameters[14].Value = model.HTTP;
			parameters[15].Value = model.VIPCARD_CODE;
			parameters[16].Value = model.VIPCARD_NAME;
			parameters[17].Value = model.CREATE_NAME;
			parameters[18].Value = model.CREATE_DATE;
			parameters[19].Value = model.UPDATE_NAME;
			parameters[20].Value = model.UPDATE_DATE;
			parameters[21].Value = model.REMARK;
			parameters[22].Value = model.CUSTOM_CODE;

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
		public bool Delete(string CUSTOM_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_CUSTOM ");
			strSql.Append(" where CUSTOM_CODE=@CUSTOM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@CUSTOM_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = CUSTOM_CODE;

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
		public bool DeleteList(string CUSTOM_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_CUSTOM ");
			strSql.Append(" where CUSTOM_CODE in ("+CUSTOM_CODElist + ")  ");
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
		public MyERP.Model.PUB_CUSTOM GetModel(string CUSTOM_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CUSTOM_CODE,CUSTOM_NAME,CREDIT_LIMIT,ORG_CODE,PARENT_CUSTOM_CODE,CREDIT_AMOUNT,CUSTOM_TYPE_CODE,FULL_NAME,SALE_MAN,FAX,MANAGER,ADDRESS,TELPHIONE,ZIP,EMAIL,HTTP,VIPCARD_CODE,VIPCARD_NAME,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from PUB_CUSTOM ");
			strSql.Append(" where CUSTOM_CODE=@CUSTOM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@CUSTOM_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = CUSTOM_CODE;

			MyERP.Model.PUB_CUSTOM model=new MyERP.Model.PUB_CUSTOM();
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
		public MyERP.Model.PUB_CUSTOM DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_CUSTOM model=new MyERP.Model.PUB_CUSTOM();
			if (row != null)
			{
				if(row["CUSTOM_CODE"]!=null)
				{
					model.CUSTOM_CODE=row["CUSTOM_CODE"].ToString();
				}
				if(row["CUSTOM_NAME"]!=null)
				{
					model.CUSTOM_NAME=row["CUSTOM_NAME"].ToString();
				}
				if(row["CREDIT_LIMIT"]!=null)
				{
					model.CREDIT_LIMIT=row["CREDIT_LIMIT"].ToString();
				}
				if(row["ORG_CODE"]!=null)
				{
					model.ORG_CODE=row["ORG_CODE"].ToString();
				}
				if(row["PARENT_CUSTOM_CODE"]!=null)
				{
					model.PARENT_CUSTOM_CODE=row["PARENT_CUSTOM_CODE"].ToString();
				}
				if(row["CREDIT_AMOUNT"]!=null && row["CREDIT_AMOUNT"].ToString()!="")
				{
					model.CREDIT_AMOUNT=decimal.Parse(row["CREDIT_AMOUNT"].ToString());
				}
				if(row["CUSTOM_TYPE_CODE"]!=null)
				{
					model.CUSTOM_TYPE_CODE=row["CUSTOM_TYPE_CODE"].ToString();
				}
				if(row["FULL_NAME"]!=null)
				{
					model.FULL_NAME=row["FULL_NAME"].ToString();
				}
				if(row["SALE_MAN"]!=null)
				{
					model.SALE_MAN=row["SALE_MAN"].ToString();
				}
				if(row["FAX"]!=null)
				{
					model.FAX=row["FAX"].ToString();
				}
				if(row["MANAGER"]!=null)
				{
					model.MANAGER=row["MANAGER"].ToString();
				}
				if(row["ADDRESS"]!=null)
				{
					model.ADDRESS=row["ADDRESS"].ToString();
				}
				if(row["TELPHIONE"]!=null)
				{
					model.TELPHIONE=row["TELPHIONE"].ToString();
				}
				if(row["ZIP"]!=null)
				{
					model.ZIP=row["ZIP"].ToString();
				}
				if(row["EMAIL"]!=null)
				{
					model.EMAIL=row["EMAIL"].ToString();
				}
				if(row["HTTP"]!=null)
				{
					model.HTTP=row["HTTP"].ToString();
				}
				if(row["VIPCARD_CODE"]!=null)
				{
					model.VIPCARD_CODE=row["VIPCARD_CODE"].ToString();
				}
				if(row["VIPCARD_NAME"]!=null)
				{
					model.VIPCARD_NAME=row["VIPCARD_NAME"].ToString();
				}
				if(row["CREATE_NAME"]!=null)
				{
					model.CREATE_NAME=row["CREATE_NAME"].ToString();
				}
				if(row["CREATE_DATE"]!=null)
				{
					model.CREATE_DATE=row["CREATE_DATE"].ToString();
				}
				if(row["UPDATE_NAME"]!=null)
				{
					model.UPDATE_NAME=row["UPDATE_NAME"].ToString();
				}
				if(row["UPDATE_DATE"]!=null)
				{
					model.UPDATE_DATE=row["UPDATE_DATE"].ToString();
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
			strSql.Append("select CUSTOM_CODE,CUSTOM_NAME,CREDIT_LIMIT,ORG_CODE,PARENT_CUSTOM_CODE,CREDIT_AMOUNT,CUSTOM_TYPE_CODE,FULL_NAME,SALE_MAN,FAX,MANAGER,ADDRESS,TELPHIONE,ZIP,EMAIL,HTTP,VIPCARD_CODE,VIPCARD_NAME,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_CUSTOM ");
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
			strSql.Append(" CUSTOM_CODE,CUSTOM_NAME,CREDIT_LIMIT,ORG_CODE,PARENT_CUSTOM_CODE,CREDIT_AMOUNT,CUSTOM_TYPE_CODE,FULL_NAME,SALE_MAN,FAX,MANAGER,ADDRESS,TELPHIONE,ZIP,EMAIL,HTTP,VIPCARD_CODE,VIPCARD_NAME,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_CUSTOM ");
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
			strSql.Append("select count(1) FROM PUB_CUSTOM ");
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
				strSql.Append("order by T.CUSTOM_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUB_CUSTOM T ");
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
			parameters[0].Value = "PUB_CUSTOM";
			parameters[1].Value = "CUSTOM_CODE";
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

