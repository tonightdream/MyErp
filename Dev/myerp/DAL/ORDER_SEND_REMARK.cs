using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_SEND_REMARK
	/// </summary>
	public partial class ORDER_SEND_REMARK
	{
		public ORDER_SEND_REMARK()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_SEND_REMARK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_SEND_REMARK(");
			strSql.Append("MASTERID,BILLNO,Sequence,MANUAL_BILLNO,Vehicle_CODE,Vehicle_NAME,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@MASTERID,@BILLNO,@Sequence,@MANUAL_BILLNO,@Vehicle_CODE,@Vehicle_NAME,@STOCK_CODE,@STOCK_NAME,@DEPARTMENT_CODE,@DEPARTMENT_NAME,@CREATE_CODE,@CREATE_NAME,@CREATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@Sequence", SqlDbType.Int,4),
					new SqlParameter("@MANUAL_BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@Vehicle_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@Vehicle_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@STOCK_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,200)};
			parameters[0].Value = model.MASTERID;
			parameters[1].Value = model.BILLNO;
			parameters[2].Value = model.Sequence;
			parameters[3].Value = model.MANUAL_BILLNO;
			parameters[4].Value = model.Vehicle_CODE;
			parameters[5].Value = model.Vehicle_NAME;
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
		public bool Update(MyERP.Model.ORDER_SEND_REMARK model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_SEND_REMARK set ");
			strSql.Append("MASTERID=@MASTERID,");
			strSql.Append("BILLNO=@BILLNO,");
			strSql.Append("Sequence=@Sequence,");
			strSql.Append("MANUAL_BILLNO=@MANUAL_BILLNO,");
			strSql.Append("Vehicle_CODE=@Vehicle_CODE,");
			strSql.Append("Vehicle_NAME=@Vehicle_NAME,");
			strSql.Append("STOCK_CODE=@STOCK_CODE,");
			strSql.Append("STOCK_NAME=@STOCK_NAME,");
			strSql.Append("DEPARTMENT_CODE=@DEPARTMENT_CODE,");
			strSql.Append("DEPARTMENT_NAME=@DEPARTMENT_NAME,");
			strSql.Append("CREATE_CODE=@CREATE_CODE,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@Sequence", SqlDbType.Int,4),
					new SqlParameter("@MANUAL_BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@Vehicle_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@Vehicle_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@STOCK_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,200)};
			parameters[0].Value = model.MASTERID;
			parameters[1].Value = model.BILLNO;
			parameters[2].Value = model.Sequence;
			parameters[3].Value = model.MANUAL_BILLNO;
			parameters[4].Value = model.Vehicle_CODE;
			parameters[5].Value = model.Vehicle_NAME;
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
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ORDER_SEND_REMARK ");
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
		public MyERP.Model.ORDER_SEND_REMARK GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MASTERID,BILLNO,Sequence,MANUAL_BILLNO,Vehicle_CODE,Vehicle_NAME,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,REMARK from ORDER_SEND_REMARK ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.ORDER_SEND_REMARK model=new MyERP.Model.ORDER_SEND_REMARK();
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
		public MyERP.Model.ORDER_SEND_REMARK DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_SEND_REMARK model=new MyERP.Model.ORDER_SEND_REMARK();
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
				if(row["Sequence"]!=null && row["Sequence"].ToString()!="")
				{
					model.Sequence=int.Parse(row["Sequence"].ToString());
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
			strSql.Append("select MASTERID,BILLNO,Sequence,MANUAL_BILLNO,Vehicle_CODE,Vehicle_NAME,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_SEND_REMARK ");
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
			strSql.Append(" MASTERID,BILLNO,Sequence,MANUAL_BILLNO,Vehicle_CODE,Vehicle_NAME,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,CREATE_CODE,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_SEND_REMARK ");
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
			strSql.Append("select count(1) FROM ORDER_SEND_REMARK ");
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
			strSql.Append(")AS Row, T.*  from ORDER_SEND_REMARK T ");
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
			parameters[0].Value = "ORDER_SEND_REMARK";
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

