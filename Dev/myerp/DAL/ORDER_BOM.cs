using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_BOM
	/// </summary>
	public partial class ORDER_BOM
	{
		public ORDER_BOM()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SEQUENCE", "ORDER_BOM"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SEQUENCE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ORDER_BOM");
			strSql.Append(" where SEQUENCE=@SEQUENCE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4)			};
			parameters[0].Value = SEQUENCE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_BOM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_BOM(");
			strSql.Append("SEQUENCE,MASTERID,DETAILID,BILLNO,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,ITEM_CZ,ITEM_LH,ITEM_LK,ITEM_BJ,ITEM_JZ,ITEM_HZ,ITEM_rate,ITEM_GYLC,NET_PRICE,PRICE,MIN_QTY,MAX_QTY,POSITION,IMAGE,IMAGE_NAME,Quantity,total_quantity,BARCODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@SEQUENCE,@MASTERID,@DETAILID,@BILLNO,@ITEM_INTERNAL_CODE,@ITEM_CODE,@ITEM_CODE_old,@ITEM_NAME,@ITEM_COLOR,@PARENT_ITEM_CODE,@ITEM_TYPE,@SPECIFICATIONS,@MEASURE_UNIT,@ITEM_CZ,@ITEM_LH,@ITEM_LK,@ITEM_BJ,@ITEM_JZ,@ITEM_HZ,@ITEM_rate,@ITEM_GYLC,@NET_PRICE,@PRICE,@MIN_QTY,@MAX_QTY,@POSITION,@IMAGE,@IMAGE_NAME,@Quantity,@total_quantity,@BARCODE,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4),
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@DETAILID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,100),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE_old", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_TYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.NVarChar,200),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.NVarChar,6),
					new SqlParameter("@ITEM_CZ", SqlDbType.NChar,10),
					new SqlParameter("@ITEM_LH", SqlDbType.Float,8),
					new SqlParameter("@ITEM_LK", SqlDbType.Float,8),
					new SqlParameter("@ITEM_BJ", SqlDbType.Float,8),
					new SqlParameter("@ITEM_JZ", SqlDbType.Float,8),
					new SqlParameter("@ITEM_HZ", SqlDbType.Float,8),
					new SqlParameter("@ITEM_rate", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_GYLC", SqlDbType.NVarChar,50),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@MIN_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@MAX_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@POSITION", SqlDbType.NVarChar,50),
					new SqlParameter("@IMAGE", SqlDbType.Image),
					new SqlParameter("@IMAGE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@Quantity", SqlDbType.Float,8),
					new SqlParameter("@total_quantity", SqlDbType.Float,8),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.SEQUENCE;
			parameters[1].Value = model.MASTERID;
			parameters[2].Value = model.DETAILID;
			parameters[3].Value = model.BILLNO;
			parameters[4].Value = model.ITEM_INTERNAL_CODE;
			parameters[5].Value = model.ITEM_CODE;
			parameters[6].Value = model.ITEM_CODE_old;
			parameters[7].Value = model.ITEM_NAME;
			parameters[8].Value = model.ITEM_COLOR;
			parameters[9].Value = model.PARENT_ITEM_CODE;
			parameters[10].Value = model.ITEM_TYPE;
			parameters[11].Value = model.SPECIFICATIONS;
			parameters[12].Value = model.MEASURE_UNIT;
			parameters[13].Value = model.ITEM_CZ;
			parameters[14].Value = model.ITEM_LH;
			parameters[15].Value = model.ITEM_LK;
			parameters[16].Value = model.ITEM_BJ;
			parameters[17].Value = model.ITEM_JZ;
			parameters[18].Value = model.ITEM_HZ;
			parameters[19].Value = model.ITEM_rate;
			parameters[20].Value = model.ITEM_GYLC;
			parameters[21].Value = model.NET_PRICE;
			parameters[22].Value = model.PRICE;
			parameters[23].Value = model.MIN_QTY;
			parameters[24].Value = model.MAX_QTY;
			parameters[25].Value = model.POSITION;
			parameters[26].Value = model.IMAGE;
			parameters[27].Value = model.IMAGE_NAME;
			parameters[28].Value = model.Quantity;
			parameters[29].Value = model.total_quantity;
			parameters[30].Value = model.BARCODE;
			parameters[31].Value = model.CREATE_NAME;
			parameters[32].Value = model.CREATE_DATE;
			parameters[33].Value = model.UPDATE_NAME;
			parameters[34].Value = model.UPDATE_DATE;
			parameters[35].Value = model.REMARK;

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
		public bool Update(MyERP.Model.ORDER_BOM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_BOM set ");
			strSql.Append("MASTERID=@MASTERID,");
			strSql.Append("DETAILID=@DETAILID,");
			strSql.Append("BILLNO=@BILLNO,");
			strSql.Append("ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE,");
			strSql.Append("ITEM_CODE=@ITEM_CODE,");
			strSql.Append("ITEM_CODE_old=@ITEM_CODE_old,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("ITEM_COLOR=@ITEM_COLOR,");
			strSql.Append("PARENT_ITEM_CODE=@PARENT_ITEM_CODE,");
			strSql.Append("ITEM_TYPE=@ITEM_TYPE,");
			strSql.Append("SPECIFICATIONS=@SPECIFICATIONS,");
			strSql.Append("MEASURE_UNIT=@MEASURE_UNIT,");
			strSql.Append("ITEM_CZ=@ITEM_CZ,");
			strSql.Append("ITEM_LH=@ITEM_LH,");
			strSql.Append("ITEM_LK=@ITEM_LK,");
			strSql.Append("ITEM_BJ=@ITEM_BJ,");
			strSql.Append("ITEM_JZ=@ITEM_JZ,");
			strSql.Append("ITEM_HZ=@ITEM_HZ,");
			strSql.Append("ITEM_rate=@ITEM_rate,");
			strSql.Append("ITEM_GYLC=@ITEM_GYLC,");
			strSql.Append("NET_PRICE=@NET_PRICE,");
			strSql.Append("PRICE=@PRICE,");
			strSql.Append("MIN_QTY=@MIN_QTY,");
			strSql.Append("MAX_QTY=@MAX_QTY,");
			strSql.Append("POSITION=@POSITION,");
			strSql.Append("IMAGE=@IMAGE,");
			strSql.Append("IMAGE_NAME=@IMAGE_NAME,");
			strSql.Append("Quantity=@Quantity,");
			strSql.Append("total_quantity=@total_quantity,");
			strSql.Append("BARCODE=@BARCODE,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where SEQUENCE=@SEQUENCE ");
			SqlParameter[] parameters = {
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@DETAILID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,100),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_CODE_old", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_TYPE", SqlDbType.NVarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.NVarChar,200),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.NVarChar,6),
					new SqlParameter("@ITEM_CZ", SqlDbType.NChar,10),
					new SqlParameter("@ITEM_LH", SqlDbType.Float,8),
					new SqlParameter("@ITEM_LK", SqlDbType.Float,8),
					new SqlParameter("@ITEM_BJ", SqlDbType.Float,8),
					new SqlParameter("@ITEM_JZ", SqlDbType.Float,8),
					new SqlParameter("@ITEM_HZ", SqlDbType.Float,8),
					new SqlParameter("@ITEM_rate", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_GYLC", SqlDbType.NVarChar,50),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@MIN_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@MAX_QTY", SqlDbType.Decimal,9),
					new SqlParameter("@POSITION", SqlDbType.NVarChar,50),
					new SqlParameter("@IMAGE", SqlDbType.Image),
					new SqlParameter("@IMAGE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@Quantity", SqlDbType.Float,8),
					new SqlParameter("@total_quantity", SqlDbType.Float,8),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200),
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4)};
			parameters[0].Value = model.MASTERID;
			parameters[1].Value = model.DETAILID;
			parameters[2].Value = model.BILLNO;
			parameters[3].Value = model.ITEM_INTERNAL_CODE;
			parameters[4].Value = model.ITEM_CODE;
			parameters[5].Value = model.ITEM_CODE_old;
			parameters[6].Value = model.ITEM_NAME;
			parameters[7].Value = model.ITEM_COLOR;
			parameters[8].Value = model.PARENT_ITEM_CODE;
			parameters[9].Value = model.ITEM_TYPE;
			parameters[10].Value = model.SPECIFICATIONS;
			parameters[11].Value = model.MEASURE_UNIT;
			parameters[12].Value = model.ITEM_CZ;
			parameters[13].Value = model.ITEM_LH;
			parameters[14].Value = model.ITEM_LK;
			parameters[15].Value = model.ITEM_BJ;
			parameters[16].Value = model.ITEM_JZ;
			parameters[17].Value = model.ITEM_HZ;
			parameters[18].Value = model.ITEM_rate;
			parameters[19].Value = model.ITEM_GYLC;
			parameters[20].Value = model.NET_PRICE;
			parameters[21].Value = model.PRICE;
			parameters[22].Value = model.MIN_QTY;
			parameters[23].Value = model.MAX_QTY;
			parameters[24].Value = model.POSITION;
			parameters[25].Value = model.IMAGE;
			parameters[26].Value = model.IMAGE_NAME;
			parameters[27].Value = model.Quantity;
			parameters[28].Value = model.total_quantity;
			parameters[29].Value = model.BARCODE;
			parameters[30].Value = model.CREATE_NAME;
			parameters[31].Value = model.CREATE_DATE;
			parameters[32].Value = model.UPDATE_NAME;
			parameters[33].Value = model.UPDATE_DATE;
			parameters[34].Value = model.REMARK;
			parameters[35].Value = model.SEQUENCE;

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
		public bool Delete(int SEQUENCE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ORDER_BOM ");
			strSql.Append(" where SEQUENCE=@SEQUENCE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4)			};
			parameters[0].Value = SEQUENCE;

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
		public bool DeleteList(string SEQUENCElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ORDER_BOM ");
			strSql.Append(" where SEQUENCE in ("+SEQUENCElist + ")  ");
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
		public MyERP.Model.ORDER_BOM GetModel(int SEQUENCE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SEQUENCE,MASTERID,DETAILID,BILLNO,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,ITEM_CZ,ITEM_LH,ITEM_LK,ITEM_BJ,ITEM_JZ,ITEM_HZ,ITEM_rate,ITEM_GYLC,NET_PRICE,PRICE,MIN_QTY,MAX_QTY,POSITION,IMAGE,IMAGE_NAME,Quantity,total_quantity,BARCODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK from ORDER_BOM ");
			strSql.Append(" where SEQUENCE=@SEQUENCE ");
			SqlParameter[] parameters = {
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4)			};
			parameters[0].Value = SEQUENCE;

			MyERP.Model.ORDER_BOM model=new MyERP.Model.ORDER_BOM();
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
		public MyERP.Model.ORDER_BOM DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_BOM model=new MyERP.Model.ORDER_BOM();
			if (row != null)
			{
				if(row["SEQUENCE"]!=null && row["SEQUENCE"].ToString()!="")
				{
					model.SEQUENCE=int.Parse(row["SEQUENCE"].ToString());
				}
				if(row["MASTERID"]!=null)
				{
					model.MASTERID=row["MASTERID"].ToString();
				}
				if(row["DETAILID"]!=null)
				{
					model.DETAILID=row["DETAILID"].ToString();
				}
				if(row["BILLNO"]!=null)
				{
					model.BILLNO=row["BILLNO"].ToString();
				}
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
				if(row["ITEM_CZ"]!=null)
				{
					model.ITEM_CZ=row["ITEM_CZ"].ToString();
				}
				if(row["ITEM_LH"]!=null && row["ITEM_LH"].ToString()!="")
				{
					model.ITEM_LH=decimal.Parse(row["ITEM_LH"].ToString());
				}
				if(row["ITEM_LK"]!=null && row["ITEM_LK"].ToString()!="")
				{
					model.ITEM_LK=decimal.Parse(row["ITEM_LK"].ToString());
				}
				if(row["ITEM_BJ"]!=null && row["ITEM_BJ"].ToString()!="")
				{
					model.ITEM_BJ=decimal.Parse(row["ITEM_BJ"].ToString());
				}
				if(row["ITEM_JZ"]!=null && row["ITEM_JZ"].ToString()!="")
				{
					model.ITEM_JZ=decimal.Parse(row["ITEM_JZ"].ToString());
				}
				if(row["ITEM_HZ"]!=null && row["ITEM_HZ"].ToString()!="")
				{
					model.ITEM_HZ=decimal.Parse(row["ITEM_HZ"].ToString());
				}
				if(row["ITEM_rate"]!=null)
				{
					model.ITEM_rate=row["ITEM_rate"].ToString();
				}
				if(row["ITEM_GYLC"]!=null)
				{
					model.ITEM_GYLC=row["ITEM_GYLC"].ToString();
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
				if(row["Quantity"]!=null && row["Quantity"].ToString()!="")
				{
					model.Quantity=decimal.Parse(row["Quantity"].ToString());
				}
				if(row["total_quantity"]!=null && row["total_quantity"].ToString()!="")
				{
					model.total_quantity=decimal.Parse(row["total_quantity"].ToString());
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
			strSql.Append("select SEQUENCE,MASTERID,DETAILID,BILLNO,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,ITEM_CZ,ITEM_LH,ITEM_LK,ITEM_BJ,ITEM_JZ,ITEM_HZ,ITEM_rate,ITEM_GYLC,NET_PRICE,PRICE,MIN_QTY,MAX_QTY,POSITION,IMAGE,IMAGE_NAME,Quantity,total_quantity,BARCODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_BOM ");
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
			strSql.Append(" SEQUENCE,MASTERID,DETAILID,BILLNO,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,ITEM_CZ,ITEM_LH,ITEM_LK,ITEM_BJ,ITEM_JZ,ITEM_HZ,ITEM_rate,ITEM_GYLC,NET_PRICE,PRICE,MIN_QTY,MAX_QTY,POSITION,IMAGE,IMAGE_NAME,Quantity,total_quantity,BARCODE,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_BOM ");
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
			strSql.Append("select count(1) FROM ORDER_BOM ");
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
				strSql.Append("order by T.SEQUENCE desc");
			}
			strSql.Append(")AS Row, T.*  from ORDER_BOM T ");
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
			parameters[0].Value = "ORDER_BOM";
			parameters[1].Value = "SEQUENCE";
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

