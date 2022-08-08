using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;
using DAO_L;
namespace DAL_L
{
    public class patientDAL
    {
        public bool insertPatientDB(patientDAO pat)
        {
            MySqlConnection conn = DBConnectionDAL.Connect();
            MySqlCommand command = new MySqlCommand("INSERT INTO patient (USER_ID,DOB,NOTE,PATIENT_ID)" +
                " VALUES (@uid,@dob,@note,@pid)", conn);
            command.Parameters.Add("@uid", MySqlDbType.Int64).Value = pat.userId;
            command.Parameters.Add("@dob", MySqlDbType.VarChar).Value = pat.dob;
            command.Parameters.Add("@note", MySqlDbType.VarChar).Value = pat.note;
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = pat.patientId;

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
    }
}
