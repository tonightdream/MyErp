using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:STEEL_GG
	/// </summary>
	public partial class STEEL_GG
	{
		public STEEL_GG()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string INTERNAL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from STEEL_GG");
			strSql.Append(" where INTERNAL_CODE=@INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = INTERNAL_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.STEEL_GG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into STEEL_GG(");
			strSql.Append("INTERNAL_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,PARENT_DEPARTMENT_CODE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,SPECIFICATIONS,HD,KD,QUANTITY,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@INTERNAL_CODE,@DEPARTMENT_CODE,@DEPARTMENT_NAME,@PARENT_DEPARTMENT_CODE,@ITEM_INTERNAL_CODE,@ITEM_CODE,@ITEM_NAME,@SPECIFICATIONS,@HD,@KD,@QUANTITY,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,12),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.NVarChar,80),
					new SqlParameter("@PARENT_DEPARTMENT_CODE", SqlDbType.NVarChar,12),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.NVarChar,50),
					new SqlParameter("@HD", SqlDbType.Float,8),
					new SqlParameter("@KD", SqlDbType.Float,8),
					new SqlParameter("@QUANTITY", SqlDbType.Float,8),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.DEPARTMENT_CODE;
			parameters[2].Value = model.DEPARTMENT_NAME;
			parameters[3].Value = model.PARENT_DEPARTMENT_CODE;
			parameters[4].Value = model.ITEM_INTERNAL_CODE;
			parameters[5].Value = model.ITEM_CODE;
			parameters[6].Value = model.ITEM_NAME;
			parameters[7].Value = model.SPECIFICATIONS;
			parameters[8].Value = model.HD;
			parameters[9].Value = model.KD;
			parameters[10].Value = model.QUANTITY;
			parameters[11].Value = model.CREATE_NAME;
			parameters[12].Value = model.CREATE_DATE;
			parameters[13].Value = model.UPDATE_NAME;
			parameters[14].Value = model.UPDATE_DATE;
			parameters[15].Value = model.REMARK;

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
		public bool Update(MyERP.Model.STEEL_GG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update STEEL_GG set ");
			strSql.Append("DEPARTMENT_CODE=@DEPARTMENT_CODE,");
			strSql.Append("DEPARTMENT_NAME=@DEPARTMENT_NAME,");
			strSql.Append("PARENT_DEPARTMENT_CODE=@PARENT_DEPARTMENT_CODE,");
			strSql.Append("ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE,");
			strSql.Append("ITEM_CODE=@ITEM_CODE,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("SPECIFICATIONS=@SPECIFICATIONS,");
			strSql.Append("HD=@HD,");
			strSql.Append("KD=@KD,");
			strSql.Append("QUANTITY=@QUANTITY,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where INTERNAL_CODE=@INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,12),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.NVarChar,80),
					new SqlParameter("@PARENT_DEPARTMENT_CODE", SqlDbType.NVarChar,12),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.NVarChar,50),
					new SqlParameter("@HD", SqlDbType.Float,8),
					new SqlParameter("@KD", SqlDbType.Float,8),
					new SqlParameter("@QUANTITY", SqlDbType.Float,8),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200),
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.DEPARTMENT_CODE;
			parameters[1].Value = model.DEPARTMENT_NAME;
			parameters[2].Value = model.PARENT_DEPARTMENT_CODE;
			parameters[3].Value = model.ITEM_INTERNAL_CODE;
			parameters[4].Value = model.ITEM_CODE;
			parameters[5].Value = model.ITEM_NAME;
			parameters[6].Value = model.SPECIFICATIONS;
			parameters[7].Value = model.HD;
			parameters[8].Value = model.KD;
			parameters[9].Value = model.QUANTITY;
			parameters[10].Value = model.CREATE_NAME;
			parameters[11].Value = model.CREATE_DATE;
			parameters[12].Value = model.UPDATE_NAME;
			parameters[13].Value = model.UPDATE_DATE;
			parameters[14].Value = model.REMARK;
			parameters[15].Value = model.INTERNAL_CODE;

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
		public bool Delete(string INTERNAL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STEEL_GG ");
			strSql.Append(" where INTERNAL_CODE=@INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = INTERNAL_CODE;

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
		public bool DeleteList(string INTERNAL_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STEEL_GG ");
			strSql.Append(" where INTERNAL_CODE in ("+INTERNAL_CODElist + ")  ");
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
		public MyERP.Model.STEEL_GG GetModel(string INTERNAL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 INTERNAL_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,PARENT_DEPARTMENT_CODE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,SPECIFICATIONS,HD,KD,QUANTITY,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from STEEL_GG ");
			strSql.Append(" where INTERNAL_CODE=@INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = INTERNAL_CODE;

			MyERP.Model.STEEL_GG model=new MyERP.Model.STEEL_GG();
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
		public MyERP.Model.STEEL_GG DataRowToModel(DataRow row)
		{
			MyERP.Model.STEEL_GG model=new MyERP.Model.STEEL_GG();
			if (row != null)
			{
				if(row["INTERNAL_CODE"]!=null)
				{
					model.INTERNAL_CODE=row["INTERNAL_CODE"].ToString();
				}
				if(row["DEPARTMENT_CODE"]!=null)
				{
					model.DEPARTMENT_CODE=row["DEPARTMENT_CODE"].ToString();
				}
				if(row["DEPARTMENT_NAME"]!=null)
				{
					model.DEPARTMENT_NAME=row["DEPARTMENT_NAME"].ToString();
				}
				if(row["PARENT_DEPARTMENT_CODE"]!=null)
				{
					model.PARENT_DEPARTMENT_CODE=row["PARENT_DEPARTMENT_CODE"].ToString();
				}
				if(row["ITEM_INTERNAL_CODE"]!=null)
				{
					model.ITEM_INTERNAL_CODE=row["ITEM_INTERNAL_CODE"].ToString();
				}
				if(row["ITEM_CODE"]!=null)
				{
					model.ITEM_CODE=row["ITEM_CODE"].ToString();
				}
				if(row["ITEM_NAME"]!=null)
				{
					model.ITEM_NAME=row["ITEM_NAME"].ToString();
				}
				if(row["SPECIFICATIONS"]!=null)
				{
					model.SPECIFICATIONS=row["SPECIFICATIONS"].ToString();
				}
				if(row["HD"]!=null && row["HD"].ToString()!="")
				{
					model.HD=decimal.Parse(row["HD"].ToString());
				}
				if(row["KD"]!=null && row["KD"].ToString()!="")
				{
					model.KD=decimal.Parse(row["KD"].ToString());
				}
				if(row["QUANTITY"]!=null && row["QUANTITY"].ToString()!="")
				{
					model.QUANTITY=decimal.Parse(row["QUANTITY"].ToString());
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
			strSql.Append("select INTERNAL_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,PARENT_DEPARTMENT_CODE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,SPECIFICATIONS,HD,KD,QUANTITY,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM STEEL_GG ");
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
			strSql.Append(" INTERNAL_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,PARENT_DEPARTMENT_CODE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,SPECIFICATIONS,HD,KD,QUANTITY,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM STEEL_GG ");
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
			strSql.Append("select count(1) FROM STEEL_GG ");
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
				strSql.Append("order by T.INTERNAL_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from STEEL_GG T ");
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
			parameters[0].Value = "STEEL_GG";
			parameters[1].Value = "INTERNAL_CODE";
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

