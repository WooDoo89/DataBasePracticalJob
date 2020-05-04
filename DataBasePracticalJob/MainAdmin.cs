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
        List<Admin> admins = new List<Admin>();
        List<Instructor> instructors = new List<Instructor>();
        List<Pilot> pilots = new List<Pilot>();
        List<Plane> planes = new List<Plane>();
        List<Schedule> schedules = new List<Schedule>();
        List<string> itemList = new List<string>();
        DateTime TodayDate = DateTime.Today;
        public MainAdmin()
        {
            InitializeComponent();
            ShowData();
            RefreshGroupList();
        }

        private void ShowData()
        {
            idLabel.Text = Convert.ToString(State.ActiveAdmin.ID);
            nameLabel.Text = Convert.ToString(State.ActiveAdmin.name);
            lastnameLabel.Text = Convert.ToString(State.ActiveAdmin.surname);
            usernameLabel.Text = Convert.ToString(State.ActiveAdmin.username);
            emailLabel.Text = Convert.ToString(State.ActiveAdmin.email);
            numberLabel.Text = Convert.ToString(State.ActiveAdmin.mobileNumber);
            

            clients = DataBase.GetClient();
            admins = DataBase.GetAdmin();
            instructors = DataBase.GetInstructor();
            pilots = DataBase.GetPilot();
            planes = DataBase.GetPlane();
            schedules = DataBase.GetSchedule();
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

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedPilots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(comboPilot.SelectedItem) == "" || Convert.ToString(comboPlane.SelectedItem) == "" || Convert.ToString(comboInstructor.SelectedItem) == "" || dateTimePicker1.Value <= TodayDate)
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
                newSchedule.date = Convert.ToString(dateTimePicker1.Value);
                DataBase.SaveSchedule(newSchedule);
                itemList.Add(newSchedule.ID + " " + Convert.ToString(dateTimePicker1.Value));
                RefreshGroupList();

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


            private void RefreshGroupList()
            {
                checkedSchedule.Items.Clear();
                checkedSchedule.Items.AddRange(schedules.ToArray());
            }

        private void checkedSchedule_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
