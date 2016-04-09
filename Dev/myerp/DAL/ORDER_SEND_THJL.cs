using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:ORDER_SEND_THJL
	/// </summary>
	public partial class ORDER_SEND_THJL
	{
		public ORDER_SEND_THJL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.ORDER_SEND_THJL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ORDER_SEND_THJL(");
			strSql.Append("DetailID,BillNo,Sequence,ItemInternalCode,ZXBJNO,SHDH,Quantity,THRQ,CREATE_NAME,CREATE_DATE,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@DetailID,@BillNo,@Sequence,@ItemInternalCode,@ZXBJNO,@SHDH,@Quantity,@THRQ,@CREATE_NAME,@CREATE_DATE,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@DetailID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@BillNo", SqlDbType.VarChar,50),
					new SqlParameter("@Sequence", SqlDbType.VarChar,50),
					new SqlParameter("@ItemInternalCode", SqlDbType.VarChar,50),
					new SqlParameter("@ZXBJNO", SqlDbType.VarChar,50),
					new SqlParameter("@SHDH", SqlDbType.VarChar,50),
					new SqlParameter("@Quantity", SqlDbType.Int,4),
					new SqlParameter("@THRQ", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.BillNo;
			parameters[2].Value = model.Sequence;
			parameters[3].Value = model.ItemInternalCode;
			parameters[4].Value = model.ZXBJNO;
			parameters[5].Value = model.SHDH;
			parameters[6].Value = model.Quantity;
			parameters[7].Value = model.THRQ;
			parameters[8].Value = model.CREATE_NAME;
			parameters[9].Value = model.CREATE_DATE;
			parameters[10].Value = model.REMARK;

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
		public bool Update(MyERP.Model.ORDER_SEND_THJL model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ORDER_SEND_THJL set ");
			strSql.Append("DetailID=@DetailID,");
			strSql.Append("BillNo=@BillNo,");
			strSql.Append("Sequence=@Sequence,");
			strSql.Append("ItemInternalCode=@ItemInternalCode,");
			strSql.Append("ZXBJNO=@ZXBJNO,");
			strSql.Append("SHDH=@SHDH,");
			strSql.Append("Quantity=@Quantity,");
			strSql.Append("THRQ=@THRQ,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@DetailID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@BillNo", SqlDbType.VarChar,50),
					new SqlParameter("@Sequence", SqlDbType.VarChar,50),
					new SqlParameter("@ItemInternalCode", SqlDbType.VarChar,50),
					new SqlParameter("@ZXBJNO", SqlDbType.VarChar,50),
					new SqlParameter("@SHDH", SqlDbType.VarChar,50),
					new SqlParameter("@Quantity", SqlDbType.Int,4),
					new SqlParameter("@THRQ", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = model.DetailID;
			parameters[1].Value = model.BillNo;
			parameters[2].Value = model.Sequence;
			parameters[3].Value = model.ItemInternalCode;
			parameters[4].Value = model.ZXBJNO;
			parameters[5].Value = model.SHDH;
			parameters[6].Value = model.Quantity;
			parameters[7].Value = model.THRQ;
			parameters[8].Value = model.CREATE_NAME;
			parameters[9].Value = model.CREATE_DATE;
			parameters[10].Value = model.REMARK;

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
			strSql.Append("delete from ORDER_SEND_THJL ");
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
		public MyERP.Model.ORDER_SEND_THJL GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DetailID,BillNo,Sequence,ItemInternalCode,ZXBJNO,SHDH,Quantity,THRQ,CREATE_NAME,CREATE_DATE,REMARK from ORDER_SEND_THJL ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.ORDER_SEND_THJL model=new MyERP.Model.ORDER_SEND_THJL();
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
		public MyERP.Model.ORDER_SEND_THJL DataRowToModel(DataRow row)
		{
			MyERP.Model.ORDER_SEND_THJL model=new MyERP.Model.ORDER_SEND_THJL();
			if (row != null)
			{
				if(row["DetailID"]!=null && row["DetailID"].ToString()!="")
				{
					model.DetailID= new Guid(row["DetailID"].ToString());
				}
				if(row["BillNo"]!=null)
				{
					model.BillNo=row["BillNo"].ToString();
				}
				if(row["Sequence"]!=null)
				{
					model.Sequence=row["Sequence"].ToString();
				}
				if(row["ItemInternalCode"]!=null)
				{
					model.ItemInternalCode=row["ItemInternalCode"].ToString();
				}
				if(row["ZXBJNO"]!=null)
				{
					model.ZXBJNO=row["ZXBJNO"].ToString();
				}
				if(row["SHDH"]!=null)
				{
					model.SHDH=row["SHDH"].ToString();
				}
				if(row["Quantity"]!=null && row["Quantity"].ToString()!="")
				{
					model.Quantity=int.Parse(row["Quantity"].ToString());
				}
				if(row["THRQ"]!=null)
				{
					model.THRQ=row["THRQ"].ToString();
				}
				if(row["CREATE_NAME"]!=null)
				{
					model.CREATE_NAME=row["CREATE_NAME"].ToString();
				}
				if(row["CREATE_DATE"]!=null && row["CREATE_DATE"].ToString()!="")
				{
					model.CREATE_DATE=DateTime.Parse(row["CREATE_DATE"].ToString());
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
			strSql.Append("select DetailID,BillNo,Sequence,ItemInternalCode,ZXBJNO,SHDH,Quantity,THRQ,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_SEND_THJL ");
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
			strSql.Append(" DetailID,BillNo,Sequence,ItemInternalCode,ZXBJNO,SHDH,Quantity,THRQ,CREATE_NAME,CREATE_DATE,REMARK ");
			strSql.Append(" FROM ORDER_SEND_THJL ");
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
			strSql.Append("select count(1) FROM ORDER_SEND_THJL ");
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
			strSql.Append(")AS Row, T.*  from ORDER_SEND_THJL T ");
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
			parameters[0].Value = "ORDER_SEND_THJL";
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

