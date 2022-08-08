using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_
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
