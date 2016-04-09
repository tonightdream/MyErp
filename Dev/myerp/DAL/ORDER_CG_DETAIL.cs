using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_CG_DETAIL
	/// </summary>
	public partial class ORDER_CG_DETAIL
	{
		public ORDER_CG_DETAIL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_CG_DETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_CG_DETAIL(");
			strSql.Append("SEQUENCE,MASTERID,DETAILID,BILLNO,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,ITEM_COLOR,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,ITEM_CZ,ITEM_LH,ITEM_LK,ITEM_BJ,ITEM_JZ,ITEM_HZ,ITEM_rate,ITEM_GYLC,NET_PRICE,PRICE,Quantity,total_quantity,ORD_TL,BARCODE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@SEQUENCE,@MASTERID,@DETAILID,@BILLNO,@ITEM_INTERNAL_CODE,@ITEM_CODE,@ITEM_NAME,@ITEM_COLOR,@ITEM_TYPE,@SPECIFICATIONS,@MEASURE_UNIT,@ITEM_CZ,@ITEM_LH,@ITEM_LK,@ITEM_BJ,@ITEM_JZ,@ITEM_HZ,@ITEM_rate,@ITEM_GYLC,@NET_PRICE,@PRICE,@Quantity,@total_quantity,@ORD_TL,@BARCODE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4),
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@DETAILID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,100),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.NVarChar,50),
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
					new SqlParameter("@Quantity", SqlDbType.Float,8),
					new SqlParameter("@total_quantity", SqlDbType.Float,8),
					new SqlParameter("@ORD_TL", SqlDbType.NChar,10),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.SEQUENCE;
			parameters[1].Value = model.MASTERID;
			parameters[2].Value = model.DETAILID;
			parameters[3].Value = model.BILLNO;
			parameters[4].Value = model.ITEM_INTERNAL_CODE;
			parameters[5].Value = model.ITEM_CODE;
			parameters[6].Value = model.ITEM_NAME;
			parameters[7].Value = model.ITEM_COLOR;
			parameters[8].Value = model.ITEM_TYPE;
			parameters[9].Value = model.SPECIFICATIONS;
			parameters[10].Value = model.MEASURE_UNIT;
			parameters[11].Value = model.ITEM_CZ;
			parameters[12].Value = model.ITEM_LH;
			parameters[13].Value = model.ITEM_LK;
			parameters[14].Value = model.ITEM_BJ;
			parameters[15].Value = model.ITEM_JZ;
			parameters[16].Value = model.ITEM_HZ;
			parameters[17].Value = model.ITEM_rate;
			parameters[18].Value = model.ITEM_GYLC;
			parameters[19].Value = model.NET_PRICE;
			parameters[20].Value = model.PRICE;
			parameters[21].Value = model.Quantity;
			parameters[22].Value = model.total_quantity;
			parameters[23].Value = model.ORD_TL;
			parameters[24].Value = model.BARCODE;
			parameters[25].Value = model.REMARK;

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
		public bool Update(MyERP.Model.ORDER_CG_DETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_CG_DETAIL set ");
			strSql.Append("SEQUENCE=@SEQUENCE,");
			strSql.Append("MASTERID=@MASTERID,");
			strSql.Append("DETAILID=@DETAILID,");
			strSql.Append("BILLNO=@BILLNO,");
			strSql.Append("ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE,");
			strSql.Append("ITEM_CODE=@ITEM_CODE,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("ITEM_COLOR=@ITEM_COLOR,");
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
			strSql.Append("Quantity=@Quantity,");
			strSql.Append("total_quantity=@total_quantity,");
			strSql.Append("ORD_TL=@ORD_TL,");
			strSql.Append("BARCODE=@BARCODE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@SEQUENCE", SqlDbType.Int,4),
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@DETAILID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.NVarChar,100),
					new SqlParameter("@ITEM_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.NVarChar,50),
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
					new SqlParameter("@Quantity", SqlDbType.Float,8),
					new SqlParameter("@total_quantity", SqlDbType.Float,8),
					new SqlParameter("@ORD_TL", SqlDbType.NChar,10),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@REMARK", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.SEQUENCE;
			parameters[1].Value = model.MASTERID;
			parameters[2].Value = model.DETAILID;
			parameters[3].Value = model.BILLNO;
			parameters[4].Value = model.ITEM_INTERNAL_CODE;
			parameters[5].Value = model.ITEM_CODE;
			parameters[6].Value = model.ITEM_NAME;
			parameters[7].Value = model.ITEM_COLOR;
			parameters[8].Value = model.ITEM_TYPE;
			parameters[9].Value = model.SPECIFICATIONS;
			parameters[10].Value = model.MEASURE_UNIT;
			parameters[11].Value = model.ITEM_CZ;
			parameters[12].Value = model.ITEM_LH;
			parameters[13].Value = model.ITEM_LK;
			parameters[14].Value = model.ITEM_BJ;
			parameters[15].Value = model.ITEM_JZ;
			parameters[16].Value = model.ITEM_HZ;
			parameters[17].Value = model.ITEM_rate;
			parameters[18].Value = model.ITEM_GYLC;
			parameters[19].Value = model.NET_PRICE;
			parameters[20].Value = model.PRICE;
			parameters[21].Value = model.Quantity;
			parameters[22].Value = model.total_quantity;
			parameters[23].Value = model.ORD_TL;
			parameters[24].Value = model.BARCODE;
			parameters[25].Value = model.REMARK;

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
			strSql.Append("delete from ORDER_CG_DETAIL ");
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
		public MyERP.Model.ORDER_CG_DETAIL GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SEQUENCE,MASTERID,DETAILID,BILLNO,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,ITEM_COLOR,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,ITEM_CZ,ITEM_LH,ITEM_LK,ITEM_BJ,ITEM_JZ,ITEM_HZ,ITEM_rate,ITEM_GYLC,NET_PRICE,PRICE,Quantity,total_quantity,ORD_TL,BARCODE,REMARK from ORDER_CG_DETAIL ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.ORDER_CG_DETAIL model=new MyERP.Model.ORDER_CG_DETAIL();
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
		public MyERP.Model.ORDER_CG_DETAIL DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_CG_DETAIL model=new MyERP.Model.ORDER_CG_DETAIL();
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
				if(row["ITEM_NAME"]!=null)
				{
					model.ITEM_NAME=row["ITEM_NAME"].ToString();
				}
				if(row["ITEM_COLOR"]!=null)
				{
					model.ITEM_COLOR=row["ITEM_COLOR"].ToString();
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
				if(row["Quantity"]!=null && row["Quantity"].ToString()!="")
				{
					model.Quantity=decimal.Parse(row["Quantity"].ToString());
				}
				if(row["total_quantity"]!=null && row["total_quantity"].ToString()!="")
				{
					model.total_quantity=decimal.Parse(row["total_quantity"].ToString());
				}
				if(row["ORD_TL"]!=null)
				{
					model.ORD_TL=row["ORD_TL"].ToString();
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
			strSql.Append("select SEQUENCE,MASTERID,DETAILID,BILLNO,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,ITEM_COLOR,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,ITEM_CZ,ITEM_LH,ITEM_LK,ITEM_BJ,ITEM_JZ,ITEM_HZ,ITEM_rate,ITEM_GYLC,NET_PRICE,PRICE,Quantity,total_quantity,ORD_TL,BARCODE,REMARK ");
			strSql.Append(" FROM ORDER_CG_DETAIL ");
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
			strSql.Append(" SEQUENCE,MASTERID,DETAILID,BILLNO,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_NAME,ITEM_COLOR,ITEM_TYPE,SPECIFICATIONS,MEASURE_UNIT,ITEM_CZ,ITEM_LH,ITEM_LK,ITEM_BJ,ITEM_JZ,ITEM_HZ,ITEM_rate,ITEM_GYLC,NET_PRICE,PRICE,Quantity,total_quantity,ORD_TL,BARCODE,REMARK ");
			strSql.Append(" FROM ORDER_CG_DETAIL ");
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
			strSql.Append("select count(1) FROM ORDER_CG_DETAIL ");
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
			strSql.Append(")AS Row, T.*  from ORDER_CG_DETAIL T ");
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
			parameters[0].Value = "ORDER_CG_DETAIL";
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

