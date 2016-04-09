using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_FIXEDASSET
	/// </summary>
	public partial class PUB_FIXEDASSET
	{
		public PUB_FIXEDASSET()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ITEM_INTERNAL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PUB_FIXEDASSET");
			strSql.Append(" where ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = ITEM_INTERNAL_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_FIXEDASSET model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_FIXEDASSET(");
			strSql.Append("ITEM_INTERNAL_CODE,FIXEDASSET_CODE,FIXEDASSET_NAME,SPECIFICATIONS,SUPPLY_CODE,SUPPLY_NAME,OUT_DATE,POWER_RATE,BEGIN_DATE,END_DATE,MEASURE_UNIT,QUANTITY,FIXEDASSET_STATUS,DEPARTMENT_CODE,DEPARTMENT_NAME,POSITION,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@ITEM_INTERNAL_CODE,@FIXEDASSET_CODE,@FIXEDASSET_NAME,@SPECIFICATIONS,@SUPPLY_CODE,@SUPPLY_NAME,@OUT_DATE,@POWER_RATE,@BEGIN_DATE,@END_DATE,@MEASURE_UNIT,@QUANTITY,@FIXEDASSET_STATUS,@DEPARTMENT_CODE,@DEPARTMENT_NAME,@POSITION,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@FIXEDASSET_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@FIXEDASSET_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.VarChar,50),
					new SqlParameter("@SUPPLY_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SUPPLY_NAME", SqlDbType.NChar,10),
					new SqlParameter("@OUT_DATE", SqlDbType.DateTime),
					new SqlParameter("@POWER_RATE", SqlDbType.VarChar,50),
					new SqlParameter("@BEGIN_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@END_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.VarChar,50),
					new SqlParameter("@QUANTITY", SqlDbType.Float,8),
					new SqlParameter("@FIXEDASSET_STATUS", SqlDbType.NChar,10),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@POSITION", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ITEM_INTERNAL_CODE;
			parameters[1].Value = model.FIXEDASSET_CODE;
			parameters[2].Value = model.FIXEDASSET_NAME;
			parameters[3].Value = model.SPECIFICATIONS;
			parameters[4].Value = model.SUPPLY_CODE;
			parameters[5].Value = model.SUPPLY_NAME;
			parameters[6].Value = model.OUT_DATE;
			parameters[7].Value = model.POWER_RATE;
			parameters[8].Value = model.BEGIN_DATE;
			parameters[9].Value = model.END_DATE;
			parameters[10].Value = model.MEASURE_UNIT;
			parameters[11].Value = model.QUANTITY;
			parameters[12].Value = model.FIXEDASSET_STATUS;
			parameters[13].Value = model.DEPARTMENT_CODE;
			parameters[14].Value = model.DEPARTMENT_NAME;
			parameters[15].Value = model.POSITION;
			parameters[16].Value = model.CREATE_NAME;
			parameters[17].Value = model.CREATE_DATE;
			parameters[18].Value = model.UPDATE_NAME;
			parameters[19].Value = model.UPDATE_DATE;
			parameters[20].Value = model.REMARK;

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
		public bool Update(MyERP.Model.PUB_FIXEDASSET model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_FIXEDASSET set ");
			strSql.Append("FIXEDASSET_CODE=@FIXEDASSET_CODE,");
			strSql.Append("FIXEDASSET_NAME=@FIXEDASSET_NAME,");
			strSql.Append("SPECIFICATIONS=@SPECIFICATIONS,");
			strSql.Append("SUPPLY_CODE=@SUPPLY_CODE,");
			strSql.Append("SUPPLY_NAME=@SUPPLY_NAME,");
			strSql.Append("OUT_DATE=@OUT_DATE,");
			strSql.Append("POWER_RATE=@POWER_RATE,");
			strSql.Append("BEGIN_DATE=@BEGIN_DATE,");
			strSql.Append("END_DATE=@END_DATE,");
			strSql.Append("MEASURE_UNIT=@MEASURE_UNIT,");
			strSql.Append("QUANTITY=@QUANTITY,");
			strSql.Append("FIXEDASSET_STATUS=@FIXEDASSET_STATUS,");
			strSql.Append("DEPARTMENT_CODE=@DEPARTMENT_CODE,");
			strSql.Append("DEPARTMENT_NAME=@DEPARTMENT_NAME,");
			strSql.Append("POSITION=@POSITION,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@FIXEDASSET_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@FIXEDASSET_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.VarChar,50),
					new SqlParameter("@SUPPLY_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SUPPLY_NAME", SqlDbType.NChar,10),
					new SqlParameter("@OUT_DATE", SqlDbType.DateTime),
					new SqlParameter("@POWER_RATE", SqlDbType.VarChar,50),
					new SqlParameter("@BEGIN_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@END_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.VarChar,50),
					new SqlParameter("@QUANTITY", SqlDbType.Float,8),
					new SqlParameter("@FIXEDASSET_STATUS", SqlDbType.NChar,10),
					new SqlParameter("@DEPARTMENT_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@DEPARTMENT_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@POSITION", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.FIXEDASSET_CODE;
			parameters[1].Value = model.FIXEDASSET_NAME;
			parameters[2].Value = model.SPECIFICATIONS;
			parameters[3].Value = model.SUPPLY_CODE;
			parameters[4].Value = model.SUPPLY_NAME;
			parameters[5].Value = model.OUT_DATE;
			parameters[6].Value = model.POWER_RATE;
			parameters[7].Value = model.BEGIN_DATE;
			parameters[8].Value = model.END_DATE;
			parameters[9].Value = model.MEASURE_UNIT;
			parameters[10].Value = model.QUANTITY;
			parameters[11].Value = model.FIXEDASSET_STATUS;
			parameters[12].Value = model.DEPARTMENT_CODE;
			parameters[13].Value = model.DEPARTMENT_NAME;
			parameters[14].Value = model.POSITION;
			parameters[15].Value = model.CREATE_NAME;
			parameters[16].Value = model.CREATE_DATE;
			parameters[17].Value = model.UPDATE_NAME;
			parameters[18].Value = model.UPDATE_DATE;
			parameters[19].Value = model.REMARK;
			parameters[20].Value = model.ITEM_INTERNAL_CODE;

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
		public bool Delete(string ITEM_INTERNAL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_FIXEDASSET ");
			strSql.Append(" where ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = ITEM_INTERNAL_CODE;

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
		public bool DeleteList(string ITEM_INTERNAL_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_FIXEDASSET ");
			strSql.Append(" where ITEM_INTERNAL_CODE in ("+ITEM_INTERNAL_CODElist + ")  ");
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
		public MyERP.Model.PUB_FIXEDASSET GetModel(string ITEM_INTERNAL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ITEM_INTERNAL_CODE,FIXEDASSET_CODE,FIXEDASSET_NAME,SPECIFICATIONS,SUPPLY_CODE,SUPPLY_NAME,OUT_DATE,POWER_RATE,BEGIN_DATE,END_DATE,MEASURE_UNIT,QUANTITY,FIXEDASSET_STATUS,DEPARTMENT_CODE,DEPARTMENT_NAME,POSITION,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from PUB_FIXEDASSET ");
			strSql.Append(" where ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.VarChar,50)			};
			parameters[0].Value = ITEM_INTERNAL_CODE;

			MyERP.Model.PUB_FIXEDASSET model=new MyERP.Model.PUB_FIXEDASSET();
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
		public MyERP.Model.PUB_FIXEDASSET DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_FIXEDASSET model=new MyERP.Model.PUB_FIXEDASSET();
			if (row != null)
			{
				if(row["ITEM_INTERNAL_CODE"]!=null)
				{
					model.ITEM_INTERNAL_CODE=row["ITEM_INTERNAL_CODE"].ToString();
				}
				if(row["FIXEDASSET_CODE"]!=null)
				{
					model.FIXEDASSET_CODE=row["FIXEDASSET_CODE"].ToString();
				}
				if(row["FIXEDASSET_NAME"]!=null)
				{
					model.FIXEDASSET_NAME=row["FIXEDASSET_NAME"].ToString();
				}
				if(row["SPECIFICATIONS"]!=null)
				{
					model.SPECIFICATIONS=row["SPECIFICATIONS"].ToString();
				}
				if(row["SUPPLY_CODE"]!=null)
				{
					model.SUPPLY_CODE=row["SUPPLY_CODE"].ToString();
				}
				if(row["SUPPLY_NAME"]!=null)
				{
					model.SUPPLY_NAME=row["SUPPLY_NAME"].ToString();
				}
				if(row["OUT_DATE"]!=null && row["OUT_DATE"].ToString()!="")
				{
					model.OUT_DATE=DateTime.Parse(row["OUT_DATE"].ToString());
				}
				if(row["POWER_RATE"]!=null)
				{
					model.POWER_RATE=row["POWER_RATE"].ToString();
				}
				if(row["BEGIN_DATE"]!=null)
				{
					model.BEGIN_DATE=row["BEGIN_DATE"].ToString();
				}
				if(row["END_DATE"]!=null)
				{
					model.END_DATE=row["END_DATE"].ToString();
				}
				if(row["MEASURE_UNIT"]!=null)
				{
					model.MEASURE_UNIT=row["MEASURE_UNIT"].ToString();
				}
				if(row["QUANTITY"]!=null && row["QUANTITY"].ToString()!="")
				{
					model.QUANTITY=decimal.Parse(row["QUANTITY"].ToString());
				}
				if(row["FIXEDASSET_STATUS"]!=null)
				{
					model.FIXEDASSET_STATUS=row["FIXEDASSET_STATUS"].ToString();
				}
				if(row["DEPARTMENT_CODE"]!=null)
				{
					model.DEPARTMENT_CODE=row["DEPARTMENT_CODE"].ToString();
				}
				if(row["DEPARTMENT_NAME"]!=null)
				{
					model.DEPARTMENT_NAME=row["DEPARTMENT_NAME"].ToString();
				}
				if(row["POSITION"]!=null)
				{
					model.POSITION=row["POSITION"].ToString();
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
			strSql.Append("select ITEM_INTERNAL_CODE,FIXEDASSET_CODE,FIXEDASSET_NAME,SPECIFICATIONS,SUPPLY_CODE,SUPPLY_NAME,OUT_DATE,POWER_RATE,BEGIN_DATE,END_DATE,MEASURE_UNIT,QUANTITY,FIXEDASSET_STATUS,DEPARTMENT_CODE,DEPARTMENT_NAME,POSITION,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_FIXEDASSET ");
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
			strSql.Append(" ITEM_INTERNAL_CODE,FIXEDASSET_CODE,FIXEDASSET_NAME,SPECIFICATIONS,SUPPLY_CODE,SUPPLY_NAME,OUT_DATE,POWER_RATE,BEGIN_DATE,END_DATE,MEASURE_UNIT,QUANTITY,FIXEDASSET_STATUS,DEPARTMENT_CODE,DEPARTMENT_NAME,POSITION,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_FIXEDASSET ");
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
			strSql.Append("select count(1) FROM PUB_FIXEDASSET ");
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
				strSql.Append("order by T.ITEM_INTERNAL_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUB_FIXEDASSET T ");
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
			parameters[0].Value = "PUB_FIXEDASSET";
			parameters[1].Value = "ITEM_INTERNAL_CODE";
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

