using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasePracticalJob
{
    class DataBase
    {
        public static List<PaymentClass> GetPayment(string TableName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PaymentClass>("select * from " + TableName, new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveBoughtGames(string TableName, BoughtGames Bg)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into BoughtGames values (@ID, @Name)", Bg);
            }
        }
        private static string LoadConnectionString(string id = "praktikosDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
