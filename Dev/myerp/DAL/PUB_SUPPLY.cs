using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_SUPPLY
	/// </summary>
	public partial class PUB_SUPPLY
	{
		public PUB_SUPPLY()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_SUPPLY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_SUPPLY(");
			strSql.Append("INTERNAL_CODE,SUPPLY_CODE,SUPPLY_NAME,PARENT_SUPPLY_CODE,TypeCode,TypeName,TELPHONE,TELPHONE1,FAX,EMAIL,FULLNAME,ADDRESS,EASYCODE,Contact_MAN,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,ALLOW_used,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@INTERNAL_CODE,@SUPPLY_CODE,@SUPPLY_NAME,@PARENT_SUPPLY_CODE,@TypeCode,@TypeName,@TELPHONE,@TELPHONE1,@FAX,@EMAIL,@FULLNAME,@ADDRESS,@EASYCODE,@Contact_MAN,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@ALLOW_used,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@SUPPLY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@SUPPLY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_SUPPLY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@TypeCode", SqlDbType.NVarChar,50),
					new SqlParameter("@TypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@TELPHONE", SqlDbType.NVarChar,50),
					new SqlParameter("@TELPHONE1", SqlDbType.NVarChar,50),
					new SqlParameter("@FAX", SqlDbType.NVarChar,50),
					new SqlParameter("@EMAIL", SqlDbType.NVarChar,50),
					new SqlParameter("@FULLNAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ADDRESS", SqlDbType.NVarChar,50),
					new SqlParameter("@EASYCODE", SqlDbType.NVarChar,50),
					new SqlParameter("@Contact_MAN", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@ALLOW_used", SqlDbType.Bit,1),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.SUPPLY_CODE;
			parameters[2].Value = model.SUPPLY_NAME;
			parameters[3].Value = model.PARENT_SUPPLY_CODE;
			parameters[4].Value = model.TypeCode;
			parameters[5].Value = model.TypeName;
			parameters[6].Value = model.TELPHONE;
			parameters[7].Value = model.TELPHONE1;
			parameters[8].Value = model.FAX;
			parameters[9].Value = model.EMAIL;
			parameters[10].Value = model.FULLNAME;
			parameters[11].Value = model.ADDRESS;
			parameters[12].Value = model.EASYCODE;
			parameters[13].Value = model.Contact_MAN;
			parameters[14].Value = model.CREATE_NAME;
			parameters[15].Value = model.CREATE_DATE;
			parameters[16].Value = model.UPDATE_NAME;
			parameters[17].Value = model.UPDATE_DATE;
			parameters[18].Value = model.ALLOW_used;
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
		public bool Update(MyERP.Model.PUB_SUPPLY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_SUPPLY set ");
			strSql.Append("INTERNAL_CODE=@INTERNAL_CODE,");
			strSql.Append("SUPPLY_CODE=@SUPPLY_CODE,");
			strSql.Append("SUPPLY_NAME=@SUPPLY_NAME,");
			strSql.Append("PARENT_SUPPLY_CODE=@PARENT_SUPPLY_CODE,");
			strSql.Append("TypeCode=@TypeCode,");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("TELPHONE=@TELPHONE,");
			strSql.Append("TELPHONE1=@TELPHONE1,");
			strSql.Append("FAX=@FAX,");
			strSql.Append("EMAIL=@EMAIL,");
			strSql.Append("FULLNAME=@FULLNAME,");
			strSql.Append("ADDRESS=@ADDRESS,");
			strSql.Append("EASYCODE=@EASYCODE,");
			strSql.Append("Contact_MAN=@Contact_MAN,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("ALLOW_used=@ALLOW_used,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@SUPPLY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@SUPPLY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_SUPPLY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@TypeCode", SqlDbType.NVarChar,50),
					new SqlParameter("@TypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@TELPHONE", SqlDbType.NVarChar,50),
					new SqlParameter("@TELPHONE1", SqlDbType.NVarChar,50),
					new SqlParameter("@FAX", SqlDbType.NVarChar,50),
					new SqlParameter("@EMAIL", SqlDbType.NVarChar,50),
					new SqlParameter("@FULLNAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ADDRESS", SqlDbType.NVarChar,50),
					new SqlParameter("@EASYCODE", SqlDbType.NVarChar,50),
					new SqlParameter("@Contact_MAN", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@ALLOW_used", SqlDbType.Bit,1),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.SUPPLY_CODE;
			parameters[2].Value = model.SUPPLY_NAME;
			parameters[3].Value = model.PARENT_SUPPLY_CODE;
			parameters[4].Value = model.TypeCode;
			parameters[5].Value = model.TypeName;
			parameters[6].Value = model.TELPHONE;
			parameters[7].Value = model.TELPHONE1;
			parameters[8].Value = model.FAX;
			parameters[9].Value = model.EMAIL;
			parameters[10].Value = model.FULLNAME;
			parameters[11].Value = model.ADDRESS;
			parameters[12].Value = model.EASYCODE;
			parameters[13].Value = model.Contact_MAN;
			parameters[14].Value = model.CREATE_NAME;
			parameters[15].Value = model.CREATE_DATE;
			parameters[16].Value = model.UPDATE_NAME;
			parameters[17].Value = model.UPDATE_DATE;
			parameters[18].Value = model.ALLOW_used;
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
			strSql.Append("delete from PUB_SUPPLY ");
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
		public MyERP.Model.PUB_SUPPLY GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 INTERNAL_CODE,SUPPLY_CODE,SUPPLY_NAME,PARENT_SUPPLY_CODE,TypeCode,TypeName,TELPHONE,TELPHONE1,FAX,EMAIL,FULLNAME,ADDRESS,EASYCODE,Contact_MAN,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,ALLOW_used,REMARK from PUB_SUPPLY ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.PUB_SUPPLY model=new MyERP.Model.PUB_SUPPLY();
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
		public MyERP.Model.PUB_SUPPLY DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_SUPPLY model=new MyERP.Model.PUB_SUPPLY();
			if (row != null)
			{
				if(row["INTERNAL_CODE"]!=null)
				{
					model.INTERNAL_CODE=row["INTERNAL_CODE"].ToString();
				}
				if(row["SUPPLY_CODE"]!=null)
				{
					model.SUPPLY_CODE=row["SUPPLY_CODE"].ToString();
				}
				if(row["SUPPLY_NAME"]!=null)
				{
					model.SUPPLY_NAME=row["SUPPLY_NAME"].ToString();
				}
				if(row["PARENT_SUPPLY_CODE"]!=null)
				{
					model.PARENT_SUPPLY_CODE=row["PARENT_SUPPLY_CODE"].ToString();
				}
				if(row["TypeCode"]!=null)
				{
					model.TypeCode=row["TypeCode"].ToString();
				}
				if(row["TypeName"]!=null)
				{
					model.TypeName=row["TypeName"].ToString();
				}
				if(row["TELPHONE"]!=null)
				{
					model.TELPHONE=row["TELPHONE"].ToString();
				}
				if(row["TELPHONE1"]!=null)
				{
					model.TELPHONE1=row["TELPHONE1"].ToString();
				}
				if(row["FAX"]!=null)
				{
					model.FAX=row["FAX"].ToString();
				}
				if(row["EMAIL"]!=null)
				{
					model.EMAIL=row["EMAIL"].ToString();
				}
				if(row["FULLNAME"]!=null)
				{
					model.FULLNAME=row["FULLNAME"].ToString();
				}
				if(row["ADDRESS"]!=null)
				{
					model.ADDRESS=row["ADDRESS"].ToString();
				}
				if(row["EASYCODE"]!=null)
				{
					model.EASYCODE=row["EASYCODE"].ToString();
				}
				if(row["Contact_MAN"]!=null)
				{
					model.Contact_MAN=row["Contact_MAN"].ToString();
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
				if(row["ALLOW_used"]!=null && row["ALLOW_used"].ToString()!="")
				{
					if((row["ALLOW_used"].ToString()=="1")||(row["ALLOW_used"].ToString().ToLower()=="true"))
					{
						model.ALLOW_used=true;
					}
					else
					{
						model.ALLOW_used=false;
					}
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
			strSql.Append("select INTERNAL_CODE,SUPPLY_CODE,SUPPLY_NAME,PARENT_SUPPLY_CODE,TypeCode,TypeName,TELPHONE,TELPHONE1,FAX,EMAIL,FULLNAME,ADDRESS,EASYCODE,Contact_MAN,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,ALLOW_used,REMARK ");
			strSql.Append(" FROM PUB_SUPPLY ");
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
			strSql.Append(" INTERNAL_CODE,SUPPLY_CODE,SUPPLY_NAME,PARENT_SUPPLY_CODE,TypeCode,TypeName,TELPHONE,TELPHONE1,FAX,EMAIL,FULLNAME,ADDRESS,EASYCODE,Contact_MAN,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,ALLOW_used,REMARK ");
			strSql.Append(" FROM PUB_SUPPLY ");
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
			strSql.Append("select count(1) FROM PUB_SUPPLY ");
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
				strSql.Append("order by T.STOCK_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUB_SUPPLY T ");
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
			parameters[0].Value = "PUB_SUPPLY";
			parameters[1].Value = "STOCK_CODE";
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

