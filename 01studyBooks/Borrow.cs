using MySql.Data.MySqlClient;
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
    public partial class Borrow : Form
    {
        public Borrow()
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
            label3.Text = dataTables.CurrentRow.Cells[1].Value.ToString();
            //textID.Text = dataTables.CurrentRow.Cells[0].Value.ToString();
            //this.data = dataTables.CurrentRow.Cells
            //   .Cast<DataGridViewCell>()
            //   .Select(cell => cell.Value)
            //   .ToArray();

        }
        private void dataTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            loadBooks();
        }

        private void dataTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //loadBooks();
            if (dataTables.CurrentRow == null || dataTables.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选中无效数据！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            label3.Text = "";
            label3.Text += dataTables.CurrentRow.Cells[1].Value.ToString();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string name = dataTables.CurrentRow.Cells[1].Value.ToString();
            int id = int.Parse(dataTables.CurrentRow.Cells[0].Value.ToString());
            int num = int.Parse(comboBox1.Text);
            DateTime data = DateTime.Now;
            int key = 1;
            Dao.Instance.connect();
            //string sql = $"select `[Key]` from T_Borrow where `[Key]` = '{key}'";
            //MySqlDataReader reader = Dao.Instance.read(sql);
            //reader.Read();
            //while (true)
            //{
            //    sql = $"select `[Key]` from T_Borrow where `[Key]` = '{key}'";
            //    reader.Read();
            //    key += 1;
            //    if (reader.Read() == false)
            //    {
            //        break;
            //    }
            //}
            //reader.Close();
            string sql = "SELECT MAX(`[Key]`) FROM T_Borrow";
            MySqlDataReader reader = Dao.Instance.read(sql);
            if (reader.Read() && !reader.IsDBNull(0))
            {
                key = reader.GetInt32(0) + 1;
            }
            reader.Close();


            //判断库存是否充足
            string sqlFlag = $"select Bid from T_Books where 0<=Num-'{num}' and Bid = '{id}'";
            MySqlDataReader reader1 = Dao.Instance.read(sqlFlag);
            if (!reader1.Read())
            {
                MessageBox.Show("库存不足！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader1.Close();
                Dao.Instance.DaoClose();
                return;
            }
            string sqlInsert = $"insert into T_Borrow values('{key}','{Form1.ID}','{Form1.UserName}','{id}','{name}','{data}',{num})";
            string sqlUpdata = $"update T_Books set Num=Num-{num},BorrowCount = BorrowCount+{num} where Bid = '{id}'";
            if (Dao.Instance.Execute(sqlInsert) + Dao.Instance.Execute(sqlUpdata) >= 2)
            {
                MessageBox.Show("租借成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reader1.Close();
                Dao.Instance.DaoClose();
                // 重新获取数据
                loadBooks();
            }
            else
            {
                Dao.Instance.DaoClose();
                MessageBox.Show("租借失败！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
