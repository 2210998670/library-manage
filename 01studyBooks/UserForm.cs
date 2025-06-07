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
    public partial class UserForm : Form
    {
        public UserForm(string username)
        {
            InitializeComponent();
            userName.Text = "用户:" + username;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("确认退出吗?", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
                new Form1().Show();
                userName.Text = "";
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePwd changePwd = new ChangePwd("T_User", this);
            changePwd.ShowDialog();
        }

        private void 注销账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认注销账号吗?", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string data = $"Uid = {Form1.ID}";
                string[] msgList = new string[] { "注销成功,请重新登陆!", "注销失败，请重试！" };
                Request.deleteApi(msgList, data, "T_User", (success, msg) =>
                {
                    MessageBox.Show(msg);
                    if (success)
                    {
                        this.Hide();
                        new Form1().Show();
                        userName.Text = "";
                    }
                });
            }
 
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void 租借图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Borrow().Show();
        }
    }
}
