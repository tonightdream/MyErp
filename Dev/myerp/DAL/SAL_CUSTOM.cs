using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:SAL_CUSTOM
	/// </summary>
	public partial class SAL_CUSTOM
	{
		public SAL_CUSTOM()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.SAL_CUSTOM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SAL_CUSTOM(");
			strSql.Append("CompanyCode,CustomerCode,CustomerLevel,Discount,DiscountGrade,TradeAmount,TradeAmountDate,TradeGrade,DueAmount,DueAmountDate,DueGrade,DueTime,DueTimeGrade,DueTimeDate,Remark)");
			strSql.Append(" values (");
			strSql.Append("@CompanyCode,@CustomerCode,@CustomerLevel,@Discount,@DiscountGrade,@TradeAmount,@TradeAmountDate,@TradeGrade,@DueAmount,@DueAmountDate,@DueGrade,@DueTime,@DueTimeGrade,@DueTimeDate,@Remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,10),
					new SqlParameter("@CustomerCode", SqlDbType.NVarChar,20),
					new SqlParameter("@CustomerLevel", SqlDbType.NVarChar,20),
					new SqlParameter("@Discount", SqlDbType.Decimal,9),
					new SqlParameter("@DiscountGrade", SqlDbType.Int,4),
					new SqlParameter("@TradeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@TradeAmountDate", SqlDbType.SmallDateTime),
					new SqlParameter("@TradeGrade", SqlDbType.Int,4),
					new SqlParameter("@DueAmount", SqlDbType.Decimal,9),
					new SqlParameter("@DueAmountDate", SqlDbType.SmallDateTime),
					new SqlParameter("@DueGrade", SqlDbType.Int,4),
					new SqlParameter("@DueTime", SqlDbType.Int,4),
					new SqlParameter("@DueTimeGrade", SqlDbType.Int,4),
					new SqlParameter("@DueTimeDate", SqlDbType.SmallDateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.CompanyCode;
			parameters[1].Value = model.CustomerCode;
			parameters[2].Value = model.CustomerLevel;
			parameters[3].Value = model.Discount;
			parameters[4].Value = model.DiscountGrade;
			parameters[5].Value = model.TradeAmount;
			parameters[6].Value = model.TradeAmountDate;
			parameters[7].Value = model.TradeGrade;
			parameters[8].Value = model.DueAmount;
			parameters[9].Value = model.DueAmountDate;
			parameters[10].Value = model.DueGrade;
			parameters[11].Value = model.DueTime;
			parameters[12].Value = model.DueTimeGrade;
			parameters[13].Value = model.DueTimeDate;
			parameters[14].Value = model.Remark;

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
		public bool Update(MyERP.Model.SAL_CUSTOM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SAL_CUSTOM set ");
			strSql.Append("CompanyCode=@CompanyCode,");
			strSql.Append("CustomerCode=@CustomerCode,");
			strSql.Append("CustomerLevel=@CustomerLevel,");
			strSql.Append("Discount=@Discount,");
			strSql.Append("DiscountGrade=@DiscountGrade,");
			strSql.Append("TradeAmount=@TradeAmount,");
			strSql.Append("TradeAmountDate=@TradeAmountDate,");
			strSql.Append("TradeGrade=@TradeGrade,");
			strSql.Append("DueAmount=@DueAmount,");
			strSql.Append("DueAmountDate=@DueAmountDate,");
			strSql.Append("DueGrade=@DueGrade,");
			strSql.Append("DueTime=@DueTime,");
			strSql.Append("DueTimeGrade=@DueTimeGrade,");
			strSql.Append("DueTimeDate=@DueTimeDate,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,10),
					new SqlParameter("@CustomerCode", SqlDbType.NVarChar,20),
					new SqlParameter("@CustomerLevel", SqlDbType.NVarChar,20),
					new SqlParameter("@Discount", SqlDbType.Decimal,9),
					new SqlParameter("@DiscountGrade", SqlDbType.Int,4),
					new SqlParameter("@TradeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@TradeAmountDate", SqlDbType.SmallDateTime),
					new SqlParameter("@TradeGrade", SqlDbType.Int,4),
					new SqlParameter("@DueAmount", SqlDbType.Decimal,9),
					new SqlParameter("@DueAmountDate", SqlDbType.SmallDateTime),
					new SqlParameter("@DueGrade", SqlDbType.Int,4),
					new SqlParameter("@DueTime", SqlDbType.Int,4),
					new SqlParameter("@DueTimeGrade", SqlDbType.Int,4),
					new SqlParameter("@DueTimeDate", SqlDbType.SmallDateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.CompanyCode;
			parameters[1].Value = model.CustomerCode;
			parameters[2].Value = model.CustomerLevel;
			parameters[3].Value = model.Discount;
			parameters[4].Value = model.DiscountGrade;
			parameters[5].Value = model.TradeAmount;
			parameters[6].Value = model.TradeAmountDate;
			parameters[7].Value = model.TradeGrade;
			parameters[8].Value = model.DueAmount;
			parameters[9].Value = model.DueAmountDate;
			parameters[10].Value = model.DueGrade;
			parameters[11].Value = model.DueTime;
			parameters[12].Value = model.DueTimeGrade;
			parameters[13].Value = model.DueTimeDate;
			parameters[14].Value = model.Remark;

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
			strSql.Append("delete from SAL_CUSTOM ");
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
		public MyERP.Model.SAL_CUSTOM GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CompanyCode,CustomerCode,CustomerLevel,Discount,DiscountGrade,TradeAmount,TradeAmountDate,TradeGrade,DueAmount,DueAmountDate,DueGrade,DueTime,DueTimeGrade,DueTimeDate,Remark from SAL_CUSTOM ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.SAL_CUSTOM model=new MyERP.Model.SAL_CUSTOM();
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
		public MyERP.Model.SAL_CUSTOM DataRowToModel(DataRow row)
		{
			MyERP.Model.SAL_CUSTOM model=new MyERP.Model.SAL_CUSTOM();
			if (row != null)
			{
				if(row["CompanyCode"]!=null)
				{
					model.CompanyCode=row["CompanyCode"].ToString();
				}
				if(row["CustomerCode"]!=null)
				{
					model.CustomerCode=row["CustomerCode"].ToString();
				}
				if(row["CustomerLevel"]!=null)
				{
					model.CustomerLevel=row["CustomerLevel"].ToString();
				}
				if(row["Discount"]!=null && row["Discount"].ToString()!="")
				{
					model.Discount=decimal.Parse(row["Discount"].ToString());
				}
				if(row["DiscountGrade"]!=null && row["DiscountGrade"].ToString()!="")
				{
					model.DiscountGrade=int.Parse(row["DiscountGrade"].ToString());
				}
				if(row["TradeAmount"]!=null && row["TradeAmount"].ToString()!="")
				{
					model.TradeAmount=decimal.Parse(row["TradeAmount"].ToString());
				}
				if(row["TradeAmountDate"]!=null && row["TradeAmountDate"].ToString()!="")
				{
					model.TradeAmountDate=DateTime.Parse(row["TradeAmountDate"].ToString());
				}
				if(row["TradeGrade"]!=null && row["TradeGrade"].ToString()!="")
				{
					model.TradeGrade=int.Parse(row["TradeGrade"].ToString());
				}
				if(row["DueAmount"]!=null && row["DueAmount"].ToString()!="")
				{
					model.DueAmount=decimal.Parse(row["DueAmount"].ToString());
				}
				if(row["DueAmountDate"]!=null && row["DueAmountDate"].ToString()!="")
				{
					model.DueAmountDate=DateTime.Parse(row["DueAmountDate"].ToString());
				}
				if(row["DueGrade"]!=null && row["DueGrade"].ToString()!="")
				{
					model.DueGrade=int.Parse(row["DueGrade"].ToString());
				}
				if(row["DueTime"]!=null && row["DueTime"].ToString()!="")
				{
					model.DueTime=int.Parse(row["DueTime"].ToString());
				}
				if(row["DueTimeGrade"]!=null && row["DueTimeGrade"].ToString()!="")
				{
					model.DueTimeGrade=int.Parse(row["DueTimeGrade"].ToString());
				}
				if(row["DueTimeDate"]!=null && row["DueTimeDate"].ToString()!="")
				{
					model.DueTimeDate=DateTime.Parse(row["DueTimeDate"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select CompanyCode,CustomerCode,CustomerLevel,Discount,DiscountGrade,TradeAmount,TradeAmountDate,TradeGrade,DueAmount,DueAmountDate,DueGrade,DueTime,DueTimeGrade,DueTimeDate,Remark ");
			strSql.Append(" FROM SAL_CUSTOM ");
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
			strSql.Append(" CompanyCode,CustomerCode,CustomerLevel,Discount,DiscountGrade,TradeAmount,TradeAmountDate,TradeGrade,DueAmount,DueAmountDate,DueGrade,DueTime,DueTimeGrade,DueTimeDate,Remark ");
			strSql.Append(" FROM SAL_CUSTOM ");
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
			strSql.Append("select count(1) FROM SAL_CUSTOM ");
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
			strSql.Append(")AS Row, T.*  from SAL_CUSTOM T ");
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
			parameters[0].Value = "SAL_CUSTOM";
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

