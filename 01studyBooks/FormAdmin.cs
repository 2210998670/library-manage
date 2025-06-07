using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01studyBooks
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 个人信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认退出吗?", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
                label1.Text = "";
                new Form1().Show();
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePwd changePwd = new ChangePwd("T_Admin", this);
            changePwd.ShowDialog();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text+Form1.UserName+" "+Form1.ID;
        }

        private void 添加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddBook().Show();
        }

        private void 修改图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new manageBooks().Show();
        }

        private void 下架图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new manageBooks().Show();
        }

        private void 搜索图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new manageBooks().Show();
        }

        private void 注销账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查看用户租借情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
