using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _01studyBooks
{
    public partial class ChangePwd : Form
    {
        public string roles { get; set; }
        private Form _parentForm;
        public ChangePwd(string roles, Form parentForm)
        {
            InitializeComponent();
            this.roles = roles;
            this._parentForm = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldpwd = oldPwd.Text;
            string newpwd = newPwd.Text;
            string enterNewPWD = enterNewPwd.Text;
            if (oldpwd == "" || newpwd == "" || enterNewPWD == "")
            {
                MessageBox.Show("有空项！");
                return;
            }
            if (newpwd != enterNewPWD)
            {
                MessageBox.Show("两次输入的新密码不一致！");
                return;
            }

            string[] msgList = new string[] { "修改成功,请重新登陆!", "修改失败！" };
            string seachdata = $"AdminID = {Form1.ID} and Pwd = '{oldpwd}'";
            string updatadata = $"Pwd = '{newpwd}' where AdminID = {Form1.ID}";
            Request.UpdataApi(msgList, seachdata, updatadata, roles, (success, msg) =>
            {
                MessageBox.Show(msg);
                if (success)
                {
                    this.Hide();
                    _parentForm?.Hide();
                    new Form1().Show();
                    oldPwd.Text = "";
                    newPwd.Text = "";
                    enterNewPwd.Text = "";
                }
            });
            //string sql = roles == "admin"
            //    ? $"select * from t_admin where AdminID = {Form1.ID} and Pwd = '{oldpwd}'"
            //    : $"select * from t_user where Uid = {Form1.ID} and Pwd = '{oldpwd}'";
            //var reader = Dao.Instance.read(sql);
            //if (reader.Read())
            //{
            //    reader.Close();
            //    // 修改密码 判断角色
            //    sql = roles == "admin"
            //        ? $"update t_admin set Pwd = '{newpwd}' where AdminID = {Form1.ID}"
            //        : $"update t_user set Pwd = '{newpwd}' where Uid = {Form1.ID}";

            //    int res = Dao.Instance.Execute(sql);

            //    if (res > 0)
            //    {
            //        MessageBox.Show("修改成功,请重新登陆!");
            //        Dao.Instance.DaoClose();
            //        this.Hide();
            //        Form1 form1 = new Form1();
            //        _parentForm?.Hide();
            //        oldPwd.Text = "";
            //        newPwd.Text = "";
            //        enterNewPwd.Text = "";
            //        form1.Show();
            //    }
            //    else AutoClosingMessageBox.Show("修改失败！", "提示", 2000); ;
            //}
            //else AutoClosingMessageBox.Show("密码错误！", "提示", 2000);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangePwd_Load(object sender, EventArgs e)
        {

        }
    }
}
