using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _01studyBooks
{
    public class Request
    {
        private static Dao dao = Dao.Instance;
        // 单例封装请求
        private static Request request = null;
        public static Request Instance
        {
            get
            {
                if (request == null)
                {
                    request = new Request();
                }
                return request;
            }
        }
        //添加                                消息提示状态     添加参数      添加表           成功或者失败回调  
        public static void AddApi(string[] msgList, string data, string tables, Action<bool, string> callback)
        {
            dao.connect(); // 连接数据库

            string sqlNew = $"insert into {tables} values({data})";
            int result = dao.Execute(sqlNew); // 关键：用正确的 SQL 去执行

            string message = result > 0 ? msgList[0] : msgList[1];
            bool success = result > 0;

            dao.DaoClose(); // 释放连接
            callback?.Invoke(success, message);
        }
        //删除                                消息提示状态     添加参数      添加表           成功或者失败回调  
        public static void deleteApi(string[] msgList, string data, string tables, Action<bool, string> callback)
        {
            dao.connect(); // 连接数据库

            string sqlNew = $"DELETE FROM {tables} WHERE {data}";
            int result = dao.Execute(sqlNew);

            string message = result > 0 ? msgList[0] : msgList[1];
            bool success = result > 0;
            dao.DaoClose(); // 释放连接
            callback?.Invoke(success, message);
        }
        //修改                                消息提示状态         添加查询参数         更新参数               添加表           成功或者失败回调  
        public static void UpdataApi(string[] msgList, string seachdata, string updata, string tables, Action<bool, string> callback)
        {
            dao.connect(); // 连接数据库

            string sqlNew = $"select * from {tables} where {seachdata}";
            var reader = dao.read(sqlNew);
            if (reader.Read())
            {
                reader.Close();
                sqlNew = $"update {tables} set {updata}";
                int result = dao.Execute(sqlNew);
                string message = result > 0 ? msgList[0] : msgList[1];
                bool success = result > 0;
                dao.DaoClose(); // 释放连接
                callback?.Invoke(success, message);
            }
        }
        //查询
        public static void GetApi(string tables, Action<bool, string> callback)
        {
            dao.connect(); // 连接数据库

            string sqlNew = $"select * from {tables}";
            MySqlDataReader reader = dao.read(sqlNew);
            while (reader.Read())
            {

            }
        }

    }
}
