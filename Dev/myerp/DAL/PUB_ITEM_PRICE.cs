using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_ITEM_PRICE
	/// </summary>
	public partial class PUB_ITEM_PRICE
	{
		public PUB_ITEM_PRICE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ITEM_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PUB_ITEM_PRICE");
			strSql.Append(" where ITEM_CODE=@ITEM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,30)			};
			parameters[0].Value = ITEM_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_ITEM_PRICE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_ITEM_PRICE(");
			strSql.Append("COMPANY_CODE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,COLOR,MeasureUnit,PRICE,START_DATE,STOP_DATE,CREATE_NAME,CREATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@COMPANY_CODE,@ITEM_INTERNAL_CODE,@ITEM_CODE,@ITEM_NAME,@COLOR,@MeasureUnit,@PRICE,@START_DATE,@STOP_DATE,@CREATE_NAME,@CREATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,10),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,30),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,20),
					new SqlParameter("@COLOR", SqlDbType.NVarChar,10),
					new SqlParameter("@MeasureUnit", SqlDbType.NVarChar,6),
					new SqlParameter("@PRICE", SqlDbType.Decimal,9),
					new SqlParameter("@START_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@STOP_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@CREATE_NAME", SqlDbType.NChar,10),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.ITEM_INTERNAL_CODE;
			parameters[2].Value = model.ITEM_CODE;
			parameters[3].Value = model.ITEM_NAME;
			parameters[4].Value = model.COLOR;
			parameters[5].Value = model.MeasureUnit;
			parameters[6].Value = model.PRICE;
			parameters[7].Value = model.START_DATE;
			parameters[8].Value = model.STOP_DATE;
			parameters[9].Value = model.CREATE_NAME;
			parameters[10].Value = model.CREATE_DATE;
			parameters[11].Value = model.REMARK;

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
		public bool Update(MyERP.Model.PUB_ITEM_PRICE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_ITEM_PRICE set ");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("COLOR=@COLOR,");
			strSql.Append("MeasureUnit=@MeasureUnit,");
			strSql.Append("PRICE=@PRICE,");
			strSql.Append("START_DATE=@START_DATE,");
			strSql.Append("STOP_DATE=@STOP_DATE,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ITEM_CODE=@ITEM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,10),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,20),
					new SqlParameter("@COLOR", SqlDbType.NVarChar,10),
					new SqlParameter("@MeasureUnit", SqlDbType.NVarChar,6),
					new SqlParameter("@PRICE", SqlDbType.Decimal,9),
					new SqlParameter("@START_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@STOP_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@CREATE_NAME", SqlDbType.NChar,10),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,30)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.ITEM_INTERNAL_CODE;
			parameters[2].Value = model.ITEM_NAME;
			parameters[3].Value = model.COLOR;
			parameters[4].Value = model.MeasureUnit;
			parameters[5].Value = model.PRICE;
			parameters[6].Value = model.START_DATE;
			parameters[7].Value = model.STOP_DATE;
			parameters[8].Value = model.CREATE_NAME;
			parameters[9].Value = model.CREATE_DATE;
			parameters[10].Value = model.REMARK;
			parameters[11].Value = model.ITEM_CODE;

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
		public bool Delete(string ITEM_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_ITEM_PRICE ");
			strSql.Append(" where ITEM_CODE=@ITEM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,30)			};
			parameters[0].Value = ITEM_CODE;

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
		public bool DeleteList(string ITEM_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_ITEM_PRICE ");
			strSql.Append(" where ITEM_CODE in ("+ITEM_CODElist + ")  ");
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
		public MyERP.Model.PUB_ITEM_PRICE GetModel(string ITEM_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 COMPANY_CODE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,COLOR,MeasureUnit,PRICE,START_DATE,STOP_DATE,CREATE_NAME,CREATE_DATE,REMARK from PUB_ITEM_PRICE ");
			strSql.Append(" where ITEM_CODE=@ITEM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,30)			};
			parameters[0].Value = ITEM_CODE;

			MyERP.Model.PUB_ITEM_PRICE model=new MyERP.Model.PUB_ITEM_PRICE();
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
		public MyERP.Model.PUB_ITEM_PRICE DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_ITEM_PRICE model=new MyERP.Model.PUB_ITEM_PRICE();
			if (row != null)
			{
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
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
				if(row["COLOR"]!=null)
				{
					model.COLOR=row["COLOR"].ToString();
				}
				if(row["MeasureUnit"]!=null)
				{
					model.MeasureUnit=row["MeasureUnit"].ToString();
				}
				if(row["PRICE"]!=null && row["PRICE"].ToString()!="")
				{
					model.PRICE=decimal.Parse(row["PRICE"].ToString());
				}
				if(row["START_DATE"]!=null && row["START_DATE"].ToString()!="")
				{
					model.START_DATE=DateTime.Parse(row["START_DATE"].ToString());
				}
				if(row["STOP_DATE"]!=null && row["STOP_DATE"].ToString()!="")
				{
					model.STOP_DATE=DateTime.Parse(row["STOP_DATE"].ToString());
				}
				if(row["CREATE_NAME"]!=null)
				{
					model.CREATE_NAME=row["CREATE_NAME"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
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
			strSql.Append("select COMPANY_CODE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,COLOR,MeasureUnit,PRICE,START_DATE,STOP_DATE,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_ITEM_PRICE ");
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
			strSql.Append(" COMPANY_CODE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,COLOR,MeasureUnit,PRICE,START_DATE,STOP_DATE,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_ITEM_PRICE ");
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
			strSql.Append("select count(1) FROM PUB_ITEM_PRICE ");
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
				strSql.Append("order by T.ITEM_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUB_ITEM_PRICE T ");
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
			parameters[0].Value = "PUB_ITEM_PRICE";
			parameters[1].Value = "ITEM_CODE";
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

