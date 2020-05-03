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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" && passwordTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
            }
            else
            {
                int help = 0;
                List<Client> clients = new List<Client>();
                List<Admin> admins = new List<Admin>();
                List<Instructor> instructors = new List<Instructor>();
                List<Pilot> pilots = new List<Pilot>();
                clients = DataBase.GetClient();
                admins = DataBase.GetAdmin();
                instructors = DataBase.GetInstructor();
                pilots = DataBase.GetPilot();
                for (int i = 0; i < clients.Count; i++)
                {
                    if (clients[i].username == usernameTextBox.Text && clients[i].password == passwordTextBox.Text)
                    {
                        help = 1;
                        this.Hide();
                        clients[i].SetList(clients[i]);
                        clients[i].SetID(0);
                        MainSystem system = new MainSystem();
                        system.ShowDialog();
                        this.Close();
                    }
                }
                for (int i = 0; i < admins.Count; i++)
                {
                    if (admins[i].username == usernameTextBox.Text && admins[i].password == passwordTextBox.Text)
                    {
                        help = 1;
                        this.Hide();
                        admins[i].SetList(admins[i]);
                        admins[i].SetID(0);
                        MainSystem system = new MainSystem();
                        system.ShowDialog();
                        this.Close();
                    }
                }
                for (int i = 0; i < instructors.Count; i++)
                {
                    if (instructors[i].username == usernameTextBox.Text && instructors[i].password == passwordTextBox.Text)
                    {
                        help = 1;
                        this.Hide();
                        instructors[i].SetList(instructors[i]);
                        instructors[i].SetID(0);
                        MainSystem system = new MainSystem();
                        system.ShowDialog();
                        this.Close();
                    }
                }
                for (int i = 0; i < pilots.Count; i++)
                {
                    if (pilots[i].username == usernameTextBox.Text && pilots[i].password == passwordTextBox.Text)
                    {
                        help = 1;
                        this.Hide();
                        pilots[i].SetList(pilots[i]);
                        pilots[i].SetID(0);
                        MainSystem system = new MainSystem();
                        system.ShowDialog();
                        this.Close();
                    }
                }
                if (help == 0)
                {
                    MessageBox.Show("Wrong username or password!");
                }
            }
        }
    }
}
