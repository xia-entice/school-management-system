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

    public partial class AdminDashboard : Form
    {
        formADadmin ADadmin;
        formADteacher ADteacher;
        formADstudent ADstudent;
        formADann ADann;
        formADats ADats;
        formADaeprof ADaeprof;
        public AdminDashboard()
        {
            InitializeComponent();
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 15;
                if(sidebar.Width <= 78)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnAAcc.Width = sidebar.Width;
                    pnTAcc.Width = sidebar.Width;
                    pnSAcc.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 15;
                if(sidebar.Width >= 230)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnAAcc.Width = sidebar.Width;
                    pnTAcc.Width = sidebar.Width;
                    pnSAcc.Width = sidebar.Width;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnADa_Click(object sender, EventArgs e)
        {

            if (ADadmin == null)
            {
                ADadmin = new formADadmin();
                ADadmin.FormClosed += ADadmin_FormClosed;
                ADadmin.MdiParent = this;
                ADadmin.StartPosition = FormStartPosition.Manual;
                ADadmin.Location = new Point(0, 0);
                ADadmin.Size = new Size(1150, 570);
                ADadmin.Show();
            } 
            else
            {
                ADadmin.Activate();
            }
        }

        private void ADadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            ADadmin = null;
        }

        private void btnADt_Click(object sender, EventArgs e)
        {
            if(ADteacher == null)
            {
                ADteacher = new formADteacher();
                ADteacher.FormClosed += ADteacher_FormClosed;
                ADteacher.MdiParent = this;
                ADteacher.StartPosition = FormStartPosition.Manual;
                ADteacher.Location = new Point(0, 0);
                ADteacher.Size = new Size(1150, 570);
                ADteacher.Show();
            }
            else
            {
                ADteacher.Activate();
            }
        }

        private void ADteacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            ADteacher = null;
        }

        private void btnADs_Click(object sender, EventArgs e)
        {
            if(ADstudent == null)
            {
                ADstudent = new formADstudent();
                ADstudent.FormClosed += ADstudent_FormClosed;
                ADstudent.MdiParent = this;
                ADstudent.StartPosition = FormStartPosition.Manual;
                ADstudent.Location = new Point(0, 0);
                ADstudent.Size = new Size(1150, 570);
                ADstudent.Show();
            }
            else
            {
                ADstudent.Activate();
            }
        }

        private void ADstudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            ADstudent = null;
        }

        private void AAnnouncement_Click(object sender, EventArgs e)
        {
            if (ADann == null)
            {
                ADann = new formADann();
                ADann.FormClosed += ADann_FormClosed;
                ADann.MdiParent = this;
                ADann.StartPosition = FormStartPosition.Manual;
                ADann.Location = new Point(0, 0);
                ADann.Size = new Size(1150, 570);
                ADann.Show();
            }
            else
            {
                ADann.Activate();
            }
        }

        private void ADann_FormClosed(object sender, FormClosedEventArgs e)
        {
            ADann = null;
        }

        private void Aats_Click(object sender, EventArgs e)
        {
            if (ADats == null)
            {
                ADats = new formADats();
                ADats.FormClosed += ADats_FormClosed;
                ADats.MdiParent = this;
                ADats.StartPosition = FormStartPosition.Manual;
                ADats.Location = new Point(0, 0);
                ADats.Size = new Size(1150, 570);
                ADats.Show();
            }
            else
            {
                ADats.Activate();
            }
        }

        private void ADats_FormClosed(object sender, FormClosedEventArgs e)
        {
            ADats = null;
        }

        private void aprof_Click(object sender, EventArgs e)
        {
            if (ADaeprof == null)
            {
                ADaeprof = new formADaeprof();
                ADaeprof.FormClosed += ADaeprof_FormClosed;
                ADaeprof.MdiParent = this;
                ADaeprof.StartPosition = FormStartPosition.Manual;
                ADaeprof.Location = new Point(0, 0);
                ADaeprof.Size = new Size(1150, 570);
                ADaeprof.Show();
            }
            else
            {
                ADaeprof.Activate();
            }
        }

        private void ADaeprof_FormClosed(object sender, FormClosedEventArgs e)
        {
            ADaeprof = null;
        }

        private void aout_Click(object sender, EventArgs e)
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
