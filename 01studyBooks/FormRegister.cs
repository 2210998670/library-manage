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
    public partial class FormRegister : Form
    {
        public Form1 form1 = new Form1(); // 创建Form1的实例
        public FormRegister()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userRegister_Click(object sender, EventArgs e)
        {
            // 先判断文本框是否为空
            if (IDcard.Text == "" || Uname.Text == "" || sex.Text == "" || Tel.Text == "" || Password.Text == "" || EnterPassword.Text == "")
            {
                MessageBox.Show("请填写完整信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Password.Text != EnterPassword.Text)
            {
                MessageBox.Show("输入的两次密码不相等", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao.Instance.connect();//链接并打开数据库
            string sql = "select MAX(Uid) from T_User";
            MySqlDataReader reader = Dao.Instance.read(sql);

            //reader.Read();
            int id = 1;//注册的账号
            if (reader.Read() && !reader.IsDBNull(0))
            {
                id = int.Parse(reader[0].ToString()) + 1;
            }
            reader.Close();
            Dao.Instance.DaoClose();
            string name = Uname.Text;
            string idCard = IDcard.Text;
            string Sex = sex.Text;
            string tel = Tel.Text;
            string password = Password.Text;
            string enterPassword = EnterPassword.Text;
            string data = $"'{id}','{name}','{password}','{Sex}','{idCard}','{tel}','0'";

            string[] msgList = new string[] { "注册成功","注册失败"};

            Request.AddApi(msgList, data, "T_User", (success, msg) =>
            {
                MessageBox.Show(msg);
                if (success)
                {
                    this.Hide();
                    new Form1().Show();
                }
            });
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }
    }
}
