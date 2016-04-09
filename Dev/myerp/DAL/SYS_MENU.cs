using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:SYS_MENU
	/// </summary>
	public partial class SYS_MENU
	{
		public SYS_MENU()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string MENU_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SYS_MENU");
			strSql.Append(" where MENU_CODE=@MENU_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@MENU_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = MENU_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.SYS_MENU model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SYS_MENU(");
			strSql.Append("MENU_CODE,MENU_NAME,MenuID,IMAGE_INDEX,MENU_UNIT,PARENT_MENU_CODE,SysSelect)");
			strSql.Append(" values (");
			strSql.Append("@MENU_CODE,@MENU_NAME,@MenuID,@IMAGE_INDEX,@MENU_UNIT,@PARENT_MENU_CODE,@SysSelect)");
			SqlParameter[] parameters = {
					new SqlParameter("@MENU_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@MENU_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@MenuID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@IMAGE_INDEX", SqlDbType.Int,4),
					new SqlParameter("@MENU_UNIT", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_MENU_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@SysSelect", SqlDbType.Bit,1)};
			parameters[0].Value = model.MENU_CODE;
			parameters[1].Value = model.MENU_NAME;
			parameters[2].Value = Guid.NewGuid();
			parameters[3].Value = model.IMAGE_INDEX;
			parameters[4].Value = model.MENU_UNIT;
			parameters[5].Value = model.PARENT_MENU_CODE;
			parameters[6].Value = model.SysSelect;

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
		public bool Update(MyERP.Model.SYS_MENU model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SYS_MENU set ");
			strSql.Append("MENU_NAME=@MENU_NAME,");
			strSql.Append("MenuID=@MenuID,");
			strSql.Append("IMAGE_INDEX=@IMAGE_INDEX,");
			strSql.Append("MENU_UNIT=@MENU_UNIT,");
			strSql.Append("PARENT_MENU_CODE=@PARENT_MENU_CODE,");
			strSql.Append("SysSelect=@SysSelect");
			strSql.Append(" where MENU_CODE=@MENU_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@MENU_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@MenuID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@IMAGE_INDEX", SqlDbType.Int,4),
					new SqlParameter("@MENU_UNIT", SqlDbType.NVarChar,50),
					new SqlParameter("@PARENT_MENU_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@SysSelect", SqlDbType.Bit,1),
					new SqlParameter("@MENU_CODE", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.MENU_NAME;
			parameters[1].Value = model.MenuID;
			parameters[2].Value = model.IMAGE_INDEX;
			parameters[3].Value = model.MENU_UNIT;
			parameters[4].Value = model.PARENT_MENU_CODE;
			parameters[5].Value = model.SysSelect;
			parameters[6].Value = model.MENU_CODE;

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
		public bool Delete(string MENU_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SYS_MENU ");
			strSql.Append(" where MENU_CODE=@MENU_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@MENU_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = MENU_CODE;

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
		public bool DeleteList(string MENU_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SYS_MENU ");
			strSql.Append(" where MENU_CODE in ("+MENU_CODElist + ")  ");
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
		public MyERP.Model.SYS_MENU GetModel(string MENU_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MENU_CODE,MENU_NAME,MenuID,IMAGE_INDEX,MENU_UNIT,PARENT_MENU_CODE,SysSelect from SYS_MENU ");
			strSql.Append(" where MENU_CODE=@MENU_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@MENU_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = MENU_CODE;

			MyERP.Model.SYS_MENU model=new MyERP.Model.SYS_MENU();
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
		public MyERP.Model.SYS_MENU DataRowToModel(DataRow row)
		{
			MyERP.Model.SYS_MENU model=new MyERP.Model.SYS_MENU();
			if (row != null)
			{
				if(row["MENU_CODE"]!=null)
				{
					model.MENU_CODE=row["MENU_CODE"].ToString();
				}
				if(row["MENU_NAME"]!=null)
				{
					model.MENU_NAME=row["MENU_NAME"].ToString();
				}
				if(row["MenuID"]!=null && row["MenuID"].ToString()!="")
				{
					model.MenuID= new Guid(row["MenuID"].ToString());
				}
				if(row["IMAGE_INDEX"]!=null && row["IMAGE_INDEX"].ToString()!="")
				{
					model.IMAGE_INDEX=int.Parse(row["IMAGE_INDEX"].ToString());
				}
				if(row["MENU_UNIT"]!=null)
				{
					model.MENU_UNIT=row["MENU_UNIT"].ToString();
				}
				if(row["PARENT_MENU_CODE"]!=null)
				{
					model.PARENT_MENU_CODE=row["PARENT_MENU_CODE"].ToString();
				}
				if(row["SysSelect"]!=null && row["SysSelect"].ToString()!="")
				{
					if((row["SysSelect"].ToString()=="1")||(row["SysSelect"].ToString().ToLower()=="true"))
					{
						model.SysSelect=true;
					}
					else
					{
						model.SysSelect=false;
					}
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
			strSql.Append("select MENU_CODE,MENU_NAME,MenuID,IMAGE_INDEX,MENU_UNIT,PARENT_MENU_CODE,SysSelect ");
			strSql.Append(" FROM SYS_MENU ");
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
			strSql.Append(" MENU_CODE,MENU_NAME,MenuID,IMAGE_INDEX,MENU_UNIT,PARENT_MENU_CODE,SysSelect ");
			strSql.Append(" FROM SYS_MENU ");
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
			strSql.Append("select count(1) FROM SYS_MENU ");
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
				strSql.Append("order by T.MENU_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from SYS_MENU T ");
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
			parameters[0].Value = "SYS_MENU";
			parameters[1].Value = "MENU_CODE";
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

