using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_ZXGG
	/// </summary>
	public partial class ORDER_ZXGG
	{
		public ORDER_ZXGG()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_ZXGG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_ZXGG(");
			strSql.Append("INTERNAL_CODE,CUSTOM_CODE,CUSTOM_NAME,ZXXXCode,ZXXXName,ZXKDGS,ZXLENGS,ZXZK,ZXDT,ZXZBSL,ZXYZBJ,ZXGZBJ,ZXIMAGE,ZXZK_cm,ZXDT_cm,ZXYxgs,ZXYXGD,IMAGE_NAME,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE)");
			strSql.Append(" values (");
			strSql.Append("@INTERNAL_CODE,@CUSTOM_CODE,@CUSTOM_NAME,@ZXXXCode,@ZXXXName,@ZXKDGS,@ZXLENGS,@ZXZK,@ZXDT,@ZXZBSL,@ZXYZBJ,@ZXGZBJ,@ZXIMAGE,@ZXZK_cm,@ZXDT_cm,@ZXYxgs,@ZXYXGD,@IMAGE_NAME,@CREATE_NAME,@CREATE_DATE,@UPDATE_NAME,@UPDATE_DATE)");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ZXXXCode", SqlDbType.NVarChar,10),
					new SqlParameter("@ZXXXName", SqlDbType.NVarChar,30),
					new SqlParameter("@ZXKDGS", SqlDbType.NVarChar,50),
					new SqlParameter("@ZXLENGS", SqlDbType.NVarChar,50),
					new SqlParameter("@ZXZK", SqlDbType.Float,8),
					new SqlParameter("@ZXDT", SqlDbType.Float,8),
					new SqlParameter("@ZXZBSL", SqlDbType.Int,4),
					new SqlParameter("@ZXYZBJ", SqlDbType.NVarChar,50),
					new SqlParameter("@ZXGZBJ", SqlDbType.NVarChar,50),
					new SqlParameter("@ZXIMAGE", SqlDbType.Image),
					new SqlParameter("@ZXZK_cm", SqlDbType.Float,8),
					new SqlParameter("@ZXDT_cm", SqlDbType.Float,8),
					new SqlParameter("@ZXYxgs", SqlDbType.NVarChar,30),
					new SqlParameter("@ZXYXGD", SqlDbType.NVarChar,30),
					new SqlParameter("@IMAGE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,10),
					new SqlParameter("@CREATE_DATE", SqlDbType.NVarChar,10),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NVarChar,10),
					new SqlParameter("@UPDATE_DATE", SqlDbType.NVarChar,10)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.CUSTOM_CODE;
			parameters[2].Value = model.CUSTOM_NAME;
			parameters[3].Value = model.ZXXXCode;
			parameters[4].Value = model.ZXXXName;
			parameters[5].Value = model.ZXKDGS;
			parameters[6].Value = model.ZXLENGS;
			parameters[7].Value = model.ZXZK;
			parameters[8].Value = model.ZXDT;
			parameters[9].Value = model.ZXZBSL;
			parameters[10].Value = model.ZXYZBJ;
			parameters[11].Value = model.ZXGZBJ;
			parameters[12].Value = model.ZXIMAGE;
			parameters[13].Value = model.ZXZK_cm;
			parameters[14].Value = model.ZXDT_cm;
			parameters[15].Value = model.ZXYxgs;
			parameters[16].Value = model.ZXYXGD;
			parameters[17].Value = model.IMAGE_NAME;
			parameters[18].Value = model.CREATE_NAME;
			parameters[19].Value = model.CREATE_DATE;
			parameters[20].Value = model.UPDATE_NAME;
			parameters[21].Value = model.UPDATE_DATE;

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
		public bool Update(MyERP.Model.ORDER_ZXGG model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_ZXGG set ");
			strSql.Append("INTERNAL_CODE=@INTERNAL_CODE,");
			strSql.Append("CUSTOM_CODE=@CUSTOM_CODE,");
			strSql.Append("CUSTOM_NAME=@CUSTOM_NAME,");
			strSql.Append("ZXXXCode=@ZXXXCode,");
			strSql.Append("ZXXXName=@ZXXXName,");
			strSql.Append("ZXKDGS=@ZXKDGS,");
			strSql.Append("ZXLENGS=@ZXLENGS,");
			strSql.Append("ZXZK=@ZXZK,");
			strSql.Append("ZXDT=@ZXDT,");
			strSql.Append("ZXZBSL=@ZXZBSL,");
			strSql.Append("ZXYZBJ=@ZXYZBJ,");
			strSql.Append("ZXGZBJ=@ZXGZBJ,");
			strSql.Append("ZXIMAGE=@ZXIMAGE,");
			strSql.Append("ZXZK_cm=@ZXZK_cm,");
			strSql.Append("ZXDT_cm=@ZXDT_cm,");
			strSql.Append("ZXYxgs=@ZXYxgs,");
			strSql.Append("ZXYXGD=@ZXYXGD,");
			strSql.Append("IMAGE_NAME=@IMAGE_NAME,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@INTERNAL_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@CUSTOM_CODE", SqlDbType.VarChar,50),
					new SqlParameter("@CUSTOM_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@ZXXXCode", SqlDbType.NVarChar,10),
					new SqlParameter("@ZXXXName", SqlDbType.NVarChar,30),
					new SqlParameter("@ZXKDGS", SqlDbType.NVarChar,50),
					new SqlParameter("@ZXLENGS", SqlDbType.NVarChar,50),
					new SqlParameter("@ZXZK", SqlDbType.Float,8),
					new SqlParameter("@ZXDT", SqlDbType.Float,8),
					new SqlParameter("@ZXZBSL", SqlDbType.Int,4),
					new SqlParameter("@ZXYZBJ", SqlDbType.NVarChar,50),
					new SqlParameter("@ZXGZBJ", SqlDbType.NVarChar,50),
					new SqlParameter("@ZXIMAGE", SqlDbType.Image),
					new SqlParameter("@ZXZK_cm", SqlDbType.Float,8),
					new SqlParameter("@ZXDT_cm", SqlDbType.Float,8),
					new SqlParameter("@ZXYxgs", SqlDbType.NVarChar,30),
					new SqlParameter("@ZXYXGD", SqlDbType.NVarChar,30),
					new SqlParameter("@IMAGE_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,10),
					new SqlParameter("@CREATE_DATE", SqlDbType.NVarChar,10),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NVarChar,10),
					new SqlParameter("@UPDATE_DATE", SqlDbType.NVarChar,10)};
			parameters[0].Value = model.INTERNAL_CODE;
			parameters[1].Value = model.CUSTOM_CODE;
			parameters[2].Value = model.CUSTOM_NAME;
			parameters[3].Value = model.ZXXXCode;
			parameters[4].Value = model.ZXXXName;
			parameters[5].Value = model.ZXKDGS;
			parameters[6].Value = model.ZXLENGS;
			parameters[7].Value = model.ZXZK;
			parameters[8].Value = model.ZXDT;
			parameters[9].Value = model.ZXZBSL;
			parameters[10].Value = model.ZXYZBJ;
			parameters[11].Value = model.ZXGZBJ;
			parameters[12].Value = model.ZXIMAGE;
			parameters[13].Value = model.ZXZK_cm;
			parameters[14].Value = model.ZXDT_cm;
			parameters[15].Value = model.ZXYxgs;
			parameters[16].Value = model.ZXYXGD;
			parameters[17].Value = model.IMAGE_NAME;
			parameters[18].Value = model.CREATE_NAME;
			parameters[19].Value = model.CREATE_DATE;
			parameters[20].Value = model.UPDATE_NAME;
			parameters[21].Value = model.UPDATE_DATE;

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
			strSql.Append("delete from ORDER_ZXGG ");
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
		public MyERP.Model.ORDER_ZXGG GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 INTERNAL_CODE,CUSTOM_CODE,CUSTOM_NAME,ZXXXCode,ZXXXName,ZXKDGS,ZXLENGS,ZXZK,ZXDT,ZXZBSL,ZXYZBJ,ZXGZBJ,ZXIMAGE,ZXZK_cm,ZXDT_cm,ZXYxgs,ZXYXGD,IMAGE_NAME,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE from ORDER_ZXGG ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.ORDER_ZXGG model=new MyERP.Model.ORDER_ZXGG();
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
		public MyERP.Model.ORDER_ZXGG DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_ZXGG model=new MyERP.Model.ORDER_ZXGG();
			if (row != null)
			{
				if(row["INTERNAL_CODE"]!=null)
				{
					model.INTERNAL_CODE=row["INTERNAL_CODE"].ToString();
				}
				if(row["CUSTOM_CODE"]!=null)
				{
					model.CUSTOM_CODE=row["CUSTOM_CODE"].ToString();
				}
				if(row["CUSTOM_NAME"]!=null)
				{
					model.CUSTOM_NAME=row["CUSTOM_NAME"].ToString();
				}
				if(row["ZXXXCode"]!=null)
				{
					model.ZXXXCode=row["ZXXXCode"].ToString();
				}
				if(row["ZXXXName"]!=null)
				{
					model.ZXXXName=row["ZXXXName"].ToString();
				}
				if(row["ZXKDGS"]!=null)
				{
					model.ZXKDGS=row["ZXKDGS"].ToString();
				}
				if(row["ZXLENGS"]!=null)
				{
					model.ZXLENGS=row["ZXLENGS"].ToString();
				}
				if(row["ZXZK"]!=null && row["ZXZK"].ToString()!="")
				{
					model.ZXZK=decimal.Parse(row["ZXZK"].ToString());
				}
				if(row["ZXDT"]!=null && row["ZXDT"].ToString()!="")
				{
					model.ZXDT=decimal.Parse(row["ZXDT"].ToString());
				}
				if(row["ZXZBSL"]!=null && row["ZXZBSL"].ToString()!="")
				{
					model.ZXZBSL=int.Parse(row["ZXZBSL"].ToString());
				}
				if(row["ZXYZBJ"]!=null)
				{
					model.ZXYZBJ=row["ZXYZBJ"].ToString();
				}
				if(row["ZXGZBJ"]!=null)
				{
					model.ZXGZBJ=row["ZXGZBJ"].ToString();
				}
				if(row["ZXIMAGE"]!=null && row["ZXIMAGE"].ToString()!="")
				{
					model.ZXIMAGE=(byte[])row["ZXIMAGE"];
				}
				if(row["ZXZK_cm"]!=null && row["ZXZK_cm"].ToString()!="")
				{
					model.ZXZK_cm=decimal.Parse(row["ZXZK_cm"].ToString());
				}
				if(row["ZXDT_cm"]!=null && row["ZXDT_cm"].ToString()!="")
				{
					model.ZXDT_cm=decimal.Parse(row["ZXDT_cm"].ToString());
				}
				if(row["ZXYxgs"]!=null)
				{
					model.ZXYxgs=row["ZXYxgs"].ToString();
				}
				if(row["ZXYXGD"]!=null)
				{
					model.ZXYXGD=row["ZXYXGD"].ToString();
				}
				if(row["IMAGE_NAME"]!=null)
				{
					model.IMAGE_NAME=row["IMAGE_NAME"].ToString();
				}
				if(row["CREATE_NAME"]!=null)
				{
					model.CREATE_NAME=row["CREATE_NAME"].ToString();
				}
				if(row["CREATE_DATE"]!=null)
				{
					model.CREATE_DATE=row["CREATE_DATE"].ToString();
				}
				if(row["UPDATE_NAME"]!=null)
				{
					model.UPDATE_NAME=row["UPDATE_NAME"].ToString();
				}
				if(row["UPDATE_DATE"]!=null)
				{
					model.UPDATE_DATE=row["UPDATE_DATE"].ToString();
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
			strSql.Append("select INTERNAL_CODE,CUSTOM_CODE,CUSTOM_NAME,ZXXXCode,ZXXXName,ZXKDGS,ZXLENGS,ZXZK,ZXDT,ZXZBSL,ZXYZBJ,ZXGZBJ,ZXIMAGE,ZXZK_cm,ZXDT_cm,ZXYxgs,ZXYXGD,IMAGE_NAME,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE ");
			strSql.Append(" FROM ORDER_ZXGG ");
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
			strSql.Append(" INTERNAL_CODE,CUSTOM_CODE,CUSTOM_NAME,ZXXXCode,ZXXXName,ZXKDGS,ZXLENGS,ZXZK,ZXDT,ZXZBSL,ZXYZBJ,ZXGZBJ,ZXIMAGE,ZXZK_cm,ZXDT_cm,ZXYxgs,ZXYXGD,IMAGE_NAME,CREATE_NAME,CREATE_DATE,UPDATE_NAME,UPDATE_DATE ");
			strSql.Append(" FROM ORDER_ZXGG ");
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
			strSql.Append("select count(1) FROM ORDER_ZXGG ");
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
			strSql.Append(")AS Row, T.*  from ORDER_ZXGG T ");
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
			parameters[0].Value = "ORDER_ZXGG";
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

