using _01studyBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//接口/依赖注入模式
namespace _01studyBooks
{

    public interface IRequestService
    {
        void Add(string[] msgList, string data, string table, Action<bool, string> callback);
        void Delete(string[] msgList, string condition, string table, Action<bool, string> callback);
        void Update(string[] msgList, string condition, string updateData, string table, Action<bool, string> callback);
        void Get(string table, Action<bool, string> callback);
    }

    public class InterFaceRequest : IRequestService
    {
        private readonly Dao _dao;

        // 通过构造函数注入 Dao
        public InterFaceRequest(Dao dao)
        {
            _dao = dao;
        }

        public void Add(string[] msgList, string data, string table, Action<bool, string> callback)
        {
            _dao.connect();
            string sql = $"INSERT INTO {table} VALUES({data})";
            int result = _dao.Execute(sql);
            _dao.DaoClose();

            bool success = result > 0;
            string message = success ? msgList[0] : msgList[1];
            callback?.Invoke(success, message);
        }

        public void Delete(string[] msgList, string condition, string table, Action<bool, string> callback)
        {
            _dao.connect();
            string sql = $"DELETE FROM {table} WHERE {condition}";
            int result = _dao.Execute(sql);
            _dao.DaoClose();

            bool success = result > 0;
            string message = success ? msgList[0] : msgList[1];
            callback?.Invoke(success, message);
        }

        public void Update(string[] msgList, string condition, string updateData, string table, Action<bool, string> callback)
        {
            _dao.connect();
            string sql = $"SELECT * FROM {table} WHERE {condition}";
            var reader = _dao.read(sql);

            if (reader.Read())
            {
                reader.Close();
                sql = $"UPDATE {table} SET {updateData} WHERE {condition}";
                int result = _dao.Execute(sql);
                _dao.DaoClose();

                bool success = result > 0;
                string message = success ? msgList[0] : msgList[1];
                callback?.Invoke(success, message);
            }
            else
            {
                reader.Close();
                _dao.DaoClose();
                callback?.Invoke(false, msgList[1]);
            }
        }

        public void Get(string table, Action<bool, string> callback)
        {
            _dao.connect();
            string sql = $"SELECT * FROM {table}";
            var reader = _dao.read(sql);
            bool hasData = reader.HasRows;
            reader.Close();
            _dao.DaoClose();

            callback?.Invoke(hasData, hasData ? "查询成功" : "无数据");
        }
    }

    //调用示例
    public class Demo
    {
        private readonly InterFaceRequest _request;

        public Demo(InterFaceRequest requestService)
        {
            _request = requestService;
        }

        public void AddBook()
        {
            _request.Add(new[] { "添加成功", "添加失败" }, "'1','C#入门经典'", "books", (success, msg) =>
            {
                Console.WriteLine(msg);
            });
        }
    }
}

