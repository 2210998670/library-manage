using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01studyBooks
{
    public class ClobalFunc
    {
        private static ClobalFunc _Instance = null;
        public static ClobalFunc Instance
        {
            get 
            {
                if (_Instance == null)
                {
                    _Instance = new ClobalFunc();
                }
                return _Instance;
            }
        }
        public string Name = "";
        public static void DaoSql()
        {
            // 这里可以添加一些全局的数据库操作方法
            // 例如连接数据库、执行查询等
            Dao dao = new Dao();
        }
    }
}
