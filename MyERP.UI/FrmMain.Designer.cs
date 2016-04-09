namespace MyERP.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolSStatusLblCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSStatusLblDept = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSStatusLblWarehouse = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSStatusLblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tabControlNavigate = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.contextMenuTabPage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuItemCloseCurrentPage = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemCloseAllPage = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemCloseOtherPage = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuItemAddMyfunction = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.tabControlNavigate.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.contextMenuTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗口ToolStripMenuItem,
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统配置ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 系统配置ToolStripMenuItem
            // 
            this.系统配置ToolStripMenuItem.Name = "系统配置ToolStripMenuItem";
            this.系统配置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.系统配置ToolStripMenuItem.Text = "系统配置";
            this.系统配置ToolStripMenuItem.Click += new System.EventHandler(this.系统配置ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(988, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton2.Text = "显示导航栏";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSStatusLblCurrentUser,
            this.toolSStatusLblDept,
            this.toolSStatusLblWarehouse,
            this.toolSStatusLblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(988, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolSStatusLblCurrentUser
            // 
            this.toolSStatusLblCurrentUser.AutoSize = false;
            this.toolSStatusLblCurrentUser.BackColor = System.Drawing.SystemColors.Control;
            this.toolSStatusLblCurrentUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolSStatusLblCurrentUser.Name = "toolSStatusLblCurrentUser";
            this.toolSStatusLblCurrentUser.Size = new System.Drawing.Size(243, 21);
            this.toolSStatusLblCurrentUser.Spring = true;
            this.toolSStatusLblCurrentUser.Text = "当前用户:";
            this.toolSStatusLblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolSStatusLblDept
            // 
            this.toolSStatusLblDept.AutoSize = false;
            this.toolSStatusLblDept.BackColor = System.Drawing.SystemColors.Control;
            this.toolSStatusLblDept.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolSStatusLblDept.Name = "toolSStatusLblDept";
            this.toolSStatusLblDept.Size = new System.Drawing.Size(243, 21);
            this.toolSStatusLblDept.Text = "部门:";
            this.toolSStatusLblDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolSStatusLblWarehouse
            // 
            this.toolSStatusLblWarehouse.AutoSize = false;
            this.toolSStatusLblWarehouse.BackColor = System.Drawing.SystemColors.Control;
            this.toolSStatusLblWarehouse.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolSStatusLblWarehouse.Name = "toolSStatusLblWarehouse";
            this.toolSStatusLblWarehouse.Size = new System.Drawing.Size(243, 21);
            this.toolSStatusLblWarehouse.Spring = true;
            this.toolSStatusLblWarehouse.Text = "所属仓库:";
            this.toolSStatusLblWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolSStatusLblDate
            // 
            this.toolSStatusLblDate.BackColor = System.Drawing.SystemColors.Control;
            this.toolSStatusLblDate.Name = "toolSStatusLblDate";
            this.toolSStatusLblDate.Size = new System.Drawing.Size(243, 21);
            this.toolSStatusLblDate.Spring = true;
            this.toolSStatusLblDate.Text = "登陆日期:";
            this.toolSStatusLblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.Controls.Add(this.toolStrip3);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(836, 50);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(152, 403);
            this.panelRight.TabIndex = 9;
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(152, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "×";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(636, 403);
            this.MainTabControl.TabIndex = 4;
            this.MainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MainTabControl_DrawItem);
            this.MainTabControl.DoubleClick += new System.EventHandler(this.MainTabControl_DoubleClick);
            this.MainTabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainTabControl_MouseDown);
            this.MainTabControl.MouseLeave += new System.EventHandler(this.MainTabControl_MouseLeave);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft.Controls.Add(this.tabControlNavigate);
            this.panelLeft.Controls.Add(this.toolStrip2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 403);
            this.panelLeft.TabIndex = 2;
            // 
            // tabControlNavigate
            // 
            this.tabControlNavigate.Controls.Add(this.tabPage1);
            this.tabControlNavigate.Controls.Add(this.tabPage2);
            this.tabControlNavigate.Controls.Add(this.tabPage3);
            this.tabControlNavigate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNavigate.Location = new System.Drawing.Point(0, 25);
            this.tabControlNavigate.Name = "tabControlNavigate";
            this.tabControlNavigate.SelectedIndex = 0;
            this.tabControlNavigate.Size = new System.Drawing.Size(200, 378);
            this.tabControlNavigate.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "功能列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(186, 346);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "我的功能";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(200, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "导航栏";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "×";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.MainTabControl);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(200, 50);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(636, 403);
            this.panelCenter.TabIndex = 11;
            // 
            // contextMenuTabPage
            // 
            this.contextMenuTabPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuItemCloseCurrentPage,
            this.ContextMenuItemCloseAllPage,
            this.ContextMenuItemCloseOtherPage,
            this.ContextMenuItemAddMyfunction});
            this.contextMenuTabPage.Name = "contextMenuStrip1";
            this.contextMenuTabPage.Size = new System.Drawing.Size(149, 92);
            // 
            // ContextMenuItemCloseCurrentPage
            // 
            this.ContextMenuItemCloseCurrentPage.Name = "ContextMenuItemCloseCurrentPage";
            this.ContextMenuItemCloseCurrentPage.Size = new System.Drawing.Size(148, 22);
            this.ContextMenuItemCloseCurrentPage.Text = "关闭当前页";
            this.ContextMenuItemCloseCurrentPage.Click += new System.EventHandler(this.ContextMenuItemCloseCurrentPage_Click);
            // 
            // ContextMenuItemCloseAllPage
            // 
            this.ContextMenuItemCloseAllPage.Name = "ContextMenuItemCloseAllPage";
            this.ContextMenuItemCloseAllPage.Size = new System.Drawing.Size(148, 22);
            this.ContextMenuItemCloseAllPage.Text = "关闭所有页";
            this.ContextMenuItemCloseAllPage.Click += new System.EventHandler(this.ContextMenuItemCloseAllPage_Click);
            // 
            // ContextMenuItemCloseOtherPage
            // 
            this.ContextMenuItemCloseOtherPage.Name = "ContextMenuItemCloseOtherPage";
            this.ContextMenuItemCloseOtherPage.Size = new System.Drawing.Size(148, 22);
            this.ContextMenuItemCloseOtherPage.Text = "关闭其它页";
            this.ContextMenuItemCloseOtherPage.Click += new System.EventHandler(this.ContextMenuItemCloseOtherPage_Click);
            // 
            // ContextMenuItemAddMyfunction
            // 
            this.ContextMenuItemAddMyfunction.Name = "ContextMenuItemAddMyfunction";
            this.ContextMenuItemAddMyfunction.Size = new System.Drawing.Size(148, 22);
            this.ContextMenuItemAddMyfunction.Text = "加入我的功能";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 352);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "最近打开";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 479);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.tabControlNavigate.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panelCenter.ResumeLayout(false);
            this.contextMenuTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.ToolStripStatusLabel toolSStatusLblCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel toolSStatusLblDept;
        private System.Windows.Forms.TabControl tabControlNavigate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolSStatusLblWarehouse;
        private System.Windows.Forms.ToolStripStatusLabel toolSStatusLblDate;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统配置ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuTabPage;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCloseCurrentPage;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCloseAllPage;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemCloseOtherPage;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuItemAddMyfunction;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

