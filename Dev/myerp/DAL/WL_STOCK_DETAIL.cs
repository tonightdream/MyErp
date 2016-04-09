using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:WL_STOCK_DETAIL
	/// </summary>
	public partial class WL_STOCK_DETAIL
	{
		public WL_STOCK_DETAIL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.WL_STOCK_DETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WL_STOCK_DETAIL(");
			strSql.Append("STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,ACTUAL_QTY)");
			strSql.Append(" values (");
			strSql.Append("@STOCK_CODE,@STOCK_NAME,@ITEM_INTERNAL_CODE,@ITEM_CODE,@ITEM_NAME,@ACTUAL_QTY)");
			SqlParameter[] parameters = {
					new SqlParameter("@STOCK_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ACTUAL_QTY", SqlDbType.Float,8)};
			parameters[0].Value = model.STOCK_CODE;
			parameters[1].Value = model.STOCK_NAME;
			parameters[2].Value = model.ITEM_INTERNAL_CODE;
			parameters[3].Value = model.ITEM_CODE;
			parameters[4].Value = model.ITEM_NAME;
			parameters[5].Value = model.ACTUAL_QTY;

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
		public bool Update(MyERP.Model.WL_STOCK_DETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WL_STOCK_DETAIL set ");
			strSql.Append("STOCK_CODE=@STOCK_CODE,");
			strSql.Append("STOCK_NAME=@STOCK_NAME,");
			strSql.Append("ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE,");
			strSql.Append("ITEM_CODE=@ITEM_CODE,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("ACTUAL_QTY=@ACTUAL_QTY");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@STOCK_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ACTUAL_QTY", SqlDbType.Float,8)};
			parameters[0].Value = model.STOCK_CODE;
			parameters[1].Value = model.STOCK_NAME;
			parameters[2].Value = model.ITEM_INTERNAL_CODE;
			parameters[3].Value = model.ITEM_CODE;
			parameters[4].Value = model.ITEM_NAME;
			parameters[5].Value = model.ACTUAL_QTY;

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
			strSql.Append("delete from WL_STOCK_DETAIL ");
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
		public MyERP.Model.WL_STOCK_DETAIL GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,ACTUAL_QTY from WL_STOCK_DETAIL ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.WL_STOCK_DETAIL model=new MyERP.Model.WL_STOCK_DETAIL();
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
		public MyERP.Model.WL_STOCK_DETAIL DataRowToModel(DataRow row)
		{
			MyERP.Model.WL_STOCK_DETAIL model=new MyERP.Model.WL_STOCK_DETAIL();
			if (row != null)
			{
				if(row["STOCK_CODE"]!=null)
				{
					model.STOCK_CODE=row["STOCK_CODE"].ToString();
				}
				if(row["STOCK_NAME"]!=null)
				{
					model.STOCK_NAME=row["STOCK_NAME"].ToString();
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
				if(row["ACTUAL_QTY"]!=null && row["ACTUAL_QTY"].ToString()!="")
				{
					model.ACTUAL_QTY=decimal.Parse(row["ACTUAL_QTY"].ToString());
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
			strSql.Append("select STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,ACTUAL_QTY ");
			strSql.Append(" FROM WL_STOCK_DETAIL ");
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
			strSql.Append(" STOCK_CODE,STOCK_NAME,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,ACTUAL_QTY ");
			strSql.Append(" FROM WL_STOCK_DETAIL ");
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
			strSql.Append("select count(1) FROM WL_STOCK_DETAIL ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from WL_STOCK_DETAIL T ");
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
			parameters[0].Value = "WL_STOCK_DETAIL";
			parameters[1].Value = "ID";
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

