using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class StudentDashboard : Form
    {
        formANN SDann;
        formATS SDats;
        formSDseprof SDseprof;
        formSDsched SDsched;
        formSDclass SDclass;
        public string loggedInUser;

        public StudentDashboard()
        {
            InitializeComponent();
            mdiProp();
        }

        // for mdi
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        bool sidebarExpand = true;

        // button clicks
        private void SAnnouncement_Click(object sender, EventArgs e)
        {
            if (SDann == null)
            {
                SDann = new formANN();
                SDann.FormClosed += SDann_FormClosed;
                SDann.MdiParent = this;
                SDann.StartPosition = FormStartPosition.Manual;
                SDann.Location = new Point(0, 0);
                SDann.Size = new Size(1150, 570);
                SDann.Show();
            }
            else
            {
                SDann.Activate();
            }
        }

        private void SDann_FormClosed(object sender, FormClosedEventArgs e)
        {
            SDann = null;
        }

        private void Sats_Click(object sender, EventArgs e)
        {
            if (SDats == null)
            {
                SDats = new formATS();
                SDats.FormClosed += SDats_FormClosed; 
                SDats.MdiParent = this;
                SDats.StartPosition = FormStartPosition.Manual;
                SDats.Location = new Point(0, 0);
                SDats.Size = new Size(1150, 570);
                SDats.Show();
            }
            else
            {
                SDats.Activate();
            }
        }

        private void SDats_FormClosed(object sender, FormClosedEventArgs e)
        {
            SDats = null;
        }

        private void sprof_Click(object sender, EventArgs e)
        {
            if (SDseprof == null)
            {
                SDseprof = new formSDseprof();
                SDseprof.GetID(loggedInUser);
                SDseprof.loggedInUser = loggedInUser;
                SDseprof.FormClosed += SDseprof_FormClosed; 
                SDseprof.MdiParent = this;
                SDseprof.StartPosition = FormStartPosition.Manual;
                SDseprof.Location = new Point(0, 0);
                SDseprof.Size = new Size(1150, 570);
                SDseprof.Show();
            }
            else
            {
                SDseprof.GetID(loggedInUser);
                SDseprof.loggedInUser = loggedInUser;
                SDseprof.Activate();
            }
        }

        private void SDseprof_FormClosed(object sender, FormClosedEventArgs e)
        {
            SDseprof = null;
        }

        // sign out
        private void sout_Click(object sender, EventArgs e)
        {
            // Show a message box to confirm logout
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicked Yes, logout and show the login form
            if (result == DialogResult.Yes)
            {
                Form1 Obj = new Form1();
                Obj.Show();
                this.Close(); // close the current form
            }
        }

        // sidebar
        bool ssidebarExpand = true;
        private void ssidebarTransition_Tick(object sender, EventArgs e)
        {
            if (ssidebarExpand)
            {
                ssidebar.Width -= 15;
                if(ssidebar.Width <= 78)
                {
                    ssidebarExpand = false;
                    ssidebarTransition.Stop();

                    pnss.Width = ssidebar.Width;
                    pnsc.Width = ssidebar.Width;
                }
            }
            else
            {
                ssidebar.Width += 15;
                if(ssidebar.Width >= 230)
                {
                    ssidebarExpand = true;
                    ssidebarTransition.Stop();

                    pnss.Width = ssidebar.Width;
                    pnsc.Width = ssidebar.Width;
                }
            }
        }
        private void btnsMenu_Click(object sender, EventArgs e)
        {
            ssidebarTransition.Start();
        }

        // buttons pt. 2 
        private void btnSDs_Click(object sender, EventArgs e)
        {
            if (SDsched == null)
            {
                SDsched = new formSDsched();
            }
        }

        private void btnSDc_Click(object sender, EventArgs e)
        {
            if(SDclass == null)
            {
                SDclass = new formSDclass();
            }
        }
    }
}
