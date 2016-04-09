using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_COMPLAIN
	/// </summary>
	public partial class ORDER_COMPLAIN
	{
		public ORDER_COMPLAIN()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_COMPLAIN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_COMPLAIN(");
			strSql.Append("INTERNAL_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,CUSTOM_CODE,CUSTOM_NAME,BILLNO,ITEM_CODE,ITEM_NAME,MEASURE_UNIT,SPECIFICATIONS,IMAGE_NAME,QUANTITY,COMPLAIN_question,UPDATE_question,Tracking_question,BEGIN_DATE,END_DATE,BILL_STATUS,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@INTERNAL_CODE,@DEPARTMENT_CODE,@DEPARTMENT_NAME,@CUSTOM_CODE,@CUSTOM_NAME,@BILLNO,@ITEM_CODE,@ITEM_NAME,@MEASURE_UNIT,@SPECIFICATIONS,@IMAGE_NAME,@QUANTITY,@COMPLAIN_question,@UPDATE_question,@Tracking_question,@BEGIN_DATE,@END_DATE,@BILL_STATUS,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.VarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.VarChar,50),
					new SqlParameter("@IMAGE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@QUANTITY", SqlDbType.Float,8),
					new SqlParameter("@COMPLAIN_question", SqlDbType.NText),
					new SqlParameter("@UPDATE_question", SqlDbType.NText),
					new SqlParameter("@Tracking_question", SqlDbType.NText),
					new SqlParameter("@BEGIN_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@END_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@BILL_STATUS", SqlDbType.NChar,10),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.DEPARTMENT_CODE;
			parameters[2].Value = model.DEPARTMENT_NAME;
			parameters[3].Value = model.CUSTOM_CODE;
			parameters[4].Value = model.CUSTOM_NAME;
			parameters[5].Value = model.BILLNO;
			parameters[6].Value = model.ITEM_CODE;
			parameters[7].Value = model.ITEM_NAME;
			parameters[8].Value = model.MEASURE_UNIT;
			parameters[9].Value = model.SPECIFICATIONS;
			parameters[10].Value = model.IMAGE_NAME;
			parameters[11].Value = model.QUANTITY;
			parameters[12].Value = model.COMPLAIN_question;
			parameters[13].Value = model.UPDATE_question;
			parameters[14].Value = model.Tracking_question;
			parameters[15].Value = model.BEGIN_DATE;
			parameters[16].Value = model.END_DATE;
			parameters[17].Value = model.BILL_STATUS;
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
		public bool Update(MyERP.Model.ORDER_COMPLAIN model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_COMPLAIN set ");
			strSql.Append("INTERNAL_CODE=@INTERNAL_CODE,");
			strSql.Append("DEPARTMENT_CODE=@DEPARTMENT_CODE,");
			strSql.Append("DEPARTMENT_NAME=@DEPARTMENT_NAME,");
			strSql.Append("CUSTOM_CODE=@CUSTOM_CODE,");
			strSql.Append("CUSTOM_NAME=@CUSTOM_NAME,");
			strSql.Append("BILLNO=@BILLNO,");
			strSql.Append("ITEM_CODE=@ITEM_CODE,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("MEASURE_UNIT=@MEASURE_UNIT,");
			strSql.Append("SPECIFICATIONS=@SPECIFICATIONS,");
			strSql.Append("IMAGE_NAME=@IMAGE_NAME,");
			strSql.Append("QUANTITY=@QUANTITY,");
			strSql.Append("COMPLAIN_question=@COMPLAIN_question,");
			strSql.Append("UPDATE_question=@UPDATE_question,");
			strSql.Append("Tracking_question=@Tracking_question,");
			strSql.Append("BEGIN_DATE=@BEGIN_DATE,");
			strSql.Append("END_DATE=@END_DATE,");
			strSql.Append("BILL_STATUS=@BILL_STATUS,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.VarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.VarChar,50),
					new SqlParameter("@IMAGE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@QUANTITY", SqlDbType.Float,8),
					new SqlParameter("@COMPLAIN_question", SqlDbType.NText),
					new SqlParameter("@UPDATE_question", SqlDbType.NText),
					new SqlParameter("@Tracking_question", SqlDbType.NText),
					new SqlParameter("@BEGIN_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@END_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@BILL_STATUS", SqlDbType.NChar,10),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.DEPARTMENT_CODE;
			parameters[2].Value = model.DEPARTMENT_NAME;
			parameters[3].Value = model.CUSTOM_CODE;
			parameters[4].Value = model.CUSTOM_NAME;
			parameters[5].Value = model.BILLNO;
			parameters[6].Value = model.ITEM_CODE;
			parameters[7].Value = model.ITEM_NAME;
			parameters[8].Value = model.MEASURE_UNIT;
			parameters[9].Value = model.SPECIFICATIONS;
			parameters[10].Value = model.IMAGE_NAME;
			parameters[11].Value = model.QUANTITY;
			parameters[12].Value = model.COMPLAIN_question;
			parameters[13].Value = model.UPDATE_question;
			parameters[14].Value = model.Tracking_question;
			parameters[15].Value = model.BEGIN_DATE;
			parameters[16].Value = model.END_DATE;
			parameters[17].Value = model.BILL_STATUS;
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
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ORDER_COMPLAIN ");
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
		public MyERP.Model.ORDER_COMPLAIN GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 INTERNAL_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,CUSTOM_CODE,CUSTOM_NAME,BILLNO,ITEM_CODE,ITEM_NAME,MEASURE_UNIT,SPECIFICATIONS,IMAGE_NAME,QUANTITY,COMPLAIN_question,UPDATE_question,Tracking_question,BEGIN_DATE,END_DATE,BILL_STATUS,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from ORDER_COMPLAIN ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.ORDER_COMPLAIN model=new MyERP.Model.ORDER_COMPLAIN();
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
		public MyERP.Model.ORDER_COMPLAIN DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_COMPLAIN model=new MyERP.Model.ORDER_COMPLAIN();
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
				if(row["CUSTOM_CODE"]!=null)
				{
					model.CUSTOM_CODE=row["CUSTOM_CODE"].ToString();
				}
				if(row["CUSTOM_NAME"]!=null)
				{
					model.CUSTOM_NAME=row["CUSTOM_NAME"].ToString();
				}
				if(row["BILLNO"]!=null)
				{
					model.BILLNO=row["BILLNO"].ToString();
				}
				if(row["ITEM_CODE"]!=null)
				{
					model.ITEM_CODE=row["ITEM_CODE"].ToString();
				}
				if(row["ITEM_NAME"]!=null)
				{
					model.ITEM_NAME=row["ITEM_NAME"].ToString();
				}
				if(row["MEASURE_UNIT"]!=null)
				{
					model.MEASURE_UNIT=row["MEASURE_UNIT"].ToString();
				}
				if(row["SPECIFICATIONS"]!=null)
				{
					model.SPECIFICATIONS=row["SPECIFICATIONS"].ToString();
				}
				if(row["IMAGE_NAME"]!=null)
				{
					model.IMAGE_NAME=row["IMAGE_NAME"].ToString();
				}
				if(row["QUANTITY"]!=null && row["QUANTITY"].ToString()!="")
				{
					model.QUANTITY=decimal.Parse(row["QUANTITY"].ToString());
				}
				if(row["COMPLAIN_question"]!=null)
				{
					model.COMPLAIN_question=row["COMPLAIN_question"].ToString();
				}
				if(row["UPDATE_question"]!=null)
				{
					model.UPDATE_question=row["UPDATE_question"].ToString();
				}
				if(row["Tracking_question"]!=null)
				{
					model.Tracking_question=row["Tracking_question"].ToString();
				}
				if(row["BEGIN_DATE"]!=null)
				{
					model.BEGIN_DATE=row["BEGIN_DATE"].ToString();
				}
				if(row["END_DATE"]!=null)
				{
					model.END_DATE=row["END_DATE"].ToString();
				}
				if(row["BILL_STATUS"]!=null)
				{
					model.BILL_STATUS=row["BILL_STATUS"].ToString();
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
			strSql.Append("select INTERNAL_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,CUSTOM_CODE,CUSTOM_NAME,BILLNO,ITEM_CODE,ITEM_NAME,MEASURE_UNIT,SPECIFICATIONS,IMAGE_NAME,QUANTITY,COMPLAIN_question,UPDATE_question,Tracking_question,BEGIN_DATE,END_DATE,BILL_STATUS,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_COMPLAIN ");
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
			strSql.Append(" INTERNAL_CODE,DEPARTMENT_CODE,DEPARTMENT_NAME,CUSTOM_CODE,CUSTOM_NAME,BILLNO,ITEM_CODE,ITEM_NAME,MEASURE_UNIT,SPECIFICATIONS,IMAGE_NAME,QUANTITY,COMPLAIN_question,UPDATE_question,Tracking_question,BEGIN_DATE,END_DATE,BILL_STATUS,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_COMPLAIN ");
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
			strSql.Append("select count(1) FROM ORDER_COMPLAIN ");
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
			strSql.Append(")AS Row, T.*  from ORDER_COMPLAIN T ");
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
			parameters[0].Value = "ORDER_COMPLAIN";
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

