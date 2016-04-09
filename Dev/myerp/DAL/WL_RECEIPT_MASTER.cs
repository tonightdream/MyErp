using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:WL_RECEIPT_MASTER
	/// </summary>
	public partial class WL_RECEIPT_MASTER
	{
		public WL_RECEIPT_MASTER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BillNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WL_RECEIPT_MASTER");
			strSql.Append(" where BillNO=@BillNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNO", SqlDbType.NVarChar,50)			};
			parameters[0].Value = BillNO;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.WL_RECEIPT_MASTER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WL_RECEIPT_MASTER(");
			strSql.Append("BillNO,COMPANY_CODE,COMPANY_NAME,PARENT_COMPANY_CODE,CUSTOM_CODE,CUSTOM_NAME,BillTYPE,STOCK_CODE,STOCK_NAME,INSTOCK_CODE,INSTOCK_NAME,EMPLOYEE_CODE,EMPLOYEE_NAME,BillDate,BILL_STATUS,PayAcount,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@BillNO,@COMPANY_CODE,@COMPANY_NAME,@PARENT_COMPANY_CODE,@CUSTOM_CODE,@CUSTOM_NAME,@BillTYPE,@STOCK_CODE,@STOCK_NAME,@INSTOCK_CODE,@INSTOCK_NAME,@EMPLOYEE_CODE,@EMPLOYEE_NAME,@BillDate,@BILL_STATUS,@PayAcount,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNO", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_COMPANY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@BillTYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@STOCK_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@INSTOCK_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@INSTOCK_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@EMPLOYEE_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@EMPLOYEE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@BillDate", SqlDbType.DateTime),
					new SqlParameter("@BILL_STATUS", SqlDbType.NVarChar,10),
					new SqlParameter("@PayAcount", SqlDbType.Float,8),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.BillNO;
			parameters[1].Value = model.COMPANY_CODE;
			parameters[2].Value = model.COMPANY_NAME;
			parameters[3].Value = model.PARENT_COMPANY_CODE;
			parameters[4].Value = model.CUSTOM_CODE;
			parameters[5].Value = model.CUSTOM_NAME;
			parameters[6].Value = model.BillTYPE;
			parameters[7].Value = model.STOCK_CODE;
			parameters[8].Value = model.STOCK_NAME;
			parameters[9].Value = model.INSTOCK_CODE;
			parameters[10].Value = model.INSTOCK_NAME;
			parameters[11].Value = model.EMPLOYEE_CODE;
			parameters[12].Value = model.EMPLOYEE_NAME;
			parameters[13].Value = model.BillDate;
			parameters[14].Value = model.BILL_STATUS;
			parameters[15].Value = model.PayAcount;
			parameters[16].Value = model.REMARK;

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
		public bool Update(MyERP.Model.WL_RECEIPT_MASTER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WL_RECEIPT_MASTER set ");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("COMPANY_NAME=@COMPANY_NAME,");
			strSql.Append("PARENT_COMPANY_CODE=@PARENT_COMPANY_CODE,");
			strSql.Append("CUSTOM_CODE=@CUSTOM_CODE,");
			strSql.Append("CUSTOM_NAME=@CUSTOM_NAME,");
			strSql.Append("BillTYPE=@BillTYPE,");
			strSql.Append("STOCK_CODE=@STOCK_CODE,");
			strSql.Append("STOCK_NAME=@STOCK_NAME,");
			strSql.Append("INSTOCK_CODE=@INSTOCK_CODE,");
			strSql.Append("INSTOCK_NAME=@INSTOCK_NAME,");
			strSql.Append("EMPLOYEE_CODE=@EMPLOYEE_CODE,");
			strSql.Append("EMPLOYEE_NAME=@EMPLOYEE_NAME,");
			strSql.Append("BillDate=@BillDate,");
			strSql.Append("BILL_STATUS=@BILL_STATUS,");
			strSql.Append("PayAcount=@PayAcount,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where BillNO=@BillNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_COMPANY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@BillTYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@STOCK_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@INSTOCK_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@INSTOCK_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@EMPLOYEE_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@EMPLOYEE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@BillDate", SqlDbType.DateTime),
					new SqlParameter("@BILL_STATUS", SqlDbType.NVarChar,10),
					new SqlParameter("@PayAcount", SqlDbType.Float,8),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50),
					new SqlParameter("@BillNO", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.COMPANY_NAME;
			parameters[2].Value = model.PARENT_COMPANY_CODE;
			parameters[3].Value = model.CUSTOM_CODE;
			parameters[4].Value = model.CUSTOM_NAME;
			parameters[5].Value = model.BillTYPE;
			parameters[6].Value = model.STOCK_CODE;
			parameters[7].Value = model.STOCK_NAME;
			parameters[8].Value = model.INSTOCK_CODE;
			parameters[9].Value = model.INSTOCK_NAME;
			parameters[10].Value = model.EMPLOYEE_CODE;
			parameters[11].Value = model.EMPLOYEE_NAME;
			parameters[12].Value = model.BillDate;
			parameters[13].Value = model.BILL_STATUS;
			parameters[14].Value = model.PayAcount;
			parameters[15].Value = model.REMARK;
			parameters[16].Value = model.BillNO;

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
		public bool Delete(string BillNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WL_RECEIPT_MASTER ");
			strSql.Append(" where BillNO=@BillNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNO", SqlDbType.NVarChar,50)			};
			parameters[0].Value = BillNO;

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
		public bool DeleteList(string BillNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WL_RECEIPT_MASTER ");
			strSql.Append(" where BillNO in ("+BillNOlist + ")  ");
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
		public MyERP.Model.WL_RECEIPT_MASTER GetModel(string BillNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BillNO,COMPANY_CODE,COMPANY_NAME,PARENT_COMPANY_CODE,CUSTOM_CODE,CUSTOM_NAME,BillTYPE,STOCK_CODE,STOCK_NAME,INSTOCK_CODE,INSTOCK_NAME,EMPLOYEE_CODE,EMPLOYEE_NAME,BillDate,BILL_STATUS,PayAcount,REMARK from WL_RECEIPT_MASTER ");
			strSql.Append(" where BillNO=@BillNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNO", SqlDbType.NVarChar,50)			};
			parameters[0].Value = BillNO;

			MyERP.Model.WL_RECEIPT_MASTER model=new MyERP.Model.WL_RECEIPT_MASTER();
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
		public MyERP.Model.WL_RECEIPT_MASTER DataRowToModel(DataRow row)
		{
			MyERP.Model.WL_RECEIPT_MASTER model=new MyERP.Model.WL_RECEIPT_MASTER();
			if (row != null)
			{
				if(row["BillNO"]!=null)
				{
					model.BillNO=row["BillNO"].ToString();
				}
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
				}
				if(row["COMPANY_NAME"]!=null)
				{
					model.COMPANY_NAME=row["COMPANY_NAME"].ToString();
				}
				if(row["PARENT_COMPANY_CODE"]!=null)
				{
					model.PARENT_COMPANY_CODE=row["PARENT_COMPANY_CODE"].ToString();
				}
				if(row["CUSTOM_CODE"]!=null)
				{
					model.CUSTOM_CODE=row["CUSTOM_CODE"].ToString();
				}
				if(row["CUSTOM_NAME"]!=null)
				{
					model.CUSTOM_NAME=row["CUSTOM_NAME"].ToString();
				}
				if(row["BillTYPE"]!=null)
				{
					model.BillTYPE=row["BillTYPE"].ToString();
				}
				if(row["STOCK_CODE"]!=null)
				{
					model.STOCK_CODE=row["STOCK_CODE"].ToString();
				}
				if(row["STOCK_NAME"]!=null)
				{
					model.STOCK_NAME=row["STOCK_NAME"].ToString();
				}
				if(row["INSTOCK_CODE"]!=null)
				{
					model.INSTOCK_CODE=row["INSTOCK_CODE"].ToString();
				}
				if(row["INSTOCK_NAME"]!=null)
				{
					model.INSTOCK_NAME=row["INSTOCK_NAME"].ToString();
				}
				if(row["EMPLOYEE_CODE"]!=null)
				{
					model.EMPLOYEE_CODE=row["EMPLOYEE_CODE"].ToString();
				}
				if(row["EMPLOYEE_NAME"]!=null)
				{
					model.EMPLOYEE_NAME=row["EMPLOYEE_NAME"].ToString();
				}
				if(row["BillDate"]!=null && row["BillDate"].ToString()!="")
				{
					model.BillDate=DateTime.Parse(row["BillDate"].ToString());
				}
				if(row["BILL_STATUS"]!=null)
				{
					model.BILL_STATUS=row["BILL_STATUS"].ToString();
				}
				if(row["PayAcount"]!=null && row["PayAcount"].ToString()!="")
				{
					model.PayAcount=decimal.Parse(row["PayAcount"].ToString());
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
			strSql.Append("select BillNO,COMPANY_CODE,COMPANY_NAME,PARENT_COMPANY_CODE,CUSTOM_CODE,CUSTOM_NAME,BillTYPE,STOCK_CODE,STOCK_NAME,INSTOCK_CODE,INSTOCK_NAME,EMPLOYEE_CODE,EMPLOYEE_NAME,BillDate,BILL_STATUS,PayAcount,REMARK ");
			strSql.Append(" FROM WL_RECEIPT_MASTER ");
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
			strSql.Append(" BillNO,COMPANY_CODE,COMPANY_NAME,PARENT_COMPANY_CODE,CUSTOM_CODE,CUSTOM_NAME,BillTYPE,STOCK_CODE,STOCK_NAME,INSTOCK_CODE,INSTOCK_NAME,EMPLOYEE_CODE,EMPLOYEE_NAME,BillDate,BILL_STATUS,PayAcount,REMARK ");
			strSql.Append(" FROM WL_RECEIPT_MASTER ");
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
			strSql.Append("select count(1) FROM WL_RECEIPT_MASTER ");
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
				strSql.Append("order by T.BillNO desc");
			}
			strSql.Append(")AS Row, T.*  from WL_RECEIPT_MASTER T ");
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
			parameters[0].Value = "WL_RECEIPT_MASTER";
			parameters[1].Value = "BillNO";
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

