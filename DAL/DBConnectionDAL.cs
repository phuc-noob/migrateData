using System;
using System.Data;
using MySqlConnector;

namespace DAL
{ 
    public class DBConnectionDAL
    {
        public static MySqlConnection Connect()
        {

            String myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=00000000;database=test";
            return new MySqlConnection(myConnectionString);

        }
    }
}
