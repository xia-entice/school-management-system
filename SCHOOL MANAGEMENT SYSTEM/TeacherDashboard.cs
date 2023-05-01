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
                TDteprof.FormClosed += TDteprof_FormClosed;
                TDteprof.MdiParent = this;
                TDteprof.StartPosition = FormStartPosition.Manual;
                TDteprof.Location = new Point(0, 0);
                TDteprof.Size = new Size(1150, 570);
                TDteprof.Show();
            }
            else
            {
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
    }
}
