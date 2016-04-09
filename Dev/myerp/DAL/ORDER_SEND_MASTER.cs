using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_SEND_MASTER
	/// </summary>
	public partial class ORDER_SEND_MASTER
	{
		public ORDER_SEND_MASTER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string BILLNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ORDER_SEND_MASTER");
			strSql.Append(" where BILLNO=@BILLNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50)			};
			parameters[0].Value = BILLNO;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_SEND_MASTER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_SEND_MASTER(");
			strSql.Append("MASTERID,BILLNO,MANUAL_BILLNO,Vehicle_CODE,Vehicle_NAME,CUSTOM_CODE,CUSTOM_NAME,BILL_DATE,BILL_STATUS,NOW_STATUS,NOW_DATE,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,FACTORY,SALE_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@MASTERID,@BILLNO,@MANUAL_BILLNO,@Vehicle_CODE,@Vehicle_NAME,@CUSTOM_CODE,@CUSTOM_NAME,@BILL_DATE,@BILL_STATUS,@NOW_STATUS,@NOW_DATE,@STOCK_CODE,@STOCK_NAME,@DEPARTMENT_CODE,@DEPARTMENT_NAME,@FACTORY,@SALE_NAME,@CREATE_CODE,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@MANUAL_BILLNO", SqlDbType.VarChar,100),
					new SqlParameter("@Vehicle_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@Vehicle_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@BILL_DATE", SqlDbType.DateTime),
					new SqlParameter("@BILL_STATUS", SqlDbType.NVarChar,10),
					new SqlParameter("@NOW_STATUS", SqlDbType.NVarChar,10),
					new SqlParameter("@NOW_DATE", SqlDbType.NVarChar,10),
					new SqlParameter("@STOCK_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@FACTORY", SqlDbType.NVarChar,50),
					new SqlParameter("@SALE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,200)};
			parameters[0].Value = model.MASTERID;
			parameters[1].Value = model.BILLNO;
			parameters[2].Value = model.MANUAL_BILLNO;
			parameters[3].Value = model.Vehicle_CODE;
			parameters[4].Value = model.Vehicle_NAME;
			parameters[5].Value = model.CUSTOM_CODE;
			parameters[6].Value = model.CUSTOM_NAME;
			parameters[7].Value = model.BILL_DATE;
			parameters[8].Value = model.BILL_STATUS;
			parameters[9].Value = model.NOW_STATUS;
			parameters[10].Value = model.NOW_DATE;
			parameters[11].Value = model.STOCK_CODE;
			parameters[12].Value = model.STOCK_NAME;
			parameters[13].Value = model.DEPARTMENT_CODE;
			parameters[14].Value = model.DEPARTMENT_NAME;
			parameters[15].Value = model.FACTORY;
			parameters[16].Value = model.SALE_NAME;
			parameters[17].Value = model.CREATE_CODE;
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
		public bool Update(MyERP.Model.ORDER_SEND_MASTER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_SEND_MASTER set ");
			strSql.Append("MASTERID=@MASTERID,");
			strSql.Append("MANUAL_BILLNO=@MANUAL_BILLNO,");
			strSql.Append("Vehicle_CODE=@Vehicle_CODE,");
			strSql.Append("Vehicle_NAME=@Vehicle_NAME,");
			strSql.Append("CUSTOM_CODE=@CUSTOM_CODE,");
			strSql.Append("CUSTOM_NAME=@CUSTOM_NAME,");
			strSql.Append("BILL_DATE=@BILL_DATE,");
			strSql.Append("BILL_STATUS=@BILL_STATUS,");
			strSql.Append("NOW_STATUS=@NOW_STATUS,");
			strSql.Append("NOW_DATE=@NOW_DATE,");
			strSql.Append("STOCK_CODE=@STOCK_CODE,");
			strSql.Append("STOCK_NAME=@STOCK_NAME,");
			strSql.Append("DEPARTMENT_CODE=@DEPARTMENT_CODE,");
			strSql.Append("DEPARTMENT_NAME=@DEPARTMENT_NAME,");
			strSql.Append("FACTORY=@FACTORY,");
			strSql.Append("SALE_NAME=@SALE_NAME,");
			strSql.Append("CREATE_CODE=@CREATE_CODE,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where BILLNO=@BILLNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@MANUAL_BILLNO", SqlDbType.VarChar,100),
					new SqlParameter("@Vehicle_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@Vehicle_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@BILL_DATE", SqlDbType.DateTime),
					new SqlParameter("@BILL_STATUS", SqlDbType.NVarChar,10),
					new SqlParameter("@NOW_STATUS", SqlDbType.NVarChar,10),
					new SqlParameter("@NOW_DATE", SqlDbType.NVarChar,10),
					new SqlParameter("@STOCK_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@FACTORY", SqlDbType.NVarChar,50),
					new SqlParameter("@SALE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,200),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50)};
			parameters[0].Value = model.MASTERID;
			parameters[1].Value = model.MANUAL_BILLNO;
			parameters[2].Value = model.Vehicle_CODE;
			parameters[3].Value = model.Vehicle_NAME;
			parameters[4].Value = model.CUSTOM_CODE;
			parameters[5].Value = model.CUSTOM_NAME;
			parameters[6].Value = model.BILL_DATE;
			parameters[7].Value = model.BILL_STATUS;
			parameters[8].Value = model.NOW_STATUS;
			parameters[9].Value = model.NOW_DATE;
			parameters[10].Value = model.STOCK_CODE;
			parameters[11].Value = model.STOCK_NAME;
			parameters[12].Value = model.DEPARTMENT_CODE;
			parameters[13].Value = model.DEPARTMENT_NAME;
			parameters[14].Value = model.FACTORY;
			parameters[15].Value = model.SALE_NAME;
			parameters[16].Value = model.CREATE_CODE;
			parameters[17].Value = model.CREATE_NAME;
			parameters[18].Value = model.CREATE_DATE;
			parameters[19].Value = model.UPDATE_NAME;
			parameters[20].Value = model.UPDATE_DATE;
			parameters[21].Value = model.REMARK;
			parameters[22].Value = model.BILLNO;

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
		public bool Delete(string BILLNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ORDER_SEND_MASTER ");
			strSql.Append(" where BILLNO=@BILLNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50)			};
			parameters[0].Value = BILLNO;

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
		public bool DeleteList(string BILLNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ORDER_SEND_MASTER ");
			strSql.Append(" where BILLNO in ("+BILLNOlist + ")  ");
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
		public MyERP.Model.ORDER_SEND_MASTER GetModel(string BILLNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MASTERID,BILLNO,MANUAL_BILLNO,Vehicle_CODE,Vehicle_NAME,CUSTOM_CODE,CUSTOM_NAME,BILL_DATE,BILL_STATUS,NOW_STATUS,NOW_DATE,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,FACTORY,SALE_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from ORDER_SEND_MASTER ");
			strSql.Append(" where BILLNO=@BILLNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50)			};
			parameters[0].Value = BILLNO;

			MyERP.Model.ORDER_SEND_MASTER model=new MyERP.Model.ORDER_SEND_MASTER();
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
		public MyERP.Model.ORDER_SEND_MASTER DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_SEND_MASTER model=new MyERP.Model.ORDER_SEND_MASTER();
			if (row != null)
			{
				if(row["MASTERID"]!=null)
				{
					model.MASTERID=row["MASTERID"].ToString();
				}
				if(row["BILLNO"]!=null)
				{
					model.BILLNO=row["BILLNO"].ToString();
				}
				if(row["MANUAL_BILLNO"]!=null)
				{
					model.MANUAL_BILLNO=row["MANUAL_BILLNO"].ToString();
				}
				if(row["Vehicle_CODE"]!=null)
				{
					model.Vehicle_CODE=row["Vehicle_CODE"].ToString();
				}
				if(row["Vehicle_NAME"]!=null)
				{
					model.Vehicle_NAME=row["Vehicle_NAME"].ToString();
				}
				if(row["CUSTOM_CODE"]!=null)
				{
					model.CUSTOM_CODE=row["CUSTOM_CODE"].ToString();
				}
				if(row["CUSTOM_NAME"]!=null)
				{
					model.CUSTOM_NAME=row["CUSTOM_NAME"].ToString();
				}
				if(row["BILL_DATE"]!=null && row["BILL_DATE"].ToString()!="")
				{
					model.BILL_DATE=DateTime.Parse(row["BILL_DATE"].ToString());
				}
				if(row["BILL_STATUS"]!=null)
				{
					model.BILL_STATUS=row["BILL_STATUS"].ToString();
				}
				if(row["NOW_STATUS"]!=null)
				{
					model.NOW_STATUS=row["NOW_STATUS"].ToString();
				}
				if(row["NOW_DATE"]!=null)
				{
					model.NOW_DATE=row["NOW_DATE"].ToString();
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
				if(row["FACTORY"]!=null)
				{
					model.FACTORY=row["FACTORY"].ToString();
				}
				if(row["SALE_NAME"]!=null)
				{
					model.SALE_NAME=row["SALE_NAME"].ToString();
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
			strSql.Append("select MASTERID,BILLNO,MANUAL_BILLNO,Vehicle_CODE,Vehicle_NAME,CUSTOM_CODE,CUSTOM_NAME,BILL_DATE,BILL_STATUS,NOW_STATUS,NOW_DATE,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,FACTORY,SALE_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_SEND_MASTER ");
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
			strSql.Append(" MASTERID,BILLNO,MANUAL_BILLNO,Vehicle_CODE,Vehicle_NAME,CUSTOM_CODE,CUSTOM_NAME,BILL_DATE,BILL_STATUS,NOW_STATUS,NOW_DATE,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,FACTORY,SALE_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_SEND_MASTER ");
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
			strSql.Append("select count(1) FROM ORDER_SEND_MASTER ");
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
				strSql.Append("order by T.BILLNO desc");
			}
			strSql.Append(")AS Row, T.*  from ORDER_SEND_MASTER T ");
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
			parameters[0].Value = "ORDER_SEND_MASTER";
			parameters[1].Value = "BILLNO";
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

