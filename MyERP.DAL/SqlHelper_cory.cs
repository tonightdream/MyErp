using MyERP.COMMON;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyERP.DAL
{
    public static class SqlHelper_cory
    {
        //将加密的连接字符串解密
        private readonly static string connStr = MyHelper_cory.DecodeBase64(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        
        //检测数据库是否连接成功
        public static bool IsConnect()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                return conn.State.Equals(ConnectionState.Open);
            }
        }

        //1.返回影响行数的方法
        public static int ExecuteNoneQuery(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pms != null) { cmd.Parameters.AddRange(pms); }
                    cmd.CommandType = cmdType;
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        //2.返回单个值的方法
        public static object ExecuteScalar(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        //3.返回多行多列的方法
        public static DataTable ExceuteDataTable(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr))
            {
                adapter.SelectCommand.CommandType = cmdType;
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                adapter.Fill(dt);
                return dt;
            }
        }

        //4.返回SqlDataReader
        public static SqlDataReader ExecuteReader(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            SqlConnection conn = new SqlConnection(connStr);
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = cmdType;
                if (pms != null)
                {
                    cmd.Parameters.AddRange(pms);
                }
                try
                {
                    conn.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection); //关闭DataReader时也关闭Connection
                }
                catch (Exception)
                {
                    conn.Close();
                    conn.Dispose();
                    throw;
                }
            }
        }




    }
}
