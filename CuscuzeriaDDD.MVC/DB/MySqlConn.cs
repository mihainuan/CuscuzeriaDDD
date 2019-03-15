using MySql.Data.MySqlClient;
using System.Data;

namespace Cuscuzeria.MVC.DB
{
    public class MySqlConn
    {
        public MySqlConnection conn;

        public MySqlConn()
        {
            string connStr = "Server=localhost;userid=root;password=mihai;database=CuscuzeriaDB;";
            conn = new MySqlConnection(connStr);
            conn.Open();
        }

        public DataTable GetData(string _sqlCmd)
        {

        }
    }
}
