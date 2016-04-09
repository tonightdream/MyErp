using MyERP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyERP.DAL
{
    public class SYS_USER_DAL
    {
        public int LoginCheck(string uid, string pwd)
        {
            string sql = "select COUNT(*) from SYS_USER where USER_CODE=@uid and PASSWORD=@pwd";
            SqlParameter[] pms = new SqlParameter[] { new SqlParameter("@uid", uid), new SqlParameter("@pwd", pwd) };
            return (int)SqlHelper_cory.ExecuteScalar(sql, CommandType.Text, pms);

        }
        /// <summary>
        /// 根据ID返回实体
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public SYS_USER CheckUid(string uid)
        {
            string sql = "select * from SYS_USER where USER_CODE=@uid";
            using (SqlDataReader reader = SqlHelper_cory.ExecuteReader(sql, CommandType.Text, new SqlParameter("@uid", uid)))
            {
                SYS_USER model = new SYS_USER();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        model.USER_CODE = reader.GetString(reader.GetOrdinal("USER_CODE"));
                        model.PASSWORD = reader.GetString(reader.GetOrdinal("PASSWORD"));
                        model.USER_NAME = reader.GetString(reader.GetOrdinal("USER_NAME"));
                        model.STOCK_CODE = reader.GetString(reader.GetOrdinal("STOCK_CODE"));
                        model.STOCK_NAME = reader.GetString(reader.GetOrdinal("STOCK_NAME"));
                        model.PPRICE_SHOW = reader.GetBoolean(reader.GetOrdinal("PPRICE_SHOW"));
                        model.DEPARTMENT_CODE = reader.GetString(reader.GetOrdinal("DEPARTMENT_CODE"));
                        model.DEPARTMENT_NAME = reader.GetString(reader.GetOrdinal("DEPARTMENT_NAME"));
                    }
                }
                return model;
            }
        }

        /// <summary>
        /// 显示所有用列表
        /// </summary>
        /// <returns></returns>
        public DataTable ListAllUsers()
        {
            string sql="select *from SYS_USer";
            return SqlHelper_cory.ExceuteDataTable(sql, CommandType.Text);
        }

    }
}
