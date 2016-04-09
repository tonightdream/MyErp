using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_ITEM_TYPE
	/// </summary>
	public partial class PUB_ITEM_TYPE
	{
		public PUB_ITEM_TYPE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string TYPE_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PUB_ITEM_TYPE");
			strSql.Append(" where TYPE_CODE=@TYPE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@TYPE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = TYPE_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_ITEM_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_ITEM_TYPE(");
			strSql.Append("INTERNAL_CODE,COMPANY_CODE,COMPANY_NAME,TYPE_CODE,TYPE_NAME,PARENT_TYPE_CODE,CREATE_NAME,CREATE_DATE,ALLOW_used)");
			strSql.Append(" values (");
			strSql.Append("@INTERNAL_CODE,@COMPANY_CODE,@COMPANY_NAME,@TYPE_CODE,@TYPE_NAME,@PARENT_TYPE_CODE,@CREATE_NAME,@CREATE_DATE,@ALLOW_used)");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@COMPANY_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@TYPE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@TYPE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@PARENT_TYPE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@ALLOW_used", SqlDbType.Bit,1)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.COMPANY_CODE;
			parameters[2].Value = model.COMPANY_NAME;
			parameters[3].Value = model.TYPE_CODE;
			parameters[4].Value = model.TYPE_NAME;
			parameters[5].Value = model.PARENT_TYPE_CODE;
			parameters[6].Value = model.CREATE_NAME;
			parameters[7].Value = model.CREATE_DATE;
			parameters[8].Value = model.ALLOW_used;

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
		public bool Update(MyERP.Model.PUB_ITEM_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_ITEM_TYPE set ");
			strSql.Append("INTERNAL_CODE=@INTERNAL_CODE,");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("COMPANY_NAME=@COMPANY_NAME,");
			strSql.Append("TYPE_NAME=@TYPE_NAME,");
			strSql.Append("PARENT_TYPE_CODE=@PARENT_TYPE_CODE,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("ALLOW_used=@ALLOW_used");
			strSql.Append(" where TYPE_CODE=@TYPE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@COMPANY_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@TYPE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@PARENT_TYPE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@ALLOW_used", SqlDbType.Bit,1),
					new SqlParameter("@TYPE_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.COMPANY_CODE;
			parameters[2].Value = model.COMPANY_NAME;
			parameters[3].Value = model.TYPE_NAME;
			parameters[4].Value = model.PARENT_TYPE_CODE;
			parameters[5].Value = model.CREATE_NAME;
			parameters[6].Value = model.CREATE_DATE;
			parameters[7].Value = model.ALLOW_used;
			parameters[8].Value = model.TYPE_CODE;

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
		public bool Delete(string TYPE_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_ITEM_TYPE ");
			strSql.Append(" where TYPE_CODE=@TYPE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@TYPE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = TYPE_CODE;

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
		public bool DeleteList(string TYPE_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_ITEM_TYPE ");
			strSql.Append(" where TYPE_CODE in ("+TYPE_CODElist + ")  ");
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
		public MyERP.Model.PUB_ITEM_TYPE GetModel(string TYPE_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 INTERNAL_CODE,COMPANY_CODE,COMPANY_NAME,TYPE_CODE,TYPE_NAME,PARENT_TYPE_CODE,CREATE_NAME,CREATE_DATE,ALLOW_used from PUB_ITEM_TYPE ");
			strSql.Append(" where TYPE_CODE=@TYPE_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@TYPE_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = TYPE_CODE;

			MyERP.Model.PUB_ITEM_TYPE model=new MyERP.Model.PUB_ITEM_TYPE();
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
		public MyERP.Model.PUB_ITEM_TYPE DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_ITEM_TYPE model=new MyERP.Model.PUB_ITEM_TYPE();
			if (row != null)
			{
				if(row["INTERNAL_CODE"]!=null)
				{
					model.INTERNAL_CODE=row["INTERNAL_CODE"].ToString();
				}
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
				}
				if(row["COMPANY_NAME"]!=null)
				{
					model.COMPANY_NAME=row["COMPANY_NAME"].ToString();
				}
				if(row["TYPE_CODE"]!=null)
				{
					model.TYPE_CODE=row["TYPE_CODE"].ToString();
				}
				if(row["TYPE_NAME"]!=null)
				{
					model.TYPE_NAME=row["TYPE_NAME"].ToString();
				}
				if(row["PARENT_TYPE_CODE"]!=null)
				{
					model.PARENT_TYPE_CODE=row["PARENT_TYPE_CODE"].ToString();
				}
				if(row["CREATE_NAME"]!=null)
				{
					model.CREATE_NAME=row["CREATE_NAME"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["ALLOW_used"]!=null && row["ALLOW_used"].ToString()!="")
				{
					if((row["ALLOW_used"].ToString()=="1")||(row["ALLOW_used"].ToString().ToLower()=="true"))
					{
						model.ALLOW_used=true;
					}
					else
					{
						model.ALLOW_used=false;
					}
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
			strSql.Append("select INTERNAL_CODE,COMPANY_CODE,COMPANY_NAME,TYPE_CODE,TYPE_NAME,PARENT_TYPE_CODE,CREATE_NAME,CREATE_DATE,ALLOW_used ");
			strSql.Append(" FROM PUB_ITEM_TYPE ");
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
			strSql.Append(" INTERNAL_CODE,COMPANY_CODE,COMPANY_NAME,TYPE_CODE,TYPE_NAME,PARENT_TYPE_CODE,CREATE_NAME,CREATE_DATE,ALLOW_used ");
			strSql.Append(" FROM PUB_ITEM_TYPE ");
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
			strSql.Append("select count(1) FROM PUB_ITEM_TYPE ");
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
				strSql.Append("order by T.TYPE_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUB_ITEM_TYPE T ");
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
			parameters[0].Value = "PUB_ITEM_TYPE";
			parameters[1].Value = "TYPE_CODE";
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

