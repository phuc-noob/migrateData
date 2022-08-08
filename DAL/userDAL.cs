using System;
using System.Data;


using MySqlConnector;
using DAO_L;
namespace DAL
{

    public class userDAL
    {
        public static int insertDB(userDAO user)
        {
            MySqlConnection conn = DBConnectionDAL.Connect();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (FIRST_NAME,MIDDLE_INITIAL, LAST_NAME, ADDRESS," +
                "SUITE,ZIP_CODE_ID,EMAIL,HOME_PHONE,MOBILE_PHONE,FACEBOOK,PHOTO_LINK,SSN,USER_NAME,PASSWORD,USER_TYPE" +
                ",TWITTER,OFFICE_HOUR_ACCESS,OTHER_NAME,CARRIER,COUNTRY_CODE,DoB,Patient_ID,IMG_FOLDER)" +
                "OUTPUT Inserted.ID VALUES (@fn, @middel_initial, @ln, @address,@suite,@zip_code,@email,@home_phone,@mobile_phone,@fb" +
                ",@pt_link,@ssn,@user_name,@pw,@user_type,@twitter,@of_hour_access,@other_name,@car,@country_code,@dob,@paid,@imgf)", conn);
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

            command.Parameters.Add("@dob", MySqlDbType.VarChar).Value = user.DoB;
            command.Parameters.Add("@paid", MySqlDbType.VarChar).Value = user.patientId;
            command.Parameters.Add("@imgf", MySqlDbType.VarChar).Value = user.imgFolder;

            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return (int)command.ExecuteScalar();
            }
            else
            {
                conn.Close();
                return (int)command.ExecuteScalar(); ;
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
            MySqlCommand command = new MySqlCommand(strCommand, conn);
            conn.Open();
            try
            {
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
                Console.WriteLine("not deleted");
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
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Column " + colname + " is exist");
            }


        }
    }

}
