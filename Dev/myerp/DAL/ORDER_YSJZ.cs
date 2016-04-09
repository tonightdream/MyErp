using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_YSJZ
	/// </summary>
	public partial class ORDER_YSJZ
	{
		public ORDER_YSJZ()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_YSJZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_YSJZ(");
			strSql.Append("FDID,customcode,customname,SJJZ,QZZK,QZYS,YSJE,YSWS,begindate,enddate,createname,createdate,remark)");
			strSql.Append(" values (");
			strSql.Append("@FDID,@customcode,@customname,@SJJZ,@QZZK,@QZYS,@YSJE,@YSWS,@begindate,@enddate,@createname,@createdate,@remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@FDID", SqlDbType.NVarChar,10),
					new SqlParameter("@customcode", SqlDbType.VarChar,50),
					new SqlParameter("@customname", SqlDbType.VarChar,50),
					new SqlParameter("@SJJZ", SqlDbType.Float,8),
					new SqlParameter("@QZZK", SqlDbType.Float,8),
					new SqlParameter("@QZYS", SqlDbType.Float,8),
					new SqlParameter("@YSJE", SqlDbType.Float,8),
					new SqlParameter("@YSWS", SqlDbType.Float,8),
					new SqlParameter("@begindate", SqlDbType.NVarChar,10),
					new SqlParameter("@enddate", SqlDbType.NVarChar,10),
					new SqlParameter("@createname", SqlDbType.NVarChar,10),
					new SqlParameter("@createdate", SqlDbType.NVarChar,10),
					new SqlParameter("@remark", SqlDbType.NVarChar,30)};
			parameters[0].Value = model.FDID;
			parameters[1].Value = model.customcode;
			parameters[2].Value = model.customname;
			parameters[3].Value = model.SJJZ;
			parameters[4].Value = model.QZZK;
			parameters[5].Value = model.QZYS;
			parameters[6].Value = model.YSJE;
			parameters[7].Value = model.YSWS;
			parameters[8].Value = model.begindate;
			parameters[9].Value = model.enddate;
			parameters[10].Value = model.createname;
			parameters[11].Value = model.createdate;
			parameters[12].Value = model.remark;

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
		public bool Update(MyERP.Model.ORDER_YSJZ model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_YSJZ set ");
			strSql.Append("FDID=@FDID,");
			strSql.Append("customcode=@customcode,");
			strSql.Append("customname=@customname,");
			strSql.Append("SJJZ=@SJJZ,");
			strSql.Append("QZZK=@QZZK,");
			strSql.Append("QZYS=@QZYS,");
			strSql.Append("YSJE=@YSJE,");
			strSql.Append("YSWS=@YSWS,");
			strSql.Append("begindate=@begindate,");
			strSql.Append("enddate=@enddate,");
			strSql.Append("createname=@createname,");
			strSql.Append("createdate=@createdate,");
			strSql.Append("remark=@remark");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@FDID", SqlDbType.NVarChar,10),
					new SqlParameter("@customcode", SqlDbType.VarChar,50),
					new SqlParameter("@customname", SqlDbType.VarChar,50),
					new SqlParameter("@SJJZ", SqlDbType.Float,8),
					new SqlParameter("@QZZK", SqlDbType.Float,8),
					new SqlParameter("@QZYS", SqlDbType.Float,8),
					new SqlParameter("@YSJE", SqlDbType.Float,8),
					new SqlParameter("@YSWS", SqlDbType.Float,8),
					new SqlParameter("@begindate", SqlDbType.NVarChar,10),
					new SqlParameter("@enddate", SqlDbType.NVarChar,10),
					new SqlParameter("@createname", SqlDbType.NVarChar,10),
					new SqlParameter("@createdate", SqlDbType.NVarChar,10),
					new SqlParameter("@remark", SqlDbType.NVarChar,30)};
			parameters[0].Value = model.FDID;
			parameters[1].Value = model.customcode;
			parameters[2].Value = model.customname;
			parameters[3].Value = model.SJJZ;
			parameters[4].Value = model.QZZK;
			parameters[5].Value = model.QZYS;
			parameters[6].Value = model.YSJE;
			parameters[7].Value = model.YSWS;
			parameters[8].Value = model.begindate;
			parameters[9].Value = model.enddate;
			parameters[10].Value = model.createname;
			parameters[11].Value = model.createdate;
			parameters[12].Value = model.remark;

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
			strSql.Append("delete from ORDER_YSJZ ");
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
		public MyERP.Model.ORDER_YSJZ GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FDID,customcode,customname,SJJZ,QZZK,QZYS,YSJE,YSWS,begindate,enddate,createname,createdate,remark from ORDER_YSJZ ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.ORDER_YSJZ model=new MyERP.Model.ORDER_YSJZ();
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
		public MyERP.Model.ORDER_YSJZ DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_YSJZ model=new MyERP.Model.ORDER_YSJZ();
			if (row != null)
			{
				if(row["FDID"]!=null)
				{
					model.FDID=row["FDID"].ToString();
				}
				if(row["customcode"]!=null)
				{
					model.customcode=row["customcode"].ToString();
				}
				if(row["customname"]!=null)
				{
					model.customname=row["customname"].ToString();
				}
				if(row["SJJZ"]!=null && row["SJJZ"].ToString()!="")
				{
					model.SJJZ=decimal.Parse(row["SJJZ"].ToString());
				}
				if(row["QZZK"]!=null && row["QZZK"].ToString()!="")
				{
					model.QZZK=decimal.Parse(row["QZZK"].ToString());
				}
				if(row["QZYS"]!=null && row["QZYS"].ToString()!="")
				{
					model.QZYS=decimal.Parse(row["QZYS"].ToString());
				}
				if(row["YSJE"]!=null && row["YSJE"].ToString()!="")
				{
					model.YSJE=decimal.Parse(row["YSJE"].ToString());
				}
				if(row["YSWS"]!=null && row["YSWS"].ToString()!="")
				{
					model.YSWS=decimal.Parse(row["YSWS"].ToString());
				}
				if(row["begindate"]!=null)
				{
					model.begindate=row["begindate"].ToString();
				}
				if(row["enddate"]!=null)
				{
					model.enddate=row["enddate"].ToString();
				}
				if(row["createname"]!=null)
				{
					model.createname=row["createname"].ToString();
				}
				if(row["createdate"]!=null)
				{
					model.createdate=row["createdate"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
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
			strSql.Append("select FDID,customcode,customname,SJJZ,QZZK,QZYS,YSJE,YSWS,begindate,enddate,createname,createdate,remark ");
			strSql.Append(" FROM ORDER_YSJZ ");
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
			strSql.Append(" FDID,customcode,customname,SJJZ,QZZK,QZYS,YSJE,YSWS,begindate,enddate,createname,createdate,remark ");
			strSql.Append(" FROM ORDER_YSJZ ");
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
			strSql.Append("select count(1) FROM ORDER_YSJZ ");
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
			strSql.Append(")AS Row, T.*  from ORDER_YSJZ T ");
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
			parameters[0].Value = "ORDER_YSJZ";
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

