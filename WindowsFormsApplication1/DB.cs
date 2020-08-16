using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DB
    {

        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=firstproject"); // параметры сервера(локальный)

        public void OpenConnection() // устанавливаем соединение с БД
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }


        public void CloseConnection() // при выходе прерываем соединение с БД
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection() // возвращает соединение с БД
        {
            return connection;
        }



    }
}
