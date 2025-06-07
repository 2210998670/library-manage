using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _01studyBooks
{
    public partial class AddBook : Form
    {
        public object[] data;
        public AddBook()
        {
            InitializeComponent();
        }
        public AddBook(object[] data)
        {
            InitializeComponent();   // 必须在最前面执行！
            this.data = data;


            bookID.Text = data[0]?.ToString();
            Bname.Text = data[1]?.ToString();
            Author.Text = data[2]?.ToString();
            company.Text = data[3]?.ToString();
            dateTime.Text = data[4]?.ToString();
            bookType.Text = data[5]?.ToString();
            price.Text = data[6]?.ToString();
            num.Text = data[7]?.ToString();
            intorduce.Text = data[8]?.ToString();
        }


        private void bName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void addBooks_Click(object sender, EventArgs e)
        {
            if (bookID.Text == "" || Bname.Text == "" || Author.Text == "" || company.Text == "" || dateTime.Text == "" || bookType.Text == "" || price.Text == "" || num.Text == "" || intorduce.Text == "")
            {
                MessageBox.Show("有空项！！！");
                return;
            }


            if (this.data.Length > 0)
            {
                string data = $"Bname='{Bname.Text}',Author='{Author.Text}',Publisher='{company.Text}',PBDate='{dateTime.Value}',Type='{bookType.Text}',Price='{double.Parse(price.Text)}',Num='{int.Parse(num.Text)}',Intorduce='{intorduce.Text}',BorrowCount='{this.data[9]}' where Bid='{int.Parse(bookID.Text)}'";
                string[] msgList = new string[] { "修改成功!", "修改失败，请重试！" };
                string seachdata = $"Bid = {this.data[0]}";
                Request.UpdataApi(msgList, seachdata, data, "T_Books", (success, msg) =>
                {
                    MessageBox.Show(msg);
                    if (success)
                    {
                        this.Hide();
                        bookID.Text = "";
                        Bname.Text = "";
                        Author.Text = "";
                        company.Text = "";
                        dateTime.Text = "";
                        bookType.Text = "";
                        price.Text = "";
                        num.Text = "";
                        intorduce.Text = "";
                    }
                });
                return;
            }
            string data1 = $"'{int.Parse(bookID.Text)}','{Bname.Text}','{Author.Text}','{company.Text}','{dateTime.Value}','{bookType.Text}','{double.Parse(price.Text)}','{int.Parse(num.Text)}','{intorduce.Text}','0'";
            string[] msgList1 = new string[] { "添加成功!", "添加失败，请重试！" };
            Request.AddApi(msgList1, data1, "T_Books", (success, msg) =>
                {
                    MessageBox.Show(msg);
                    if (success)
                    {
                        this.Hide();
                        bookID.Text = "";
                        Bname.Text = "";
                        Author.Text = "";
                        company.Text = "";
                        dateTime.Text = "";
                        bookType.Text = "";
                        price.Text = "";
                        num.Text = "";
                        intorduce.Text = "";
                    }
                });
        }
    }
}
