using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DataBasePracticalJob
{
    public partial class Registrate : Form
    {
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$");
        public Registrate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Match match = regex.Match(emailTextBox.Text);
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "" || confirmPasswordTextBox.Text == ""
                && nameTextBox.Text == "" || surnameTextBox.Text == "" || phoneTextBox.Text == ""
                && emailTextBox.Text == "" || weightTextBox.Text == "" || heightTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
            }
            else if (match.Success == false)
            {
                MessageBox.Show("Please check if you entered correct email address!");
            }
            else if (passwordTextBox.Text == confirmPasswordTextBox.Text)
            {
                List<Client> clients = new List<Client>();
                int h = 0;
                clients = DataBase.GetClient();

                Client newClient = new Client();
                newClient.ID = clients.Count;
                newClient.admin = 0;
                newClient.username = usernameTextBox.Text;
                newClient.password = passwordTextBox.Text;
                newClient.name = nameTextBox.Text;
                newClient.surname = surnameTextBox.Text;
                newClient.email = emailTextBox.Text;
                newClient.mobileNumber = phoneTextBox.Text;
                newClient.weight = Convert.ToInt32(weightTextBox.Text);
                newClient.height = Convert.ToInt32(heightTextBox.Text);

                for (int i = 0; i < clients.Count; i++)
                {
                    if (clients[i].username == newClient.username)
                    {
                        MessageBox.Show("This Username is already taken");
                        h = 1;
                        i = clients.Count + 1;
                    }
                }
                if (h == 0)
                {
                    DataBase.SaveClient(newClient);
                    MessageBox.Show("New user has been created");
                    Close();
                }
                //usernameTextBox.Text = "";
                //passwordTextBox.Text = "";
                //confirmPasswordTextBox.Text = "";
                //nameTextBox.Text = "";
                //surnameTextBox.Text = "";
                //emailTextBox.Text = "";
                //phoneTextBox.Text = "+370";
                //weightTextBox.Text = "";
                //heightTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Passwords does not match!");
            }
        }
        private void Check(KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid value");
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check(e);
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check(e);
        }

        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check(e);
        }
        private void phoneTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && phoneTextBox.Text.Length == 4)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Registrate_Load(object sender, EventArgs e)
        {

        }
    }
}
