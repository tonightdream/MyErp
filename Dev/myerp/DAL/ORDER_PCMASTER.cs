using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_PCMASTER
	/// </summary>
	public partial class ORDER_PCMASTER
	{
		public ORDER_PCMASTER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BillNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ORDER_PCMASTER");
			strSql.Append(" where BillNo=@BillNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNo", SqlDbType.VarChar,50)			};
			parameters[0].Value = BillNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_PCMASTER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_PCMASTER(");
			strSql.Append("BillNo,BILL_DATE,GROUP,MACHINE,FACTORY,BILL_STATUS,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@BillNo,@BILL_DATE,@GROUP,@MACHINE,@FACTORY,@BILL_STATUS,@STOCK_CODE,@STOCK_NAME,@DEPARTMENT_CODE,@DEPARTMENT_NAME,@CREATE_CODE,@CREATE_NAME,@CREATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNo", SqlDbType.VarChar,50),
					new SqlParameter("@BILL_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@GROUP", SqlDbType.VarChar,50),
					new SqlParameter("@MACHINE", SqlDbType.VarChar,50),
					new SqlParameter("@FACTORY", SqlDbType.VarChar,50),
					new SqlParameter("@BILL_STATUS", SqlDbType.Int,4),
					new SqlParameter("@STOCK_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BillNo;
			parameters[1].Value = model.BILL_DATE;
			parameters[2].Value = model.GROUP;
			parameters[3].Value = model.MACHINE;
			parameters[4].Value = model.FACTORY;
			parameters[5].Value = model.BILL_STATUS;
			parameters[6].Value = model.STOCK_CODE;
			parameters[7].Value = model.STOCK_NAME;
			parameters[8].Value = model.DEPARTMENT_CODE;
			parameters[9].Value = model.DEPARTMENT_NAME;
			parameters[10].Value = model.CREATE_CODE;
			parameters[11].Value = model.CREATE_NAME;
			parameters[12].Value = model.CREATE_DATE;
			parameters[13].Value = model.REMARK;

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
		public bool Update(MyERP.Model.ORDER_PCMASTER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_PCMASTER set ");
			strSql.Append("BILL_DATE=@BILL_DATE,");
			strSql.Append("GROUP=@GROUP,");
			strSql.Append("MACHINE=@MACHINE,");
			strSql.Append("FACTORY=@FACTORY,");
			strSql.Append("BILL_STATUS=@BILL_STATUS,");
			strSql.Append("STOCK_CODE=@STOCK_CODE,");
			strSql.Append("STOCK_NAME=@STOCK_NAME,");
			strSql.Append("DEPARTMENT_CODE=@DEPARTMENT_CODE,");
			strSql.Append("DEPARTMENT_NAME=@DEPARTMENT_NAME,");
			strSql.Append("CREATE_CODE=@CREATE_CODE,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where BillNo=@BillNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@BILL_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@GROUP", SqlDbType.VarChar,50),
					new SqlParameter("@MACHINE", SqlDbType.VarChar,50),
					new SqlParameter("@FACTORY", SqlDbType.VarChar,50),
					new SqlParameter("@BILL_STATUS", SqlDbType.Int,4),
					new SqlParameter("@STOCK_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50),
					new SqlParameter("@BillNo", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BILL_DATE;
			parameters[1].Value = model.GROUP;
			parameters[2].Value = model.MACHINE;
			parameters[3].Value = model.FACTORY;
			parameters[4].Value = model.BILL_STATUS;
			parameters[5].Value = model.STOCK_CODE;
			parameters[6].Value = model.STOCK_NAME;
			parameters[7].Value = model.DEPARTMENT_CODE;
			parameters[8].Value = model.DEPARTMENT_NAME;
			parameters[9].Value = model.CREATE_CODE;
			parameters[10].Value = model.CREATE_NAME;
			parameters[11].Value = model.CREATE_DATE;
			parameters[12].Value = model.REMARK;
			parameters[13].Value = model.BillNo;

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
			strSql.Append("delete from ORDER_PCMASTER ");
			strSql.Append(" where BillNo=@BillNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNo", SqlDbType.VarChar,50)			};
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
			strSql.Append("delete from ORDER_PCMASTER ");
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
		public MyERP.Model.ORDER_PCMASTER GetModel(string BillNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BillNo,BILL_DATE,GROUP,MACHINE,FACTORY,BILL_STATUS,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,REMARK from ORDER_PCMASTER ");
			strSql.Append(" where BillNo=@BillNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNo", SqlDbType.VarChar,50)			};
			parameters[0].Value = BillNo;

			MyERP.Model.ORDER_PCMASTER model=new MyERP.Model.ORDER_PCMASTER();
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
		public MyERP.Model.ORDER_PCMASTER DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_PCMASTER model=new MyERP.Model.ORDER_PCMASTER();
			if (row != null)
			{
				if(row["BillNo"]!=null)
				{
					model.BillNo=row["BillNo"].ToString();
				}
				if(row["BILL_DATE"]!=null)
				{
					model.BILL_DATE=row["BILL_DATE"].ToString();
				}
				if(row["GROUP"]!=null)
				{
					model.GROUP=row["GROUP"].ToString();
				}
				if(row["MACHINE"]!=null)
				{
					model.MACHINE=row["MACHINE"].ToString();
				}
				if(row["FACTORY"]!=null)
				{
					model.FACTORY=row["FACTORY"].ToString();
				}
				if(row["BILL_STATUS"]!=null && row["BILL_STATUS"].ToString()!="")
				{
					model.BILL_STATUS=int.Parse(row["BILL_STATUS"].ToString());
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
				if(row["CREATE_CODE"]!=null)
				{
					model.CREATE_CODE=row["CREATE_CODE"].ToString();
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
			strSql.Append("select BillNo,BILL_DATE,GROUP,MACHINE,FACTORY,BILL_STATUS,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_PCMASTER ");
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
			strSql.Append(" BillNo,BILL_DATE,GROUP,MACHINE,FACTORY,BILL_STATUS,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_PCMASTER ");
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
			strSql.Append("select count(1) FROM ORDER_PCMASTER ");
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
			strSql.Append(")AS Row, T.*  from ORDER_PCMASTER T ");
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
			parameters[0].Value = "ORDER_PCMASTER";
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

