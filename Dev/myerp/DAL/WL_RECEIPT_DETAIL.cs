﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:WL_RECEIPT_DETAIL
	/// </summary>
	public partial class WL_RECEIPT_DETAIL
	{
		public WL_RECEIPT_DETAIL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(MyERP.Model.WL_RECEIPT_DETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WL_RECEIPT_DETAIL(");
			strSql.Append("BillNO,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,QUANTITY,YKQUANTITY,PAYAMOUNT,NET_PAYAMOUNT,BARCODE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@BillNO,@SEQUENCE,@ITEM_INTERNAL_CODE,@ITEM_CODE,@ITEM_NAME,@PARENT_ITEM_CODE,@ITEM_TYPE,@ITEM_COLOR,@SPECIFICATIONS,@MEASURE_UNIT,@NET_PRICE,@PRICE,@ACTUAL_QTY,@QUANTITY,@YKQUANTITY,@PAYAMOUNT,@NET_PAYAMOUNT,@BARCODE,@REMARK)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNO", SqlDbType.NVarChar,50),
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_TYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.NVarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.NVarChar,50),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.NVarChar,50),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@ACTUAL_QTY", SqlDbType.Float,8),
					new SqlParameter("@QUANTITY", SqlDbType.Float,8),
					new SqlParameter("@YKQUANTITY", SqlDbType.Float,8),
					new SqlParameter("@PAYAMOUNT", SqlDbType.Float,8),
					new SqlParameter("@NET_PAYAMOUNT", SqlDbType.Float,8),
					new SqlParameter("@BARCODE", SqlDbType.NVarChar,50),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.BillNO;
			parameters[1].Value = model.SEQUENCE;
			parameters[2].Value = model.ITEM_INTERNAL_CODE;
			parameters[3].Value = model.ITEM_CODE;
			parameters[4].Value = model.ITEM_NAME;
			parameters[5].Value = model.PARENT_ITEM_CODE;
			parameters[6].Value = model.ITEM_TYPE;
			parameters[7].Value = model.ITEM_COLOR;
			parameters[8].Value = model.SPECIFICATIONS;
			parameters[9].Value = model.MEASURE_UNIT;
			parameters[10].Value = model.NET_PRICE;
			parameters[11].Value = model.PRICE;
			parameters[12].Value = model.ACTUAL_QTY;
			parameters[13].Value = model.QUANTITY;
			parameters[14].Value = model.YKQUANTITY;
			parameters[15].Value = model.PAYAMOUNT;
			parameters[16].Value = model.NET_PAYAMOUNT;
			parameters[17].Value = model.BARCODE;
			parameters[18].Value = model.REMARK;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(MyERP.Model.WL_RECEIPT_DETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WL_RECEIPT_DETAIL set ");
			strSql.Append("BillNO=@BillNO,");
			strSql.Append("SEQUENCE=@SEQUENCE,");
			strSql.Append("ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE,");
			strSql.Append("ITEM_CODE=@ITEM_CODE,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("PARENT_ITEM_CODE=@PARENT_ITEM_CODE,");
			strSql.Append("ITEM_TYPE=@ITEM_TYPE,");
			strSql.Append("ITEM_COLOR=@ITEM_COLOR,");
			strSql.Append("SPECIFICATIONS=@SPECIFICATIONS,");
			strSql.Append("MEASURE_UNIT=@MEASURE_UNIT,");
			strSql.Append("NET_PRICE=@NET_PRICE,");
			strSql.Append("PRICE=@PRICE,");
			strSql.Append("ACTUAL_QTY=@ACTUAL_QTY,");
			strSql.Append("QUANTITY=@QUANTITY,");
			strSql.Append("YKQUANTITY=@YKQUANTITY,");
			strSql.Append("PAYAMOUNT=@PAYAMOUNT,");
			strSql.Append("NET_PAYAMOUNT=@NET_PAYAMOUNT,");
			strSql.Append("BARCODE=@BARCODE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where TempID=@TempID");
			SqlParameter[] parameters = {
					new SqlParameter("@BillNO", SqlDbType.NVarChar,50),
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_TYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.NVarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.NVarChar,50),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.NVarChar,50),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@ACTUAL_QTY", SqlDbType.Float,8),
					new SqlParameter("@QUANTITY", SqlDbType.Float,8),
					new SqlParameter("@YKQUANTITY", SqlDbType.Float,8),
					new SqlParameter("@PAYAMOUNT", SqlDbType.Float,8),
					new SqlParameter("@NET_PAYAMOUNT", SqlDbType.Float,8),
					new SqlParameter("@BARCODE", SqlDbType.NVarChar,50),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200),
					new SqlParameter("@TempID", SqlDbType.Int,4)};
			parameters[0].Value = model.BillNO;
			parameters[1].Value = model.SEQUENCE;
			parameters[2].Value = model.ITEM_INTERNAL_CODE;
			parameters[3].Value = model.ITEM_CODE;
			parameters[4].Value = model.ITEM_NAME;
			parameters[5].Value = model.PARENT_ITEM_CODE;
			parameters[6].Value = model.ITEM_TYPE;
			parameters[7].Value = model.ITEM_COLOR;
			parameters[8].Value = model.SPECIFICATIONS;
			parameters[9].Value = model.MEASURE_UNIT;
			parameters[10].Value = model.NET_PRICE;
			parameters[11].Value = model.PRICE;
			parameters[12].Value = model.ACTUAL_QTY;
			parameters[13].Value = model.QUANTITY;
			parameters[14].Value = model.YKQUANTITY;
			parameters[15].Value = model.PAYAMOUNT;
			parameters[16].Value = model.NET_PAYAMOUNT;
			parameters[17].Value = model.BARCODE;
			parameters[18].Value = model.REMARK;
			parameters[19].Value = model.TempID;

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
		public bool Delete(int TempID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WL_RECEIPT_DETAIL ");
			strSql.Append(" where TempID=@TempID");
			SqlParameter[] parameters = {
					new SqlParameter("@TempID", SqlDbType.Int,4)
			};
			parameters[0].Value = TempID;

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
		public bool DeleteList(string TempIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WL_RECEIPT_DETAIL ");
			strSql.Append(" where TempID in ("+TempIDlist + ")  ");
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
		public MyERP.Model.WL_RECEIPT_DETAIL GetModel(int TempID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TempID,BillNO,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,QUANTITY,YKQUANTITY,PAYAMOUNT,NET_PAYAMOUNT,BARCODE,REMARK from WL_RECEIPT_DETAIL ");
			strSql.Append(" where TempID=@TempID");
			SqlParameter[] parameters = {
					new SqlParameter("@TempID", SqlDbType.Int,4)
			};
			parameters[0].Value = TempID;

			MyERP.Model.WL_RECEIPT_DETAIL model=new MyERP.Model.WL_RECEIPT_DETAIL();
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
		public MyERP.Model.WL_RECEIPT_DETAIL DataRowToModel(DataRow row)
		{
			MyERP.Model.WL_RECEIPT_DETAIL model=new MyERP.Model.WL_RECEIPT_DETAIL();
			if (row != null)
			{
				if(row["TempID"]!=null && row["TempID"].ToString()!="")
				{
					model.TempID=int.Parse(row["TempID"].ToString());
				}
				if(row["BillNO"]!=null)
				{
					model.BillNO=row["BillNO"].ToString();
				}
				if(row["SEQUENCE"]!=null && row["SEQUENCE"].ToString()!="")
				{
					model.SEQUENCE=int.Parse(row["SEQUENCE"].ToString());
				}
				if(row["ITEM_INTERNAL_CODE"]!=null)
				{
					model.ITEM_INTERNAL_CODE=row["ITEM_INTERNAL_CODE"].ToString();
				}
				if(row["ITEM_CODE"]!=null)
				{
					model.ITEM_CODE=row["ITEM_CODE"].ToString();
				}
				if(row["ITEM_NAME"]!=null)
				{
					model.ITEM_NAME=row["ITEM_NAME"].ToString();
				}
				if(row["PARENT_ITEM_CODE"]!=null)
				{
					model.PARENT_ITEM_CODE=row["PARENT_ITEM_CODE"].ToString();
				}
				if(row["ITEM_TYPE"]!=null)
				{
					model.ITEM_TYPE=row["ITEM_TYPE"].ToString();
				}
				if(row["ITEM_COLOR"]!=null)
				{
					model.ITEM_COLOR=row["ITEM_COLOR"].ToString();
				}
				if(row["SPECIFICATIONS"]!=null)
				{
					model.SPECIFICATIONS=row["SPECIFICATIONS"].ToString();
				}
				if(row["MEASURE_UNIT"]!=null)
				{
					model.MEASURE_UNIT=row["MEASURE_UNIT"].ToString();
				}
				if(row["NET_PRICE"]!=null && row["NET_PRICE"].ToString()!="")
				{
					model.NET_PRICE=decimal.Parse(row["NET_PRICE"].ToString());
				}
				if(row["PRICE"]!=null && row["PRICE"].ToString()!="")
				{
					model.PRICE=decimal.Parse(row["PRICE"].ToString());
				}
				if(row["ACTUAL_QTY"]!=null && row["ACTUAL_QTY"].ToString()!="")
				{
					model.ACTUAL_QTY=decimal.Parse(row["ACTUAL_QTY"].ToString());
				}
				if(row["QUANTITY"]!=null && row["QUANTITY"].ToString()!="")
				{
					model.QUANTITY=decimal.Parse(row["QUANTITY"].ToString());
				}
				if(row["YKQUANTITY"]!=null && row["YKQUANTITY"].ToString()!="")
				{
					model.YKQUANTITY=decimal.Parse(row["YKQUANTITY"].ToString());
				}
				if(row["PAYAMOUNT"]!=null && row["PAYAMOUNT"].ToString()!="")
				{
					model.PAYAMOUNT=decimal.Parse(row["PAYAMOUNT"].ToString());
				}
				if(row["NET_PAYAMOUNT"]!=null && row["NET_PAYAMOUNT"].ToString()!="")
				{
					model.NET_PAYAMOUNT=decimal.Parse(row["NET_PAYAMOUNT"].ToString());
				}
				if(row["BARCODE"]!=null)
				{
					model.BARCODE=row["BARCODE"].ToString();
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
			strSql.Append("select TempID,BillNO,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,QUANTITY,YKQUANTITY,PAYAMOUNT,NET_PAYAMOUNT,BARCODE,REMARK ");
			strSql.Append(" FROM WL_RECEIPT_DETAIL ");
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
			strSql.Append(" TempID,BillNO,SEQUENCE,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_COLOR,SPECIFICATIONS,MEASURE_UNIT,NET_PRICE,PRICE,ACTUAL_QTY,QUANTITY,YKQUANTITY,PAYAMOUNT,NET_PAYAMOUNT,BARCODE,REMARK ");
			strSql.Append(" FROM WL_RECEIPT_DETAIL ");
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
			strSql.Append("select count(1) FROM WL_RECEIPT_DETAIL ");
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
				strSql.Append("order by T.TempID desc");
			}
			strSql.Append(")AS Row, T.*  from WL_RECEIPT_DETAIL T ");
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
			parameters[0].Value = "WL_RECEIPT_DETAIL";
			parameters[1].Value = "TempID";
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

