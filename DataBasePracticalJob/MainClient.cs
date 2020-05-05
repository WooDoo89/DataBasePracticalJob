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
    public partial class MainClient : Form
    {
        List<Admin> admins = new List<Admin>();
        List<JumpType> jumpTypes = new List<JumpType>();
        List<Instructor> instructors = new List<Instructor>();
        List<Pilot> pilots = new List<Pilot>();
        List<Plane> planes = new List<Plane>();
        List<Schedule> schedules = new List<Schedule>();
        List<Equipment> equipments = new List<Equipment>();
        List<Order> orders = new List<Order>();

        public MainClient()
        {
            InitializeComponent();
            UpdateData();
            ShowData();
        }

        private void UpdateData()
        {
            admins = DataBase.GetAdmin();
            instructors = DataBase.GetInstructor();
            pilots = DataBase.GetPilot();
            planes = DataBase.GetPlane();
            schedules = DataBase.GetSchedule();
            equipments = DataBase.GetEquipment();
            //orders = DataBase.GetOrder();
        }

        private void ShowData()
        {
            idLabel.Text = Convert.ToString(State.ActiveClient.ID);
            nameLabel.Text = Convert.ToString(State.ActiveClient.name);
            lastnameLabel.Text = Convert.ToString(State.ActiveClient.surname);
            usernameLabel.Text = Convert.ToString(State.ActiveClient.username);
            emailLabel.Text = Convert.ToString(State.ActiveClient.email);
            numberLabel.Text = Convert.ToString(State.ActiveClient.mobileNumber);
            weightLabel.Text = Convert.ToString(State.ActiveClient.weight) + "kg";
            heightLabel.Text = Convert.ToString(State.ActiveClient.height) + "cm";

            for (int i = 0; i < jumpTypes.Count; i++)
            {
                comboJumpType.Items.Add(jumpTypes[i].type);
            }
            for (int i = 0; i < schedules.Count; i++)
            {
                comboDate.Items.Add(schedules[i].date);
            }
            for (int i = 0; i < equipments.Count; i++)
            {
                if(i == 0)
                    comboEquipment.Items.Add("");
                if (equipments[i].photographing == null)
                    comboEquipment.Items.Add("Video: " + equipments[i].filming + " " + "Price: " + equipments[i].price);
                else if (equipments[i].filming == null)
                    comboEquipment.Items.Add("Photo: " + equipments[i].photographing + " " + "Price: " + equipments[i].price);
                else
                    comboEquipment.Items.Add("Video: " + equipments[i].filming + " " + "Photo: " + equipments[i].photographing + " " + "Price: " + equipments[i].price);
            }

        }

        private void ShowInfo()
        {
            instructorLabel.Visible = true;
            planeLabel.Visible = true;
            pilotLabel.Visible = true;
            State.ActiveSchedule = schedules[comboDate.SelectedIndex];
            instructorNameLabel.Text = instructors[State.ActiveSchedule.instructor].name;
            instructorSurnameLabel.Text = instructors[State.ActiveSchedule.instructor].surname;
            pilotNameLabel.Text = pilots[State.ActiveSchedule.pilot].name;
            pilotSurnameLabel.Text = pilots[State.ActiveSchedule.pilot].surname;
            planeTypeLabel.Text = planes[State.ActiveSchedule.plane].type;
        }

        private void profileTab_Click(object sender, EventArgs e)
        {

        }

        private void couponNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            //if (Convert.ToString(comboDate.SelectedItem) == "" || Convert.ToString(comboJumpType.SelectedItem) == "")
            //{
            //    MessageBox.Show("Please check if all data is correct");
            //}
            //else
            //{

            //    Order newOrder = new Order();
            //    if(comboEquipment.SelectedItem != null)
            //        newOrder.equipment = comboEquipment.SelectedIndex;
            //    if(couponNumber.Text != null)
            //        newOrder.coupon = Convert.ToInt32(couponNumber.Text);
            //    newOrder.ID = orders.Count;
            //    newOrder.admin = 0;
            //    newOrder.plane = planes[State.ActiveSchedule.plane].ID;
            //    newOrder.pilot = pilots[State.ActiveSchedule.pilot].ID;
            //    newOrder.client = State.ActiveClient.ID;
            //    newOrder.instructor = instructors[State.ActiveSchedule.instructor].ID;
            //    newOrder.schedule = comboDate.SelectedIndex;
            //    newOrder.jumpType = comboJumpType.SelectedIndex;
            //    newOrder.status = "Confirming";
            //    newOrder.peopleNumber = 0;
            //    DataBase.SaveOrder(newOrder);
            //    UpdateData();
            //}
        }
    }
}
