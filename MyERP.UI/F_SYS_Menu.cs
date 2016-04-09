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
    public partial class F_SYS_Menu : Form
    {
        public F_SYS_Menu()
        {
            InitializeComponent();
        }

        private void F_SYS_Menu_Load(object sender, EventArgs e)
        {
           TreeNode rootNode=treeView1.Nodes[0];
          //  LoadTreeViewData( code , rootNode);
        }

        private void LoadTreeViewData(object code, TreeNode rootNode)
        {
            throw new NotImplementedException();
        }
    }
}
