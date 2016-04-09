using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:VIP_GRADE
	/// </summary>
	public partial class VIP_GRADE
	{
		public VIP_GRADE()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.VIP_GRADE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into VIP_GRADE(");
			strSql.Append("COMPANY_CODE,GRADE_CODE,GRADE_NAME,GRADE_TYPE,indate,outdate,LOW_SALES,TOTAL_SALES,zsrgrade,standrate,specialrate,birthdayrate,birthdayspsrate,year_option,run,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@COMPANY_CODE,@GRADE_CODE,@GRADE_NAME,@GRADE_TYPE,@indate,@outdate,@LOW_SALES,@TOTAL_SALES,@zsrgrade,@standrate,@specialrate,@birthdayrate,@birthdayspsrate,@year_option,@run,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.VarChar,40),
					new SqlParameter("@GRADE_CODE", SqlDbType.VarChar,40),
					new SqlParameter("@GRADE_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@GRADE_TYPE", SqlDbType.VarChar,30),
					new SqlParameter("@indate", SqlDbType.DateTime),
					new SqlParameter("@outdate", SqlDbType.DateTime),
					new SqlParameter("@LOW_SALES", SqlDbType.Decimal,17),
					new SqlParameter("@TOTAL_SALES", SqlDbType.Decimal,17),
					new SqlParameter("@zsrgrade", SqlDbType.Decimal,9),
					new SqlParameter("@standrate", SqlDbType.Decimal,5),
					new SqlParameter("@specialrate", SqlDbType.Decimal,5),
					new SqlParameter("@birthdayrate", SqlDbType.Decimal,5),
					new SqlParameter("@birthdayspsrate", SqlDbType.Decimal,5),
					new SqlParameter("@year_option", SqlDbType.Decimal,5),
					new SqlParameter("@run", SqlDbType.VarChar,10),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,100)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.GRADE_CODE;
			parameters[2].Value = model.GRADE_NAME;
			parameters[3].Value = model.GRADE_TYPE;
			parameters[4].Value = model.indate;
			parameters[5].Value = model.outdate;
			parameters[6].Value = model.LOW_SALES;
			parameters[7].Value = model.TOTAL_SALES;
			parameters[8].Value = model.zsrgrade;
			parameters[9].Value = model.standrate;
			parameters[10].Value = model.specialrate;
			parameters[11].Value = model.birthdayrate;
			parameters[12].Value = model.birthdayspsrate;
			parameters[13].Value = model.year_option;
			parameters[14].Value = model.run;
			parameters[15].Value = model.CREATE_NAME;
			parameters[16].Value = model.CREATE_DATE;
			parameters[17].Value = model.UPDATE_NAME;
			parameters[18].Value = model.UPDATE_DATE;
			parameters[19].Value = model.REMARK;

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
		public bool Update(MyERP.Model.VIP_GRADE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update VIP_GRADE set ");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("GRADE_CODE=@GRADE_CODE,");
			strSql.Append("GRADE_NAME=@GRADE_NAME,");
			strSql.Append("GRADE_TYPE=@GRADE_TYPE,");
			strSql.Append("indate=@indate,");
			strSql.Append("outdate=@outdate,");
			strSql.Append("LOW_SALES=@LOW_SALES,");
			strSql.Append("TOTAL_SALES=@TOTAL_SALES,");
			strSql.Append("zsrgrade=@zsrgrade,");
			strSql.Append("standrate=@standrate,");
			strSql.Append("specialrate=@specialrate,");
			strSql.Append("birthdayrate=@birthdayrate,");
			strSql.Append("birthdayspsrate=@birthdayspsrate,");
			strSql.Append("year_option=@year_option,");
			strSql.Append("run=@run,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.VarChar,40),
					new SqlParameter("@GRADE_CODE", SqlDbType.VarChar,40),
					new SqlParameter("@GRADE_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@GRADE_TYPE", SqlDbType.VarChar,30),
					new SqlParameter("@indate", SqlDbType.DateTime),
					new SqlParameter("@outdate", SqlDbType.DateTime),
					new SqlParameter("@LOW_SALES", SqlDbType.Decimal,17),
					new SqlParameter("@TOTAL_SALES", SqlDbType.Decimal,17),
					new SqlParameter("@zsrgrade", SqlDbType.Decimal,9),
					new SqlParameter("@standrate", SqlDbType.Decimal,5),
					new SqlParameter("@specialrate", SqlDbType.Decimal,5),
					new SqlParameter("@birthdayrate", SqlDbType.Decimal,5),
					new SqlParameter("@birthdayspsrate", SqlDbType.Decimal,5),
					new SqlParameter("@year_option", SqlDbType.Decimal,5),
					new SqlParameter("@run", SqlDbType.VarChar,10),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,20),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,100)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.GRADE_CODE;
			parameters[2].Value = model.GRADE_NAME;
			parameters[3].Value = model.GRADE_TYPE;
			parameters[4].Value = model.indate;
			parameters[5].Value = model.outdate;
			parameters[6].Value = model.LOW_SALES;
			parameters[7].Value = model.TOTAL_SALES;
			parameters[8].Value = model.zsrgrade;
			parameters[9].Value = model.standrate;
			parameters[10].Value = model.specialrate;
			parameters[11].Value = model.birthdayrate;
			parameters[12].Value = model.birthdayspsrate;
			parameters[13].Value = model.year_option;
			parameters[14].Value = model.run;
			parameters[15].Value = model.CREATE_NAME;
			parameters[16].Value = model.CREATE_DATE;
			parameters[17].Value = model.UPDATE_NAME;
			parameters[18].Value = model.UPDATE_DATE;
			parameters[19].Value = model.REMARK;

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
			strSql.Append("delete from VIP_GRADE ");
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
		public MyERP.Model.VIP_GRADE GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 COMPANY_CODE,GRADE_CODE,GRADE_NAME,GRADE_TYPE,indate,outdate,LOW_SALES,TOTAL_SALES,zsrgrade,standrate,specialrate,birthdayrate,birthdayspsrate,year_option,run,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from VIP_GRADE ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.VIP_GRADE model=new MyERP.Model.VIP_GRADE();
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
		public MyERP.Model.VIP_GRADE DataRowToModel(DataRow row)
		{
			MyERP.Model.VIP_GRADE model=new MyERP.Model.VIP_GRADE();
			if (row != null)
			{
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
				}
				if(row["GRADE_CODE"]!=null)
				{
					model.GRADE_CODE=row["GRADE_CODE"].ToString();
				}
				if(row["GRADE_NAME"]!=null)
				{
					model.GRADE_NAME=row["GRADE_NAME"].ToString();
				}
				if(row["GRADE_TYPE"]!=null)
				{
					model.GRADE_TYPE=row["GRADE_TYPE"].ToString();
				}
				if(row["indate"]!=null && row["indate"].ToString()!="")
				{
					model.indate=DateTime.Parse(row["indate"].ToString());
				}
				if(row["outdate"]!=null && row["outdate"].ToString()!="")
				{
					model.outdate=DateTime.Parse(row["outdate"].ToString());
				}
				if(row["LOW_SALES"]!=null && row["LOW_SALES"].ToString()!="")
				{
					model.LOW_SALES=decimal.Parse(row["LOW_SALES"].ToString());
				}
				if(row["TOTAL_SALES"]!=null && row["TOTAL_SALES"].ToString()!="")
				{
					model.TOTAL_SALES=decimal.Parse(row["TOTAL_SALES"].ToString());
				}
				if(row["zsrgrade"]!=null && row["zsrgrade"].ToString()!="")
				{
					model.zsrgrade=decimal.Parse(row["zsrgrade"].ToString());
				}
				if(row["standrate"]!=null && row["standrate"].ToString()!="")
				{
					model.standrate=decimal.Parse(row["standrate"].ToString());
				}
				if(row["specialrate"]!=null && row["specialrate"].ToString()!="")
				{
					model.specialrate=decimal.Parse(row["specialrate"].ToString());
				}
				if(row["birthdayrate"]!=null && row["birthdayrate"].ToString()!="")
				{
					model.birthdayrate=decimal.Parse(row["birthdayrate"].ToString());
				}
				if(row["birthdayspsrate"]!=null && row["birthdayspsrate"].ToString()!="")
				{
					model.birthdayspsrate=decimal.Parse(row["birthdayspsrate"].ToString());
				}
				if(row["year_option"]!=null && row["year_option"].ToString()!="")
				{
					model.year_option=decimal.Parse(row["year_option"].ToString());
				}
				if(row["run"]!=null)
				{
					model.run=row["run"].ToString();
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
			strSql.Append("select COMPANY_CODE,GRADE_CODE,GRADE_NAME,GRADE_TYPE,indate,outdate,LOW_SALES,TOTAL_SALES,zsrgrade,standrate,specialrate,birthdayrate,birthdayspsrate,year_option,run,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM VIP_GRADE ");
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
			strSql.Append(" COMPANY_CODE,GRADE_CODE,GRADE_NAME,GRADE_TYPE,indate,outdate,LOW_SALES,TOTAL_SALES,zsrgrade,standrate,specialrate,birthdayrate,birthdayspsrate,year_option,run,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM VIP_GRADE ");
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
			strSql.Append("select count(1) FROM VIP_GRADE ");
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
			strSql.Append(")AS Row, T.*  from VIP_GRADE T ");
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
			parameters[0].Value = "VIP_GRADE";
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

