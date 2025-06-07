using System;
using System.Collections.Generic;
// 这是SQL Server驱动程序的命名空间 但这这里我使用的是MySQL驱动程序
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// MySQL驱动程序的命名空间 需要在NuGet添加包 Install-Package MySql.Data
// NuGet打开流程-工具-NuGet包管理器-程序包管理器控制台-输入上面代码回车下载
using MySql.Data.MySqlClient;
//namespace _01studyBooks
//{
//    internal class Dao
//    {
//        SqlConnection sc; // sql链接对象
//        public SqlConnection connect() //链接sql
//        {
//            //string str = @"Data Source=.;Initial Catalog=booklibrary;Integrated Security=True"; //连接串
//            //string str = @"Data Source=.;Initial Catalog=booklibrary;Integrated Security=True";
//            //string str = @"Data Source=.;Initial Catalog=booklibrary;Integrated Security=True";
//            string str = "server=localhost;port=3306;user=root;password=123456;database=books;";
//            sc = new SqlConnection(str);
//            sc.Open();
//            return sc;
//        }
//        public SqlCommand command(string sql) // 执行一条sql
//        {
//            SqlCommand cmd = new SqlCommand(sql, connect());
//            return cmd;
//        }
//        public int Execute(string sql) //获取执行状态结果
//        {
//            return command(sql).ExecuteNonQuery();
//        }
//        public SqlDataReader read(string sql) // 读取数据库数据
//        {
//            return command(sql).ExecuteReader();
//        }
//        public void DaoClose() // 关闭数据库
//        {
//            sc.Close();
//        }
//    }
//}
namespace _01studyBooks
{
    public class Dao
    {
        private static Dao _Instance = null;
        public static Dao Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Dao();
                }
                return _Instance;
            }
        }
        MySqlConnection sc; // MySQL连接对象

        public MySqlConnection connect()
        {
            // MySQL 连接字符串
            string str = "Server=localhost;Database=booklibrary;User ID=root;Password=123456;Allow User Variables=True;";
            sc = new MySqlConnection(str);
            sc.Open();
            return sc;
        }

        public MySqlCommand command(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        public MySqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

        public void DaoClose()
        {
            sc.Close();
        }
    }
}