using MyERP.COMMON;
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
    public partial class F_SYS_CS : Form
    {
        public F_SYS_CS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChangePwd_Click(object sender, EventArgs e)
        {
            if (TxtOldPwd.Text.Length <= 0)
            {
                MessageBox.Show("必须先输入旧密码,才能修改密码!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtNewPwd1.Text != TxtNewPwd2.Text)
            {
                MessageBox.Show("两次输入的新密码不相同!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TxtOldPwd.Text == TxtNewPwd1.Text)
            {
                MessageBox.Show("新密码和旧密码不能相同!");
            }

        }

        private void FrmSysConfig_Load(object sender, EventArgs e)
        {
            //默认密码框显示系统密码字符
            TxtOldPwd.UseSystemPasswordChar = true;
            TxtNewPwd1.UseSystemPasswordChar = true;
            TxtNewPwd2.UseSystemPasswordChar = true;

            TxtMachineCode.Text = GetLocalMachineCode();

        }

        private string GetLocalMachineCode()
        {
            return MyHelper_cory.GetHardDiskID();
        }
        /// <summary>
        /// 是否显示明文密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (CbShowPwd.Checked)
            {
                TxtOldPwd.UseSystemPasswordChar = false;
                TxtNewPwd1.UseSystemPasswordChar = false;
                TxtNewPwd2.UseSystemPasswordChar = false;
            }
            else
            {
                TxtOldPwd.UseSystemPasswordChar = true;
                TxtNewPwd1.UseSystemPasswordChar = true;
                TxtNewPwd2.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// 单击或双击文本框将文本框内容复制到剪贴板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMachineCode_DoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtMachineCode.Text))
            {
                Clipboard.SetText(TxtMachineCode.Text);
            }

        }
    }
}
