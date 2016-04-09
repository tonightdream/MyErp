using MyERP.BLL;
using MyERP.Model;
using MyERP.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyERP.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 隐藏导航栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelLeft.Visible = false;//隐藏导航栏
            toolStripButton2.Visible = true;//显示工具栏上的导航栏按钮

        }

        /// <summary>
        /// 添加TabPage
        /// </summary>
        /// <param name="str"></param>
        /// <param name="myForm"></param>
        public void Add_TabPage(string str, Form myForm)
        {
            if (tabControlCheckHave(this.MainTabControl, str))
            {
                return;
            }
            else
            {
                MainTabControl.TabPages.Add(str);
                MainTabControl.SelectTab(MainTabControl.TabPages.Count - 1);
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.Dock = DockStyle.Fill;
                myForm.TopLevel = false;
                myForm.Show();
                myForm.Parent = MainTabControl.SelectedTab;
            }
        }
        /// <summary>
        /// 判断窗体是否已经打开
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="tabName"></param>
        /// <returns></returns>
        public bool tabControlCheckHave(System.Windows.Forms.TabControl tab, String tabName)
        {
            for (int i = 0; i < tab.TabCount; i++)
            {
                if (tab.TabPages[i].Text == tabName)
                {
                    tab.SelectedIndex = i;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 主窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.MainTabControl.SizeMode = TabSizeMode.Fixed;
            this.MainTabControl.ItemSize = new Size(100, 25);
            this.toolStripButton2.Visible = false;

            toolSStatusLblCurrentUser.Text = "当前用户:" + GlobalHelper.CurrenLoginUser.USER_NAME;
            toolSStatusLblDept.Text = "部门:" + GlobalHelper.CurrenLoginUser.DEPARTMENT_NAME;
            toolSStatusLblWarehouse.Text = "所属仓:" + GlobalHelper.CurrenLoginUser.STOCK_NAME;
            toolSStatusLblDate.Text = DateTime.Now.ToLongDateString();

            TreeNode rootNode = treeView1.Nodes.Add("泰明集团");//根节点
            LoadNavMenu("s01", rootNode.Nodes);
            rootNode.Expand();//此行要放在TreeView数据加载后,否则不会展开节点
           
            FrmNotices frm = new FrmNotices();
            //frm.ShowDialog(); //显示提示窗体


        }


        private void LoadNavMenu(string pid, TreeNodeCollection treeNodeCollection)
        {
            SYS_MENU_BLL BLL = new SYS_MENU_BLL();
            DataTable dt = BLL.LoadNavMenu(pid);
            //加载数据
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode tnode = treeNodeCollection.Add(dr[1].ToString());
                tnode.Tag = dr[0];
                LoadNavMenu((string)dr[0], tnode.Nodes);
            }

        }

        //重绘TabControl
        private void MainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*如果将 DrawMode 属性设置为 OwnerDrawFixed，
                      则每当 TabControl 需要绘制它的一个选项卡时，它就会引发 DrawItem 事件*/
            try
            {
                this.MainTabControl.TabPages[e.Index].BackColor = Color.White;//设置TabPage的背景色
                if (e.Index == this.MainTabControl.SelectedIndex)//TabPage被选中时header的背景色为白色
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                }
                Rectangle tabRect = this.MainTabControl.GetTabRect(e.Index);//根据TabPage索引获取TabPage标题栏矩形
                //如Tabpage名称太长截取显示
                string tabPageName = this.MainTabControl.TabPages[e.Index].Text;
                if (tabPageName.Length > 6)
                {
                    tabPageName = tabPageName.Substring(0, 6) + "...";
                }

                e.Graphics.DrawString(tabPageName, this.Font, SystemBrushes.ControlText/*TabPageHeader字体颜色*/, (float)(tabRect.X + 2/*TabPage标题到左边的距离*/), (float)(tabRect.Y + 5));

                using (Pen pen = new Pen(Color.Transparent/*TabPage右侧关闭区边框颜色*/))
                {
                    tabRect.Offset(tabRect.Width - 18, 5);  //TabPage右侧关闭区边框位置
                    tabRect.Width = 15;//TabPage右侧关闭区的宽
                    tabRect.Height = 15;//TabPage右侧关闭区的高
                    e.Graphics.DrawRectangle(pen, tabRect);
                }
                //Color color = (e.State == DrawItemState.Selected) ? Color.Red/*TabPage右则的关闭叉选中时的背景色*/ : Color.White/*未选中时的背景色*/;
                Color color = (e.State == DrawItemState.Selected) ? Color.FromArgb(50, Color.Gray)/*TabPage右则的关闭叉选中时的背景色*/ : Color.FromArgb(0, Color.Gray)/*未选中时的背景色*/;
                using (Brush brush = new SolidBrush(color))//选中和未选中两种状况下Tabpage关闭区背景色填充色
                {
                    e.Graphics.FillRectangle(brush, tabRect);
                }
                using (Pen pen2 = new Pen(Color.Black/*TabPage右则的关闭叉颜色*/))
                {
                    Point point = new Point(tabRect.X + 3, tabRect.Y + 3);
                    Point point2 = new Point((tabRect.X + tabRect.Width) - 3, (tabRect.Y + tabRect.Height) - 3);
                    e.Graphics.DrawLine(pen2, point, point2);
                    Point point3 = new Point(tabRect.X + 3, (tabRect.Y + tabRect.Height) - 3);
                    Point point4 = new Point((tabRect.X + tabRect.Width) - 3, tabRect.Y + 3);
                    e.Graphics.DrawLine(pen2, point3, point4);
                }
                e.Graphics.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// TabControl点击关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//鼠标左键点击事件
            {
                int x = e.X;
                int y = e.Y;
                Rectangle tabRect = this.MainTabControl.GetTabRect(this.MainTabControl.SelectedIndex);
                tabRect.Offset(tabRect.Width - 0x12, 2);
                tabRect.Width = 15;
                tabRect.Height = 15;
                if ((((x > tabRect.X) && (x < tabRect.Right)) && (y > tabRect.Y)) && (y < tabRect.Bottom))
                {
                    this.MainTabControl.TabPages.Remove(this.MainTabControl.SelectedTab);
                }
            }


            if (e.Button == MouseButtons.Right) //实现右键选中选项卡
            {
                for (int i = 0; i < MainTabControl.TabPages.Count; i++)
                {
                    TabPage tp = MainTabControl.TabPages[i];
                    if (MainTabControl.GetTabRect(i).Contains(new Point(e.X, e.Y)))
                    {
                        MainTabControl.SelectedTab = tp;
                        break;
                    }
                }
                this.MainTabControl.ContextMenuStrip = this.contextMenuTabPage;  //弹出菜单
            }
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            panelLeft.Visible = true;
            this.toolStripButton2.Visible = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.panelRight.Visible = false;
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            this.panelRight.Visible = false;
        }

        private void 系统配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_SYS_CS frml = new F_SYS_CS();
            Add_TabPage("系统配置", frml);
        }
        /// <summary>
        /// 导航栏项目选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode CurrentNode = e.Node;//获取当前选中的节点
            if (CurrentNode.Tag != null)
            {
                string menu_code = CurrentNode.Tag.ToString();

                //根据Menu_code查询对应的Menu_Unit打开相应的窗体

                SYS_MENU_BLL bll = new SYS_MENU_BLL();
                SYS_MENU menu = bll.GetMenuByCode(menu_code);
                //tring formName = menu.MENU_UNIT;

                string strnamespace = "MyERP.UI";//根据你自己的命名空间来修改
                string strfrm = menu.MENU_UNIT;
                //注意:要动态打开的窗体要放在MyERP.UI根目录下一行才能找到 (strnamespace + "." + strfrm)
                Form frm = (Form)Assembly.Load(strnamespace).CreateInstance(strnamespace + "." + strfrm);
                if (frm != null)
                {
                    Add_TabPage(menu.MENU_NAME, frm);
                }
            }
        }
        /// <summary>  
        /// 打开新的子窗体  
        /// </summary>  
        /// <param name="strName">窗体的类名</param>  
        /// <param name="AssemblyName">窗体所在类库的名称</param>   
        public void CreateForm(string strName, string AssemblyName)
        {
            string path = AssemblyName;//项目的Assembly选项名称  
            string name = strName; //类的名字  
            Form doc = (Form)Assembly.Load(path).CreateInstance(name);
            // doc.Show();
            Add_TabPage(strName, doc);
        }
        /// <summary>
        /// 双击关闭TabPage实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTabControl_DoubleClick(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)sender;
            TabPage tp = this.MainTabControl.TabPages[tc.SelectedIndex];
            this.MainTabControl.TabPages.Remove(tp);
        }

        /// <summary>
        /// 关闭当前页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContextMenuItemCloseCurrentPage_Click(object sender, EventArgs e)
        {
            int CurrentIndex = MainTabControl.SelectedIndex;//保存当前页索引
            int count = MainTabControl.TabCount;
            if (CurrentIndex == count - 1)//说明选中的是最后一个页
            {
                //如关闭的是最一页则默认关闭后会选中第一页
                //实现要关闭最后一页后再选中最后一页
                MainTabControl.SelectedTab.Dispose();//关闭当前页
                MainTabControl.SelectedIndex = CurrentIndex - 1;

            }
            else
            {
                MainTabControl.SelectedTab.Dispose();//关闭当前页
                MainTabControl.SelectedIndex = CurrentIndex;//原来的当前页关闭后它之后页会自动占用关闭页的索引,直接选中那页
            }





        }
        /// <summary>
        /// 关闭的所有的TabPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContextMenuItemCloseAllPage_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in MainTabControl.TabPages)
            {
                tp.Dispose();
            }
        }

        private void ContextMenuItemCloseOtherPage_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in MainTabControl.TabPages)
            {
                if (tp != MainTabControl.SelectedTab)//不是选中的TabPage则关闭
                {
                    tp.Dispose();
                }
            }
        }

        /// <summary>
        /// 鼠标移出TabPage标题栏后设置右键菜单为null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTabControl_MouseLeave(object sender, EventArgs e)
        {
            this.MainTabControl.ContextMenuStrip = null;
        }


    }
}
