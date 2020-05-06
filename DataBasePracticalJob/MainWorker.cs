using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBasePracticalJob
{
    public partial class MainWorker : Form
    {
        List<Order> orders = new List<Order>();
        List<Schedule> schedules = new List<Schedule>();
        List<Equipment> equipments = new List<Equipment>();
        List<JumpType> jumpType = new List<JumpType>();
        List<Instructor> instructors = new List<Instructor>();
        List<Pilot> pilots = new List<Pilot>();
        List<Plane> planes = new List<Plane>();
        List<Coupon> coupones = new List<Coupon>();
        List<string> ordertList = new List<string>();
        List<string> dateList = new List<string>();
        public MainWorker()
        {
            InitializeComponent();
            UpdateData();
            FillData();
            RefreshDateList();
            RefreshDateList();
        }
        private void UpdateData()
        {
            orders = DataBase.GetOrder();
            schedules = DataBase.GetSchedule();
            equipments = DataBase.GetEquipment();
            jumpType = DataBase.GetJumpType();
            instructors = DataBase.GetInstructor();
            pilots = DataBase.GetPilot();
            planes = DataBase.GetPlane();
            coupones = DataBase.GetCoupon();
        }
        private void FillData()
        {
            idLabel.Text = Convert.ToString(State.ActiveWorker.ID);
            nameLabel.Text = Convert.ToString(State.ActiveWorker.name);
            lastnameLabel.Text = Convert.ToString(State.ActiveWorker.surname);
            usernameLabel.Text = Convert.ToString(State.ActiveWorker.username);
            emailLabel.Text = Convert.ToString(State.ActiveWorker.email);
            numberLabel.Text = Convert.ToString(State.ActiveWorker.mobileNumber);

            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].coupon == 0)
                {
                    ordertList.Add("Orders ID: " + orders[i].ID + ", Coupon: No coupon, Selected date: " + schedules[orders[i].schedule].ID + " " + schedules[orders[i].schedule].date
                        + ", Status: " + orders[i].status + ", People number: " + orders[i].peopleNumber + ", Jump type: " + jumpType[orders[i].jumpType].type
                        + ", Equipment: " + equipments[orders[i].equipment].ID + " " + equipments[orders[i].equipment].filming + " " + equipments[orders[i].equipment].photographing
                        + " " + equipments[orders[i].equipment].price);
                    ordertList.Add("-----------------------------------------------");
                }
                else
                {
                    ordertList.Add("Orders ID: " + orders[i].ID + ", Coupon: " + coupones[orders[i].coupon].code + ", Selected date: " + schedules[orders[i].schedule].ID + " " + schedules[orders[i].schedule].date
                        + ", Status: " + orders[i].status + ", People number: " + orders[i].peopleNumber + ", Jump type: " + jumpType[orders[i].jumpType].type
                        + ", Equipment: " + equipments[orders[i].equipment].ID + " " + equipments[orders[i].equipment].filming + " " + equipments[orders[i].equipment].photographing
                        + " " + equipments[orders[i].equipment].price);
                    ordertList.Add("-----------------------------------------------");
                }
            }

            for (int i = 0; i < schedules.Count; i++)
            {
                dateList.Add("Schedule ID: " + schedules[i].ID + ", Date: " + schedules[i].date + ", Instructor: " + instructors[schedules[i].instructor].name
                    + " " + instructors[schedules[i].instructor].surname + ", Pilot: " + pilots[schedules[i].pilot].name + " " + pilots[schedules[i].pilot].surname
                    + ", Plane: " + planes[schedules[i].plane].type);
                dateList.Add("-----------------------------------------------");
            }
        }
        private void MainWorker_Load(object sender, EventArgs e)
        {

        }
        private void RefreshOrderList()
        {
            orderListBox.Items.Clear();
            orderListBox.Items.AddRange(ordertList.ToArray());
        }
        private void RefreshDateList()
        {
            scheduleListBox.Items.Clear();
            scheduleListBox.Items.AddRange(dateList.ToArray());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
