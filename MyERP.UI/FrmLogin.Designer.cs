namespace MyERP.UI
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtbox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.cbUid = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNotices = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(135, 238);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "登  陆";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(299, 238);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "退  出";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名:";
            // 
            // mtxtbox
            // 
            this.mtxtbox.Location = new System.Drawing.Point(168, 201);
            this.mtxtbox.Name = "mtxtbox";
            this.mtxtbox.PasswordChar = '*';
            this.mtxtbox.Size = new System.Drawing.Size(209, 21);
            this.mtxtbox.TabIndex = 2;
            this.mtxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtbox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密  码:";
            // 
            // txtRealName
            // 
            this.txtRealName.Location = new System.Drawing.Point(288, 164);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.ReadOnly = true;
            this.txtRealName.Size = new System.Drawing.Size(89, 21);
            this.txtRealName.TabIndex = 10;
            // 
            // cbUid
            // 
            this.cbUid.FormattingEnabled = true;
            this.cbUid.Location = new System.Drawing.Point(168, 164);
            this.cbUid.Name = "cbUid";
            this.cbUid.Size = new System.Drawing.Size(114, 20);
            this.cbUid.TabIndex = 0;
            this.cbUid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbUid_KeyDown);
            this.cbUid.Leave += new System.EventHandler(this.cbUid_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 113);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblNotices
            // 
            this.lblNotices.AutoSize = true;
            this.lblNotices.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNotices.Location = new System.Drawing.Point(210, 120);
            this.lblNotices.Name = "lblNotices";
            this.lblNotices.Size = new System.Drawing.Size(85, 19);
            this.lblNotices.TabIndex = 9;
            this.lblNotices.Text = "系统通知";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 288);
            this.Controls.Add(this.lblNotices);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbUid);
            this.Controls.Add(this.txtRealName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登陆";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.ComboBox cbUid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNotices;
    }
}