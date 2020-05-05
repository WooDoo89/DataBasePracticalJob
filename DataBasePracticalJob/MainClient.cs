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
        List<Order> orders = new List<Order>();
        List<JumpType> jumpTypes = new List<JumpType>();
        List<Instructor> instructors = new List<Instructor>();
        List<Pilot> pilots = new List<Pilot>();
        List<Plane> planes = new List<Plane>();
        List<Schedule> schedules = new List<Schedule>();
        List<Equipment> equipments = new List<Equipment>();
        public MainClient()
        {
            InitializeComponent();
            ShowData();
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

            admins = DataBase.GetAdmin();
            instructors = DataBase.GetInstructor();
            pilots = DataBase.GetPilot();
            planes = DataBase.GetPlane();
            schedules = DataBase.GetSchedule();
            equipments = DataBase.GetEquipment();
            jumpTypes = DataBase.GetJumpType();

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
                if (equipments[i].photographing == null)
                    comboEquipment.Items.Add("Video: " + equipments[i].filming + " " + "Price: " + equipments[i].price);
                else if (equipments[i].filming == null)
                    comboEquipment.Items.Add("Photo: " + equipments[i].photographing + " " + "Price: " + equipments[i].price);
                else
                    comboEquipment.Items.Add("Video: " + equipments[i].filming + " " + "Photo: " + equipments[i].photographing + " " + "Price: " + equipments[i].price);
            }

        }

        private void MakingOrder()
        {
            instructorLabel.Visible = true;
            planeLabel.Visible = true;
            pilotLabel.Visible = true;
            int selectedDate = comboDate.SelectedIndex;
            for (int i = 0; i < schedules.Count; i++)
            {
                State.ActiveSchedule = schedules[selectedDate];
            }
            instructorNameLabel.Text = instructors[selectedDate].name;
            instructorSurnameLabel.Text = instructors[selectedDate].surname;
            pilotNameLabel.Text = pilots[selectedDate].name;
            pilotSurnameLabel.Text = pilots[selectedDate].surname;
            planeTypeLabel.Text = planes[selectedDate].type;
        }

        private void profileTab_Click(object sender, EventArgs e)
        {

        }

        private void couponNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakingOrder();
        }
    }
}
