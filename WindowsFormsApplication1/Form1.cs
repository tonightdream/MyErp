using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          TreeNode rootNode=  treeView1.Nodes.Add("tm");
          rootNode.Nodes.Add("tm01");
        TreeNode a=  rootNode.Nodes.Add("tm02");
        a.Nodes.Add("tm0201");
        a.Nodes.Add("tm0202");
          rootNode.Nodes.Add("tm03");
          rootNode.Nodes.Add("tm04");

        //  rootNode.Expand();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes[0].Expand();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
