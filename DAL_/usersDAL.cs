using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO_;
using MySqlConnector;

namespace DAL_
{
    public class usersDAL
    {
        public static int insertDB(userDAO user)
        {
            MySqlConnection conn = DBConnectionDAL.Connect();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (FIRST_NAME,MIDDLE_INITIAL, LAST_NAME, ADDRESS," +
                "SUITE,ZIP_CODE_ID,EMAIL,HOME_PHONE,MOBILE_PHONE,FACEBOOK,PHOTO_LINK,SSN,USER_NAME,PASSWORD,USER_TYPE" +
                ",TWITTER,OFFICE_HOUR_ACCESS,OTHER_NAME,CARRIER,COUNTRY_CODE)" +
                " VALUES (@fn, @middel_initial, @ln, @address,@suite,@zip_code,@email,@home_phone,@mobile_phone,@fb" +
                ",@pt_link,@ssn,@user_name,@pw,@user_type,@twitter,@of_hour_access,@other_name,@car,@country_code); SELECT LAST_INSERT_ID();", conn);
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = user.first_name;
            command.Parameters.Add("@middel_initial", MySqlDbType.VarChar).Value = user.middleInitial;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = user.last_name;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = user.address;
            command.Parameters.Add("@suite", MySqlDbType.VarChar).Value = user.suite;
            command.Parameters.Add("@zip_code", MySqlDbType.VarChar).Value = user.zipCodeId;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = user.email;
            command.Parameters.Add("@home_phone", MySqlDbType.VarChar).Value = user.homePhone;
            command.Parameters.Add("@mobile_phone", MySqlDbType.VarChar).Value = user.mobilePhone;
            command.Parameters.Add("@fb", MySqlDbType.VarChar).Value = user.facebook;

            command.Parameters.Add("@pt_link", MySqlDbType.VarChar).Value = user.photoLink;
            command.Parameters.Add("@ssn", MySqlDbType.VarChar).Value = user.ssn;
            command.Parameters.Add("@user_name", MySqlDbType.VarChar).Value = user.userName;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = user.password;
            command.Parameters.Add("@user_type", MySqlDbType.VarChar).Value = user.userType;

            command.Parameters.Add("@twitter", MySqlDbType.VarChar).Value = user.switter;
            command.Parameters.Add("@of_hour_access", MySqlDbType.VarChar).Value = user.officeHouerAccess;
            command.Parameters.Add("@other_name", MySqlDbType.VarChar).Value = user.otherName;
            command.Parameters.Add("@car", MySqlDbType.VarChar).Value = user.carrier;
            command.Parameters.Add("@country_code", MySqlDbType.VarChar).Value = user.countryCode;

            
                
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                
                conn.Open();
            }
            int lastId;
            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                lastId = (Int32)command.LastInsertedId;
                Console.WriteLine("last id " + lastId);
                return lastId;
            }
            else
            {
                lastId = 0;
                conn.Close();
                return lastId;
            }


        }
        public static bool reset()
        {
            MySqlConnection conn = DBConnectionDAL.Connect();
            MySqlCommand command = new MySqlCommand("DELETE FROM users", conn);
            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        public static void delColbyId(string tabName, string colName)
        {
            string strCommand = "ALTER TABLE " + tabName + " DROP COLUMN " + colName + ";";
            Console.WriteLine(strCommand);
            MySqlConnection conn = DBConnectionDAL.Connect();
            conn.Open();
            MySqlCommand command = new MySqlCommand(strCommand, conn);
            
            try
            {
                if(command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("delete done");
                    conn.Close();
                }
                else
                {
                    Console.WriteLine("not delete");
                    conn.Close();
                }
                
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                Console.WriteLine("not deleted");
                conn.Close();
            }
        }
        public static void addColumnName(String tableName, string colname, String dataType)
        {
            String strCommand = "ALTER TABLE " + tableName + " ADD COLUMN " + colname + " VARCHAR(30) NULL AFTER USER_ID;";
            Console.WriteLine(strCommand);
            MySqlConnection conn = DBConnectionDAL.Connect();
            Console.WriteLine("ALTER TABLE " + tableName + " ADD COLUMN " + colname + " VARCHAR(30) NULL AFTER USER_ID;");
            /*MySqlCommand command = new MySqlCommand("ALTER TABLE "+tableName+" ADD COLUMN " + colname +" "+ dataType +" NULL AFTER USER_ID;", conn);*/
            MySqlCommand command = new MySqlCommand(strCommand, conn);
            conn.Open();
            try
            {

                if (command.ExecuteNonQuery() == 1)
                {
                    conn.Close();
                }
                else
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Column " + colname + " is exist");
            }


        }
    }
}
