using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01studyBooks
{
    public partial class Form1 : Form
    {
        public static string UserName { get; set; }
        public string PassWord { get; set; }
        public static int ID { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        // 封装登陆
        private void Login(string sql, Dao dao, int id, string roles)
        {
            string sqlNew = sql;
            dao.connect();
            MySqlDataReader reader = dao.read(sqlNew);
            bool res = reader.Read();
            if (res)
            {
                Form1.ID = id;
                if (roles == "admin")
                {
                    sqlNew = $"select `Name` from t_admin where AdminID = '{id}'";
                    reader = dao.read(sqlNew);
                    reader.Read();
                    Form1.UserName = reader[0].ToString();
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                }
                if (roles == "user")
                {
                    sqlNew = $"select `Uname` from t_user where Uid = '{ID}'";
                    reader = dao.read(sqlNew);
                    reader.Read();
                    Form1.UserName = reader[0].ToString();
                    UserForm userform = new UserForm(reader[0].ToString());
                    userform.Show();
                }
                MessageBox.Show("登录成功");
                username.Text = "";
                password.Text = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show("账号密码错误");
                return;
            }
        }
        private void login_Click(object sender, EventArgs e)
        {

            if (username.Text == "" || PassWord == "")
            {
                MessageBox.Show("有空项！！！");
                return;
            }
            int id = int.Parse(username.Text.Trim());
            PassWord = password.Text;
            string sql;
            Dao dao = new Dao();

            //管理员登录
            if (admin.Checked == true)
            {
                sql = $"select * from t_admin where AdminID = {id} and Pwd = '{PassWord}'";
                Login(sql, dao, id, "admin");
            }
            if (user.Checked == true)
            {
                sql = $"select * from t_user where Uid = '{id}' and Pwd = '{PassWord}'";
                Login(sql, dao, id, "user");

            }
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {

        }

        private void user_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void admin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
