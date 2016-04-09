using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:SAL_ITEM_NOW_PRICE
	/// </summary>
	public partial class SAL_ITEM_NOW_PRICE
	{
		public SAL_ITEM_NOW_PRICE()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.SAL_ITEM_NOW_PRICE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SAL_ITEM_NOW_PRICE(");
			strSql.Append("CompanyCode,ItemNo,Color,ItemInternalCode,InternalCodeMean,AllPrice,WholeSalePrice,OncePrice,MeasureUnit,LastEdit)");
			strSql.Append(" values (");
			strSql.Append("@CompanyCode,@ItemNo,@Color,@ItemInternalCode,@InternalCodeMean,@AllPrice,@WholeSalePrice,@OncePrice,@MeasureUnit,@LastEdit)");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,10),
					new SqlParameter("@ItemNo", SqlDbType.NVarChar,20),
					new SqlParameter("@Color", SqlDbType.NVarChar,10),
					new SqlParameter("@ItemInternalCode", SqlDbType.NVarChar,200),
					new SqlParameter("@InternalCodeMean", SqlDbType.NVarChar,200),
					new SqlParameter("@AllPrice", SqlDbType.Decimal,9),
					new SqlParameter("@WholeSalePrice", SqlDbType.Decimal,9),
					new SqlParameter("@OncePrice", SqlDbType.Decimal,9),
					new SqlParameter("@MeasureUnit", SqlDbType.NVarChar,6),
					new SqlParameter("@LastEdit", SqlDbType.VarBinary,8)};
			parameters[0].Value = model.CompanyCode;
			parameters[1].Value = model.ItemNo;
			parameters[2].Value = model.Color;
			parameters[3].Value = model.ItemInternalCode;
			parameters[4].Value = model.InternalCodeMean;
			parameters[5].Value = model.AllPrice;
			parameters[6].Value = model.WholeSalePrice;
			parameters[7].Value = model.OncePrice;
			parameters[8].Value = model.MeasureUnit;
			parameters[9].Value = model.LastEdit;

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
		public bool Update(MyERP.Model.SAL_ITEM_NOW_PRICE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SAL_ITEM_NOW_PRICE set ");
			strSql.Append("CompanyCode=@CompanyCode,");
			strSql.Append("ItemNo=@ItemNo,");
			strSql.Append("Color=@Color,");
			strSql.Append("ItemInternalCode=@ItemInternalCode,");
			strSql.Append("InternalCodeMean=@InternalCodeMean,");
			strSql.Append("AllPrice=@AllPrice,");
			strSql.Append("WholeSalePrice=@WholeSalePrice,");
			strSql.Append("OncePrice=@OncePrice,");
			strSql.Append("MeasureUnit=@MeasureUnit,");
			strSql.Append("LastEdit=@LastEdit");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,10),
					new SqlParameter("@ItemNo", SqlDbType.NVarChar,20),
					new SqlParameter("@Color", SqlDbType.NVarChar,10),
					new SqlParameter("@ItemInternalCode", SqlDbType.NVarChar,200),
					new SqlParameter("@InternalCodeMean", SqlDbType.NVarChar,200),
					new SqlParameter("@AllPrice", SqlDbType.Decimal,9),
					new SqlParameter("@WholeSalePrice", SqlDbType.Decimal,9),
					new SqlParameter("@OncePrice", SqlDbType.Decimal,9),
					new SqlParameter("@MeasureUnit", SqlDbType.NVarChar,6),
					new SqlParameter("@LastEdit", SqlDbType.VarBinary,8)};
			parameters[0].Value = model.CompanyCode;
			parameters[1].Value = model.ItemNo;
			parameters[2].Value = model.Color;
			parameters[3].Value = model.ItemInternalCode;
			parameters[4].Value = model.InternalCodeMean;
			parameters[5].Value = model.AllPrice;
			parameters[6].Value = model.WholeSalePrice;
			parameters[7].Value = model.OncePrice;
			parameters[8].Value = model.MeasureUnit;
			parameters[9].Value = model.LastEdit;

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
			strSql.Append("delete from SAL_ITEM_NOW_PRICE ");
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
		public MyERP.Model.SAL_ITEM_NOW_PRICE GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CompanyCode,ItemNo,Color,ItemInternalCode,InternalCodeMean,AllPrice,WholeSalePrice,OncePrice,MeasureUnit,LastEdit from SAL_ITEM_NOW_PRICE ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.SAL_ITEM_NOW_PRICE model=new MyERP.Model.SAL_ITEM_NOW_PRICE();
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
		public MyERP.Model.SAL_ITEM_NOW_PRICE DataRowToModel(DataRow row)
		{
			MyERP.Model.SAL_ITEM_NOW_PRICE model=new MyERP.Model.SAL_ITEM_NOW_PRICE();
			if (row != null)
			{
				if(row["CompanyCode"]!=null)
				{
					model.CompanyCode=row["CompanyCode"].ToString();
				}
				if(row["ItemNo"]!=null)
				{
					model.ItemNo=row["ItemNo"].ToString();
				}
				if(row["Color"]!=null)
				{
					model.Color=row["Color"].ToString();
				}
				if(row["ItemInternalCode"]!=null)
				{
					model.ItemInternalCode=row["ItemInternalCode"].ToString();
				}
				if(row["InternalCodeMean"]!=null)
				{
					model.InternalCodeMean=row["InternalCodeMean"].ToString();
				}
				if(row["AllPrice"]!=null && row["AllPrice"].ToString()!="")
				{
					model.AllPrice=decimal.Parse(row["AllPrice"].ToString());
				}
				if(row["WholeSalePrice"]!=null && row["WholeSalePrice"].ToString()!="")
				{
					model.WholeSalePrice=decimal.Parse(row["WholeSalePrice"].ToString());
				}
				if(row["OncePrice"]!=null && row["OncePrice"].ToString()!="")
				{
					model.OncePrice=decimal.Parse(row["OncePrice"].ToString());
				}
				if(row["MeasureUnit"]!=null)
				{
					model.MeasureUnit=row["MeasureUnit"].ToString();
				}
				if(row["LastEdit"]!=null && row["LastEdit"].ToString()!="")
				{
					model.LastEdit=(byte[])row["LastEdit"];
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
			strSql.Append("select CompanyCode,ItemNo,Color,ItemInternalCode,InternalCodeMean,AllPrice,WholeSalePrice,OncePrice,MeasureUnit,LastEdit ");
			strSql.Append(" FROM SAL_ITEM_NOW_PRICE ");
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
			strSql.Append(" CompanyCode,ItemNo,Color,ItemInternalCode,InternalCodeMean,AllPrice,WholeSalePrice,OncePrice,MeasureUnit,LastEdit ");
			strSql.Append(" FROM SAL_ITEM_NOW_PRICE ");
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
			strSql.Append("select count(1) FROM SAL_ITEM_NOW_PRICE ");
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
			strSql.Append(")AS Row, T.*  from SAL_ITEM_NOW_PRICE T ");
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
			parameters[0].Value = "SAL_ITEM_NOW_PRICE";
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

