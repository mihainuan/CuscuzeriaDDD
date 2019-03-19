extern alias MySqlConnectorAlias;

using MySql.Data.MySqlClient;
using System.Data;

namespace Cuscuzeria.MVC.DB
{
    public class ConnDb
    {
        private string connString = "Server=localhost;userid=root;password=mihai;database=CuscuzeriaDB;";
        public MySqlConnection mysqlconnection;

        public ConnDb()
        {
            mysqlconnection = new MySqlConnection(connString);
            mysqlconnection.Open();
        }

        public DataTable GetData(string _sqlCmd)
        {
            MySqlConnection mySqlConn = new MySqlConnection(connString);
            MySqlCommand command = new MySqlCommand(_sqlCmd, mySqlConn);
            command.Connection = mySqlConn;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        public void ExecuteQuery(string _sqlCommand)
        {
            MySqlCommand command = new MySqlCommand("", mysqlconnection);
            command.CommandText = _sqlCommand;
            command.CommandType = CommandType.Text;
            command.Connection = mysqlconnection;
            command.ExecuteNonQuery();
        }
    }
}
