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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are a group of shit data base programmers. Our product is not so good. Don't blame us");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Radau klaida admine orderliste su coupon'u, jei nerasyt ar dar kazka, tai atsikelsiu ir ziuresim kaip istaisyt, nes man galva neveikia (btw taip ir nesugalvojau kaip realizuoti additionalJumpers ivedima)");
            Login log = new Login();
            log.ShowDialog();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Registrate reg = new Registrate();
            reg.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
