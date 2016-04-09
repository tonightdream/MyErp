using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:SYS_USER
	/// </summary>
	public partial class SYS_USER
	{
		public SYS_USER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string USER_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SYS_USER");
			strSql.Append(" where USER_CODE=@USER_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_CODE", SqlDbType.NVarChar,12)			};
			parameters[0].Value = USER_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.SYS_USER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SYS_USER(");
			strSql.Append("USER_CODE,COMPANY_CODE,COMPANY_NAME,USER_NAME,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,department,PARENT_DEPARTMENT_CODE,PPRICE_SHOW,PASSWORD,Description,EmployeeCode,AllowUsed,isLicenceAudit,UserType,LastEdit,AuditDate)");
			strSql.Append(" values (");
			strSql.Append("@USER_CODE,@COMPANY_CODE,@COMPANY_NAME,@USER_NAME,@STOCK_CODE,@STOCK_NAME,@DEPARTMENT_CODE,@DEPARTMENT_NAME,@department,@PARENT_DEPARTMENT_CODE,@PPRICE_SHOW,@PASSWORD,@Description,@EmployeeCode,@AllowUsed,@isLicenceAudit,@UserType,@LastEdit,@AuditDate)");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_CODE", SqlDbType.NVarChar,12),
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@USER_NAME", SqlDbType.NVarChar,20),
					new SqlParameter("@STOCK_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@department", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_DEPARTMENT_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@PPRICE_SHOW", SqlDbType.Bit,1),
					new SqlParameter("@PASSWORD", SqlDbType.NVarChar,20),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeCode", SqlDbType.NVarChar,12),
					new SqlParameter("@AllowUsed", SqlDbType.Text),
					new SqlParameter("@isLicenceAudit", SqlDbType.NVarChar,1),
					new SqlParameter("@UserType", SqlDbType.NVarChar,20),
					new SqlParameter("@LastEdit", SqlDbType.VarBinary,8),
					new SqlParameter("@AuditDate", SqlDbType.DateTime)};
			parameters[0].Value = model.USER_CODE;
			parameters[1].Value = model.COMPANY_CODE;
			parameters[2].Value = model.COMPANY_NAME;
			parameters[3].Value = model.USER_NAME;
			parameters[4].Value = model.STOCK_CODE;
			parameters[5].Value = model.STOCK_NAME;
			parameters[6].Value = model.DEPARTMENT_CODE;
			parameters[7].Value = model.DEPARTMENT_NAME;
			parameters[8].Value = model.department;
			parameters[9].Value = model.PARENT_DEPARTMENT_CODE;
			parameters[10].Value = model.PPRICE_SHOW;
			parameters[11].Value = model.PASSWORD;
			parameters[12].Value = model.Description;
			parameters[13].Value = model.EmployeeCode;
			parameters[14].Value = model.AllowUsed;
			parameters[15].Value = model.isLicenceAudit;
			parameters[16].Value = model.UserType;
			parameters[17].Value = model.LastEdit;
			parameters[18].Value = model.AuditDate;

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
		public bool Update(MyERP.Model.SYS_USER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SYS_USER set ");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("COMPANY_NAME=@COMPANY_NAME,");
			strSql.Append("USER_NAME=@USER_NAME,");
			strSql.Append("STOCK_CODE=@STOCK_CODE,");
			strSql.Append("STOCK_NAME=@STOCK_NAME,");
			strSql.Append("DEPARTMENT_CODE=@DEPARTMENT_CODE,");
			strSql.Append("DEPARTMENT_NAME=@DEPARTMENT_NAME,");
			strSql.Append("department=@department,");
			strSql.Append("PARENT_DEPARTMENT_CODE=@PARENT_DEPARTMENT_CODE,");
			strSql.Append("PPRICE_SHOW=@PPRICE_SHOW,");
			strSql.Append("PASSWORD=@PASSWORD,");
			strSql.Append("Description=@Description,");
			strSql.Append("EmployeeCode=@EmployeeCode,");
			strSql.Append("AllowUsed=@AllowUsed,");
			strSql.Append("isLicenceAudit=@isLicenceAudit,");
			strSql.Append("UserType=@UserType,");
			strSql.Append("LastEdit=@LastEdit,");
			strSql.Append("AuditDate=@AuditDate");
			strSql.Append(" where USER_CODE=@USER_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@USER_NAME", SqlDbType.NVarChar,20),
					new SqlParameter("@STOCK_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@STOCK_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@department", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_DEPARTMENT_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@PPRICE_SHOW", SqlDbType.Bit,1),
					new SqlParameter("@PASSWORD", SqlDbType.NVarChar,20),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeCode", SqlDbType.NVarChar,12),
					new SqlParameter("@AllowUsed", SqlDbType.Text),
					new SqlParameter("@isLicenceAudit", SqlDbType.NVarChar,1),
					new SqlParameter("@UserType", SqlDbType.NVarChar,20),
					new SqlParameter("@LastEdit", SqlDbType.VarBinary,8),
					new SqlParameter("@AuditDate", SqlDbType.DateTime),
					new SqlParameter("@USER_CODE", SqlDbType.NVarChar,12)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.COMPANY_NAME;
			parameters[2].Value = model.USER_NAME;
			parameters[3].Value = model.STOCK_CODE;
			parameters[4].Value = model.STOCK_NAME;
			parameters[5].Value = model.DEPARTMENT_CODE;
			parameters[6].Value = model.DEPARTMENT_NAME;
			parameters[7].Value = model.department;
			parameters[8].Value = model.PARENT_DEPARTMENT_CODE;
			parameters[9].Value = model.PPRICE_SHOW;
			parameters[10].Value = model.PASSWORD;
			parameters[11].Value = model.Description;
			parameters[12].Value = model.EmployeeCode;
			parameters[13].Value = model.AllowUsed;
			parameters[14].Value = model.isLicenceAudit;
			parameters[15].Value = model.UserType;
			parameters[16].Value = model.LastEdit;
			parameters[17].Value = model.AuditDate;
			parameters[18].Value = model.USER_CODE;

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
		public bool Delete(string USER_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SYS_USER ");
			strSql.Append(" where USER_CODE=@USER_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_CODE", SqlDbType.NVarChar,12)			};
			parameters[0].Value = USER_CODE;

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
		public bool DeleteList(string USER_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SYS_USER ");
			strSql.Append(" where USER_CODE in ("+USER_CODElist + ")  ");
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
		public MyERP.Model.SYS_USER GetModel(string USER_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 USER_CODE,COMPANY_CODE,COMPANY_NAME,USER_NAME,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,department,PARENT_DEPARTMENT_CODE,PPRICE_SHOW,PASSWORD,Description,EmployeeCode,AllowUsed,isLicenceAudit,UserType,LastEdit,AuditDate from SYS_USER ");
			strSql.Append(" where USER_CODE=@USER_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_CODE", SqlDbType.NVarChar,12)			};
			parameters[0].Value = USER_CODE;

			MyERP.Model.SYS_USER model=new MyERP.Model.SYS_USER();
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
		public MyERP.Model.SYS_USER DataRowToModel(DataRow row)
		{
			MyERP.Model.SYS_USER model=new MyERP.Model.SYS_USER();
			if (row != null)
			{
				if(row["USER_CODE"]!=null)
				{
					model.USER_CODE=row["USER_CODE"].ToString();
				}
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
				}
				if(row["COMPANY_NAME"]!=null)
				{
					model.COMPANY_NAME=row["COMPANY_NAME"].ToString();
				}
				if(row["USER_NAME"]!=null)
				{
					model.USER_NAME=row["USER_NAME"].ToString();
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
				if(row["department"]!=null)
				{
					model.department=row["department"].ToString();
				}
				if(row["PARENT_DEPARTMENT_CODE"]!=null)
				{
					model.PARENT_DEPARTMENT_CODE=row["PARENT_DEPARTMENT_CODE"].ToString();
				}
				if(row["PPRICE_SHOW"]!=null && row["PPRICE_SHOW"].ToString()!="")
				{
					if((row["PPRICE_SHOW"].ToString()=="1")||(row["PPRICE_SHOW"].ToString().ToLower()=="true"))
					{
						model.PPRICE_SHOW=true;
					}
					else
					{
						model.PPRICE_SHOW=false;
					}
				}
				if(row["PASSWORD"]!=null)
				{
					model.PASSWORD=row["PASSWORD"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["EmployeeCode"]!=null)
				{
					model.EmployeeCode=row["EmployeeCode"].ToString();
				}
				if(row["AllowUsed"]!=null)
				{
					model.AllowUsed=row["AllowUsed"].ToString();
				}
				if(row["isLicenceAudit"]!=null)
				{
					model.isLicenceAudit=row["isLicenceAudit"].ToString();
				}
				if(row["UserType"]!=null)
				{
					model.UserType=row["UserType"].ToString();
				}
				if(row["LastEdit"]!=null && row["LastEdit"].ToString()!="")
				{
					model.LastEdit=(byte[])row["LastEdit"];
				}
				if(row["AuditDate"]!=null && row["AuditDate"].ToString()!="")
				{
					model.AuditDate=DateTime.Parse(row["AuditDate"].ToString());
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
			strSql.Append("select USER_CODE,COMPANY_CODE,COMPANY_NAME,USER_NAME,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,department,PARENT_DEPARTMENT_CODE,PPRICE_SHOW,PASSWORD,Description,EmployeeCode,AllowUsed,isLicenceAudit,UserType,LastEdit,AuditDate ");
			strSql.Append(" FROM SYS_USER ");
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
			strSql.Append(" USER_CODE,COMPANY_CODE,COMPANY_NAME,USER_NAME,STOCK_CODE,STOCK_NAME,DEPARTMENT_CODE,DEPARTMENT_NAME,department,PARENT_DEPARTMENT_CODE,PPRICE_SHOW,PASSWORD,Description,EmployeeCode,AllowUsed,isLicenceAudit,UserType,LastEdit,AuditDate ");
			strSql.Append(" FROM SYS_USER ");
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
			strSql.Append("select count(1) FROM SYS_USER ");
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
				strSql.Append("order by T.USER_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from SYS_USER T ");
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
			parameters[0].Value = "SYS_USER";
			parameters[1].Value = "USER_CODE";
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

