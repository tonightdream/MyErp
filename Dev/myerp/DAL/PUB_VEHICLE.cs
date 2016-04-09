using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_VEHICLE
	/// </summary>
	public partial class PUB_VEHICLE
	{
		public PUB_VEHICLE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Vehicle_CODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PUB_VEHICLE");
			strSql.Append(" where Vehicle_CODE=@Vehicle_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@Vehicle_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Vehicle_CODE;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_VEHICLE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_VEHICLE(");
			strSql.Append("VehicleID,Vehicle_CODE,Vehicle_NAME,MobilePhone,standard_area,Real_area,weigth,Withcar,CREATE_DATE,CREATE_NAME,UPDATE_DATE,UPDATE_NAME,REMARK)");
			strSql.Append(" values (");
			strSql.Append("@VehicleID,@Vehicle_CODE,@Vehicle_NAME,@MobilePhone,@standard_area,@Real_area,@weigth,@Withcar,@CREATE_DATE,@CREATE_NAME,@UPDATE_DATE,@UPDATE_NAME,@REMARK)");
			SqlParameter[] parameters = {
					new SqlParameter("@VehicleID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Vehicle_CODE", SqlDbType.NVarChar,50),
					new SqlParameter("@Vehicle_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@MobilePhone", SqlDbType.NVarChar,50),
					new SqlParameter("@standard_area", SqlDbType.Float,8),
					new SqlParameter("@Real_area", SqlDbType.Float,8),
					new SqlParameter("@weigth", SqlDbType.Float,8),
					new SqlParameter("@Withcar", SqlDbType.NVarChar,30),
					new SqlParameter("@CREATE_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,10),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NChar,10),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50)};
			parameters[0].Value = Guid.NewGuid();
			parameters[1].Value = model.Vehicle_CODE;
			parameters[2].Value = model.Vehicle_NAME;
			parameters[3].Value = model.MobilePhone;
			parameters[4].Value = model.standard_area;
			parameters[5].Value = model.Real_area;
			parameters[6].Value = model.weigth;
			parameters[7].Value = model.Withcar;
			parameters[8].Value = model.CREATE_DATE;
			parameters[9].Value = model.CREATE_NAME;
			parameters[10].Value = model.UPDATE_DATE;
			parameters[11].Value = model.UPDATE_NAME;
			parameters[12].Value = model.REMARK;

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
		public bool Update(MyERP.Model.PUB_VEHICLE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_VEHICLE set ");
			strSql.Append("VehicleID=@VehicleID,");
			strSql.Append("Vehicle_NAME=@Vehicle_NAME,");
			strSql.Append("MobilePhone=@MobilePhone,");
			strSql.Append("standard_area=@standard_area,");
			strSql.Append("Real_area=@Real_area,");
			strSql.Append("weigth=@weigth,");
			strSql.Append("Withcar=@Withcar,");
			strSql.Append("CREATE_DATE=@CREATE_DATE,");
			strSql.Append("CREATE_NAME=@CREATE_NAME,");
			strSql.Append("UPDATE_DATE=@UPDATE_DATE,");
			strSql.Append("UPDATE_NAME=@UPDATE_NAME,");
			strSql.Append("REMARK=@REMARK");
			strSql.Append(" where Vehicle_CODE=@Vehicle_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@VehicleID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@Vehicle_NAME", SqlDbType.NVarChar,50),
					new SqlParameter("@MobilePhone", SqlDbType.NVarChar,50),
					new SqlParameter("@standard_area", SqlDbType.Float,8),
					new SqlParameter("@Real_area", SqlDbType.Float,8),
					new SqlParameter("@weigth", SqlDbType.Float,8),
					new SqlParameter("@Withcar", SqlDbType.NVarChar,30),
					new SqlParameter("@CREATE_DATE", SqlDbType.VarChar,50),
					new SqlParameter("@CREATE_NAME", SqlDbType.NVarChar,10),
					new SqlParameter("@UPDATE_DATE", SqlDbType.DateTime),
					new SqlParameter("@UPDATE_NAME", SqlDbType.NChar,10),
					new SqlParameter("@REMARK", SqlDbType.VarChar,50),
					new SqlParameter("@Vehicle_CODE", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.VehicleID;
			parameters[1].Value = model.Vehicle_NAME;
			parameters[2].Value = model.MobilePhone;
			parameters[3].Value = model.standard_area;
			parameters[4].Value = model.Real_area;
			parameters[5].Value = model.weigth;
			parameters[6].Value = model.Withcar;
			parameters[7].Value = model.CREATE_DATE;
			parameters[8].Value = model.CREATE_NAME;
			parameters[9].Value = model.UPDATE_DATE;
			parameters[10].Value = model.UPDATE_NAME;
			parameters[11].Value = model.REMARK;
			parameters[12].Value = model.Vehicle_CODE;

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
		public bool Delete(string Vehicle_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_VEHICLE ");
			strSql.Append(" where Vehicle_CODE=@Vehicle_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@Vehicle_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Vehicle_CODE;

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
		public bool DeleteList(string Vehicle_CODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PUB_VEHICLE ");
			strSql.Append(" where Vehicle_CODE in ("+Vehicle_CODElist + ")  ");
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
		public MyERP.Model.PUB_VEHICLE GetModel(string Vehicle_CODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 VehicleID,Vehicle_CODE,Vehicle_NAME,MobilePhone,standard_area,Real_area,weigth,Withcar,CREATE_DATE,CREATE_NAME,UPDATE_DATE,UPDATE_NAME,REMARK from PUB_VEHICLE ");
			strSql.Append(" where Vehicle_CODE=@Vehicle_CODE ");
			SqlParameter[] parameters = {
					new SqlParameter("@Vehicle_CODE", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Vehicle_CODE;

			MyERP.Model.PUB_VEHICLE model=new MyERP.Model.PUB_VEHICLE();
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
		public MyERP.Model.PUB_VEHICLE DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_VEHICLE model=new MyERP.Model.PUB_VEHICLE();
			if (row != null)
			{
				if(row["VehicleID"]!=null && row["VehicleID"].ToString()!="")
				{
					model.VehicleID= new Guid(row["VehicleID"].ToString());
				}
				if(row["Vehicle_CODE"]!=null)
				{
					model.Vehicle_CODE=row["Vehicle_CODE"].ToString();
				}
				if(row["Vehicle_NAME"]!=null)
				{
					model.Vehicle_NAME=row["Vehicle_NAME"].ToString();
				}
				if(row["MobilePhone"]!=null)
				{
					model.MobilePhone=row["MobilePhone"].ToString();
				}
				if(row["standard_area"]!=null && row["standard_area"].ToString()!="")
				{
					model.standard_area=decimal.Parse(row["standard_area"].ToString());
				}
				if(row["Real_area"]!=null && row["Real_area"].ToString()!="")
				{
					model.Real_area=decimal.Parse(row["Real_area"].ToString());
				}
				if(row["weigth"]!=null && row["weigth"].ToString()!="")
				{
					model.weigth=decimal.Parse(row["weigth"].ToString());
				}
				if(row["Withcar"]!=null)
				{
					model.Withcar=row["Withcar"].ToString();
				}
				if(row["CREATE_DATE"]!=null)
				{
					model.CREATE_DATE=row["CREATE_DATE"].ToString();
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
			strSql.Append("select VehicleID,Vehicle_CODE,Vehicle_NAME,MobilePhone,standard_area,Real_area,weigth,Withcar,CREATE_DATE,CREATE_NAME,UPDATE_DATE,UPDATE_NAME,REMARK ");
			strSql.Append(" FROM PUB_VEHICLE ");
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
			strSql.Append(" VehicleID,Vehicle_CODE,Vehicle_NAME,MobilePhone,standard_area,Real_area,weigth,Withcar,CREATE_DATE,CREATE_NAME,UPDATE_DATE,UPDATE_NAME,REMARK ");
			strSql.Append(" FROM PUB_VEHICLE ");
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
			strSql.Append("select count(1) FROM PUB_VEHICLE ");
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
			strSql.Append(")AS Row, T.*  from PUB_VEHICLE T ");
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
			parameters[0].Value = "PUB_VEHICLE";
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

