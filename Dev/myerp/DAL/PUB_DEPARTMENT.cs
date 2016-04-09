using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_DEPARTMENT
	/// </summary>
	public partial class PUB_DEPARTMENT
	{
		public PUB_DEPARTMENT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string DEPARTMENT_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PUB_DEPARTMENT");
			strSql.Append(" where DEPARTMENT_CODE=@DEPARTMENT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,12)			};
			parameters[0].Value = DEPARTMENT_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_DEPARTMENT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_DEPARTMENT(");
			strSql.Append("INTERNAL_CODE,COMPANY_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,PARENT_DEPARTMENT_CODE,MANAGER,TELEPHONE,ADDRESS,SHOP_NAME,SETTLE_DATE,SIZE,EMAIL,FAX,DISCOUNT,SHIP,PPRICE_SHOW,SALE_METHOD,ALLOW_USED,START_DATE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@INTERNAL_CODE,@COMPANY_CODE,@DEPARTMENT_CODE,@DEPARTMENT_NAME,@PARENT_DEPARTMENT_CODE,@MANAGER,@TELEPHONE,@ADDRESS,@SHOP_NAME,@SETTLE_DATE,@SIZE,@EMAIL,@FAX,@DISCOUNT,@SHIP,@PPRICE_SHOW,@SALE_METHOD,@ALLOW_USED,@START_DATE,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,10),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,12),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.NVarChar,80),
					new SqlParameter("@PARENT_DEPARTMENT_CODE", SqlDbType.NVarChar,12),
					new SqlParameter("@MANAGER", SqlDbType.NVarChar,12),
					new SqlParameter("@TELEPHONE", SqlDbType.NVarChar,100),
					new SqlParameter("@ADDRESS", SqlDbType.NVarChar,100),
					new SqlParameter("@SHOP_NAME", SqlDbType.NVarChar,30),
					new SqlParameter("@SETTLE_DATE", SqlDbType.Decimal,9),
					new SqlParameter("@SIZE", SqlDbType.Decimal,9),
					new SqlParameter("@EMAIL", SqlDbType.NVarChar,50),
					new SqlParameter("@FAX", SqlDbType.NVarChar,50),
					new SqlParameter("@DISCOUNT", SqlDbType.Decimal,9),
					new SqlParameter("@SHIP", SqlDbType.Decimal,9),
					new SqlParameter("@PPRICE_SHOW", SqlDbType.Int,4),
					new SqlParameter("@SALE_METHOD", SqlDbType.NVarChar,10),
					new SqlParameter("@ALLOW_USED", SqlDbType.NVarChar,1),
					new SqlParameter("@START_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.COMPANY_CODE;
			parameters[2].Value = model.DEPARTMENT_CODE;
			parameters[3].Value = model.DEPARTMENT_NAME;
			parameters[4].Value = model.PARENT_DEPARTMENT_CODE;
			parameters[5].Value = model.MANAGER;
			parameters[6].Value = model.TELEPHONE;
			parameters[7].Value = model.ADDRESS;
			parameters[8].Value = model.SHOP_NAME;
			parameters[9].Value = model.SETTLE_DATE;
			parameters[10].Value = model.SIZE;
			parameters[11].Value = model.EMAIL;
			parameters[12].Value = model.FAX;
			parameters[13].Value = model.DISCOUNT;
			parameters[14].Value = model.SHIP;
			parameters[15].Value = model.PPRICE_SHOW;
			parameters[16].Value = model.SALE_METHOD;
			parameters[17].Value = model.ALLOW_USED;
			parameters[18].Value = model.START_DATE;
			parameters[19].Value = model.CREATE_NAME;
			parameters[20].Value = model.CREATE_DATE;
			parameters[21].Value = model.UPDATE_NAME;
			parameters[22].Value = model.UPDATE_DATE;
			parameters[23].Value = model.REMARK;

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
		public bool Update(MyERP.Model.PUB_DEPARTMENT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_DEPARTMENT set ");
			strSql.Append("INTERNAL_CODE=@INTERNAL_CODE,");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("DEPARTMENT_NAME=@DEPARTMENT_NAME,");
			strSql.Append("PARENT_DEPARTMENT_CODE=@PARENT_DEPARTMENT_CODE,");
			strSql.Append("MANAGER=@MANAGER,");
			strSql.Append("TELEPHONE=@TELEPHONE,");
			strSql.Append("ADDRESS=@ADDRESS,");
			strSql.Append("SHOP_NAME=@SHOP_NAME,");
			strSql.Append("SETTLE_DATE=@SETTLE_DATE,");
			strSql.Append("SIZE=@SIZE,");
			strSql.Append("EMAIL=@EMAIL,");
			strSql.Append("FAX=@FAX,");
			strSql.Append("DISCOUNT=@DISCOUNT,");
			strSql.Append("SHIP=@SHIP,");
			strSql.Append("PPRICE_SHOW=@PPRICE_SHOW,");
			strSql.Append("SALE_METHOD=@SALE_METHOD,");
			strSql.Append("ALLOW_USED=@ALLOW_USED,");
			strSql.Append("START_DATE=@START_DATE,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where DEPARTMENT_CODE=@DEPARTMENT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,10),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.NVarChar,80),
					new SqlParameter("@PARENT_DEPARTMENT_CODE", SqlDbType.NVarChar,12),
					new SqlParameter("@MANAGER", SqlDbType.NVarChar,12),
					new SqlParameter("@TELEPHONE", SqlDbType.NVarChar,100),
					new SqlParameter("@ADDRESS", SqlDbType.NVarChar,100),
					new SqlParameter("@SHOP_NAME", SqlDbType.NVarChar,30),
					new SqlParameter("@SETTLE_DATE", SqlDbType.Decimal,9),
					new SqlParameter("@SIZE", SqlDbType.Decimal,9),
					new SqlParameter("@EMAIL", SqlDbType.NVarChar,50),
					new SqlParameter("@FAX", SqlDbType.NVarChar,50),
					new SqlParameter("@DISCOUNT", SqlDbType.Decimal,9),
					new SqlParameter("@SHIP", SqlDbType.Decimal,9),
					new SqlParameter("@PPRICE_SHOW", SqlDbType.Int,4),
					new SqlParameter("@SALE_METHOD", SqlDbType.NVarChar,10),
					new SqlParameter("@ALLOW_USED", SqlDbType.NVarChar,1),
					new SqlParameter("@START_DATE", SqlDbType.SmallDateTime),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,12)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.COMPANY_CODE;
			parameters[2].Value = model.DEPARTMENT_NAME;
			parameters[3].Value = model.PARENT_DEPARTMENT_CODE;
			parameters[4].Value = model.MANAGER;
			parameters[5].Value = model.TELEPHONE;
			parameters[6].Value = model.ADDRESS;
			parameters[7].Value = model.SHOP_NAME;
			parameters[8].Value = model.SETTLE_DATE;
			parameters[9].Value = model.SIZE;
			parameters[10].Value = model.EMAIL;
			parameters[11].Value = model.FAX;
			parameters[12].Value = model.DISCOUNT;
			parameters[13].Value = model.SHIP;
			parameters[14].Value = model.PPRICE_SHOW;
			parameters[15].Value = model.SALE_METHOD;
			parameters[16].Value = model.ALLOW_USED;
			parameters[17].Value = model.START_DATE;
			parameters[18].Value = model.CREATE_NAME;
			parameters[19].Value = model.CREATE_DATE;
			parameters[20].Value = model.UPDATE_NAME;
			parameters[21].Value = model.UPDATE_DATE;
			parameters[22].Value = model.REMARK;
			parameters[23].Value = model.DEPARTMENT_CODE;

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
		public bool Delete(string DEPARTMENT_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_DEPARTMENT ");
			strSql.Append(" where DEPARTMENT_CODE=@DEPARTMENT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,12)			};
			parameters[0].Value = DEPARTMENT_CODE;

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
		public bool DeleteList(string DEPARTMENT_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_DEPARTMENT ");
			strSql.Append(" where DEPARTMENT_CODE in ("+DEPARTMENT_CODElist + ")  ");
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
		public MyERP.Model.PUB_DEPARTMENT GetModel(string DEPARTMENT_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 INTERNAL_CODE,COMPANY_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,PARENT_DEPARTMENT_CODE,MANAGER,TELEPHONE,ADDRESS,SHOP_NAME,SETTLE_DATE,SIZE,EMAIL,FAX,DISCOUNT,SHIP,PPRICE_SHOW,SALE_METHOD,ALLOW_USED,START_DATE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from PUB_DEPARTMENT ");
			strSql.Append(" where DEPARTMENT_CODE=@DEPARTMENT_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,12)			};
			parameters[0].Value = DEPARTMENT_CODE;

			MyERP.Model.PUB_DEPARTMENT model=new MyERP.Model.PUB_DEPARTMENT();
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
		public MyERP.Model.PUB_DEPARTMENT DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_DEPARTMENT model=new MyERP.Model.PUB_DEPARTMENT();
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
				if(row["MANAGER"]!=null)
				{
					model.MANAGER=row["MANAGER"].ToString();
				}
				if(row["TELEPHONE"]!=null)
				{
					model.TELEPHONE=row["TELEPHONE"].ToString();
				}
				if(row["ADDRESS"]!=null)
				{
					model.ADDRESS=row["ADDRESS"].ToString();
				}
				if(row["SHOP_NAME"]!=null)
				{
					model.SHOP_NAME=row["SHOP_NAME"].ToString();
				}
				if(row["SETTLE_DATE"]!=null && row["SETTLE_DATE"].ToString()!="")
				{
					model.SETTLE_DATE=decimal.Parse(row["SETTLE_DATE"].ToString());
				}
				if(row["SIZE"]!=null && row["SIZE"].ToString()!="")
				{
					model.SIZE=decimal.Parse(row["SIZE"].ToString());
				}
				if(row["EMAIL"]!=null)
				{
					model.EMAIL=row["EMAIL"].ToString();
				}
				if(row["FAX"]!=null)
				{
					model.FAX=row["FAX"].ToString();
				}
				if(row["DISCOUNT"]!=null && row["DISCOUNT"].ToString()!="")
				{
					model.DISCOUNT=decimal.Parse(row["DISCOUNT"].ToString());
				}
				if(row["SHIP"]!=null && row["SHIP"].ToString()!="")
				{
					model.SHIP=decimal.Parse(row["SHIP"].ToString());
				}
				if(row["PPRICE_SHOW"]!=null && row["PPRICE_SHOW"].ToString()!="")
				{
					model.PPRICE_SHOW=int.Parse(row["PPRICE_SHOW"].ToString());
				}
				if(row["SALE_METHOD"]!=null)
				{
					model.SALE_METHOD=row["SALE_METHOD"].ToString();
				}
				if(row["ALLOW_USED"]!=null)
				{
					model.ALLOW_USED=row["ALLOW_USED"].ToString();
				}
				if(row["START_DATE"]!=null && row["START_DATE"].ToString()!="")
				{
					model.START_DATE=DateTime.Parse(row["START_DATE"].ToString());
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
			strSql.Append("select INTERNAL_CODE,COMPANY_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,PARENT_DEPARTMENT_CODE,MANAGER,TELEPHONE,ADDRESS,SHOP_NAME,SETTLE_DATE,SIZE,EMAIL,FAX,DISCOUNT,SHIP,PPRICE_SHOW,SALE_METHOD,ALLOW_USED,START_DATE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_DEPARTMENT ");
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
			strSql.Append(" INTERNAL_CODE,COMPANY_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,PARENT_DEPARTMENT_CODE,MANAGER,TELEPHONE,ADDRESS,SHOP_NAME,SETTLE_DATE,SIZE,EMAIL,FAX,DISCOUNT,SHIP,PPRICE_SHOW,SALE_METHOD,ALLOW_USED,START_DATE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_DEPARTMENT ");
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
			strSql.Append("select count(1) FROM PUB_DEPARTMENT ");
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
				strSql.Append("order by T.DEPARTMENT_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUB_DEPARTMENT T ");
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
			parameters[0].Value = "PUB_DEPARTMENT";
			parameters[1].Value = "DEPARTMENT_CODE";
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

