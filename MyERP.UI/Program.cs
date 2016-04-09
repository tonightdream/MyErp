using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyERP.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frm = new FrmLogin();  //创建登陆窗体对象
            if (frm.ShowDialog() == DialogResult.OK)//显示登陆窗体如登陆窗体返回ok,则打开主窗体
            {
                Application.Run(new FrmMain());
            }

        }
    }
}
