using MyERP.BLL;
using MyERP.Model;
using MyERP.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyERP.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 登陆验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SYS_USER_BLL bll = new SYS_USER_BLL();
            if (bll.LoginCheck(cbUid.Text, mtxtbox.Text))
            {
                this.DialogResult = DialogResult.OK;//设置登陆窗体返回值为ok并关闭本窗体

                SYS_USER USER = bll.CheckUid(cbUid.Text);
                if (USER != null)//如用户登陆成功存入全局变量
                {

                    GlobalHelper.CurrenLoginUser = USER;
                    //用户登陆成功将用户名保存入配置文件
                    SaveCofing(USER.USER_CODE);

                }
            }
            else
            {
                MessageBox.Show("用户名或密码不对!");
            }

        }

        /// <summary>
        /// 将登陆成功的用户名保存为配置文件
        /// </summary>
        /// <param name="uCode"></param>
        private void SaveCofing(string uCode)
        {
            //是否存在配置文件
            if (File.Exists("config.xml"))
            { //配置文件存在则加载
                XDocument document = XDocument.Load("config.xml");
                XElement rootElement = document.Root;
                //添加用户前判断是否已经添加
                //用用户名查找
                int n = rootElement.Elements("LoginUser").Where(u => u.Attribute("code").Value == uCode).Count();
                if (n > 0)
                {//已经添加用户了
                    //查找到已经添加用户的节点
                    XElement userElement = rootElement.Elements("LoginUser").Where(u => u.Attribute("code").Value == uCode).First();
                    userElement.SetElementValue("loginDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                }
                else//没有添加过用户
                {
                    XElement loginUserElement = new XElement("LoginUser");
                    rootElement.Add(loginUserElement);
                    loginUserElement.SetElementValue("loginDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    loginUserElement.SetAttributeValue("code", uCode);
                }
                //保存配置文件
                document.Save("config.xml");

            }
            else//配置文件不存在则创建
            {
                XDocument document = new XDocument();
                XDeclaration xdec = new XDeclaration("1.0", "utf-8", "yes");
                document.Declaration = xdec;
                XElement rootElement = new XElement("MyERP");
                document.Add(rootElement);
                XElement loginElement = new XElement("LoginUser");
                loginElement.SetAttributeValue("code", uCode);
                loginElement.SetElementValue("loginDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                rootElement.Add(loginElement);
                document.Save("config.xml");
            }






        }

        /// <summary>
        /// 用户名失去焦点时判断用户是否存在,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbUid_Leave(object sender, EventArgs e)
        {
            if (cbUid.Text.Length > 0)
            {
                SYS_USER_BLL bll = new SYS_USER_BLL();
                SYS_USER model = bll.CheckUid(cbUid.Text);
                if (model.USER_NAME == null)
                {
                    txtRealName.Text = "用户不存在";
                }
                else
                {
                    txtRealName.Text = model.USER_NAME;//用户名存在时显示真实姓名
                }
            }

        }
        /// <summary>
        /// 登陆窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //加载登陆过用户名
            LoadConfig();
        }

        private void LoadConfig()
        {
            if (File.Exists("config.xml"))
            {//如配置文件存在则加载
                //加载xml
                XDocument document = XDocument.Load("config.xml");
                //创建Xml根节点
                XElement rootElement = document.Root;

                DateTime lastLoginDate=DateTime.MinValue;
                //遍历xml根节点
                foreach (var item in rootElement.Elements())
                {
                    //将根节点的的有子节点LoginUser的属性加入下拉框
                    cbUid.Items.Add(item.Attribute("code").Value);
                   DateTime userLoginDate= DateTime.Parse(item.Element("loginDate").Value);
                    if(DateTime.Compare(lastLoginDate,userLoginDate)<0){
                        lastLoginDate=userLoginDate;
                    }
                }
                string last = null;
                XElement lastElement = rootElement.Elements("loginDate").Where(u => u.Value == lastLoginDate.ToString()).First().Parent;
            string lastuser= lastElement.Attribute("code").Value;
                //默认选中最后登陆的用户名
                //思路:先找到最后的登陆日期,再根据登陆日期找到用户名,再设置默认选中
                if (lastuser != null)
                {

            cbUid.SelectedText = lastuser;
                }
                else
                {
                    this.cbUid.SelectedIndex = 1;
                }
               // cbUid.SelectedIndex = cbUid.sel
            }



        }

        /// <summary>
        /// 回车移动焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbUid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void mtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
    }
}
