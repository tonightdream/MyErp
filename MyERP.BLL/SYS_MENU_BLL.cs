using MyERP.DAL;
using MyERP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyERP.BLL
{
   public class SYS_MENU_BLL
    {
       SYS_MENU_DAL dal = new SYS_MENU_DAL();
       public DataTable LoadNavMenu(string pid)
       {
           return dal.LoadNavMenu(pid);
       }

       public SYS_MENU GetMenuByCode(string code)
       {
           return dal.GetMenuByCode(code);
       }
    }
}
