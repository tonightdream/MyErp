﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:STEEL_DA
	/// </summary>
	public partial class STEEL_DA
	{
		public STEEL_DA()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ITEM_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from STEEL_DA");
			strSql.Append(" where ITEM_CODE=@ITEM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = ITEM_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.STEEL_DA model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into STEEL_DA(");
			strSql.Append("SEQUENCE,ITEM_INTERNAL_CODE,SUPPLY_CODE,SUPPLY_NAME,COMPANY_CODE,COMPANY_NAME,ITEM_CODE,ITEM_NAME,ITEM_HD,ITEM_TYPE,ITEM_COLOR,IMAGE,PARENT_ITEM_CODE,TYPE_NAME,SPECIFICATIONS,ITEM_rate,MEASURE_CODE,MEASURE_UNIT,NET_PRICE,PRICE,QTY,ACTUAL_QTY,MIN_QTY,MAX_QTY,POSITION_CODE,POSITION,DESCRIPTION,BARCODE,CREATE_DATE,CREATE_NAME,UPDATE_DATE,UPDATE_NAME,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@SEQUENCE,@ITEM_INTERNAL_CODE,@SUPPLY_CODE,@SUPPLY_NAME,@COMPANY_CODE,@COMPANY_NAME,@ITEM_CODE,@ITEM_NAME,@ITEM_HD,@ITEM_TYPE,@ITEM_COLOR,@IMAGE,@PARENT_ITEM_CODE,@TYPE_NAME,@SPECIFICATIONS,@ITEM_rate,@MEASURE_CODE,@MEASURE_UNIT,@NET_PRICE,@PRICE,@QTY,@ACTUAL_QTY,@MIN_QTY,@MAX_QTY,@POSITION_CODE,@POSITION,@DESCRIPTION,@BARCODE,@CREATE_DATE,@CREATE_NAME,@UPDATE_DATE,@UPDATE_NAME,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,200),
					new SqlParameter("@SUPPLY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@SUPPLY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,200),
					new SqlParameter("@ITEM_HD", SqlDbType.NVarChar,10),
					new SqlParameter("@ITEM_TYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.NVarChar,200),
					new SqlParameter("@IMAGE", SqlDbType.Image),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@TYPE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.NVarChar,200),
					new SqlParameter("@ITEM_rate", SqlDbType.NVarChar,50),
					new SqlParameter("@MEASURE_CODE", SqlDbType.NVarChar,20),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.NVarChar,20),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@QTY", SqlDbType.Float,8),
					new SqlParameter("@ACTUAL_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@MIN_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@MAX_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@POSITION_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@POSITION", SqlDbType.NVarChar,50),
					new SqlParameter("@DESCRIPTION", SqlDbType.VarChar,200),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.SEQUENCE;
			parameters[1].Value = model.ITEM_INTERNAL_CODE;
			parameters[2].Value = model.SUPPLY_CODE;
			parameters[3].Value = model.SUPPLY_NAME;
			parameters[4].Value = model.COMPANY_CODE;
			parameters[5].Value = model.COMPANY_NAME;
			parameters[6].Value = model.ITEM_CODE;
			parameters[7].Value = model.ITEM_NAME;
			parameters[8].Value = model.ITEM_HD;
			parameters[9].Value = model.ITEM_TYPE;
			parameters[10].Value = model.ITEM_COLOR;
			parameters[11].Value = model.IMAGE;
			parameters[12].Value = model.PARENT_ITEM_CODE;
			parameters[13].Value = model.TYPE_NAME;
			parameters[14].Value = model.SPECIFICATIONS;
			parameters[15].Value = model.ITEM_rate;
			parameters[16].Value = model.MEASURE_CODE;
			parameters[17].Value = model.MEASURE_UNIT;
			parameters[18].Value = model.NET_PRICE;
			parameters[19].Value = model.PRICE;
			parameters[20].Value = model.QTY;
			parameters[21].Value = model.ACTUAL_QTY;
			parameters[22].Value = model.MIN_QTY;
			parameters[23].Value = model.MAX_QTY;
			parameters[24].Value = model.POSITION_CODE;
			parameters[25].Value = model.POSITION;
			parameters[26].Value = model.DESCRIPTION;
			parameters[27].Value = model.BARCODE;
			parameters[28].Value = model.CREATE_DATE;
			parameters[29].Value = model.CREATE_NAME;
			parameters[30].Value = model.UPDATE_DATE;
			parameters[31].Value = model.UPDATE_NAME;
			parameters[32].Value = model.REMARK;

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
		public bool Update(MyERP.Model.STEEL_DA model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update STEEL_DA set ");
			strSql.Append("SEQUENCE=@SEQUENCE,");
			strSql.Append("ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE,");
			strSql.Append("SUPPLY_CODE=@SUPPLY_CODE,");
			strSql.Append("SUPPLY_NAME=@SUPPLY_NAME,");
			strSql.Append("COMPANY_CODE=@COMPANY_CODE,");
			strSql.Append("COMPANY_NAME=@COMPANY_NAME,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("ITEM_HD=@ITEM_HD,");
			strSql.Append("ITEM_TYPE=@ITEM_TYPE,");
			strSql.Append("ITEM_COLOR=@ITEM_COLOR,");
			strSql.Append("IMAGE=@IMAGE,");
			strSql.Append("PARENT_ITEM_CODE=@PARENT_ITEM_CODE,");
			strSql.Append("TYPE_NAME=@TYPE_NAME,");
			strSql.Append("SPECIFICATIONS=@SPECIFICATIONS,");
			strSql.Append("ITEM_rate=@ITEM_rate,");
			strSql.Append("MEASURE_CODE=@MEASURE_CODE,");
			strSql.Append("MEASURE_UNIT=@MEASURE_UNIT,");
			strSql.Append("NET_PRICE=@NET_PRICE,");
			strSql.Append("PRICE=@PRICE,");
			strSql.Append("QTY=@QTY,");
			strSql.Append("ACTUAL_QTY=@ACTUAL_QTY,");
			strSql.Append("MIN_QTY=@MIN_QTY,");
			strSql.Append("MAX_QTY=@MAX_QTY,");
			strSql.Append("POSITION_CODE=@POSITION_CODE,");
			strSql.Append("POSITION=@POSITION,");
			strSql.Append("DESCRIPTION=@DESCRIPTION,");
			strSql.Append("BARCODE=@BARCODE,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ITEM_CODE=@ITEM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,200),
					new SqlParameter("@SUPPLY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@SUPPLY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@COMPANY_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,200),
					new SqlParameter("@ITEM_HD", SqlDbType.NVarChar,10),
					new SqlParameter("@ITEM_TYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.NVarChar,200),
					new SqlParameter("@IMAGE", SqlDbType.Image),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@TYPE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.NVarChar,200),
					new SqlParameter("@ITEM_rate", SqlDbType.NVarChar,50),
					new SqlParameter("@MEASURE_CODE", SqlDbType.NVarChar,20),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.NVarChar,20),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@QTY", SqlDbType.Float,8),
					new SqlParameter("@ACTUAL_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@MIN_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@MAX_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@POSITION_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@POSITION", SqlDbType.NVarChar,50),
					new SqlParameter("@DESCRIPTION", SqlDbType.VarChar,200),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.SEQUENCE;
			parameters[1].Value = model.ITEM_INTERNAL_CODE;
			parameters[2].Value = model.SUPPLY_CODE;
			parameters[3].Value = model.SUPPLY_NAME;
			parameters[4].Value = model.COMPANY_CODE;
			parameters[5].Value = model.COMPANY_NAME;
			parameters[6].Value = model.ITEM_NAME;
			parameters[7].Value = model.ITEM_HD;
			parameters[8].Value = model.ITEM_TYPE;
			parameters[9].Value = model.ITEM_COLOR;
			parameters[10].Value = model.IMAGE;
			parameters[11].Value = model.PARENT_ITEM_CODE;
			parameters[12].Value = model.TYPE_NAME;
			parameters[13].Value = model.SPECIFICATIONS;
			parameters[14].Value = model.ITEM_rate;
			parameters[15].Value = model.MEASURE_CODE;
			parameters[16].Value = model.MEASURE_UNIT;
			parameters[17].Value = model.NET_PRICE;
			parameters[18].Value = model.PRICE;
			parameters[19].Value = model.QTY;
			parameters[20].Value = model.ACTUAL_QTY;
			parameters[21].Value = model.MIN_QTY;
			parameters[22].Value = model.MAX_QTY;
			parameters[23].Value = model.POSITION_CODE;
			parameters[24].Value = model.POSITION;
			parameters[25].Value = model.DESCRIPTION;
			parameters[26].Value = model.BARCODE;
			parameters[27].Value = model.CREATE_DATE;
			parameters[28].Value = model.CREATE_NAME;
			parameters[29].Value = model.UPDATE_DATE;
			parameters[30].Value = model.UPDATE_NAME;
			parameters[31].Value = model.REMARK;
			parameters[32].Value = model.ITEM_CODE;

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
		public bool Delete(string ITEM_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STEEL_DA ");
			strSql.Append(" where ITEM_CODE=@ITEM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = ITEM_CODE;

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
		public bool DeleteList(string ITEM_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STEEL_DA ");
			strSql.Append(" where ITEM_CODE in ("+ITEM_CODElist + ")  ");
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
		public MyERP.Model.STEEL_DA GetModel(string ITEM_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SEQUENCE,ITEM_INTERNAL_CODE,SUPPLY_CODE,SUPPLY_NAME,COMPANY_CODE,COMPANY_NAME,ITEM_CODE,ITEM_NAME,ITEM_HD,ITEM_TYPE,ITEM_COLOR,IMAGE,PARENT_ITEM_CODE,TYPE_NAME,SPECIFICATIONS,ITEM_rate,MEASURE_CODE,MEASURE_UNIT,NET_PRICE,PRICE,QTY,ACTUAL_QTY,MIN_QTY,MAX_QTY,POSITION_CODE,POSITION,DESCRIPTION,BARCODE,CREATE_DATE,CREATE_NAME,UPDATE_DATE,UPDATE_NAME,REMARK from STEEL_DA ");
			strSql.Append(" where ITEM_CODE=@ITEM_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = ITEM_CODE;

			MyERP.Model.STEEL_DA model=new MyERP.Model.STEEL_DA();
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
		public MyERP.Model.STEEL_DA DataRowToModel(DataRow row)
		{
			MyERP.Model.STEEL_DA model=new MyERP.Model.STEEL_DA();
			if (row != null)
			{
				if(row["SEQUENCE"]!=null && row["SEQUENCE"].ToString()!="")
				{
					model.SEQUENCE=int.Parse(row["SEQUENCE"].ToString());
				}
				if(row["ITEM_INTERNAL_CODE"]!=null)
				{
					model.ITEM_INTERNAL_CODE=row["ITEM_INTERNAL_CODE"].ToString();
				}
				if(row["SUPPLY_CODE"]!=null)
				{
					model.SUPPLY_CODE=row["SUPPLY_CODE"].ToString();
				}
				if(row["SUPPLY_NAME"]!=null)
				{
					model.SUPPLY_NAME=row["SUPPLY_NAME"].ToString();
				}
				if(row["COMPANY_CODE"]!=null)
				{
					model.COMPANY_CODE=row["COMPANY_CODE"].ToString();
				}
				if(row["COMPANY_NAME"]!=null)
				{
					model.COMPANY_NAME=row["COMPANY_NAME"].ToString();
				}
				if(row["ITEM_CODE"]!=null)
				{
					model.ITEM_CODE=row["ITEM_CODE"].ToString();
				}
				if(row["ITEM_NAME"]!=null)
				{
					model.ITEM_NAME=row["ITEM_NAME"].ToString();
				}
				if(row["ITEM_HD"]!=null)
				{
					model.ITEM_HD=row["ITEM_HD"].ToString();
				}
				if(row["ITEM_TYPE"]!=null)
				{
					model.ITEM_TYPE=row["ITEM_TYPE"].ToString();
				}
				if(row["ITEM_COLOR"]!=null)
				{
					model.ITEM_COLOR=row["ITEM_COLOR"].ToString();
				}
				if(row["IMAGE"]!=null && row["IMAGE"].ToString()!="")
				{
					model.IMAGE=(byte[])row["IMAGE"];
				}
				if(row["PARENT_ITEM_CODE"]!=null)
				{
					model.PARENT_ITEM_CODE=row["PARENT_ITEM_CODE"].ToString();
				}
				if(row["TYPE_NAME"]!=null)
				{
					model.TYPE_NAME=row["TYPE_NAME"].ToString();
				}
				if(row["SPECIFICATIONS"]!=null)
				{
					model.SPECIFICATIONS=row["SPECIFICATIONS"].ToString();
				}
				if(row["ITEM_rate"]!=null)
				{
					model.ITEM_rate=row["ITEM_rate"].ToString();
				}
				if(row["MEASURE_CODE"]!=null)
				{
					model.MEASURE_CODE=row["MEASURE_CODE"].ToString();
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
				if(row["QTY"]!=null && row["QTY"].ToString()!="")
				{
					model.QTY=decimal.Parse(row["QTY"].ToString());
				}
				if(row["ACTUAL_QTY"]!=null && row["ACTUAL_QTY"].ToString()!="")
				{
					model.ACTUAL_QTY=decimal.Parse(row["ACTUAL_QTY"].ToString());
				}
				if(row["MIN_QTY"]!=null && row["MIN_QTY"].ToString()!="")
				{
					model.MIN_QTY=decimal.Parse(row["MIN_QTY"].ToString());
				}
				if(row["MAX_QTY"]!=null && row["MAX_QTY"].ToString()!="")
				{
					model.MAX_QTY=decimal.Parse(row["MAX_QTY"].ToString());
				}
				if(row["POSITION_CODE"]!=null)
				{
					model.POSITION_CODE=row["POSITION_CODE"].ToString();
				}
				if(row["POSITION"]!=null)
				{
					model.POSITION=row["POSITION"].ToString();
				}
				if(row["DESCRIPTION"]!=null)
				{
					model.DESCRIPTION=row["DESCRIPTION"].ToString();
				}
				if(row["BARCODE"]!=null)
				{
					model.BARCODE=row["BARCODE"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
				}
				if(row["CREATE_NAME"]!=null)
				{
					model.CREATE_NAME=row["CREATE_NAME"].ToString();
				}
				if(row["UPDATE_DATE"]!=null && row["UPDATE_DATE"].ToString()!="")
				{
					model.UPDATE_DATE=DateTime.Parse(row["UPDATE_DATE"].ToString());
				}
				if(row["UPDATE_NAME"]!=null)
				{
					model.UPDATE_NAME=row["UPDATE_NAME"].ToString();
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
			strSql.Append("select SEQUENCE,ITEM_INTERNAL_CODE,SUPPLY_CODE,SUPPLY_NAME,COMPANY_CODE,COMPANY_NAME,ITEM_CODE,ITEM_NAME,ITEM_HD,ITEM_TYPE,ITEM_COLOR,IMAGE,PARENT_ITEM_CODE,TYPE_NAME,SPECIFICATIONS,ITEM_rate,MEASURE_CODE,MEASURE_UNIT,NET_PRICE,PRICE,QTY,ACTUAL_QTY,MIN_QTY,MAX_QTY,POSITION_CODE,POSITION,DESCRIPTION,BARCODE,CREATE_DATE,CREATE_NAME,UPDATE_DATE,UPDATE_NAME,REMARK ");
			strSql.Append(" FROM STEEL_DA ");
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
			strSql.Append(" SEQUENCE,ITEM_INTERNAL_CODE,SUPPLY_CODE,SUPPLY_NAME,COMPANY_CODE,COMPANY_NAME,ITEM_CODE,ITEM_NAME,ITEM_HD,ITEM_TYPE,ITEM_COLOR,IMAGE,PARENT_ITEM_CODE,TYPE_NAME,SPECIFICATIONS,ITEM_rate,MEASURE_CODE,MEASURE_UNIT,NET_PRICE,PRICE,QTY,ACTUAL_QTY,MIN_QTY,MAX_QTY,POSITION_CODE,POSITION,DESCRIPTION,BARCODE,CREATE_DATE,CREATE_NAME,UPDATE_DATE,UPDATE_NAME,REMARK ");
			strSql.Append(" FROM STEEL_DA ");
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
			strSql.Append("select count(1) FROM STEEL_DA ");
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
				strSql.Append("order by T.ITEM_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from STEEL_DA T ");
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
			parameters[0].Value = "STEEL_DA";
			parameters[1].Value = "ITEM_CODE";
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

