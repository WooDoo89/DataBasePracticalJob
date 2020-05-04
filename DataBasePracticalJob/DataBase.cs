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
        public static List<Client> GetClient()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Client>("select * from Client", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Admin> GetAdmin()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Admin>("select * from Admin", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Instructor> GetInstructor()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Instructor>("select * from Instructor", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Pilot> GetPilot()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Pilot>("select * from Pilot", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveClient(Client cl)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Client values (@ID, @admin, @username, @password, @name, @surname, @email, @mobileNumber, @weight, @height)", cl);
            }
        }
        private static string LoadConnectionString(string id = "praktikosDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public static List<Plane> GetPlane()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Plane>("select * from Plane", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Schedule> GetSchedule()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Schedule>("select * from Schedule", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveSchedule(Schedule cl)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Schedule values (@ID, @admin, @client,  @instructor, @pilot, @plane, @date)", cl);
            }
        }
    }
}
