namespace _01studyBooks
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.个人信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.租借管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.租借图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.归还图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书评价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看评价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反馈到管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息管理ToolStripMenuItem,
            this.租借管理ToolStripMenuItem,
            this.图书评价ToolStripMenuItem,
            this.系统反馈ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 个人信息管理ToolStripMenuItem
            // 
            this.个人信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.注销账号ToolStripMenuItem});
            this.个人信息管理ToolStripMenuItem.Name = "个人信息管理ToolStripMenuItem";
            this.个人信息管理ToolStripMenuItem.Size = new System.Drawing.Size(199, 41);
            this.个人信息管理ToolStripMenuItem.Text = "个人信息管理";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(220, 42);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 注销账号ToolStripMenuItem
            // 
            this.注销账号ToolStripMenuItem.Name = "注销账号ToolStripMenuItem";
            this.注销账号ToolStripMenuItem.Size = new System.Drawing.Size(220, 42);
            this.注销账号ToolStripMenuItem.Text = "注销账号";
            this.注销账号ToolStripMenuItem.Click += new System.EventHandler(this.注销账号ToolStripMenuItem_Click);
            // 
            // 租借管理ToolStripMenuItem
            // 
            this.租借管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.租借图书ToolStripMenuItem,
            this.归还图书ToolStripMenuItem});
            this.租借管理ToolStripMenuItem.Name = "租借管理ToolStripMenuItem";
            this.租借管理ToolStripMenuItem.Size = new System.Drawing.Size(143, 41);
            this.租借管理ToolStripMenuItem.Text = "租借管理";
            // 
            // 租借图书ToolStripMenuItem
            // 
            this.租借图书ToolStripMenuItem.Name = "租借图书ToolStripMenuItem";
            this.租借图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 42);
            this.租借图书ToolStripMenuItem.Text = "租借图书";
            this.租借图书ToolStripMenuItem.Click += new System.EventHandler(this.租借图书ToolStripMenuItem_Click);
            // 
            // 归还图书ToolStripMenuItem
            // 
            this.归还图书ToolStripMenuItem.Name = "归还图书ToolStripMenuItem";
            this.归还图书ToolStripMenuItem.Size = new System.Drawing.Size(224, 42);
            this.归还图书ToolStripMenuItem.Text = "归还图书";
            // 
            // 图书评价ToolStripMenuItem
            // 
            this.图书评价ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看评价ToolStripMenuItem});
            this.图书评价ToolStripMenuItem.Name = "图书评价ToolStripMenuItem";
            this.图书评价ToolStripMenuItem.Size = new System.Drawing.Size(143, 41);
            this.图书评价ToolStripMenuItem.Text = "图书评价";
            // 
            // 查看评价ToolStripMenuItem
            // 
            this.查看评价ToolStripMenuItem.Name = "查看评价ToolStripMenuItem";
            this.查看评价ToolStripMenuItem.Size = new System.Drawing.Size(220, 42);
            this.查看评价ToolStripMenuItem.Text = "查看评价";
            // 
            // 系统反馈ToolStripMenuItem
            // 
            this.系统反馈ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.反馈到管理员ToolStripMenuItem});
            this.系统反馈ToolStripMenuItem.Name = "系统反馈ToolStripMenuItem";
            this.系统反馈ToolStripMenuItem.Size = new System.Drawing.Size(143, 41);
            this.系统反馈ToolStripMenuItem.Text = "系统反馈";
            // 
            // 反馈到管理员ToolStripMenuItem
            // 
            this.反馈到管理员ToolStripMenuItem.Name = "反馈到管理员ToolStripMenuItem";
            this.反馈到管理员ToolStripMenuItem.Size = new System.Drawing.Size(276, 42);
            this.反馈到管理员ToolStripMenuItem.Text = "反馈到管理员";
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(143, 41);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userName.ForeColor = System.Drawing.Color.Turquoise;
            this.userName.Location = new System.Drawing.Point(12, 56);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(223, 43);
            this.userName.TabIndex = 1;
            this.userName.Text = "用户";
            this.userName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(340, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 93);
            this.label1.TabIndex = 3;
            this.label1.Text = "欢迎使用图书管理系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1445, 1298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3845, 3773);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销账号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 租借管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 租借图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 归还图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书评价ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看评价ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反馈到管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}