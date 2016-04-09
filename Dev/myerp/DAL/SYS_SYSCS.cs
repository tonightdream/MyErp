using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:SYS_SYSCS
	/// </summary>
	public partial class SYS_SYSCS
	{
		public SYS_SYSCS()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.SYS_SYSCS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SYS_SYSCS(");
			strSql.Append("COMPANY_CODE,COMPANY_NAME,FullName,Address,Phone,Email,Fax,SHDCNT,ITEM_CODE_LENGTH,Billasstock,MAYLH,ServiceTelphone,CREATE_NAME,CREATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@COMPANY_CODE,@COMPANY_NAME,@FullName,@Address,@Phone,@Email,@Fax,@SHDCNT,@ITEM_CODE_LENGTH,@Billasstock,@MAYLH,@ServiceTelphone,@CREATE_NAME,@CREATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@FullName", SqlDbType.NVarChar,80),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@SHDCNT", SqlDbType.Int,4),
					new SqlParameter("@ITEM_CODE_LENGTH", SqlDbType.VarChar,50),
					new SqlParameter("@Billasstock", SqlDbType.Bit,1),
					new SqlParameter("@MAYLH", SqlDbType.NVarChar,1),
					new SqlParameter("@ServiceTelphone", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.NVarChar,50),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.COMPANY_NAME;
			parameters[2].Value = model.FullName;
			parameters[3].Value = model.Address;
			parameters[4].Value = model.Phone;
			parameters[5].Value = model.Email;
			parameters[6].Value = model.Fax;
			parameters[7].Value = model.SHDCNT;
			parameters[8].Value = model.ITEM_CODE_LENGTH;
			parameters[9].Value = model.Billasstock;
			parameters[10].Value = model.MAYLH;
			parameters[11].Value = model.ServiceTelphone;
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
		public bool Update(MyERP.Model.SYS_SYSCS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SYS_SYSCS set ");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("COMPANY_NAME=@COMPANY_NAME,");
			strSql.Append("FullName=@FullName,");
			strSql.Append("Address=@Address,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Email=@Email,");
			strSql.Append("Fax=@Fax,");
			strSql.Append("SHDCNT=@SHDCNT,");
			strSql.Append("ITEM_CODE_LENGTH=@ITEM_CODE_LENGTH,");
			strSql.Append("Billasstock=@Billasstock,");
			strSql.Append("MAYLH=@MAYLH,");
			strSql.Append("ServiceTelphone=@ServiceTelphone,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@FullName", SqlDbType.NVarChar,80),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@SHDCNT", SqlDbType.Int,4),
					new SqlParameter("@ITEM_CODE_LENGTH", SqlDbType.VarChar,50),
					new SqlParameter("@Billasstock", SqlDbType.Bit,1),
					new SqlParameter("@MAYLH", SqlDbType.NVarChar,1),
					new SqlParameter("@ServiceTelphone", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.NVarChar,50),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.COMPANY_NAME;
			parameters[2].Value = model.FullName;
			parameters[3].Value = model.Address;
			parameters[4].Value = model.Phone;
			parameters[5].Value = model.Email;
			parameters[6].Value = model.Fax;
			parameters[7].Value = model.SHDCNT;
			parameters[8].Value = model.ITEM_CODE_LENGTH;
			parameters[9].Value = model.Billasstock;
			parameters[10].Value = model.MAYLH;
			parameters[11].Value = model.ServiceTelphone;
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
			strSql.Append("delete from SYS_SYSCS ");
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
		public MyERP.Model.SYS_SYSCS GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 COMPANY_CODE,COMPANY_NAME,FullName,Address,Phone,Email,Fax,SHDCNT,ITEM_CODE_LENGTH,Billasstock,MAYLH,ServiceTelphone,CREATE_NAME,CREATE_DATE,REMARK from SYS_SYSCS ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.SYS_SYSCS model=new MyERP.Model.SYS_SYSCS();
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
		public MyERP.Model.SYS_SYSCS DataRowToModel(DataRow row)
		{
			MyERP.Model.SYS_SYSCS model=new MyERP.Model.SYS_SYSCS();
			if (row != null)
			{
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
				}
				if(row["COMPANY_NAME"]!=null)
				{
					model.COMPANY_NAME=row["COMPANY_NAME"].ToString();
				}
				if(row["FullName"]!=null)
				{
					model.FullName=row["FullName"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Fax"]!=null)
				{
					model.Fax=row["Fax"].ToString();
				}
				if(row["SHDCNT"]!=null && row["SHDCNT"].ToString()!="")
				{
					model.SHDCNT=int.Parse(row["SHDCNT"].ToString());
				}
				if(row["ITEM_CODE_LENGTH"]!=null)
				{
					model.ITEM_CODE_LENGTH=row["ITEM_CODE_LENGTH"].ToString();
				}
				if(row["Billasstock"]!=null && row["Billasstock"].ToString()!="")
				{
					if((row["Billasstock"].ToString()=="1")||(row["Billasstock"].ToString().ToLower()=="true"))
					{
						model.Billasstock=true;
					}
					else
					{
						model.Billasstock=false;
					}
				}
				if(row["MAYLH"]!=null)
				{
					model.MAYLH=row["MAYLH"].ToString();
				}
				if(row["ServiceTelphone"]!=null)
				{
					model.ServiceTelphone=row["ServiceTelphone"].ToString();
				}
				if(row["CREATE_NAME"]!=null)
				{
					model.CREATE_NAME=row["CREATE_NAME"].ToString();
				}
				if(row["CREATE_DATE"]!=null)
				{
					model.CREATE_DATE=row["CREATE_DATE"].ToString();
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
			strSql.Append("select COMPANY_CODE,COMPANY_NAME,FullName,Address,Phone,Email,Fax,SHDCNT,ITEM_CODE_LENGTH,Billasstock,MAYLH,ServiceTelphone,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM SYS_SYSCS ");
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
			strSql.Append(" COMPANY_CODE,COMPANY_NAME,FullName,Address,Phone,Email,Fax,SHDCNT,ITEM_CODE_LENGTH,Billasstock,MAYLH,ServiceTelphone,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM SYS_SYSCS ");
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
			strSql.Append("select count(1) FROM SYS_SYSCS ");
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
				strSql.Append("order by T.COMPANY_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from SYS_SYSCS T ");
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
			parameters[0].Value = "SYS_SYSCS";
			parameters[1].Value = "COMPANY_CODE";
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

