using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace MyERP.DAL
{
	/// <summary>
	/// 数据访问类:PUB_SALE
	/// </summary>
	public partial class PUB_SALE
	{
		public PUB_SALE()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyERP.Model.PUB_SALE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PUB_SALE(");
			strSql.Append("CompanyCode,EmployeCode,EmployeeName,DepartmentCode,EmployeeType,IDCardNo,SociatyNo,SensusData,Sex,BirthDay,Degree,DegreeCard,Health,HealthDate,Spinsterhood,SpinsterhoodDate,Idleness,IdlenessDate,Title,ArrialDay,LeaveDay,Phone,Address,Zip,Email,AllowUsed,SociatyCode,SociatyDate,SociatyPay,IndiSWBX,IndiSYBX,SociatyComp,Remark,EmployeNo,WorkID,Situations,HospitalPay,HospitalDate,Contract,ContractDate,PayMounth,IsZB,IsBD,LastEdit)");
			strSql.Append(" values (");
			strSql.Append("@CompanyCode,@EmployeCode,@EmployeeName,@DepartmentCode,@EmployeeType,@IDCardNo,@SociatyNo,@SensusData,@Sex,@BirthDay,@Degree,@DegreeCard,@Health,@HealthDate,@Spinsterhood,@SpinsterhoodDate,@Idleness,@IdlenessDate,@Title,@ArrialDay,@LeaveDay,@Phone,@Address,@Zip,@Email,@AllowUsed,@SociatyCode,@SociatyDate,@SociatyPay,@IndiSWBX,@IndiSYBX,@SociatyComp,@Remark,@EmployeNo,@WorkID,@Situations,@HospitalPay,@HospitalDate,@Contract,@ContractDate,@PayMounth,@IsZB,@IsBD,@LastEdit)");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,10),
					new SqlParameter("@EmployeCode", SqlDbType.NVarChar,12),
					new SqlParameter("@EmployeeName", SqlDbType.NVarChar,20),
					new SqlParameter("@DepartmentCode", SqlDbType.NVarChar,12),
					new SqlParameter("@EmployeeType", SqlDbType.NVarChar,6),
					new SqlParameter("@IDCardNo", SqlDbType.NVarChar,20),
					new SqlParameter("@SociatyNo", SqlDbType.NVarChar,20),
					new SqlParameter("@SensusData", SqlDbType.NVarChar,1),
					new SqlParameter("@Sex", SqlDbType.NVarChar,6),
					new SqlParameter("@BirthDay", SqlDbType.SmallDateTime),
					new SqlParameter("@Degree", SqlDbType.NVarChar,6),
					new SqlParameter("@DegreeCard", SqlDbType.NVarChar,1),
					new SqlParameter("@Health", SqlDbType.NVarChar,1),
					new SqlParameter("@HealthDate", SqlDbType.SmallDateTime),
					new SqlParameter("@Spinsterhood", SqlDbType.NVarChar,1),
					new SqlParameter("@SpinsterhoodDate", SqlDbType.SmallDateTime),
					new SqlParameter("@Idleness", SqlDbType.NVarChar,1),
					new SqlParameter("@IdlenessDate", SqlDbType.SmallDateTime),
					new SqlParameter("@Title", SqlDbType.NVarChar,20),
					new SqlParameter("@ArrialDay", SqlDbType.SmallDateTime),
					new SqlParameter("@LeaveDay", SqlDbType.SmallDateTime),
					new SqlParameter("@Phone", SqlDbType.NVarChar,100),
					new SqlParameter("@Address", SqlDbType.NVarChar,60),
					new SqlParameter("@Zip", SqlDbType.NVarChar,6),
					new SqlParameter("@Email", SqlDbType.NVarChar,40),
					new SqlParameter("@AllowUsed", SqlDbType.NVarChar,1),
					new SqlParameter("@SociatyCode", SqlDbType.NVarChar,50),
					new SqlParameter("@SociatyDate", SqlDbType.SmallDateTime),
					new SqlParameter("@SociatyPay", SqlDbType.Decimal,9),
					new SqlParameter("@IndiSWBX", SqlDbType.Decimal,9),
					new SqlParameter("@IndiSYBX", SqlDbType.Decimal,9),
					new SqlParameter("@SociatyComp", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@EmployeNo", SqlDbType.NVarChar,30),
					new SqlParameter("@WorkID", SqlDbType.NVarChar,30),
					new SqlParameter("@Situations", SqlDbType.NVarChar,20),
					new SqlParameter("@HospitalPay", SqlDbType.NText),
					new SqlParameter("@HospitalDate", SqlDbType.SmallDateTime),
					new SqlParameter("@Contract", SqlDbType.NText),
					new SqlParameter("@ContractDate", SqlDbType.SmallDateTime),
					new SqlParameter("@PayMounth", SqlDbType.NVarChar,20),
					new SqlParameter("@IsZB", SqlDbType.NVarChar,1),
					new SqlParameter("@IsBD", SqlDbType.NVarChar,1),
					new SqlParameter("@LastEdit", SqlDbType.VarBinary,8)};
			parameters[0].Value = model.CompanyCode;
			parameters[1].Value = model.EmployeCode;
			parameters[2].Value = model.EmployeeName;
			parameters[3].Value = model.DepartmentCode;
			parameters[4].Value = model.EmployeeType;
			parameters[5].Value = model.IDCardNo;
			parameters[6].Value = model.SociatyNo;
			parameters[7].Value = model.SensusData;
			parameters[8].Value = model.Sex;
			parameters[9].Value = model.BirthDay;
			parameters[10].Value = model.Degree;
			parameters[11].Value = model.DegreeCard;
			parameters[12].Value = model.Health;
			parameters[13].Value = model.HealthDate;
			parameters[14].Value = model.Spinsterhood;
			parameters[15].Value = model.SpinsterhoodDate;
			parameters[16].Value = model.Idleness;
			parameters[17].Value = model.IdlenessDate;
			parameters[18].Value = model.Title;
			parameters[19].Value = model.ArrialDay;
			parameters[20].Value = model.LeaveDay;
			parameters[21].Value = model.Phone;
			parameters[22].Value = model.Address;
			parameters[23].Value = model.Zip;
			parameters[24].Value = model.Email;
			parameters[25].Value = model.AllowUsed;
			parameters[26].Value = model.SociatyCode;
			parameters[27].Value = model.SociatyDate;
			parameters[28].Value = model.SociatyPay;
			parameters[29].Value = model.IndiSWBX;
			parameters[30].Value = model.IndiSYBX;
			parameters[31].Value = model.SociatyComp;
			parameters[32].Value = model.Remark;
			parameters[33].Value = model.EmployeNo;
			parameters[34].Value = model.WorkID;
			parameters[35].Value = model.Situations;
			parameters[36].Value = model.HospitalPay;
			parameters[37].Value = model.HospitalDate;
			parameters[38].Value = model.Contract;
			parameters[39].Value = model.ContractDate;
			parameters[40].Value = model.PayMounth;
			parameters[41].Value = model.IsZB;
			parameters[42].Value = model.IsBD;
			parameters[43].Value = model.LastEdit;

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
		public bool Update(MyERP.Model.PUB_SALE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PUB_SALE set ");
			strSql.Append("CompanyCode=@CompanyCode,");
			strSql.Append("EmployeCode=@EmployeCode,");
			strSql.Append("EmployeeName=@EmployeeName,");
			strSql.Append("DepartmentCode=@DepartmentCode,");
			strSql.Append("EmployeeType=@EmployeeType,");
			strSql.Append("IDCardNo=@IDCardNo,");
			strSql.Append("SociatyNo=@SociatyNo,");
			strSql.Append("SensusData=@SensusData,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("BirthDay=@BirthDay,");
			strSql.Append("Degree=@Degree,");
			strSql.Append("DegreeCard=@DegreeCard,");
			strSql.Append("Health=@Health,");
			strSql.Append("HealthDate=@HealthDate,");
			strSql.Append("Spinsterhood=@Spinsterhood,");
			strSql.Append("SpinsterhoodDate=@SpinsterhoodDate,");
			strSql.Append("Idleness=@Idleness,");
			strSql.Append("IdlenessDate=@IdlenessDate,");
			strSql.Append("Title=@Title,");
			strSql.Append("ArrialDay=@ArrialDay,");
			strSql.Append("LeaveDay=@LeaveDay,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Address=@Address,");
			strSql.Append("Zip=@Zip,");
			strSql.Append("Email=@Email,");
			strSql.Append("AllowUsed=@AllowUsed,");
			strSql.Append("SociatyCode=@SociatyCode,");
			strSql.Append("SociatyDate=@SociatyDate,");
			strSql.Append("SociatyPay=@SociatyPay,");
			strSql.Append("IndiSWBX=@IndiSWBX,");
			strSql.Append("IndiSYBX=@IndiSYBX,");
			strSql.Append("SociatyComp=@SociatyComp,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("EmployeNo=@EmployeNo,");
			strSql.Append("WorkID=@WorkID,");
			strSql.Append("Situations=@Situations,");
			strSql.Append("HospitalPay=@HospitalPay,");
			strSql.Append("HospitalDate=@HospitalDate,");
			strSql.Append("Contract=@Contract,");
			strSql.Append("ContractDate=@ContractDate,");
			strSql.Append("PayMounth=@PayMounth,");
			strSql.Append("IsZB=@IsZB,");
			strSql.Append("IsBD=@IsBD,");
			strSql.Append("LastEdit=@LastEdit");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyCode", SqlDbType.NVarChar,10),
					new SqlParameter("@EmployeCode", SqlDbType.NVarChar,12),
					new SqlParameter("@EmployeeName", SqlDbType.NVarChar,20),
					new SqlParameter("@DepartmentCode", SqlDbType.NVarChar,12),
					new SqlParameter("@EmployeeType", SqlDbType.NVarChar,6),
					new SqlParameter("@IDCardNo", SqlDbType.NVarChar,20),
					new SqlParameter("@SociatyNo", SqlDbType.NVarChar,20),
					new SqlParameter("@SensusData", SqlDbType.NVarChar,1),
					new SqlParameter("@Sex", SqlDbType.NVarChar,6),
					new SqlParameter("@BirthDay", SqlDbType.SmallDateTime),
					new SqlParameter("@Degree", SqlDbType.NVarChar,6),
					new SqlParameter("@DegreeCard", SqlDbType.NVarChar,1),
					new SqlParameter("@Health", SqlDbType.NVarChar,1),
					new SqlParameter("@HealthDate", SqlDbType.SmallDateTime),
					new SqlParameter("@Spinsterhood", SqlDbType.NVarChar,1),
					new SqlParameter("@SpinsterhoodDate", SqlDbType.SmallDateTime),
					new SqlParameter("@Idleness", SqlDbType.NVarChar,1),
					new SqlParameter("@IdlenessDate", SqlDbType.SmallDateTime),
					new SqlParameter("@Title", SqlDbType.NVarChar,20),
					new SqlParameter("@ArrialDay", SqlDbType.SmallDateTime),
					new SqlParameter("@LeaveDay", SqlDbType.SmallDateTime),
					new SqlParameter("@Phone", SqlDbType.NVarChar,100),
					new SqlParameter("@Address", SqlDbType.NVarChar,60),
					new SqlParameter("@Zip", SqlDbType.NVarChar,6),
					new SqlParameter("@Email", SqlDbType.NVarChar,40),
					new SqlParameter("@AllowUsed", SqlDbType.NVarChar,1),
					new SqlParameter("@SociatyCode", SqlDbType.NVarChar,50),
					new SqlParameter("@SociatyDate", SqlDbType.SmallDateTime),
					new SqlParameter("@SociatyPay", SqlDbType.Decimal,9),
					new SqlParameter("@IndiSWBX", SqlDbType.Decimal,9),
					new SqlParameter("@IndiSYBX", SqlDbType.Decimal,9),
					new SqlParameter("@SociatyComp", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@EmployeNo", SqlDbType.NVarChar,30),
					new SqlParameter("@WorkID", SqlDbType.NVarChar,30),
					new SqlParameter("@Situations", SqlDbType.NVarChar,20),
					new SqlParameter("@HospitalPay", SqlDbType.NText),
					new SqlParameter("@HospitalDate", SqlDbType.SmallDateTime),
					new SqlParameter("@Contract", SqlDbType.NText),
					new SqlParameter("@ContractDate", SqlDbType.SmallDateTime),
					new SqlParameter("@PayMounth", SqlDbType.NVarChar,20),
					new SqlParameter("@IsZB", SqlDbType.NVarChar,1),
					new SqlParameter("@IsBD", SqlDbType.NVarChar,1),
					new SqlParameter("@LastEdit", SqlDbType.VarBinary,8)};
			parameters[0].Value = model.CompanyCode;
			parameters[1].Value = model.EmployeCode;
			parameters[2].Value = model.EmployeeName;
			parameters[3].Value = model.DepartmentCode;
			parameters[4].Value = model.EmployeeType;
			parameters[5].Value = model.IDCardNo;
			parameters[6].Value = model.SociatyNo;
			parameters[7].Value = model.SensusData;
			parameters[8].Value = model.Sex;
			parameters[9].Value = model.BirthDay;
			parameters[10].Value = model.Degree;
			parameters[11].Value = model.DegreeCard;
			parameters[12].Value = model.Health;
			parameters[13].Value = model.HealthDate;
			parameters[14].Value = model.Spinsterhood;
			parameters[15].Value = model.SpinsterhoodDate;
			parameters[16].Value = model.Idleness;
			parameters[17].Value = model.IdlenessDate;
			parameters[18].Value = model.Title;
			parameters[19].Value = model.ArrialDay;
			parameters[20].Value = model.LeaveDay;
			parameters[21].Value = model.Phone;
			parameters[22].Value = model.Address;
			parameters[23].Value = model.Zip;
			parameters[24].Value = model.Email;
			parameters[25].Value = model.AllowUsed;
			parameters[26].Value = model.SociatyCode;
			parameters[27].Value = model.SociatyDate;
			parameters[28].Value = model.SociatyPay;
			parameters[29].Value = model.IndiSWBX;
			parameters[30].Value = model.IndiSYBX;
			parameters[31].Value = model.SociatyComp;
			parameters[32].Value = model.Remark;
			parameters[33].Value = model.EmployeNo;
			parameters[34].Value = model.WorkID;
			parameters[35].Value = model.Situations;
			parameters[36].Value = model.HospitalPay;
			parameters[37].Value = model.HospitalDate;
			parameters[38].Value = model.Contract;
			parameters[39].Value = model.ContractDate;
			parameters[40].Value = model.PayMounth;
			parameters[41].Value = model.IsZB;
			parameters[42].Value = model.IsBD;
			parameters[43].Value = model.LastEdit;

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
			strSql.Append("delete from PUB_SALE ");
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
		public MyERP.Model.PUB_SALE GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CompanyCode,EmployeCode,EmployeeName,DepartmentCode,EmployeeType,IDCardNo,SociatyNo,SensusData,Sex,BirthDay,Degree,DegreeCard,Health,HealthDate,Spinsterhood,SpinsterhoodDate,Idleness,IdlenessDate,Title,ArrialDay,LeaveDay,Phone,Address,Zip,Email,AllowUsed,SociatyCode,SociatyDate,SociatyPay,IndiSWBX,IndiSYBX,SociatyComp,Remark,EmployeNo,WorkID,Situations,HospitalPay,HospitalDate,Contract,ContractDate,PayMounth,IsZB,IsBD,LastEdit from PUB_SALE ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			MyERP.Model.PUB_SALE model=new MyERP.Model.PUB_SALE();
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
		public MyERP.Model.PUB_SALE DataRowToModel(DataRow row)
		{
			MyERP.Model.PUB_SALE model=new MyERP.Model.PUB_SALE();
			if (row != null)
			{
				if(row["CompanyCode"]!=null)
				{
					model.CompanyCode=row["CompanyCode"].ToString();
				}
				if(row["EmployeCode"]!=null)
				{
					model.EmployeCode=row["EmployeCode"].ToString();
				}
				if(row["EmployeeName"]!=null)
				{
					model.EmployeeName=row["EmployeeName"].ToString();
				}
				if(row["DepartmentCode"]!=null)
				{
					model.DepartmentCode=row["DepartmentCode"].ToString();
				}
				if(row["EmployeeType"]!=null)
				{
					model.EmployeeType=row["EmployeeType"].ToString();
				}
				if(row["IDCardNo"]!=null)
				{
					model.IDCardNo=row["IDCardNo"].ToString();
				}
				if(row["SociatyNo"]!=null)
				{
					model.SociatyNo=row["SociatyNo"].ToString();
				}
				if(row["SensusData"]!=null)
				{
					model.SensusData=row["SensusData"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["BirthDay"]!=null && row["BirthDay"].ToString()!="")
				{
					model.BirthDay=DateTime.Parse(row["BirthDay"].ToString());
				}
				if(row["Degree"]!=null)
				{
					model.Degree=row["Degree"].ToString();
				}
				if(row["DegreeCard"]!=null)
				{
					model.DegreeCard=row["DegreeCard"].ToString();
				}
				if(row["Health"]!=null)
				{
					model.Health=row["Health"].ToString();
				}
				if(row["HealthDate"]!=null && row["HealthDate"].ToString()!="")
				{
					model.HealthDate=DateTime.Parse(row["HealthDate"].ToString());
				}
				if(row["Spinsterhood"]!=null)
				{
					model.Spinsterhood=row["Spinsterhood"].ToString();
				}
				if(row["SpinsterhoodDate"]!=null && row["SpinsterhoodDate"].ToString()!="")
				{
					model.SpinsterhoodDate=DateTime.Parse(row["SpinsterhoodDate"].ToString());
				}
				if(row["Idleness"]!=null)
				{
					model.Idleness=row["Idleness"].ToString();
				}
				if(row["IdlenessDate"]!=null && row["IdlenessDate"].ToString()!="")
				{
					model.IdlenessDate=DateTime.Parse(row["IdlenessDate"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["ArrialDay"]!=null && row["ArrialDay"].ToString()!="")
				{
					model.ArrialDay=DateTime.Parse(row["ArrialDay"].ToString());
				}
				if(row["LeaveDay"]!=null && row["LeaveDay"].ToString()!="")
				{
					model.LeaveDay=DateTime.Parse(row["LeaveDay"].ToString());
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Zip"]!=null)
				{
					model.Zip=row["Zip"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["AllowUsed"]!=null)
				{
					model.AllowUsed=row["AllowUsed"].ToString();
				}
				if(row["SociatyCode"]!=null)
				{
					model.SociatyCode=row["SociatyCode"].ToString();
				}
				if(row["SociatyDate"]!=null && row["SociatyDate"].ToString()!="")
				{
					model.SociatyDate=DateTime.Parse(row["SociatyDate"].ToString());
				}
				if(row["SociatyPay"]!=null && row["SociatyPay"].ToString()!="")
				{
					model.SociatyPay=decimal.Parse(row["SociatyPay"].ToString());
				}
				if(row["IndiSWBX"]!=null && row["IndiSWBX"].ToString()!="")
				{
					model.IndiSWBX=decimal.Parse(row["IndiSWBX"].ToString());
				}
				if(row["IndiSYBX"]!=null && row["IndiSYBX"].ToString()!="")
				{
					model.IndiSYBX=decimal.Parse(row["IndiSYBX"].ToString());
				}
				if(row["SociatyComp"]!=null)
				{
					model.SociatyComp=row["SociatyComp"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["EmployeNo"]!=null)
				{
					model.EmployeNo=row["EmployeNo"].ToString();
				}
				if(row["WorkID"]!=null)
				{
					model.WorkID=row["WorkID"].ToString();
				}
				if(row["Situations"]!=null)
				{
					model.Situations=row["Situations"].ToString();
				}
				if(row["HospitalPay"]!=null)
				{
					model.HospitalPay=row["HospitalPay"].ToString();
				}
				if(row["HospitalDate"]!=null && row["HospitalDate"].ToString()!="")
				{
					model.HospitalDate=DateTime.Parse(row["HospitalDate"].ToString());
				}
				if(row["Contract"]!=null)
				{
					model.Contract=row["Contract"].ToString();
				}
				if(row["ContractDate"]!=null && row["ContractDate"].ToString()!="")
				{
					model.ContractDate=DateTime.Parse(row["ContractDate"].ToString());
				}
				if(row["PayMounth"]!=null)
				{
					model.PayMounth=row["PayMounth"].ToString();
				}
				if(row["IsZB"]!=null)
				{
					model.IsZB=row["IsZB"].ToString();
				}
				if(row["IsBD"]!=null)
				{
					model.IsBD=row["IsBD"].ToString();
				}
				if(row["LastEdit"]!=null && row["LastEdit"].ToString()!="")
				{
					model.LastEdit=(byte[])row["LastEdit"];
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
			strSql.Append("select CompanyCode,EmployeCode,EmployeeName,DepartmentCode,EmployeeType,IDCardNo,SociatyNo,SensusData,Sex,BirthDay,Degree,DegreeCard,Health,HealthDate,Spinsterhood,SpinsterhoodDate,Idleness,IdlenessDate,Title,ArrialDay,LeaveDay,Phone,Address,Zip,Email,AllowUsed,SociatyCode,SociatyDate,SociatyPay,IndiSWBX,IndiSYBX,SociatyComp,Remark,EmployeNo,WorkID,Situations,HospitalPay,HospitalDate,Contract,ContractDate,PayMounth,IsZB,IsBD,LastEdit ");
			strSql.Append(" FROM PUB_SALE ");
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
			strSql.Append(" CompanyCode,EmployeCode,EmployeeName,DepartmentCode,EmployeeType,IDCardNo,SociatyNo,SensusData,Sex,BirthDay,Degree,DegreeCard,Health,HealthDate,Spinsterhood,SpinsterhoodDate,Idleness,IdlenessDate,Title,ArrialDay,LeaveDay,Phone,Address,Zip,Email,AllowUsed,SociatyCode,SociatyDate,SociatyPay,IndiSWBX,IndiSYBX,SociatyComp,Remark,EmployeNo,WorkID,Situations,HospitalPay,HospitalDate,Contract,ContractDate,PayMounth,IsZB,IsBD,LastEdit ");
			strSql.Append(" FROM PUB_SALE ");
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
			strSql.Append("select count(1) FROM PUB_SALE ");
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
				strSql.Append("order by T.PAYMENT_CODE desc");
			}
			strSql.Append(")AS Row, T.*  from PUB_SALE T ");
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
			parameters[0].Value = "PUB_SALE";
			parameters[1].Value = "PAYMENT_CODE";
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

