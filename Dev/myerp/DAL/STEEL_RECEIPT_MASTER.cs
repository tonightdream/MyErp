using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:STEEL_RECEIPT_MASTER
	/// </summary>
	public partial class STEEL_RECEIPT_MASTER
	{
		public STEEL_RECEIPT_MASTER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BillNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from STEEL_RECEIPT_MASTER");
			strSql.Append(" where BillNo=@BillNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNo", SqlDbType.NVarChar,50)			};
			parameters[0].Value = BillNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.STEEL_RECEIPT_MASTER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into STEEL_RECEIPT_MASTER(");
			strSql.Append("BillNo,MANUAL_BILLNO,COMPANY_CODE,COMPANY_NAME,CUSTOM_CODE,CUSTOM_NAME,BILLTYPE,BILL_STATUS,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,EMPLOYEE_CODE,EMPLOYEE_NAME,BILLDATE,CREATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@BillNo,@MANUAL_BILLNO,@COMPANY_CODE,@COMPANY_NAME,@CUSTOM_CODE,@CUSTOM_NAME,@BILLTYPE,@BILL_STATUS,@STOCK_CODE,@STOCK_NAME,@DEPARTMENT_CODE,@DEPARTMENT_NAME,@EMPLOYEE_CODE,@EMPLOYEE_NAME,@BILLDATE,@CREATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNo", SqlDbType.NVarChar,50),
					new SqlParameter("@MANUAL_BILLNO", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.NChar,10),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@BILLTYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@BILL_STATUS", SqlDbType.NVarChar,10),
					new SqlParameter("@STOCK_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@EMPLOYEE_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@EMPLOYEE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@BILLDATE", SqlDbType.DateTime),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.BillNo;
			parameters[1].Value = model.MANUAL_BILLNO;
			parameters[2].Value = model.COMPANY_CODE;
			parameters[3].Value = model.COMPANY_NAME;
			parameters[4].Value = model.CUSTOM_CODE;
			parameters[5].Value = model.CUSTOM_NAME;
			parameters[6].Value = model.BILLTYPE;
			parameters[7].Value = model.BILL_STATUS;
			parameters[8].Value = model.STOCK_CODE;
			parameters[9].Value = model.STOCK_NAME;
			parameters[10].Value = model.DEPARTMENT_CODE;
			parameters[11].Value = model.DEPARTMENT_NAME;
			parameters[12].Value = model.EMPLOYEE_CODE;
			parameters[13].Value = model.EMPLOYEE_NAME;
			parameters[14].Value = model.BILLDATE;
			parameters[15].Value = model.CREATE_DATE;
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
		public bool Update(MyERP.Model.STEEL_RECEIPT_MASTER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update STEEL_RECEIPT_MASTER set ");
			strSql.Append("MANUAL_BILLNO=@MANUAL_BILLNO,");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("COMPANY_NAME=@COMPANY_NAME,");
			strSql.Append("CUSTOM_CODE=@CUSTOM_CODE,");
			strSql.Append("CUSTOM_NAME=@CUSTOM_NAME,");
			strSql.Append("BILLTYPE=@BILLTYPE,");
			strSql.Append("BILL_STATUS=@BILL_STATUS,");
			strSql.Append("STOCK_CODE=@STOCK_CODE,");
			strSql.Append("STOCK_NAME=@STOCK_NAME,");
			strSql.Append("DEPARTMENT_CODE=@DEPARTMENT_CODE,");
			strSql.Append("DEPARTMENT_NAME=@DEPARTMENT_NAME,");
			strSql.Append("EMPLOYEE_CODE=@EMPLOYEE_CODE,");
			strSql.Append("EMPLOYEE_NAME=@EMPLOYEE_NAME,");
			strSql.Append("BILLDATE=@BILLDATE,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where BillNo=@BillNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@MANUAL_BILLNO", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.NChar,10),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@BILLTYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@BILL_STATUS", SqlDbType.NVarChar,10),
					new SqlParameter("@STOCK_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@EMPLOYEE_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@EMPLOYEE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@BILLDATE", SqlDbType.DateTime),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50),
					new SqlParameter("@BillNo", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.MANUAL_BILLNO;
			parameters[1].Value = model.COMPANY_CODE;
			parameters[2].Value = model.COMPANY_NAME;
			parameters[3].Value = model.CUSTOM_CODE;
			parameters[4].Value = model.CUSTOM_NAME;
			parameters[5].Value = model.BILLTYPE;
			parameters[6].Value = model.BILL_STATUS;
			parameters[7].Value = model.STOCK_CODE;
			parameters[8].Value = model.STOCK_NAME;
			parameters[9].Value = model.DEPARTMENT_CODE;
			parameters[10].Value = model.DEPARTMENT_NAME;
			parameters[11].Value = model.EMPLOYEE_CODE;
			parameters[12].Value = model.EMPLOYEE_NAME;
			parameters[13].Value = model.BILLDATE;
			parameters[14].Value = model.CREATE_DATE;
			parameters[15].Value = model.REMARK;
			parameters[16].Value = model.BillNo;

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
		public bool Delete(string BillNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STEEL_RECEIPT_MASTER ");
			strSql.Append(" where BillNo=@BillNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNo", SqlDbType.NVarChar,50)			};
			parameters[0].Value = BillNo;

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
		public bool DeleteList(string BillNolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STEEL_RECEIPT_MASTER ");
			strSql.Append(" where BillNo in ("+BillNolist + ")  ");
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
		public MyERP.Model.STEEL_RECEIPT_MASTER GetModel(string BillNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BillNo,MANUAL_BILLNO,COMPANY_CODE,COMPANY_NAME,CUSTOM_CODE,CUSTOM_NAME,BILLTYPE,BILL_STATUS,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,EMPLOYEE_CODE,EMPLOYEE_NAME,BILLDATE,CREATE_DATE,REMARK from STEEL_RECEIPT_MASTER ");
			strSql.Append(" where BillNo=@BillNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNo", SqlDbType.NVarChar,50)			};
			parameters[0].Value = BillNo;

			MyERP.Model.STEEL_RECEIPT_MASTER model=new MyERP.Model.STEEL_RECEIPT_MASTER();
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
		public MyERP.Model.STEEL_RECEIPT_MASTER DataRowToModel(DataRow row)
		{
			MyERP.Model.STEEL_RECEIPT_MASTER model=new MyERP.Model.STEEL_RECEIPT_MASTER();
			if (row != null)
			{
				if(row["BillNo"]!=null)
				{
					model.BillNo=row["BillNo"].ToString();
				}
				if(row["MANUAL_BILLNO"]!=null)
				{
					model.MANUAL_BILLNO=row["MANUAL_BILLNO"].ToString();
				}
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
				}
				if(row["COMPANY_NAME"]!=null)
				{
					model.COMPANY_NAME=row["COMPANY_NAME"].ToString();
				}
				if(row["CUSTOM_CODE"]!=null)
				{
					model.CUSTOM_CODE=row["CUSTOM_CODE"].ToString();
				}
				if(row["CUSTOM_NAME"]!=null)
				{
					model.CUSTOM_NAME=row["CUSTOM_NAME"].ToString();
				}
				if(row["BILLTYPE"]!=null)
				{
					model.BILLTYPE=row["BILLTYPE"].ToString();
				}
				if(row["BILL_STATUS"]!=null)
				{
					model.BILL_STATUS=row["BILL_STATUS"].ToString();
				}
				if(row["STOCK_CODE"]!=null)
				{
					model.STOCK_CODE=row["STOCK_CODE"].ToString();
				}
				if(row["STOCK_NAME"]!=null)
				{
					model.STOCK_NAME=row["STOCK_NAME"].ToString();
				}
				if(row["DEPARTMENT_CODE"]!=null)
				{
					model.DEPARTMENT_CODE=row["DEPARTMENT_CODE"].ToString();
				}
				if(row["DEPARTMENT_NAME"]!=null)
				{
					model.DEPARTMENT_NAME=row["DEPARTMENT_NAME"].ToString();
				}
				if(row["EMPLOYEE_CODE"]!=null)
				{
					model.EMPLOYEE_CODE=row["EMPLOYEE_CODE"].ToString();
				}
				if(row["EMPLOYEE_NAME"]!=null)
				{
					model.EMPLOYEE_NAME=row["EMPLOYEE_NAME"].ToString();
				}
				if(row["BILLDATE"]!=null && row["BILLDATE"].ToString()!="")
				{
					model.BILLDATE=DateTime.Parse(row["BILLDATE"].ToString());
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
			strSql.Append("select BillNo,MANUAL_BILLNO,COMPANY_CODE,COMPANY_NAME,CUSTOM_CODE,CUSTOM_NAME,BILLTYPE,BILL_STATUS,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,EMPLOYEE_CODE,EMPLOYEE_NAME,BILLDATE,CREATE_DATE,REMARK ");
			strSql.Append(" FROM STEEL_RECEIPT_MASTER ");
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
			strSql.Append(" BillNo,MANUAL_BILLNO,COMPANY_CODE,COMPANY_NAME,CUSTOM_CODE,CUSTOM_NAME,BILLTYPE,BILL_STATUS,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,EMPLOYEE_CODE,EMPLOYEE_NAME,BILLDATE,CREATE_DATE,REMARK ");
			strSql.Append(" FROM STEEL_RECEIPT_MASTER ");
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
			strSql.Append("select count(1) FROM STEEL_RECEIPT_MASTER ");
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
				strSql.Append("order by T.BillNo desc");
			}
			strSql.Append(")AS Row, T.*  from STEEL_RECEIPT_MASTER T ");
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
			parameters[0].Value = "STEEL_RECEIPT_MASTER";
			parameters[1].Value = "BillNo";
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

