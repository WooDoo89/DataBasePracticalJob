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
    public partial class MainSystem : Form
    {
        /**
         * Checks what kind of user is online.
         * 0 - Admin
         * 1 - Client
         * 2 - Pilot
         * 3 - Instructor
         */
        private int whoOnline;
        public MainSystem()
        {
            InitializeComponent();
            Pilot p = new Pilot();
            Admin a = new Admin();
            Client c = new Client();
            Instructor i = new Instructor();
            if(p.GetList() != null) 
            {
                whoOnline = 2;
            }
            if (a.GetList() != null)
            {
                whoOnline = 0;
            }
            if (c.GetList() != null)
            {
                whoOnline = 1;
            }
            if (i.GetList() != null)
            {
                whoOnline = 3;
            }
        }

        private void MainSystem_Load(object sender, EventArgs e)
        {
            if(whoOnline == 0)
            {
                string title = "Clients";
                TabPage myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Planes";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Equipments";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Shedule";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Coupones";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Orders";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Archyve";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);
            }
            if (whoOnline == 1)
            {
                string title = "Planes";
                TabPage myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Pilots";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Instructors";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Coupones";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Equipment";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Shedule";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);    
            }
            if(whoOnline == 2)
            {
                string title = "Planes";
                TabPage myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Shedule";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Orders";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);
            }
            if(whoOnline == 3)
            {
                string title = "Planes";
                TabPage myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Shedule";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);

                title = "Orders";
                myTabPage = new TabPage(title);
                tabControl1.TabPages.Add(myTabPage);
            }
        }
    }
}
