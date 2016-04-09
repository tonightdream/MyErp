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
   public class SYS_MENU_DAL
    {
       public DataTable LoadNavMenu(string pid)
       {
           string sql = "select Menu_code,Menu_name,menu_unit,parent_menu_code from sys_menu where parent_menu_code=@pid";
           return SqlHelper_cory.ExceuteDataTable(sql,CommandType.Text, new SqlParameter("@pid", pid));
       }

       public SYS_MENU GetMenuByCode(string code)
       {
           string sql = "select *from sys_menu where Menu_code=@code and Menu_unit is not null";
           SqlDataReader reader = SqlHelper_cory.ExecuteReader(sql, CommandType.Text, new SqlParameter("@code", code));
           SYS_MENU model = new SYS_MENU();
           if (reader.HasRows)
           {
               if (reader.Read())
               {
                   model.MENU_CODE = reader.GetString(reader.GetOrdinal("MENU_CODE"));
                   model.MENU_NAME = reader.GetString(reader.GetOrdinal("MENU_NAME"));
                   model.MENU_UNIT = reader.GetString(reader.GetOrdinal("MENU_UNIT"));
                   model.PARENT_MENU_CODE = reader.GetString(reader.GetOrdinal("PARENT_MENU_CODE"));
               }
           }
           return model;
       }
    }
}
