﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_ITEM_LIST
	/// </summary>
	public partial class PUB_ITEM_LIST
	{
		public PUB_ITEM_LIST()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ITEM_INTERNAL_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PUB_ITEM_LIST");
			strSql.Append(" where ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,100)			};
			parameters[0].Value = ITEM_INTERNAL_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_ITEM_LIST model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_ITEM_LIST(");
			strSql.Append("ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,TYPE_NAME,NET_PRICE,PRICE,MIN_QTY,MAX_QTY,POSITION,IMAGE,IMAGE_NAME,Actual_Qty,BARCODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@ITEM_INTERNAL_CODE,@ITEM_CODE,@ITEM_CODE_old,@ITEM_NAME,@ITEM_COLOR,@PARENT_ITEM_CODE,@ITEM_TYPE,@SPECIFICATIONS,@MEASURE_UNIT,@TYPE_NAME,@NET_PRICE,@PRICE,@MIN_QTY,@MAX_QTY,@POSITION,@IMAGE,@IMAGE_NAME,@Actual_Qty,@BARCODE,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,100),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE_old", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_TYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.NVarChar,200),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.NVarChar,6),
					new SqlParameter("@TYPE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@MIN_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@MAX_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@POSITION", SqlDbType.NVarChar,50),
					new SqlParameter("@IMAGE", SqlDbType.Image),
					new SqlParameter("@IMAGE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@Actual_Qty", SqlDbType.Float,8),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.ITEM_INTERNAL_CODE;
			parameters[1].Value = model.ITEM_CODE;
			parameters[2].Value = model.ITEM_CODE_old;
			parameters[3].Value = model.ITEM_NAME;
			parameters[4].Value = model.ITEM_COLOR;
			parameters[5].Value = model.PARENT_ITEM_CODE;
			parameters[6].Value = model.ITEM_TYPE;
			parameters[7].Value = model.SPECIFICATIONS;
			parameters[8].Value = model.MEASURE_UNIT;
			parameters[9].Value = model.TYPE_NAME;
			parameters[10].Value = model.NET_PRICE;
			parameters[11].Value = model.PRICE;
			parameters[12].Value = model.MIN_QTY;
			parameters[13].Value = model.MAX_QTY;
			parameters[14].Value = model.POSITION;
			parameters[15].Value = model.IMAGE;
			parameters[16].Value = model.IMAGE_NAME;
			parameters[17].Value = model.Actual_Qty;
			parameters[18].Value = model.BARCODE;
			parameters[19].Value = model.CREATE_NAME;
			parameters[20].Value = model.CREATE_DATE;
			parameters[21].Value = model.UPDATE_NAME;
			parameters[22].Value = model.UPDATE_DATE;
			parameters[23].Value = model.REMARK;

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
		public bool Update(MyERP.Model.PUB_ITEM_LIST model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_ITEM_LIST set ");
			strSql.Append("ITEM_CODE=@ITEM_CODE,");
			strSql.Append("ITEM_CODE_old=@ITEM_CODE_old,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("ITEM_COLOR=@ITEM_COLOR,");
			strSql.Append("PARENT_ITEM_CODE=@PARENT_ITEM_CODE,");
			strSql.Append("ITEM_TYPE=@ITEM_TYPE,");
			strSql.Append("SPECIFICATIONS=@SPECIFICATIONS,");
			strSql.Append("MEASURE_UNIT=@MEASURE_UNIT,");
			strSql.Append("TYPE_NAME=@TYPE_NAME,");
			strSql.Append("NET_PRICE=@NET_PRICE,");
			strSql.Append("PRICE=@PRICE,");
			strSql.Append("MIN_QTY=@MIN_QTY,");
			strSql.Append("MAX_QTY=@MAX_QTY,");
			strSql.Append("POSITION=@POSITION,");
			strSql.Append("IMAGE=@IMAGE,");
			strSql.Append("IMAGE_NAME=@IMAGE_NAME,");
			strSql.Append("Actual_Qty=@Actual_Qty,");
			strSql.Append("BARCODE=@BARCODE,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE_old", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_TYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.NVarChar,200),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.NVarChar,6),
					new SqlParameter("@TYPE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@MIN_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@MAX_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@POSITION", SqlDbType.NVarChar,50),
					new SqlParameter("@IMAGE", SqlDbType.Image),
					new SqlParameter("@IMAGE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@Actual_Qty", SqlDbType.Float,8),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.ITEM_CODE;
			parameters[1].Value = model.ITEM_CODE_old;
			parameters[2].Value = model.ITEM_NAME;
			parameters[3].Value = model.ITEM_COLOR;
			parameters[4].Value = model.PARENT_ITEM_CODE;
			parameters[5].Value = model.ITEM_TYPE;
			parameters[6].Value = model.SPECIFICATIONS;
			parameters[7].Value = model.MEASURE_UNIT;
			parameters[8].Value = model.TYPE_NAME;
			parameters[9].Value = model.NET_PRICE;
			parameters[10].Value = model.PRICE;
			parameters[11].Value = model.MIN_QTY;
			parameters[12].Value = model.MAX_QTY;
			parameters[13].Value = model.POSITION;
			parameters[14].Value = model.IMAGE;
			parameters[15].Value = model.IMAGE_NAME;
			parameters[16].Value = model.Actual_Qty;
			parameters[17].Value = model.BARCODE;
			parameters[18].Value = model.CREATE_NAME;
			parameters[19].Value = model.CREATE_DATE;
			parameters[20].Value = model.UPDATE_NAME;
			parameters[21].Value = model.UPDATE_DATE;
			parameters[22].Value = model.REMARK;
			parameters[23].Value = model.ITEM_INTERNAL_CODE;

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
			strSql.Append("delete from PUB_ITEM_LIST ");
			strSql.Append(" where ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,100)			};
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
			strSql.Append("delete from PUB_ITEM_LIST ");
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
		public MyERP.Model.PUB_ITEM_LIST GetModel(string ITEM_INTERNAL_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,TYPE_NAME,NET_PRICE,PRICE,MIN_QTY,MAX_QTY,POSITION,IMAGE,IMAGE_NAME,Actual_Qty,BARCODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from PUB_ITEM_LIST ");
			strSql.Append(" where ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,100)			};
			parameters[0].Value = ITEM_INTERNAL_CODE;

			MyERP.Model.PUB_ITEM_LIST model=new MyERP.Model.PUB_ITEM_LIST();
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
		public MyERP.Model.PUB_ITEM_LIST DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_ITEM_LIST model=new MyERP.Model.PUB_ITEM_LIST();
			if (row != null)
			{
				if(row["ITEM_INTERNAL_CODE"]!=null)
				{
					model.ITEM_INTERNAL_CODE=row["ITEM_INTERNAL_CODE"].ToString();
				}
				if(row["ITEM_CODE"]!=null)
				{
					model.ITEM_CODE=row["ITEM_CODE"].ToString();
				}
				if(row["ITEM_CODE_old"]!=null)
				{
					model.ITEM_CODE_old=row["ITEM_CODE_old"].ToString();
				}
				if(row["ITEM_NAME"]!=null)
				{
					model.ITEM_NAME=row["ITEM_NAME"].ToString();
				}
				if(row["ITEM_COLOR"]!=null)
				{
					model.ITEM_COLOR=row["ITEM_COLOR"].ToString();
				}
				if(row["PARENT_ITEM_CODE"]!=null)
				{
					model.PARENT_ITEM_CODE=row["PARENT_ITEM_CODE"].ToString();
				}
				if(row["ITEM_TYPE"]!=null)
				{
					model.ITEM_TYPE=row["ITEM_TYPE"].ToString();
				}
				if(row["SPECIFICATIONS"]!=null)
				{
					model.SPECIFICATIONS=row["SPECIFICATIONS"].ToString();
				}
				if(row["MEASURE_UNIT"]!=null)
				{
					model.MEASURE_UNIT=row["MEASURE_UNIT"].ToString();
				}
				if(row["TYPE_NAME"]!=null)
				{
					model.TYPE_NAME=row["TYPE_NAME"].ToString();
				}
				if(row["NET_PRICE"]!=null && row["NET_PRICE"].ToString()!="")
				{
					model.NET_PRICE=decimal.Parse(row["NET_PRICE"].ToString());
				}
				if(row["PRICE"]!=null && row["PRICE"].ToString()!="")
				{
					model.PRICE=decimal.Parse(row["PRICE"].ToString());
				}
				if(row["MIN_QTY"]!=null && row["MIN_QTY"].ToString()!="")
				{
					model.MIN_QTY=decimal.Parse(row["MIN_QTY"].ToString());
				}
				if(row["MAX_QTY"]!=null && row["MAX_QTY"].ToString()!="")
				{
					model.MAX_QTY=decimal.Parse(row["MAX_QTY"].ToString());
				}
				if(row["POSITION"]!=null)
				{
					model.POSITION=row["POSITION"].ToString();
				}
				if(row["IMAGE"]!=null && row["IMAGE"].ToString()!="")
				{
					model.IMAGE=(byte[])row["IMAGE"];
				}
				if(row["IMAGE_NAME"]!=null)
				{
					model.IMAGE_NAME=row["IMAGE_NAME"].ToString();
				}
				if(row["Actual_Qty"]!=null && row["Actual_Qty"].ToString()!="")
				{
					model.Actual_Qty=decimal.Parse(row["Actual_Qty"].ToString());
				}
				if(row["BARCODE"]!=null)
				{
					model.BARCODE=row["BARCODE"].ToString();
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
			strSql.Append("select ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,TYPE_NAME,NET_PRICE,PRICE,MIN_QTY,MAX_QTY,POSITION,IMAGE,IMAGE_NAME,Actual_Qty,BARCODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_ITEM_LIST ");
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
			strSql.Append(" ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,TYPE_NAME,NET_PRICE,PRICE,MIN_QTY,MAX_QTY,POSITION,IMAGE,IMAGE_NAME,Actual_Qty,BARCODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM PUB_ITEM_LIST ");
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
			strSql.Append("select count(1) FROM PUB_ITEM_LIST ");
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
			strSql.Append(")AS Row, T.*  from PUB_ITEM_LIST T ");
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
			parameters[0].Value = "PUB_ITEM_LIST";
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

