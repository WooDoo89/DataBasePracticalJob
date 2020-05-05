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
    public partial class MainAdmin : Form
    {
        List<Client> clients = new List<Client>();
        List<Order> orders = new List<Order>();
        List<Admin> admins = new List<Admin>();
        List<Instructor> instructors = new List<Instructor>();
        List<Pilot> pilots = new List<Pilot>();
        List<Plane> planes = new List<Plane>();
        List<Schedule> schedules = new List<Schedule>();
        List<Equipment> equipments = new List<Equipment>();
        List<JumpType> jumpType = new List<JumpType>();
        List<string> dateList = new List<string>();
        List<string> equipmentList = new List<string>();
        List<string> ordertList = new List<string>();
        DateTime TodayDate = DateTime.Today;
        public MainAdmin()
        {
            InitializeComponent();
            UpdateData();
            FillData();
            RefreshDateList();
            RefreshEquipmentList();
            RefreshOrderList();
        }
        private void FillData()
        {

            idLabel.Text = Convert.ToString(State.ActiveWorker.ID);
            nameLabel.Text = Convert.ToString(State.ActiveWorker.name);
            lastnameLabel.Text = Convert.ToString(State.ActiveWorker.surname);
            usernameLabel.Text = Convert.ToString(State.ActiveWorker.username);
            emailLabel.Text = Convert.ToString(State.ActiveWorker.email);
            numberLabel.Text = Convert.ToString(State.ActiveWorker.mobileNumber);
            dateTimePicker1.MinDate = TodayDate;

            for (int i = 0; i < orders.Count; i++)
            {
                ordertList.Add("Orders ID: " + orders[i].ID + "\nCoupon: " + orders[i].coupon + "\nSelected date: " + schedules[orders[i].schedule].ID + " " + schedules[orders[i].schedule].date
                    + "\nStatus: " + orders[i].status + "\nPeople number: " + orders[i].peopleNumber + "\nJump type: " + jumpType[orders[i].jumpType].type
                    + "\nEquipment: " + equipments[orders[i].equipment].ID + " " + equipments[orders[i].equipment].filming + " " + equipments[orders[i].equipment].photographing
                    + " " + equipments[orders[i].equipment].price);
                ordertList.Add("-----------------------------------------------");
            }

            for (int i = 0; i < schedules.Count; i++)
            {
                dateList.Add(schedules[i].ID + " " + schedules[i].date);
            }

            for (int i = 0; i < equipments.Count; i++)
            {
                equipmentList.Add(equipments[i].ID + " " + equipments[i].filming + " " + equipments[i].photographing + " " + equipments[i].price);
            }

            for (int i = 0; i < clients.Count; i++)
            {
                checkedClients.Items.Add(Convert.ToString(clients[i].ID + " " + clients[i].name + " " + clients[i].surname));
            }

            for (int i = 0; i < instructors.Count; i++)
            {
                checkedInstructors.Items.Add(Convert.ToString(instructors[i].ID + " " + instructors[i].name + " " + instructors[i].surname));
            }

            for (int i = 0; i < pilots.Count; i++)
            {
                checkedPilots.Items.Add(Convert.ToString(pilots[i].ID + " " + pilots[i].name + " " + pilots[i].surname));
            }

            for (int i = 0; i < pilots.Count; i++)
            {
                comboPilot.Items.Add(pilots[i].name + " " + pilots[i].surname);
            }

            for (int i = 0; i < instructors.Count; i++)
            {
                comboInstructor.Items.Add(instructors[i].name + " " + instructors[i].surname);
            }

            for (int i = 0; i < planes.Count; i++)
            {
                comboPlane.Items.Add(planes[i].type);
            }

            for (int i = 0; i < planes.Count; i++)
            {
                checkedPlanes.Items.Add(Convert.ToString(planes[i].ID + " " + planes[i].type + " " + planes[i].place));
            }

        }

        private void UpdateData()
        {

            clients = DataBase.GetClient();
            admins = DataBase.GetAdmin();
            instructors = DataBase.GetInstructor();
            pilots = DataBase.GetPilot();
            planes = DataBase.GetPlane();
            schedules = DataBase.GetSchedule();
            equipments = DataBase.GetEquipment();
            orders = DataBase.GetOrder();
            jumpType = DataBase.GetJumpType();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToShortDateString();

            if (Convert.ToString(comboPilot.SelectedItem) == "" || Convert.ToString(comboPlane.SelectedItem) == "" || Convert.ToString(comboInstructor.SelectedItem) == "")
            {
                MessageBox.Show("Please check if all data is correct");
            }
            else
            {

                Schedule newSchedule = new Schedule();
                newSchedule.ID = schedules.Count;
                newSchedule.admin = 0;
                newSchedule.plane = comboPlane.SelectedIndex;
                newSchedule.pilot = comboPilot.SelectedIndex;
                newSchedule.client = 0;
                newSchedule.instructor = comboInstructor.SelectedIndex;
                newSchedule.date = theDate;
                DataBase.SaveSchedule(newSchedule);
                dateList.Add(newSchedule.ID + " " + theDate);
                RefreshDateList();
                UpdateData();

            }
        }
        private void RefreshDateList()
        {
            scheduleListBox.Items.Clear();
            scheduleListBox.Items.AddRange(dateList.ToArray());
        }
        private void RefreshEquipmentList()
        {
            equipmentListBox.Items.Clear();
            equipmentListBox.Items.AddRange(equipmentList.ToArray());
        }
        private void RefreshOrderList()
        {
            orderListBox.Items.Clear();
            orderListBox.Items.AddRange(ordertList.ToArray());
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedSchedule_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void profileTab_Click(object sender, EventArgs e)
        {

        }

        private void clientsTab_Click(object sender, EventArgs e)
        {

        }

        private void checkedClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedPilots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void equipmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scheduleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboPlane_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
