using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_PCDETAIL
	/// </summary>
	public partial class ORDER_PCDETAIL
	{
		public ORDER_PCDETAIL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_PCDETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_PCDETAIL(");
			strSql.Append("DETAILID,MASTERID,BILLNO,Sequence,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_LOGO,ITEM_DESCRIPTION,ITEM_CD,ITEM_KD,ITEM_GD,ITEM_SPECIFICATIONS,ITEM_MEASURE_UNIT,ITEM_GYLC,ITEM_POSITION,ITEM_MIN_QTY,ITEM_MAX_QTY,ITEM_IMAGE,ITEM_IMAGE_NAME,ITEM_DWMJ,ITEM_BARCODE,NET_PRICE,PRICE,Quantity,ORD_CGqty,ORD_CLqty,ORD_PCqty,ORD_WGqty,ORD_TCqty,ORD_WGZL,ORD_FPqty,ORD_Sendqty,ORD_SHqty,ORD_LHqty,ORD_HZqty,ORD_THqty,ORD_Acceptqty,ORD_TL,ORD_GRAPHICNO,ORD_SHDH,ORD_BZFS,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@DETAILID,@MASTERID,@BILLNO,@Sequence,@ITEM_INTERNAL_CODE,@ITEM_CODE,@ITEM_CODE_old,@ITEM_NAME,@ITEM_COLOR,@PARENT_ITEM_CODE,@ITEM_TYPE,@ITEM_LOGO,@ITEM_DESCRIPTION,@ITEM_CD,@ITEM_KD,@ITEM_GD,@ITEM_SPECIFICATIONS,@ITEM_MEASURE_UNIT,@ITEM_GYLC,@ITEM_POSITION,@ITEM_MIN_QTY,@ITEM_MAX_QTY,@ITEM_IMAGE,@ITEM_IMAGE_NAME,@ITEM_DWMJ,@ITEM_BARCODE,@NET_PRICE,@PRICE,@Quantity,@ORD_CGqty,@ORD_CLqty,@ORD_PCqty,@ORD_WGqty,@ORD_TCqty,@ORD_WGZL,@ORD_FPqty,@ORD_Sendqty,@ORD_SHqty,@ORD_LHqty,@ORD_HZqty,@ORD_THqty,@ORD_Acceptqty,@ORD_TL,@ORD_GRAPHICNO,@ORD_SHDH,@ORD_BZFS,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@DETAILID", SqlDbType.VarChar,50),
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@Sequence", SqlDbType.Int,4),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CODE_old", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.VarChar,50),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.Float,8),
					new SqlParameter("@ITEM_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_LOGO", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_DESCRIPTION", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CD", SqlDbType.Float,8),
					new SqlParameter("@ITEM_KD", SqlDbType.Float,8),
					new SqlParameter("@ITEM_GD", SqlDbType.Float,8),
					new SqlParameter("@ITEM_SPECIFICATIONS", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_MEASURE_UNIT", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_GYLC", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_POSITION", SqlDbType.Float,8),
					new SqlParameter("@ITEM_MIN_QTY", SqlDbType.Float,8),
					new SqlParameter("@ITEM_MAX_QTY", SqlDbType.Float,8),
					new SqlParameter("@ITEM_IMAGE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_IMAGE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_DWMJ", SqlDbType.Float,8),
					new SqlParameter("@ITEM_BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@Quantity", SqlDbType.Int,4),
					new SqlParameter("@ORD_CGqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_CLqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_PCqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_WGqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_TCqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_WGZL", SqlDbType.Int,4),
					new SqlParameter("@ORD_FPqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_Sendqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_SHqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_LHqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_HZqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_THqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_Acceptqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_TL", SqlDbType.VarChar,50),
					new SqlParameter("@ORD_GRAPHICNO", SqlDbType.VarChar,50),
					new SqlParameter("@ORD_SHDH", SqlDbType.VarChar,50),
					new SqlParameter("@ORD_BZFS", SqlDbType.NVarChar,50),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.DETAILID;
			parameters[1].Value = model.MASTERID;
			parameters[2].Value = model.BILLNO;
			parameters[3].Value = model.Sequence;
			parameters[4].Value = model.ITEM_INTERNAL_CODE;
			parameters[5].Value = model.ITEM_CODE;
			parameters[6].Value = model.ITEM_CODE_old;
			parameters[7].Value = model.ITEM_NAME;
			parameters[8].Value = model.ITEM_COLOR;
			parameters[9].Value = model.PARENT_ITEM_CODE;
			parameters[10].Value = model.ITEM_TYPE;
			parameters[11].Value = model.ITEM_LOGO;
			parameters[12].Value = model.ITEM_DESCRIPTION;
			parameters[13].Value = model.ITEM_CD;
			parameters[14].Value = model.ITEM_KD;
			parameters[15].Value = model.ITEM_GD;
			parameters[16].Value = model.ITEM_SPECIFICATIONS;
			parameters[17].Value = model.ITEM_MEASURE_UNIT;
			parameters[18].Value = model.ITEM_GYLC;
			parameters[19].Value = model.ITEM_POSITION;
			parameters[20].Value = model.ITEM_MIN_QTY;
			parameters[21].Value = model.ITEM_MAX_QTY;
			parameters[22].Value = model.ITEM_IMAGE;
			parameters[23].Value = model.ITEM_IMAGE_NAME;
			parameters[24].Value = model.ITEM_DWMJ;
			parameters[25].Value = model.ITEM_BARCODE;
			parameters[26].Value = model.NET_PRICE;
			parameters[27].Value = model.PRICE;
			parameters[28].Value = model.Quantity;
			parameters[29].Value = model.ORD_CGqty;
			parameters[30].Value = model.ORD_CLqty;
			parameters[31].Value = model.ORD_PCqty;
			parameters[32].Value = model.ORD_WGqty;
			parameters[33].Value = model.ORD_TCqty;
			parameters[34].Value = model.ORD_WGZL;
			parameters[35].Value = model.ORD_FPqty;
			parameters[36].Value = model.ORD_Sendqty;
			parameters[37].Value = model.ORD_SHqty;
			parameters[38].Value = model.ORD_LHqty;
			parameters[39].Value = model.ORD_HZqty;
			parameters[40].Value = model.ORD_THqty;
			parameters[41].Value = model.ORD_Acceptqty;
			parameters[42].Value = model.ORD_TL;
			parameters[43].Value = model.ORD_GRAPHICNO;
			parameters[44].Value = model.ORD_SHDH;
			parameters[45].Value = model.ORD_BZFS;
			parameters[46].Value = model.REMARK;

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
		public bool Update(MyERP.Model.ORDER_PCDETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_PCDETAIL set ");
			strSql.Append("DETAILID=@DETAILID,");
			strSql.Append("MASTERID=@MASTERID,");
			strSql.Append("BILLNO=@BILLNO,");
			strSql.Append("Sequence=@Sequence,");
			strSql.Append("ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE,");
			strSql.Append("ITEM_CODE=@ITEM_CODE,");
			strSql.Append("ITEM_CODE_old=@ITEM_CODE_old,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("ITEM_COLOR=@ITEM_COLOR,");
			strSql.Append("PARENT_ITEM_CODE=@PARENT_ITEM_CODE,");
			strSql.Append("ITEM_TYPE=@ITEM_TYPE,");
			strSql.Append("ITEM_LOGO=@ITEM_LOGO,");
			strSql.Append("ITEM_DESCRIPTION=@ITEM_DESCRIPTION,");
			strSql.Append("ITEM_CD=@ITEM_CD,");
			strSql.Append("ITEM_KD=@ITEM_KD,");
			strSql.Append("ITEM_GD=@ITEM_GD,");
			strSql.Append("ITEM_SPECIFICATIONS=@ITEM_SPECIFICATIONS,");
			strSql.Append("ITEM_MEASURE_UNIT=@ITEM_MEASURE_UNIT,");
			strSql.Append("ITEM_GYLC=@ITEM_GYLC,");
			strSql.Append("ITEM_POSITION=@ITEM_POSITION,");
			strSql.Append("ITEM_MIN_QTY=@ITEM_MIN_QTY,");
			strSql.Append("ITEM_MAX_QTY=@ITEM_MAX_QTY,");
			strSql.Append("ITEM_IMAGE=@ITEM_IMAGE,");
			strSql.Append("ITEM_IMAGE_NAME=@ITEM_IMAGE_NAME,");
			strSql.Append("ITEM_DWMJ=@ITEM_DWMJ,");
			strSql.Append("ITEM_BARCODE=@ITEM_BARCODE,");
			strSql.Append("NET_PRICE=@NET_PRICE,");
			strSql.Append("PRICE=@PRICE,");
			strSql.Append("Quantity=@Quantity,");
			strSql.Append("ORD_CGqty=@ORD_CGqty,");
			strSql.Append("ORD_CLqty=@ORD_CLqty,");
			strSql.Append("ORD_PCqty=@ORD_PCqty,");
			strSql.Append("ORD_WGqty=@ORD_WGqty,");
			strSql.Append("ORD_TCqty=@ORD_TCqty,");
			strSql.Append("ORD_WGZL=@ORD_WGZL,");
			strSql.Append("ORD_FPqty=@ORD_FPqty,");
			strSql.Append("ORD_Sendqty=@ORD_Sendqty,");
			strSql.Append("ORD_SHqty=@ORD_SHqty,");
			strSql.Append("ORD_LHqty=@ORD_LHqty,");
			strSql.Append("ORD_HZqty=@ORD_HZqty,");
			strSql.Append("ORD_THqty=@ORD_THqty,");
			strSql.Append("ORD_Acceptqty=@ORD_Acceptqty,");
			strSql.Append("ORD_TL=@ORD_TL,");
			strSql.Append("ORD_GRAPHICNO=@ORD_GRAPHICNO,");
			strSql.Append("ORD_SHDH=@ORD_SHDH,");
			strSql.Append("ORD_BZFS=@ORD_BZFS,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@DETAILID", SqlDbType.VarChar,50),
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@Sequence", SqlDbType.Int,4),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CODE_old", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_COLOR", SqlDbType.VarChar,50),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.Float,8),
					new SqlParameter("@ITEM_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_LOGO", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_DESCRIPTION", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CD", SqlDbType.Float,8),
					new SqlParameter("@ITEM_KD", SqlDbType.Float,8),
					new SqlParameter("@ITEM_GD", SqlDbType.Float,8),
					new SqlParameter("@ITEM_SPECIFICATIONS", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_MEASURE_UNIT", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_GYLC", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_POSITION", SqlDbType.Float,8),
					new SqlParameter("@ITEM_MIN_QTY", SqlDbType.Float,8),
					new SqlParameter("@ITEM_MAX_QTY", SqlDbType.Float,8),
					new SqlParameter("@ITEM_IMAGE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_IMAGE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_DWMJ", SqlDbType.Float,8),
					new SqlParameter("@ITEM_BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@Quantity", SqlDbType.Int,4),
					new SqlParameter("@ORD_CGqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_CLqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_PCqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_WGqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_TCqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_WGZL", SqlDbType.Int,4),
					new SqlParameter("@ORD_FPqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_Sendqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_SHqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_LHqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_HZqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_THqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_Acceptqty", SqlDbType.Int,4),
					new SqlParameter("@ORD_TL", SqlDbType.VarChar,50),
					new SqlParameter("@ORD_GRAPHICNO", SqlDbType.VarChar,50),
					new SqlParameter("@ORD_SHDH", SqlDbType.VarChar,50),
					new SqlParameter("@ORD_BZFS", SqlDbType.NVarChar,50),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.DETAILID;
			parameters[1].Value = model.MASTERID;
			parameters[2].Value = model.BILLNO;
			parameters[3].Value = model.Sequence;
			parameters[4].Value = model.ITEM_INTERNAL_CODE;
			parameters[5].Value = model.ITEM_CODE;
			parameters[6].Value = model.ITEM_CODE_old;
			parameters[7].Value = model.ITEM_NAME;
			parameters[8].Value = model.ITEM_COLOR;
			parameters[9].Value = model.PARENT_ITEM_CODE;
			parameters[10].Value = model.ITEM_TYPE;
			parameters[11].Value = model.ITEM_LOGO;
			parameters[12].Value = model.ITEM_DESCRIPTION;
			parameters[13].Value = model.ITEM_CD;
			parameters[14].Value = model.ITEM_KD;
			parameters[15].Value = model.ITEM_GD;
			parameters[16].Value = model.ITEM_SPECIFICATIONS;
			parameters[17].Value = model.ITEM_MEASURE_UNIT;
			parameters[18].Value = model.ITEM_GYLC;
			parameters[19].Value = model.ITEM_POSITION;
			parameters[20].Value = model.ITEM_MIN_QTY;
			parameters[21].Value = model.ITEM_MAX_QTY;
			parameters[22].Value = model.ITEM_IMAGE;
			parameters[23].Value = model.ITEM_IMAGE_NAME;
			parameters[24].Value = model.ITEM_DWMJ;
			parameters[25].Value = model.ITEM_BARCODE;
			parameters[26].Value = model.NET_PRICE;
			parameters[27].Value = model.PRICE;
			parameters[28].Value = model.Quantity;
			parameters[29].Value = model.ORD_CGqty;
			parameters[30].Value = model.ORD_CLqty;
			parameters[31].Value = model.ORD_PCqty;
			parameters[32].Value = model.ORD_WGqty;
			parameters[33].Value = model.ORD_TCqty;
			parameters[34].Value = model.ORD_WGZL;
			parameters[35].Value = model.ORD_FPqty;
			parameters[36].Value = model.ORD_Sendqty;
			parameters[37].Value = model.ORD_SHqty;
			parameters[38].Value = model.ORD_LHqty;
			parameters[39].Value = model.ORD_HZqty;
			parameters[40].Value = model.ORD_THqty;
			parameters[41].Value = model.ORD_Acceptqty;
			parameters[42].Value = model.ORD_TL;
			parameters[43].Value = model.ORD_GRAPHICNO;
			parameters[44].Value = model.ORD_SHDH;
			parameters[45].Value = model.ORD_BZFS;
			parameters[46].Value = model.REMARK;

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
			strSql.Append("delete from ORDER_PCDETAIL ");
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
		public MyERP.Model.ORDER_PCDETAIL GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DETAILID,MASTERID,BILLNO,Sequence,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_LOGO,ITEM_DESCRIPTION,ITEM_CD,ITEM_KD,ITEM_GD,ITEM_SPECIFICATIONS,ITEM_MEASURE_UNIT,ITEM_GYLC,ITEM_POSITION,ITEM_MIN_QTY,ITEM_MAX_QTY,ITEM_IMAGE,ITEM_IMAGE_NAME,ITEM_DWMJ,ITEM_BARCODE,NET_PRICE,PRICE,Quantity,ORD_CGqty,ORD_CLqty,ORD_PCqty,ORD_WGqty,ORD_TCqty,ORD_WGZL,ORD_FPqty,ORD_Sendqty,ORD_SHqty,ORD_LHqty,ORD_HZqty,ORD_THqty,ORD_Acceptqty,ORD_TL,ORD_GRAPHICNO,ORD_SHDH,ORD_BZFS,REMARK from ORDER_PCDETAIL ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.ORDER_PCDETAIL model=new MyERP.Model.ORDER_PCDETAIL();
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
		public MyERP.Model.ORDER_PCDETAIL DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_PCDETAIL model=new MyERP.Model.ORDER_PCDETAIL();
			if (row != null)
			{
				if(row["DETAILID"]!=null)
				{
					model.DETAILID=row["DETAILID"].ToString();
				}
				if(row["MASTERID"]!=null)
				{
					model.MASTERID=row["MASTERID"].ToString();
				}
				if(row["BILLNO"]!=null)
				{
					model.BILLNO=row["BILLNO"].ToString();
				}
				if(row["Sequence"]!=null && row["Sequence"].ToString()!="")
				{
					model.Sequence=int.Parse(row["Sequence"].ToString());
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
				if(row["PARENT_ITEM_CODE"]!=null && row["PARENT_ITEM_CODE"].ToString()!="")
				{
					model.PARENT_ITEM_CODE=decimal.Parse(row["PARENT_ITEM_CODE"].ToString());
				}
				if(row["ITEM_TYPE"]!=null)
				{
					model.ITEM_TYPE=row["ITEM_TYPE"].ToString();
				}
				if(row["ITEM_LOGO"]!=null)
				{
					model.ITEM_LOGO=row["ITEM_LOGO"].ToString();
				}
				if(row["ITEM_DESCRIPTION"]!=null)
				{
					model.ITEM_DESCRIPTION=row["ITEM_DESCRIPTION"].ToString();
				}
				if(row["ITEM_CD"]!=null && row["ITEM_CD"].ToString()!="")
				{
					model.ITEM_CD=decimal.Parse(row["ITEM_CD"].ToString());
				}
				if(row["ITEM_KD"]!=null && row["ITEM_KD"].ToString()!="")
				{
					model.ITEM_KD=decimal.Parse(row["ITEM_KD"].ToString());
				}
				if(row["ITEM_GD"]!=null && row["ITEM_GD"].ToString()!="")
				{
					model.ITEM_GD=decimal.Parse(row["ITEM_GD"].ToString());
				}
				if(row["ITEM_SPECIFICATIONS"]!=null)
				{
					model.ITEM_SPECIFICATIONS=row["ITEM_SPECIFICATIONS"].ToString();
				}
				if(row["ITEM_MEASURE_UNIT"]!=null)
				{
					model.ITEM_MEASURE_UNIT=row["ITEM_MEASURE_UNIT"].ToString();
				}
				if(row["ITEM_GYLC"]!=null)
				{
					model.ITEM_GYLC=row["ITEM_GYLC"].ToString();
				}
				if(row["ITEM_POSITION"]!=null && row["ITEM_POSITION"].ToString()!="")
				{
					model.ITEM_POSITION=decimal.Parse(row["ITEM_POSITION"].ToString());
				}
				if(row["ITEM_MIN_QTY"]!=null && row["ITEM_MIN_QTY"].ToString()!="")
				{
					model.ITEM_MIN_QTY=decimal.Parse(row["ITEM_MIN_QTY"].ToString());
				}
				if(row["ITEM_MAX_QTY"]!=null && row["ITEM_MAX_QTY"].ToString()!="")
				{
					model.ITEM_MAX_QTY=decimal.Parse(row["ITEM_MAX_QTY"].ToString());
				}
				if(row["ITEM_IMAGE"]!=null)
				{
					model.ITEM_IMAGE=row["ITEM_IMAGE"].ToString();
				}
				if(row["ITEM_IMAGE_NAME"]!=null)
				{
					model.ITEM_IMAGE_NAME=row["ITEM_IMAGE_NAME"].ToString();
				}
				if(row["ITEM_DWMJ"]!=null && row["ITEM_DWMJ"].ToString()!="")
				{
					model.ITEM_DWMJ=decimal.Parse(row["ITEM_DWMJ"].ToString());
				}
				if(row["ITEM_BARCODE"]!=null)
				{
					model.ITEM_BARCODE=row["ITEM_BARCODE"].ToString();
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
					model.Quantity=int.Parse(row["Quantity"].ToString());
				}
				if(row["ORD_CGqty"]!=null && row["ORD_CGqty"].ToString()!="")
				{
					model.ORD_CGqty=int.Parse(row["ORD_CGqty"].ToString());
				}
				if(row["ORD_CLqty"]!=null && row["ORD_CLqty"].ToString()!="")
				{
					model.ORD_CLqty=int.Parse(row["ORD_CLqty"].ToString());
				}
				if(row["ORD_PCqty"]!=null && row["ORD_PCqty"].ToString()!="")
				{
					model.ORD_PCqty=int.Parse(row["ORD_PCqty"].ToString());
				}
				if(row["ORD_WGqty"]!=null && row["ORD_WGqty"].ToString()!="")
				{
					model.ORD_WGqty=int.Parse(row["ORD_WGqty"].ToString());
				}
				if(row["ORD_TCqty"]!=null && row["ORD_TCqty"].ToString()!="")
				{
					model.ORD_TCqty=int.Parse(row["ORD_TCqty"].ToString());
				}
				if(row["ORD_WGZL"]!=null && row["ORD_WGZL"].ToString()!="")
				{
					model.ORD_WGZL=int.Parse(row["ORD_WGZL"].ToString());
				}
				if(row["ORD_FPqty"]!=null && row["ORD_FPqty"].ToString()!="")
				{
					model.ORD_FPqty=int.Parse(row["ORD_FPqty"].ToString());
				}
				if(row["ORD_Sendqty"]!=null && row["ORD_Sendqty"].ToString()!="")
				{
					model.ORD_Sendqty=int.Parse(row["ORD_Sendqty"].ToString());
				}
				if(row["ORD_SHqty"]!=null && row["ORD_SHqty"].ToString()!="")
				{
					model.ORD_SHqty=int.Parse(row["ORD_SHqty"].ToString());
				}
				if(row["ORD_LHqty"]!=null && row["ORD_LHqty"].ToString()!="")
				{
					model.ORD_LHqty=int.Parse(row["ORD_LHqty"].ToString());
				}
				if(row["ORD_HZqty"]!=null && row["ORD_HZqty"].ToString()!="")
				{
					model.ORD_HZqty=int.Parse(row["ORD_HZqty"].ToString());
				}
				if(row["ORD_THqty"]!=null && row["ORD_THqty"].ToString()!="")
				{
					model.ORD_THqty=int.Parse(row["ORD_THqty"].ToString());
				}
				if(row["ORD_Acceptqty"]!=null && row["ORD_Acceptqty"].ToString()!="")
				{
					model.ORD_Acceptqty=int.Parse(row["ORD_Acceptqty"].ToString());
				}
				if(row["ORD_TL"]!=null)
				{
					model.ORD_TL=row["ORD_TL"].ToString();
				}
				if(row["ORD_GRAPHICNO"]!=null)
				{
					model.ORD_GRAPHICNO=row["ORD_GRAPHICNO"].ToString();
				}
				if(row["ORD_SHDH"]!=null)
				{
					model.ORD_SHDH=row["ORD_SHDH"].ToString();
				}
				if(row["ORD_BZFS"]!=null)
				{
					model.ORD_BZFS=row["ORD_BZFS"].ToString();
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
			strSql.Append("select DETAILID,MASTERID,BILLNO,Sequence,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_LOGO,ITEM_DESCRIPTION,ITEM_CD,ITEM_KD,ITEM_GD,ITEM_SPECIFICATIONS,ITEM_MEASURE_UNIT,ITEM_GYLC,ITEM_POSITION,ITEM_MIN_QTY,ITEM_MAX_QTY,ITEM_IMAGE,ITEM_IMAGE_NAME,ITEM_DWMJ,ITEM_BARCODE,NET_PRICE,PRICE,Quantity,ORD_CGqty,ORD_CLqty,ORD_PCqty,ORD_WGqty,ORD_TCqty,ORD_WGZL,ORD_FPqty,ORD_Sendqty,ORD_SHqty,ORD_LHqty,ORD_HZqty,ORD_THqty,ORD_Acceptqty,ORD_TL,ORD_GRAPHICNO,ORD_SHDH,ORD_BZFS,REMARK ");
			strSql.Append(" FROM ORDER_PCDETAIL ");
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
			strSql.Append(" DETAILID,MASTERID,BILLNO,Sequence,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,ITEM_NAME,ITEM_COLOR,PARENT_ITEM_CODE,ITEM_TYPE,ITEM_LOGO,ITEM_DESCRIPTION,ITEM_CD,ITEM_KD,ITEM_GD,ITEM_SPECIFICATIONS,ITEM_MEASURE_UNIT,ITEM_GYLC,ITEM_POSITION,ITEM_MIN_QTY,ITEM_MAX_QTY,ITEM_IMAGE,ITEM_IMAGE_NAME,ITEM_DWMJ,ITEM_BARCODE,NET_PRICE,PRICE,Quantity,ORD_CGqty,ORD_CLqty,ORD_PCqty,ORD_WGqty,ORD_TCqty,ORD_WGZL,ORD_FPqty,ORD_Sendqty,ORD_SHqty,ORD_LHqty,ORD_HZqty,ORD_THqty,ORD_Acceptqty,ORD_TL,ORD_GRAPHICNO,ORD_SHDH,ORD_BZFS,REMARK ");
			strSql.Append(" FROM ORDER_PCDETAIL ");
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
			strSql.Append("select count(1) FROM ORDER_PCDETAIL ");
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
			strSql.Append(")AS Row, T.*  from ORDER_PCDETAIL T ");
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
			parameters[0].Value = "ORDER_PCDETAIL";
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

