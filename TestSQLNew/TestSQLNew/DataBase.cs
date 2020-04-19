using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQLNew
{
    class DataBase
    {
        MySqlConnection Connect = new MySqlConnection("server=localhost;port=3306;username=root;database=justoleg");

        public void OpenConnection()
        {
            if (Connect.State == System.Data.ConnectionState.Closed) // если мы не подключены
                Connect.Open(); // то подключаемся
        }

        public void CloseConnection()
        {
            if (Connect.State == System.Data.ConnectionState.Open)
                Connect.Close(); 
        }

        public MySqlConnection GetConnect()
        {
            return Connect;
        }

    }
}
