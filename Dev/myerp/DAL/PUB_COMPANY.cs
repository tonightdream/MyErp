using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_COMPANY
	/// </summary>
	public partial class PUB_COMPANY
	{
		public PUB_COMPANY()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_COMPANY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_COMPANY(");
			strSql.Append("COMPANY_CODE,COMPANY_NAME,COMPANY_FULLNAME,PARENT_COMPANY_CODE,MANAGER,ADDRESS,TELPHONE,ZIP,EMAIL,HTTP,LICENSE,REGISTER_BANK,BANK_ACCOUNT,ALLOW_USED,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@COMPANY_CODE,@COMPANY_NAME,@COMPANY_FULLNAME,@PARENT_COMPANY_CODE,@MANAGER,@ADDRESS,@TELPHONE,@ZIP,@EMAIL,@HTTP,@LICENSE,@REGISTER_BANK,@BANK_ACCOUNT,@ALLOW_USED,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,10),
					new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar,60),
					new SqlParameter("@COMPANY_FULLNAME", SqlDbType.NChar,200),
					new SqlParameter("@PARENT_COMPANY_CODE", SqlDbType.NVarChar,10),
					new SqlParameter("@MANAGER", SqlDbType.NVarChar,20),
					new SqlParameter("@ADDRESS", SqlDbType.NVarChar,200),
					new SqlParameter("@TELPHONE", SqlDbType.NVarChar,20),
					new SqlParameter("@ZIP", SqlDbType.NVarChar,6),
					new SqlParameter("@EMAIL", SqlDbType.NVarChar,20),
					new SqlParameter("@HTTP", SqlDbType.NVarChar,20),
					new SqlParameter("@LICENSE", SqlDbType.NVarChar,50),
					new SqlParameter("@REGISTER_BANK", SqlDbType.NVarChar,60),
					new SqlParameter("@BANK_ACCOUNT", SqlDbType.NVarChar,30),
					new SqlParameter("@ALLOW_USED", SqlDbType.NVarChar,1),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.COMPANY_NAME;
			parameters[2].Value = model.COMPANY_FULLNAME;
			parameters[3].Value = model.PARENT_COMPANY_CODE;
			parameters[4].Value = model.MANAGER;
			parameters[5].Value = model.ADDRESS;
			parameters[6].Value = model.TELPHONE;
			parameters[7].Value = model.ZIP;
			parameters[8].Value = model.EMAIL;
			parameters[9].Value = model.HTTP;
			parameters[10].Value = model.LICENSE;
			parameters[11].Value = model.REGISTER_BANK;
			parameters[12].Value = model.BANK_ACCOUNT;
			parameters[13].Value = model.ALLOW_USED;
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
		public bool Update(MyERP.Model.PUB_COMPANY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_COMPANY set ");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("COMPANY_NAME=@COMPANY_NAME,");
			strSql.Append("COMPANY_FULLNAME=@COMPANY_FULLNAME,");
			strSql.Append("PARENT_COMPANY_CODE=@PARENT_COMPANY_CODE,");
			strSql.Append("MANAGER=@MANAGER,");
			strSql.Append("ADDRESS=@ADDRESS,");
			strSql.Append("TELPHONE=@TELPHONE,");
			strSql.Append("ZIP=@ZIP,");
			strSql.Append("EMAIL=@EMAIL,");
			strSql.Append("HTTP=@HTTP,");
			strSql.Append("LICENSE=@LICENSE,");
			strSql.Append("REGISTER_BANK=@REGISTER_BANK,");
			strSql.Append("BANK_ACCOUNT=@BANK_ACCOUNT,");
			strSql.Append("ALLOW_USED=@ALLOW_USED,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,10),
					new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar,60),
					new SqlParameter("@COMPANY_FULLNAME", SqlDbType.NChar,200),
					new SqlParameter("@PARENT_COMPANY_CODE", SqlDbType.NVarChar,10),
					new SqlParameter("@MANAGER", SqlDbType.NVarChar,20),
					new SqlParameter("@ADDRESS", SqlDbType.NVarChar,200),
					new SqlParameter("@TELPHONE", SqlDbType.NVarChar,20),
					new SqlParameter("@ZIP", SqlDbType.NVarChar,6),
					new SqlParameter("@EMAIL", SqlDbType.NVarChar,20),
					new SqlParameter("@HTTP", SqlDbType.NVarChar,20),
					new SqlParameter("@LICENSE", SqlDbType.NVarChar,50),
					new SqlParameter("@REGISTER_BANK", SqlDbType.NVarChar,60),
					new SqlParameter("@BANK_ACCOUNT", SqlDbType.NVarChar,30),
					new SqlParameter("@ALLOW_USED", SqlDbType.NVarChar,1),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.COMPANY_CODE;
			parameters[1].Value = model.COMPANY_NAME;
			parameters[2].Value = model.COMPANY_FULLNAME;
			parameters[3].Value = model.PARENT_COMPANY_CODE;
			parameters[4].Value = model.MANAGER;
			parameters[5].Value = model.ADDRESS;
			parameters[6].Value = model.TELPHONE;
			parameters[7].Value = model.ZIP;
			parameters[8].Value = model.EMAIL;
			parameters[9].Value = model.HTTP;
			parameters[10].Value = model.LICENSE;
			parameters[11].Value = model.REGISTER_BANK;
			parameters[12].Value = model.BANK_ACCOUNT;
			parameters[13].Value = model.ALLOW_USED;
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
			strSql.Append("delete from PUB_COMPANY ");
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
		public MyERP.Model.PUB_COMPANY GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 COMPANY_CODE,COMPANY_NAME,COMPANY_FULLNAME,PARENT_COMPANY_CODE,MANAGER,ADDRESS,TELPHONE,ZIP,EMAIL,HTTP,LICENSE,REGISTER_BANK,BANK_ACCOUNT,ALLOW_USED,REMARK from PUB_COMPANY ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.PUB_COMPANY model=new MyERP.Model.PUB_COMPANY();
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
		public MyERP.Model.PUB_COMPANY DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_COMPANY model=new MyERP.Model.PUB_COMPANY();
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
				if(row["COMPANY_FULLNAME"]!=null)
				{
					model.COMPANY_FULLNAME=row["COMPANY_FULLNAME"].ToString();
				}
				if(row["PARENT_COMPANY_CODE"]!=null)
				{
					model.PARENT_COMPANY_CODE=row["PARENT_COMPANY_CODE"].ToString();
				}
				if(row["MANAGER"]!=null)
				{
					model.MANAGER=row["MANAGER"].ToString();
				}
				if(row["ADDRESS"]!=null)
				{
					model.ADDRESS=row["ADDRESS"].ToString();
				}
				if(row["TELPHONE"]!=null)
				{
					model.TELPHONE=row["TELPHONE"].ToString();
				}
				if(row["ZIP"]!=null)
				{
					model.ZIP=row["ZIP"].ToString();
				}
				if(row["EMAIL"]!=null)
				{
					model.EMAIL=row["EMAIL"].ToString();
				}
				if(row["HTTP"]!=null)
				{
					model.HTTP=row["HTTP"].ToString();
				}
				if(row["LICENSE"]!=null)
				{
					model.LICENSE=row["LICENSE"].ToString();
				}
				if(row["REGISTER_BANK"]!=null)
				{
					model.REGISTER_BANK=row["REGISTER_BANK"].ToString();
				}
				if(row["BANK_ACCOUNT"]!=null)
				{
					model.BANK_ACCOUNT=row["BANK_ACCOUNT"].ToString();
				}
				if(row["ALLOW_USED"]!=null)
				{
					model.ALLOW_USED=row["ALLOW_USED"].ToString();
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
			strSql.Append("select COMPANY_CODE,COMPANY_NAME,COMPANY_FULLNAME,PARENT_COMPANY_CODE,MANAGER,ADDRESS,TELPHONE,ZIP,EMAIL,HTTP,LICENSE,REGISTER_BANK,BANK_ACCOUNT,ALLOW_USED,REMARK ");
			strSql.Append(" FROM PUB_COMPANY ");
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
			strSql.Append(" COMPANY_CODE,COMPANY_NAME,COMPANY_FULLNAME,PARENT_COMPANY_CODE,MANAGER,ADDRESS,TELPHONE,ZIP,EMAIL,HTTP,LICENSE,REGISTER_BANK,BANK_ACCOUNT,ALLOW_USED,REMARK ");
			strSql.Append(" FROM PUB_COMPANY ");
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
			strSql.Append("select count(1) FROM PUB_COMPANY ");
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
				strSql.Append("order by T.BANK_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUB_COMPANY T ");
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
			parameters[0].Value = "PUB_COMPANY";
			parameters[1].Value = "BANK_CODE";
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

