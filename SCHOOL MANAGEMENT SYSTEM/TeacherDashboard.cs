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
    public partial class TeacherDashboard : Form
    {
        formANN TDann;
        formATS TDats;
        formTDteprof TDteprof;
        formTDsched TDsched;
        formTDclass TDclass;
        public string loggedInUser;

        public TeacherDashboard()
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
        private void TAnnouncement_Click(object sender, EventArgs e)
        {
            if (TDann == null)
            {
                TDann = new formANN();
                TDann.FormClosed += TDann_FormClosed;
                TDann.MdiParent = this;
                TDann.StartPosition = FormStartPosition.Manual;
                TDann.Location = new Point(0, 0);
                TDann.Size = new Size(1150, 570);
                TDann.Show();
            }
            else
            {
                TDann.Activate();
            }
        }

        private void TDann_FormClosed(object sender, FormClosedEventArgs e)
        {
            TDann = null;
        }

        private void Tats_Click(object sender, EventArgs e)
        {
            if (TDats == null)
            {
                TDats = new formATS();
                TDats.FormClosed += TDats_FormClosed;
                TDats.MdiParent = this;
                TDats.StartPosition = FormStartPosition.Manual;
                TDats.Location = new Point(0, 0);
                TDats.Size = new Size(1150, 570);
                TDats.Show();
            }
            else
            {
                TDats.Activate();
            }
        }

        private void TDats_FormClosed(object sender, FormClosedEventArgs e)
        {
            TDats = null;
        }

        private void tprof_Click(object sender, EventArgs e)
        {
            if (TDteprof == null)
            {
                TDteprof = new formTDteprof();
                TDteprof.GetID(loggedInUser);
                TDteprof.loggedInUser = loggedInUser;
                TDteprof.FormClosed += TDteprof_FormClosed;
                TDteprof.MdiParent = this;
                TDteprof.StartPosition = FormStartPosition.Manual;
                TDteprof.Location = new Point(0, 0);
                TDteprof.Size = new Size(1150, 570);
                TDteprof.Show();
            }
            else
            {
                TDteprof.GetID(loggedInUser);
                TDteprof.loggedInUser = loggedInUser;
                TDteprof.Activate();
            }
        }

        private void TDteprof_FormClosed(object sender, FormClosedEventArgs e)
        {
            TDteprof = null;
        }

        // sign out
        private void tout_Click(object sender, EventArgs e)
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
        bool tsidebarExpand = true;
        private void tsidebarTransition_Tick(object sender, EventArgs e)
        {
            if (tsidebarExpand)
            {
                tsidebar.Width -= 15;
                if (tsidebar.Width <= 78)
                {
                    tsidebarExpand = false;
                    tsidebarTransition.Stop();

                    pnts.Width = tsidebar.Width;
                    pntc.Width = tsidebar.Width;
                }
            }
            else
            {
                tsidebar.Width += 15;
                if (tsidebar.Width >= 230)
                {
                    tsidebarExpand = true;
                    tsidebarTransition.Stop();

                    pnts.Width = tsidebar.Width;
                    pntc.Width = tsidebar.Width;
                }
            }
        }
        private void btntMenu_Click(object sender, EventArgs e)
        {
            tsidebarTransition.Start();
        }

        // buttons pt. 2
        private void btnTDs_Click(object sender, EventArgs e)
        {
            if (TDsched == null)
            {
                TDsched = new formTDsched();
                TDsched.MdiParent = this;
                TDsched.StartPosition = FormStartPosition.Manual;
                TDsched.Location = new Point(0, 0);
                TDsched.Size = new Size(1150, 570);
                TDsched.Show();
            }
            else
            {
                TDsched.Activate();
            }

        }

        private void btnTDs_FormClosed(object sender, FormClosedEventArgs e)
        {
            TDsched = null;
        }
        private void btnTDc_Click(object sender, EventArgs e)
        {
            if (TDclass == null)
            {
                TDclass = new formTDclass();
                TDclass.MdiParent = this;
                TDclass.StartPosition =
            }
        }
    }
}
