using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUR_PURCHASE_DETAIL
	/// </summary>
	public partial class PUR_PURCHASE_DETAIL
	{
		public PUR_PURCHASE_DETAIL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUR_PURCHASE_DETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUR_PURCHASE_DETAIL(");
			strSql.Append("DETAILID,MASTERID,BILLNO,Sequence,SUPPLY_CODE,SUPPLY_NAME,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_CD,ITEM_KD,ITEM_GD,MEASURE_UNIT,ITEM_NAME,ITEM_TYPE,COLOR,IMAGE,DWMJ,DESCRIPTION,BARCODE,NET_PRICE,PRICE,Quantity,PAYAMOUNT,TAX_RATE,ORD_CGqty,ORD_CLqty,ORD_PCqty,ORD_WGqty,ORD_TCqty,ORD_WGZL,ORD_FPqty,ORD_Sendqty,ORD_SHqty,ORD_LHqty,ORD_HZqty,ORD_THqty,ORD_Acceptqty,ORD_SHDH,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@DETAILID,@MASTERID,@BILLNO,@Sequence,@SUPPLY_CODE,@SUPPLY_NAME,@ITEM_INTERNAL_CODE,@ITEM_CODE,@ITEM_CODE_old,@SPECIFICATIONS,@PARENT_ITEM_CODE,@ITEM_CD,@ITEM_KD,@ITEM_GD,@MEASURE_UNIT,@ITEM_NAME,@ITEM_TYPE,@COLOR,@IMAGE,@DWMJ,@DESCRIPTION,@BARCODE,@NET_PRICE,@PRICE,@Quantity,@PAYAMOUNT,@TAX_RATE,@ORD_CGqty,@ORD_CLqty,@ORD_PCqty,@ORD_WGqty,@ORD_TCqty,@ORD_WGZL,@ORD_FPqty,@ORD_Sendqty,@ORD_SHqty,@ORD_LHqty,@ORD_HZqty,@ORD_THqty,@ORD_Acceptqty,@ORD_SHDH,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@DETAILID", SqlDbType.VarChar,50),
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@Sequence", SqlDbType.Int,4),
					new SqlParameter("@SUPPLY_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SUPPLY_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CODE_old", SqlDbType.VarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.VarChar,50),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.Float,8),
					new SqlParameter("@ITEM_CD", SqlDbType.Float,8),
					new SqlParameter("@ITEM_KD", SqlDbType.Float,8),
					new SqlParameter("@ITEM_GD", SqlDbType.Float,8),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@COLOR", SqlDbType.VarChar,50),
					new SqlParameter("@IMAGE", SqlDbType.VarChar,50),
					new SqlParameter("@DWMJ", SqlDbType.Float,8),
					new SqlParameter("@DESCRIPTION", SqlDbType.VarChar,50),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@Quantity", SqlDbType.Int,4),
					new SqlParameter("@PAYAMOUNT", SqlDbType.Float,8),
					new SqlParameter("@TAX_RATE", SqlDbType.Float,8),
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
					new SqlParameter("@ORD_SHDH", SqlDbType.VarChar,50),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.DETAILID;
			parameters[1].Value = model.MASTERID;
			parameters[2].Value = model.BILLNO;
			parameters[3].Value = model.Sequence;
			parameters[4].Value = model.SUPPLY_CODE;
			parameters[5].Value = model.SUPPLY_NAME;
			parameters[6].Value = model.ITEM_INTERNAL_CODE;
			parameters[7].Value = model.ITEM_CODE;
			parameters[8].Value = model.ITEM_CODE_old;
			parameters[9].Value = model.SPECIFICATIONS;
			parameters[10].Value = model.PARENT_ITEM_CODE;
			parameters[11].Value = model.ITEM_CD;
			parameters[12].Value = model.ITEM_KD;
			parameters[13].Value = model.ITEM_GD;
			parameters[14].Value = model.MEASURE_UNIT;
			parameters[15].Value = model.ITEM_NAME;
			parameters[16].Value = model.ITEM_TYPE;
			parameters[17].Value = model.COLOR;
			parameters[18].Value = model.IMAGE;
			parameters[19].Value = model.DWMJ;
			parameters[20].Value = model.DESCRIPTION;
			parameters[21].Value = model.BARCODE;
			parameters[22].Value = model.NET_PRICE;
			parameters[23].Value = model.PRICE;
			parameters[24].Value = model.Quantity;
			parameters[25].Value = model.PAYAMOUNT;
			parameters[26].Value = model.TAX_RATE;
			parameters[27].Value = model.ORD_CGqty;
			parameters[28].Value = model.ORD_CLqty;
			parameters[29].Value = model.ORD_PCqty;
			parameters[30].Value = model.ORD_WGqty;
			parameters[31].Value = model.ORD_TCqty;
			parameters[32].Value = model.ORD_WGZL;
			parameters[33].Value = model.ORD_FPqty;
			parameters[34].Value = model.ORD_Sendqty;
			parameters[35].Value = model.ORD_SHqty;
			parameters[36].Value = model.ORD_LHqty;
			parameters[37].Value = model.ORD_HZqty;
			parameters[38].Value = model.ORD_THqty;
			parameters[39].Value = model.ORD_Acceptqty;
			parameters[40].Value = model.ORD_SHDH;
			parameters[41].Value = model.REMARK;

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
		public bool Update(MyERP.Model.PUR_PURCHASE_DETAIL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUR_PURCHASE_DETAIL set ");
			strSql.Append("DETAILID=@DETAILID,");
			strSql.Append("MASTERID=@MASTERID,");
			strSql.Append("BILLNO=@BILLNO,");
			strSql.Append("Sequence=@Sequence,");
			strSql.Append("SUPPLY_CODE=@SUPPLY_CODE,");
			strSql.Append("SUPPLY_NAME=@SUPPLY_NAME,");
			strSql.Append("ITEM_INTERNAL_CODE=@ITEM_INTERNAL_CODE,");
			strSql.Append("ITEM_CODE=@ITEM_CODE,");
			strSql.Append("ITEM_CODE_old=@ITEM_CODE_old,");
			strSql.Append("SPECIFICATIONS=@SPECIFICATIONS,");
			strSql.Append("PARENT_ITEM_CODE=@PARENT_ITEM_CODE,");
			strSql.Append("ITEM_CD=@ITEM_CD,");
			strSql.Append("ITEM_KD=@ITEM_KD,");
			strSql.Append("ITEM_GD=@ITEM_GD,");
			strSql.Append("MEASURE_UNIT=@MEASURE_UNIT,");
			strSql.Append("ITEM_NAME=@ITEM_NAME,");
			strSql.Append("ITEM_TYPE=@ITEM_TYPE,");
			strSql.Append("COLOR=@COLOR,");
			strSql.Append("IMAGE=@IMAGE,");
			strSql.Append("DWMJ=@DWMJ,");
			strSql.Append("DESCRIPTION=@DESCRIPTION,");
			strSql.Append("BARCODE=@BARCODE,");
			strSql.Append("NET_PRICE=@NET_PRICE,");
			strSql.Append("PRICE=@PRICE,");
			strSql.Append("Quantity=@Quantity,");
			strSql.Append("PAYAMOUNT=@PAYAMOUNT,");
			strSql.Append("TAX_RATE=@TAX_RATE,");
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
			strSql.Append("ORD_SHDH=@ORD_SHDH,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@DETAILID", SqlDbType.VarChar,50),
					new SqlParameter("@MASTERID", SqlDbType.VarChar,50),
					new SqlParameter("@BILLNO", SqlDbType.VarChar,50),
					new SqlParameter("@Sequence", SqlDbType.Int,4),
					new SqlParameter("@SUPPLY_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@SUPPLY_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_INTERNAL_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_CODE_old", SqlDbType.VarChar,50),
					new SqlParameter("@SPECIFICATIONS", SqlDbType.VarChar,50),
					new SqlParameter("@PARENT_ITEM_CODE", SqlDbType.Float,8),
					new SqlParameter("@ITEM_CD", SqlDbType.Float,8),
					new SqlParameter("@ITEM_KD", SqlDbType.Float,8),
					new SqlParameter("@ITEM_GD", SqlDbType.Float,8),
					new SqlParameter("@MEASURE_UNIT", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ITEM_TYPE", SqlDbType.VarChar,50),
					new SqlParameter("@COLOR", SqlDbType.VarChar,50),
					new SqlParameter("@IMAGE", SqlDbType.VarChar,50),
					new SqlParameter("@DWMJ", SqlDbType.Float,8),
					new SqlParameter("@DESCRIPTION", SqlDbType.VarChar,50),
					new SqlParameter("@BARCODE", SqlDbType.VarChar,50),
					new SqlParameter("@NET_PRICE", SqlDbType.Float,8),
					new SqlParameter("@PRICE", SqlDbType.Float,8),
					new SqlParameter("@Quantity", SqlDbType.Int,4),
					new SqlParameter("@PAYAMOUNT", SqlDbType.Float,8),
					new SqlParameter("@TAX_RATE", SqlDbType.Float,8),
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
					new SqlParameter("@ORD_SHDH", SqlDbType.VarChar,50),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.DETAILID;
			parameters[1].Value = model.MASTERID;
			parameters[2].Value = model.BILLNO;
			parameters[3].Value = model.Sequence;
			parameters[4].Value = model.SUPPLY_CODE;
			parameters[5].Value = model.SUPPLY_NAME;
			parameters[6].Value = model.ITEM_INTERNAL_CODE;
			parameters[7].Value = model.ITEM_CODE;
			parameters[8].Value = model.ITEM_CODE_old;
			parameters[9].Value = model.SPECIFICATIONS;
			parameters[10].Value = model.PARENT_ITEM_CODE;
			parameters[11].Value = model.ITEM_CD;
			parameters[12].Value = model.ITEM_KD;
			parameters[13].Value = model.ITEM_GD;
			parameters[14].Value = model.MEASURE_UNIT;
			parameters[15].Value = model.ITEM_NAME;
			parameters[16].Value = model.ITEM_TYPE;
			parameters[17].Value = model.COLOR;
			parameters[18].Value = model.IMAGE;
			parameters[19].Value = model.DWMJ;
			parameters[20].Value = model.DESCRIPTION;
			parameters[21].Value = model.BARCODE;
			parameters[22].Value = model.NET_PRICE;
			parameters[23].Value = model.PRICE;
			parameters[24].Value = model.Quantity;
			parameters[25].Value = model.PAYAMOUNT;
			parameters[26].Value = model.TAX_RATE;
			parameters[27].Value = model.ORD_CGqty;
			parameters[28].Value = model.ORD_CLqty;
			parameters[29].Value = model.ORD_PCqty;
			parameters[30].Value = model.ORD_WGqty;
			parameters[31].Value = model.ORD_TCqty;
			parameters[32].Value = model.ORD_WGZL;
			parameters[33].Value = model.ORD_FPqty;
			parameters[34].Value = model.ORD_Sendqty;
			parameters[35].Value = model.ORD_SHqty;
			parameters[36].Value = model.ORD_LHqty;
			parameters[37].Value = model.ORD_HZqty;
			parameters[38].Value = model.ORD_THqty;
			parameters[39].Value = model.ORD_Acceptqty;
			parameters[40].Value = model.ORD_SHDH;
			parameters[41].Value = model.REMARK;

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
			strSql.Append("delete from PUR_PURCHASE_DETAIL ");
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
		public MyERP.Model.PUR_PURCHASE_DETAIL GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DETAILID,MASTERID,BILLNO,Sequence,SUPPLY_CODE,SUPPLY_NAME,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_CD,ITEM_KD,ITEM_GD,MEASURE_UNIT,ITEM_NAME,ITEM_TYPE,COLOR,IMAGE,DWMJ,DESCRIPTION,BARCODE,NET_PRICE,PRICE,Quantity,PAYAMOUNT,TAX_RATE,ORD_CGqty,ORD_CLqty,ORD_PCqty,ORD_WGqty,ORD_TCqty,ORD_WGZL,ORD_FPqty,ORD_Sendqty,ORD_SHqty,ORD_LHqty,ORD_HZqty,ORD_THqty,ORD_Acceptqty,ORD_SHDH,REMARK from PUR_PURCHASE_DETAIL ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.PUR_PURCHASE_DETAIL model=new MyERP.Model.PUR_PURCHASE_DETAIL();
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
		public MyERP.Model.PUR_PURCHASE_DETAIL DataRowToModel(DataRow row)
		{
			MyERP.Model.PUR_PURCHASE_DETAIL model=new MyERP.Model.PUR_PURCHASE_DETAIL();
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
				if(row["SUPPLY_CODE"]!=null)
				{
					model.SUPPLY_CODE=row["SUPPLY_CODE"].ToString();
				}
				if(row["SUPPLY_NAME"]!=null)
				{
					model.SUPPLY_NAME=row["SUPPLY_NAME"].ToString();
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
				if(row["SPECIFICATIONS"]!=null)
				{
					model.SPECIFICATIONS=row["SPECIFICATIONS"].ToString();
				}
				if(row["PARENT_ITEM_CODE"]!=null && row["PARENT_ITEM_CODE"].ToString()!="")
				{
					model.PARENT_ITEM_CODE=decimal.Parse(row["PARENT_ITEM_CODE"].ToString());
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
				if(row["MEASURE_UNIT"]!=null)
				{
					model.MEASURE_UNIT=row["MEASURE_UNIT"].ToString();
				}
				if(row["ITEM_NAME"]!=null)
				{
					model.ITEM_NAME=row["ITEM_NAME"].ToString();
				}
				if(row["ITEM_TYPE"]!=null)
				{
					model.ITEM_TYPE=row["ITEM_TYPE"].ToString();
				}
				if(row["COLOR"]!=null)
				{
					model.COLOR=row["COLOR"].ToString();
				}
				if(row["IMAGE"]!=null)
				{
					model.IMAGE=row["IMAGE"].ToString();
				}
				if(row["DWMJ"]!=null && row["DWMJ"].ToString()!="")
				{
					model.DWMJ=decimal.Parse(row["DWMJ"].ToString());
				}
				if(row["DESCRIPTION"]!=null)
				{
					model.DESCRIPTION=row["DESCRIPTION"].ToString();
				}
				if(row["BARCODE"]!=null)
				{
					model.BARCODE=row["BARCODE"].ToString();
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
				if(row["PAYAMOUNT"]!=null && row["PAYAMOUNT"].ToString()!="")
				{
					model.PAYAMOUNT=decimal.Parse(row["PAYAMOUNT"].ToString());
				}
				if(row["TAX_RATE"]!=null && row["TAX_RATE"].ToString()!="")
				{
					model.TAX_RATE=decimal.Parse(row["TAX_RATE"].ToString());
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
				if(row["ORD_SHDH"]!=null)
				{
					model.ORD_SHDH=row["ORD_SHDH"].ToString();
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
			strSql.Append("select DETAILID,MASTERID,BILLNO,Sequence,SUPPLY_CODE,SUPPLY_NAME,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_CD,ITEM_KD,ITEM_GD,MEASURE_UNIT,ITEM_NAME,ITEM_TYPE,COLOR,IMAGE,DWMJ,DESCRIPTION,BARCODE,NET_PRICE,PRICE,Quantity,PAYAMOUNT,TAX_RATE,ORD_CGqty,ORD_CLqty,ORD_PCqty,ORD_WGqty,ORD_TCqty,ORD_WGZL,ORD_FPqty,ORD_Sendqty,ORD_SHqty,ORD_LHqty,ORD_HZqty,ORD_THqty,ORD_Acceptqty,ORD_SHDH,REMARK ");
			strSql.Append(" FROM PUR_PURCHASE_DETAIL ");
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
			strSql.Append(" DETAILID,MASTERID,BILLNO,Sequence,SUPPLY_CODE,SUPPLY_NAME,ITEM_INTERNAL_CODE,ITEM_CODE,ITEM_CODE_old,SPECIFICATIONS,PARENT_ITEM_CODE,ITEM_CD,ITEM_KD,ITEM_GD,MEASURE_UNIT,ITEM_NAME,ITEM_TYPE,COLOR,IMAGE,DWMJ,DESCRIPTION,BARCODE,NET_PRICE,PRICE,Quantity,PAYAMOUNT,TAX_RATE,ORD_CGqty,ORD_CLqty,ORD_PCqty,ORD_WGqty,ORD_TCqty,ORD_WGZL,ORD_FPqty,ORD_Sendqty,ORD_SHqty,ORD_LHqty,ORD_HZqty,ORD_THqty,ORD_Acceptqty,ORD_SHDH,REMARK ");
			strSql.Append(" FROM PUR_PURCHASE_DETAIL ");
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
			strSql.Append("select count(1) FROM PUR_PURCHASE_DETAIL ");
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
				strSql.Append("order by T.Vehicle_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUR_PURCHASE_DETAIL T ");
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
			parameters[0].Value = "PUR_PURCHASE_DETAIL";
			parameters[1].Value = "Vehicle_CODE";
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

