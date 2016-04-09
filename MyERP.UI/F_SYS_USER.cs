using MyERP.BLL;
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
    public partial class F_SYS_USER : Form
    {
        public F_SYS_USER()
        {
            InitializeComponent();
        }

        private void F_SYS_USER_Load(object sender, EventArgs e)
        {
            SYS_USER_BLL bll = new SYS_USER_BLL();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bll.ListAllUsers();
        }
    }
}
