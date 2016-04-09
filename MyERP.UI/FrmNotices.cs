using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyERP.UI
{
    public partial class FrmNotices : Form
    {
        public FrmNotices()
        {
            InitializeComponent();
        }

        private void FrmNotices_Load(object sender, EventArgs e)
        {
            int Swidth = Screen.PrimaryScreen.WorkingArea.Width;//获取屏幕宽度
            int SHeight = Screen.PrimaryScreen.WorkingArea.Height;//获取屏幕高度
            this.DesktopLocation = new Point(Swidth - this.Width, SHeight - this.Height);//设置窗体加载时位置
        }
    }
}
