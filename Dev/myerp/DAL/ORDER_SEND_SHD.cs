using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_SEND_SHD
	/// </summary>
	public partial class ORDER_SEND_SHD
	{
		public ORDER_SEND_SHD()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_SEND_SHD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_SEND_SHD(");
			strSql.Append("BillNo,BILL_DATE,CUSTOM_CODE,CUSTOM_NAME,PCBH,CLBH,SHJE,THJE,HZJE,LWKKJE,YSJE,Accepter,CREATE_NAME,CREATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@BillNo,@BILL_DATE,@CUSTOM_CODE,@CUSTOM_NAME,@PCBH,@CLBH,@SHJE,@THJE,@HZJE,@LWKKJE,@YSJE,@Accepter,@CREATE_NAME,@CREATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNo", SqlDbType.VarChar,50),
					new SqlParameter("@BILL_DATE", SqlDbType.DateTime),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@PCBH", SqlDbType.VarChar,50),
					new SqlParameter("@CLBH", SqlDbType.VarChar,50),
					new SqlParameter("@SHJE", SqlDbType.Float,8),
					new SqlParameter("@THJE", SqlDbType.Float,8),
					new SqlParameter("@HZJE", SqlDbType.Float,8),
					new SqlParameter("@LWKKJE", SqlDbType.Float,8),
					new SqlParameter("@YSJE", SqlDbType.Float,8),
					new SqlParameter("@Accepter", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BillNo;
			parameters[1].Value = model.BILL_DATE;
			parameters[2].Value = model.CUSTOM_CODE;
			parameters[3].Value = model.CUSTOM_NAME;
			parameters[4].Value = model.PCBH;
			parameters[5].Value = model.CLBH;
			parameters[6].Value = model.SHJE;
			parameters[7].Value = model.THJE;
			parameters[8].Value = model.HZJE;
			parameters[9].Value = model.LWKKJE;
			parameters[10].Value = model.YSJE;
			parameters[11].Value = model.Accepter;
			parameters[12].Value = model.CREATE_NAME;
			parameters[13].Value = model.CREATE_DATE;
			parameters[14].Value = model.REMARK;

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
		public bool Update(MyERP.Model.ORDER_SEND_SHD model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_SEND_SHD set ");
			strSql.Append("BillNo=@BillNo,");
			strSql.Append("BILL_DATE=@BILL_DATE,");
			strSql.Append("CUSTOM_CODE=@CUSTOM_CODE,");
			strSql.Append("CUSTOM_NAME=@CUSTOM_NAME,");
			strSql.Append("PCBH=@PCBH,");
			strSql.Append("CLBH=@CLBH,");
			strSql.Append("SHJE=@SHJE,");
			strSql.Append("THJE=@THJE,");
			strSql.Append("HZJE=@HZJE,");
			strSql.Append("LWKKJE=@LWKKJE,");
			strSql.Append("YSJE=@YSJE,");
			strSql.Append("Accepter=@Accepter,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNo", SqlDbType.VarChar,50),
					new SqlParameter("@BILL_DATE", SqlDbType.DateTime),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@PCBH", SqlDbType.VarChar,50),
					new SqlParameter("@CLBH", SqlDbType.VarChar,50),
					new SqlParameter("@SHJE", SqlDbType.Float,8),
					new SqlParameter("@THJE", SqlDbType.Float,8),
					new SqlParameter("@HZJE", SqlDbType.Float,8),
					new SqlParameter("@LWKKJE", SqlDbType.Float,8),
					new SqlParameter("@YSJE", SqlDbType.Float,8),
					new SqlParameter("@Accepter", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BillNo;
			parameters[1].Value = model.BILL_DATE;
			parameters[2].Value = model.CUSTOM_CODE;
			parameters[3].Value = model.CUSTOM_NAME;
			parameters[4].Value = model.PCBH;
			parameters[5].Value = model.CLBH;
			parameters[6].Value = model.SHJE;
			parameters[7].Value = model.THJE;
			parameters[8].Value = model.HZJE;
			parameters[9].Value = model.LWKKJE;
			parameters[10].Value = model.YSJE;
			parameters[11].Value = model.Accepter;
			parameters[12].Value = model.CREATE_NAME;
			parameters[13].Value = model.CREATE_DATE;
			parameters[14].Value = model.REMARK;

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
			strSql.Append("delete from ORDER_SEND_SHD ");
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
		public MyERP.Model.ORDER_SEND_SHD GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BillNo,BILL_DATE,CUSTOM_CODE,CUSTOM_NAME,PCBH,CLBH,SHJE,THJE,HZJE,LWKKJE,YSJE,Accepter,CREATE_NAME,CREATE_DATE,REMARK from ORDER_SEND_SHD ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.ORDER_SEND_SHD model=new MyERP.Model.ORDER_SEND_SHD();
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
		public MyERP.Model.ORDER_SEND_SHD DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_SEND_SHD model=new MyERP.Model.ORDER_SEND_SHD();
			if (row != null)
			{
				if(row["BillNo"]!=null)
				{
					model.BillNo=row["BillNo"].ToString();
				}
				if(row["BILL_DATE"]!=null && row["BILL_DATE"].ToString()!="")
				{
					model.BILL_DATE=DateTime.Parse(row["BILL_DATE"].ToString());
				}
				if(row["CUSTOM_CODE"]!=null)
				{
					model.CUSTOM_CODE=row["CUSTOM_CODE"].ToString();
				}
				if(row["CUSTOM_NAME"]!=null)
				{
					model.CUSTOM_NAME=row["CUSTOM_NAME"].ToString();
				}
				if(row["PCBH"]!=null)
				{
					model.PCBH=row["PCBH"].ToString();
				}
				if(row["CLBH"]!=null)
				{
					model.CLBH=row["CLBH"].ToString();
				}
				if(row["SHJE"]!=null && row["SHJE"].ToString()!="")
				{
					model.SHJE=decimal.Parse(row["SHJE"].ToString());
				}
				if(row["THJE"]!=null && row["THJE"].ToString()!="")
				{
					model.THJE=decimal.Parse(row["THJE"].ToString());
				}
				if(row["HZJE"]!=null && row["HZJE"].ToString()!="")
				{
					model.HZJE=decimal.Parse(row["HZJE"].ToString());
				}
				if(row["LWKKJE"]!=null && row["LWKKJE"].ToString()!="")
				{
					model.LWKKJE=decimal.Parse(row["LWKKJE"].ToString());
				}
				if(row["YSJE"]!=null && row["YSJE"].ToString()!="")
				{
					model.YSJE=decimal.Parse(row["YSJE"].ToString());
				}
				if(row["Accepter"]!=null)
				{
					model.Accepter=row["Accepter"].ToString();
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
			strSql.Append("select BillNo,BILL_DATE,CUSTOM_CODE,CUSTOM_NAME,PCBH,CLBH,SHJE,THJE,HZJE,LWKKJE,YSJE,Accepter,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_SEND_SHD ");
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
			strSql.Append(" BillNo,BILL_DATE,CUSTOM_CODE,CUSTOM_NAME,PCBH,CLBH,SHJE,THJE,HZJE,LWKKJE,YSJE,Accepter,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_SEND_SHD ");
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
			strSql.Append("select count(1) FROM ORDER_SEND_SHD ");
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
			strSql.Append(")AS Row, T.*  from ORDER_SEND_SHD T ");
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
			parameters[0].Value = "ORDER_SEND_SHD";
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

