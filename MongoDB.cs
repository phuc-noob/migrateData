using Migration.Utils;

namespace ExampleSample
{
   public class MongoDB
   {
      private static MongoDatabase _instance;

      public static MongoDatabase Instance
      {
         get
         {
            if (_instance == null)
            {
               _instance = new MongoDatabase(
                  "localhost" ,      // host
                  "27017",          // port
                  "",               // userName
                  "",               // password
                 "OD21_baliga"      // db name
               );
               Instance.OpenConnection();
            }
            return _instance;
         }
      }
   }
}