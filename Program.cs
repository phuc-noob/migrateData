using Baseline.ImTools;

using System;
using System.Data;

namespace ExampleSample
{
   public class Program
   {
      [STAThread]
      private static void Main(string[] args)
      {
            ConvertToDB.reset();

            DataTable dataTableSource = MongoDB.Instance.Gets("patient");

            User user = new User();
            for(int i = 0; i < dataTableSource.Rows.Count; i++)
            {
                user.first_name = dataTableSource.Rows[i]["FName"].ToString();
                user.last_name = dataTableSource.Rows[i]["LName"].ToString();
                user.middleInitial = dataTableSource.Rows[i]["MiddleI"].ToString();
                user.address = dataTableSource.Rows[i]["Address"].ToString();
                user.homePhone = dataTableSource.Rows[i]["HmPhone"].ToString();
                user.mobilePhone = dataTableSource.Rows[i]["WirelessPhone"].ToString();
                user.facebook = "";
                user.suite = "";
                Console.WriteLine(dataTableSource.Rows[i]["Zip"].ToString());
                
                if (int.TryParse(dataTableSource.Rows[i]["Zip"].ToString(),out int a)) { user.zipCodeId = int.Parse(dataTableSource.Rows[i]["Zip"].ToString());}
                user.photoLink = dataTableSource.Rows[i]["HmPhone"].ToString();
                user.ssn = "";
                user.email = "";
                user.userName = "";
                user.password = "";
                user.userType = "";
                user.userName = "";
                user.otherName = "";



                if (ConvertToDB.insertDB(user))
                {
                    Console.WriteLine("done");
                }
                else
                {
                    Console.WriteLine("fail");
                }
            }   
            
        }
   }
}