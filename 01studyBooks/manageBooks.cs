using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _01studyBooks
{
    public partial class manageBooks : Form
    {
        public object[] data;
        public manageBooks()
        {
            InitializeComponent();
        }
        public void loadBooks()
        {
            dataTables.Rows.Clear();  // 清空表格数据
            Dao.Instance.connect();
            string sql = "select * from T_Books";
            MySqlDataReader reader = Dao.Instance.read(sql);
            while (reader.Read())
            {
                dataTables.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                    reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()
                    );
            }
            reader.Close();
            Dao.Instance.DaoClose();
            textID.Text = dataTables.CurrentRow.Cells[0].Value.ToString();
            textName.Text = dataTables.CurrentRow.Cells[1].Value.ToString();
            this.data = dataTables.CurrentRow.Cells
               .Cast<DataGridViewCell>()
               .Select(cell => cell.Value)
               .ToArray();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SeachText_TextChanged(object sender, EventArgs e)
        {

        }
        // 窗口加载事件
        private void manageBooks_Load(object sender, EventArgs e)
        {
            loadBooks();

        }
        //获取选中当前项
        private void dataTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataTables.CurrentRow == null || dataTables.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选中无效数据！","消息",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                return;
            }
            textID.Text = dataTables.CurrentRow.Cells [0].Value.ToString();
            textName.Text = dataTables.CurrentRow.Cells[1].Value.ToString();
            var index = 0;
            this.data = dataTables.CurrentRow.Cells
               .Cast<DataGridViewCell>()
               .Select(cell => cell.Value)
               .ToArray();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UpdataBook_Click(object sender, EventArgs e)
        {
            new AddBook(data).Show();
        }

        private void DownBook_Click(object sender, EventArgs e)
        {
            //this.data
            if (DialogResult.Yes == MessageBox.Show("确认下架图书吗?", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string data = $"Bid = {this.data[0]}";
                string[] msgList = new string[] { "下架成功", "下架失败，请重试！" };
                Request.deleteApi(msgList, data, "T_Books", (success, msg) =>
                {
                    MessageBox.Show(msg);
                    if (success)
                    {
                        loadBooks();
                        //this.Hide();
                        //new Form1().Show();
                    }
                });
            }
        }

        private void Seach_Click(object sender, EventArgs e)
        {
            //
            //SELECT* FROM 表名 WHERE name = '张三';
            dataTables.Rows.Clear();  // 清空表格数据
            Dao.Instance.connect();
            string sql = $"select * from T_Books WHERE Bname = '{SeachText.Text}'";
            MySqlDataReader reader = Dao.Instance.read(sql);
            while (reader.Read())
            {
                dataTables.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                    reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString()
                    );
            }
            reader.Close();
            Dao.Instance.DaoClose();
            textID.Text = dataTables.CurrentRow.Cells[0].Value.ToString();
            textName.Text = dataTables.CurrentRow.Cells[1].Value.ToString();
            this.data = dataTables.CurrentRow.Cells
               .Cast<DataGridViewCell>()
               .Select(cell => cell.Value)
               .ToArray();
        }

        private void newSeach_Click(object sender, EventArgs e)
        {
            SeachText.Text = "";
            loadBooks();
        }
    }
}
