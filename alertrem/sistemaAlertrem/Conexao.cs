using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemaAlertrem
{
    class Conexao
    {
        private static string connString = "Server=10.23.49.30; port=3306; uid=alertrem; pwd=alertrem; database=db_alertrem";
        //private static string connString = "Server=127.0.0.1; port=3306; uid=alertrem; pwd=alertrem; database=db_alertrem";
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
            }
            catch (MySqlException)
            {
                conn = null;
            }
            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public static bool testarConexao()
        {
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }
    }
}
