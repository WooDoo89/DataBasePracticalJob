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
                cnn.Execute("insert into Schedule values (@ID, @client, @instructor ,@admin, @plane, @pilot, @date)", cl);
            }
        }
        public static List<Equipment> GetEquipment()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Equipment>("select * from Equipment", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveEquipment(Equipment cl)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Equipment values (@ID, @admin, @filming, @photographing, @price)", cl);
            }
        }
        public static List<JumpType> GetJumpType()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<JumpType>("select * from JumpType", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<Order> GetOrder()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Order>("select * from Orders", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveOrder(Order cl)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Orders values (@ID, @admin, @coupon, @schedule, @jumpType, @equipment, @peopleNumber, @status)", cl);
            }
        }
        public static List<Coupon> GetCoupon()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Coupon>("select * from Coupon", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveCoupon(Coupon cl)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Coupon values (@ID, @admin, @code)", cl);
            }
        }
        public static void UpdateOrder(UpdateOrder u)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Orders set status = @status where ID = @ID", u);
            }
        }
        public static List<Review> GetReview()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Review>("select * from Review", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveReview(Review cl)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Review values (@ID, @order, @instructor, @jump)", cl);
            }
        }
        public static void UpdateSchedule(UpdateSchedule u)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Schedule set client = @client where date = @date", u);
            }
        }
    }
}
