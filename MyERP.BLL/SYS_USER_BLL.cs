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
    public  class SYS_USER_BLL
    {
        SYS_USER_DAL dal = new SYS_USER_DAL();
        /// <summary>
        /// 判断是否登陆成功
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public  bool LoginCheck(string uid, string pwd)
        {
           
            if (dal.LoginCheck(uid, pwd) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public SYS_USER CheckUid(string uid)
        {
            return dal.CheckUid(uid);
        }

        public DataTable ListAllUsers()
        {
            return dal.ListAllUsers();
        }
    }
}
