using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CopyPost
{
    class DataBase
    { 
        private string ConnectStr;
        private MySqlConnection Connection;

        public DataBase()
        {
            ConnectStr = GetConnectionString();
            Connection = new MySqlConnection(ConnectStr);
        }

        private string GetConnectionString()
        {
            string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "root"; // Имя пользователя
            string dbName = "mydb"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = ""; // Пароль для подключения
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port + 
                ";password=" + password + 
                ";SslMode=none" + ";";

            return connStr;
        }

        public static List<SQLParam> AddParam(List<SQLParam> list, string name,  string value)
        {
            SQLParam param = new SQLParam();
            param.name = name;
            param.value = value;

            list.Add(param);

            return list;
        }

        public struct SQLParam
        {
            public string name;
            public string value;
        }

        private string PrepareReqest(string sql, List<SQLParam> param)
        {
            string newSql = sql;

            if(param != null)
            {
                foreach (SQLParam item in param)
                {
                    newSql = newSql.Replace(item.name, item.value);
                }
            }
            return newSql;
        }

        public DataTable SendReqest(string sql, List<SQLParam> param = null)
        {
            Connection.Open();
            sql = PrepareReqest(sql, param);

            MySqlCommand sqlCom = new MySqlCommand(sql, Connection);
            sqlCom.ExecuteNonQuery();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            Connection.Close();
            return dt;
        }

        public void SendReqestNoAnswer(string sql, List<SQLParam> param = null)
        {
            Connection.Open();
            sql = PrepareReqest(sql, param);

            MySqlCommand command = new MySqlCommand(sql, Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }
        
    }
}
