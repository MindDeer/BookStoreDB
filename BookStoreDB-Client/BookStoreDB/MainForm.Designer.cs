namespace BookStoreDB
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.现有图书查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.现有图书查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.期刊管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.期刊录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.期刊修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.期刊删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.租还书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书租出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书还入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.期刊租出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.期刊还入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书借还情况查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.期刊借还情况查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.零售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书售出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.期刊售出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书销售情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.期刊销售情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理ToolStripMenuItem,
            this.期刊管理ToolStripMenuItem,
            this.读者管理ToolStripMenuItem,
            this.租还书管理ToolStripMenuItem,
            this.零售管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书录入ToolStripMenuItem,
            this.现有图书查询ToolStripMenuItem,
            this.现有图书查询ToolStripMenuItem1});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // 图书录入ToolStripMenuItem
            // 
            this.图书录入ToolStripMenuItem.Name = "图书录入ToolStripMenuItem";
            this.图书录入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.图书录入ToolStripMenuItem.Text = "图书信息管理";
            this.图书录入ToolStripMenuItem.Click += new System.EventHandler(this.图书信息管理ToolStripMenuItem_Click);
            // 
            // 现有图书查询ToolStripMenuItem
            // 
            this.现有图书查询ToolStripMenuItem.Name = "现有图书查询ToolStripMenuItem";
            this.现有图书查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.现有图书查询ToolStripMenuItem.Text = "图书副本管理";
            this.现有图书查询ToolStripMenuItem.Click += new System.EventHandler(this.图书副本管理ToolStripMenuItem_Click);
            // 
            // 现有图书查询ToolStripMenuItem1
            // 
            this.现有图书查询ToolStripMenuItem1.Name = "现有图书查询ToolStripMenuItem1";
            this.现有图书查询ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.现有图书查询ToolStripMenuItem1.Text = "现有图书查询";
            this.现有图书查询ToolStripMenuItem1.Click += new System.EventHandler(this.现有图书查询ToolStripMenuItem1_Click);
            // 
            // 期刊管理ToolStripMenuItem
            // 
            this.期刊管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.期刊录入ToolStripMenuItem,
            this.期刊修改ToolStripMenuItem,
            this.期刊删除ToolStripMenuItem});
            this.期刊管理ToolStripMenuItem.Name = "期刊管理ToolStripMenuItem";
            this.期刊管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.期刊管理ToolStripMenuItem.Text = "期刊管理";
            // 
            // 期刊录入ToolStripMenuItem
            // 
            this.期刊录入ToolStripMenuItem.Name = "期刊录入ToolStripMenuItem";
            this.期刊录入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.期刊录入ToolStripMenuItem.Text = "期刊信息管理";
            this.期刊录入ToolStripMenuItem.Click += new System.EventHandler(this.期刊信息管理ToolStripMenuItem_Click);
            // 
            // 期刊修改ToolStripMenuItem
            // 
            this.期刊修改ToolStripMenuItem.Name = "期刊修改ToolStripMenuItem";
            this.期刊修改ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.期刊修改ToolStripMenuItem.Text = "期刊副本管理";
            this.期刊修改ToolStripMenuItem.Click += new System.EventHandler(this.期刊副本管理ToolStripMenuItem_Click);
            // 
            // 期刊删除ToolStripMenuItem
            // 
            this.期刊删除ToolStripMenuItem.Name = "期刊删除ToolStripMenuItem";
            this.期刊删除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.期刊删除ToolStripMenuItem.Text = "现有期刊查询";
            this.期刊删除ToolStripMenuItem.Click += new System.EventHandler(this.现有期刊查询ToolStripMenuItem_Click);
            // 
            // 读者管理ToolStripMenuItem
            // 
            this.读者管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者录入ToolStripMenuItem,
            this.读者信息查询ToolStripMenuItem});
            this.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            this.读者管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.读者管理ToolStripMenuItem.Text = "读者管理";
            // 
            // 读者录入ToolStripMenuItem
            // 
            this.读者录入ToolStripMenuItem.Name = "读者录入ToolStripMenuItem";
            this.读者录入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.读者录入ToolStripMenuItem.Text = "读者信息管理";
            this.读者录入ToolStripMenuItem.Click += new System.EventHandler(this.读者信息管理ToolStripMenuItem_Click);
            // 
            // 读者信息查询ToolStripMenuItem
            // 
            this.读者信息查询ToolStripMenuItem.Name = "读者信息查询ToolStripMenuItem";
            this.读者信息查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.读者信息查询ToolStripMenuItem.Text = "读者信息查询";
            this.读者信息查询ToolStripMenuItem.Click += new System.EventHandler(this.读者信息查询ToolStripMenuItem_Click);
            // 
            // 租还书管理ToolStripMenuItem
            // 
            this.租还书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书租出ToolStripMenuItem,
            this.图书还入ToolStripMenuItem,
            this.期刊租出ToolStripMenuItem,
            this.期刊还入ToolStripMenuItem,
            this.图书借还情况查询ToolStripMenuItem,
            this.期刊借还情况查询ToolStripMenuItem});
            this.租还书管理ToolStripMenuItem.Name = "租还书管理ToolStripMenuItem";
            this.租还书管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.租还书管理ToolStripMenuItem.Text = "租还书管理";
            // 
            // 图书租出ToolStripMenuItem
            // 
            this.图书租出ToolStripMenuItem.Name = "图书租出ToolStripMenuItem";
            this.图书租出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.图书租出ToolStripMenuItem.Text = "图书租出";
            this.图书租出ToolStripMenuItem.Click += new System.EventHandler(this.图书租出ToolStripMenuItem_Click);
            // 
            // 图书还入ToolStripMenuItem
            // 
            this.图书还入ToolStripMenuItem.Name = "图书还入ToolStripMenuItem";
            this.图书还入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.图书还入ToolStripMenuItem.Text = "图书还入";
            this.图书还入ToolStripMenuItem.Click += new System.EventHandler(this.图书还入ToolStripMenuItem_Click);
            // 
            // 期刊租出ToolStripMenuItem
            // 
            this.期刊租出ToolStripMenuItem.Name = "期刊租出ToolStripMenuItem";
            this.期刊租出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.期刊租出ToolStripMenuItem.Text = "期刊租出";
            this.期刊租出ToolStripMenuItem.Click += new System.EventHandler(this.期刊租出ToolStripMenuItem_Click);
            // 
            // 期刊还入ToolStripMenuItem
            // 
            this.期刊还入ToolStripMenuItem.Name = "期刊还入ToolStripMenuItem";
            this.期刊还入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.期刊还入ToolStripMenuItem.Text = "期刊还入";
            this.期刊还入ToolStripMenuItem.Click += new System.EventHandler(this.期刊还入ToolStripMenuItem_Click);
            // 
            // 图书借还情况查询ToolStripMenuItem
            // 
            this.图书借还情况查询ToolStripMenuItem.Name = "图书借还情况查询ToolStripMenuItem";
            this.图书借还情况查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.图书借还情况查询ToolStripMenuItem.Text = "图书租还情况";
            this.图书借还情况查询ToolStripMenuItem.Click += new System.EventHandler(this.图书借还情况查询ToolStripMenuItem_Click);
            // 
            // 期刊借还情况查询ToolStripMenuItem
            // 
            this.期刊借还情况查询ToolStripMenuItem.Name = "期刊借还情况查询ToolStripMenuItem";
            this.期刊借还情况查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.期刊借还情况查询ToolStripMenuItem.Text = "期刊租还情况";
            this.期刊借还情况查询ToolStripMenuItem.Click += new System.EventHandler(this.期刊借还情况查询ToolStripMenuItem_Click);
            // 
            // 零售管理ToolStripMenuItem
            // 
            this.零售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书售出ToolStripMenuItem,
            this.期刊售出ToolStripMenuItem,
            this.图书销售情况ToolStripMenuItem,
            this.期刊销售情况ToolStripMenuItem});
            this.零售管理ToolStripMenuItem.Name = "零售管理ToolStripMenuItem";
            this.零售管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.零售管理ToolStripMenuItem.Text = "零售管理";
            // 
            // 图书售出ToolStripMenuItem
            // 
            this.图书售出ToolStripMenuItem.Name = "图书售出ToolStripMenuItem";
            this.图书售出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图书售出ToolStripMenuItem.Text = "图书售出";
            this.图书售出ToolStripMenuItem.Click += new System.EventHandler(this.图书售出ToolStripMenuItem_Click);
            // 
            // 期刊售出ToolStripMenuItem
            // 
            this.期刊售出ToolStripMenuItem.Name = "期刊售出ToolStripMenuItem";
            this.期刊售出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.期刊售出ToolStripMenuItem.Text = "期刊售出";
            this.期刊售出ToolStripMenuItem.Click += new System.EventHandler(this.期刊售出ToolStripMenuItem_Click);
            // 
            // 图书销售情况ToolStripMenuItem
            // 
            this.图书销售情况ToolStripMenuItem.Name = "图书销售情况ToolStripMenuItem";
            this.图书销售情况ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.图书销售情况ToolStripMenuItem.Text = "图书销售情况";
            this.图书销售情况ToolStripMenuItem.Click += new System.EventHandler(this.图书销售情况ToolStripMenuItem_Click);
            // 
            // 期刊销售情况ToolStripMenuItem
            // 
            this.期刊销售情况ToolStripMenuItem.Name = "期刊销售情况ToolStripMenuItem";
            this.期刊销售情况ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.期刊销售情况ToolStripMenuItem.Text = "期刊销售情况";
            this.期刊销售情况ToolStripMenuItem.Click += new System.EventHandler(this.期刊销售情况ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 222);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号：";
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(101, 267);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(100, 21);
            this.tbAccount.TabIndex = 3;
            this.tbAccount.Text = "Dreaming";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码：";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(101, 309);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 21);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "135704";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(287, 285);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "登录";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(262, 333);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(41, 12);
            this.lbMessage.TabIndex = 7;
            this.lbMessage.Text = "label3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 357);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "书店书刊出租和零售管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 期刊管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 期刊录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 期刊修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 期刊删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 租还书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书租出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书还入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 期刊租出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 期刊还入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 零售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书售出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 期刊售出ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.ToolStripMenuItem 现有图书查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书借还情况查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 期刊借还情况查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书销售情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 期刊销售情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 现有图书查询ToolStripMenuItem1;
    }
}

