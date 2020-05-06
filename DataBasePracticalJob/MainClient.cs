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
        List<Coupon> coupones = new List<Coupon>();
        List<Review> reviews = new List<Review>();
        List<string> ordertList = new List<string>();
        List<int> ids = new List<int>();
        public MainClient()
        {
            InitializeComponent();
            UpdateData();
            ShowData();
            UpdateOrderData();
        }
        private void RefreshOrderList()
        {
            orderListBox.Items.Clear();
            orderListBox.Items.AddRange(ordertList.ToArray());
        }
        private void UpdateOrderData()
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (schedules[orders[i].schedule].client == State.ActiveClient.ID && orders[i].status == "Completed")
                {
                    if (orders[i].coupon == 0)
                    {
                        ordertList.Add("Orders ID: " + orders[i].ID + ", Coupon: No coupon, Selected date: " + schedules[orders[i].schedule].ID + " " + schedules[orders[i].schedule].date
                            + ", Status: " + orders[i].status + ", People number: " + orders[i].peopleNumber + ", Jump type: " + jumpTypes[orders[i].jumpType].type
                            + ", Equipment: " + equipments[orders[i].equipment].ID + " " + equipments[orders[i].equipment].filming + " " + equipments[orders[i].equipment].photographing
                            + " " + equipments[orders[i].equipment].price);
                    }
                    else
                    {
                        ordertList.Add("Orders ID: " + orders[i].ID + ", Coupon: " + coupones[orders[i].coupon].code + ", Selected date: " + schedules[orders[i].schedule].ID + " " + schedules[orders[i].schedule].date
                            + ", Status: " + orders[i].status + ", People number: " + orders[i].peopleNumber + ", Jump type: " + jumpTypes[orders[i].jumpType].type
                            + ", Equipment: " + equipments[orders[i].equipment].ID + " " + equipments[orders[i].equipment].filming + " " + equipments[orders[i].equipment].photographing
                            + " " + equipments[orders[i].equipment].price);
                    }
                    ids.Add(orders[i].ID);
                }
            }
            RefreshOrderList();
        }
        private void UpdateData()
        {
            admins = DataBase.GetAdmin();
            instructors = DataBase.GetInstructor();
            pilots = DataBase.GetPilot();
            planes = DataBase.GetPlane();
            schedules = DataBase.GetSchedule();
            equipments = DataBase.GetEquipment();
            orders = DataBase.GetOrder();
            jumpTypes = DataBase.GetJumpType();
            coupones = DataBase.GetCoupon();
            reviews = DataBase.GetReview();
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
                if (schedules[i].client == 0)
                {
                    comboDate.Items.Add(schedules[i].date);
                }
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
            int help = 0;
            Order newOrder = new Order();
            UpdateSchedule us = new UpdateSchedule();
            if (Convert.ToString(comboDate.SelectedItem) == "" || Convert.ToString(comboJumpType.SelectedItem) == "")
            {
                MessageBox.Show("Please check if all data is correct");
            }
            else if (couponNumber.Text != "")
            {
                for (int i = 0; i < coupones.Count; i++)
                {
                    if (coupones[i].code == couponNumber.Text)
                    {
                        newOrder.coupon = coupones[i].ID;
                        i = coupones.Count + 1;
                        help = 1;
                    }
                }
                if (help == 0)
                {
                    MessageBox.Show("You entered wrong code. Please try again!");
                    couponNumber.Text = "";
                }
                else
                {
                    if ((string)comboEquipment.SelectedItem != "")
                        newOrder.equipment = comboEquipment.SelectedIndex - 1;
                    if (peopleNTextBox.Text != "")
                        newOrder.peopleNumber = Convert.ToInt32(peopleNTextBox.Text);
                    newOrder.ID = orders.Count;
                    newOrder.admin = 0;
                    newOrder.schedule = comboDate.SelectedIndex;
                    newOrder.jumpType = comboJumpType.SelectedIndex;
                    newOrder.status = "Confirming";
                    us.client = State.ActiveClient.ID;
                    us.date = (string)comboDate.SelectedItem;
                    DataBase.UpdateSchedule(us);
                    DataBase.SaveOrder(newOrder);
                    UpdateData();
                    MessageBox.Show("Your order has been saved");
                }
            }
            else
            {
                if ((string)comboEquipment.SelectedItem != "")
                    newOrder.equipment = comboEquipment.SelectedIndex - 1;
                if (peopleNTextBox.Text != "")
                    newOrder.peopleNumber = Convert.ToInt32(peopleNTextBox.Text);
                newOrder.ID = orders.Count;
                newOrder.admin = 0;
                newOrder.schedule = comboDate.SelectedIndex;
                newOrder.jumpType = comboJumpType.SelectedIndex;
                newOrder.status = "Confirming";
                us.client = State.ActiveClient.ID;
                us.date = (string)comboDate.SelectedItem;
                DataBase.UpdateSchedule(us);
                DataBase.SaveOrder(newOrder);
                UpdateData();
                MessageBox.Show("Your order has been saved");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)orderListBox.SelectedItem != "" && richTextBox1.Text != "" && richTextBox2.Text != "")
            {
                Review newReview = new Review();
                newReview.ID = reviews.Count;
                newReview.order = ids[orderListBox.SelectedIndex];
                newReview.instructor = richTextBox1.Text;
                newReview.jump = richTextBox2.Text;
                try
                {
                    DataBase.SaveReview(newReview);
                    MessageBox.Show("Review has been saved!");
                }
                catch
                {
                    MessageBox.Show("Review on this order already exists");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all data");
            }
        }
    }
}
