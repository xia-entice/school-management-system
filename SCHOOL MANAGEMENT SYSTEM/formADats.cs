using System;
using System.Drawing;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class formADats : Form
    {
        public formADats()
        {
            InitializeComponent();
        }

        private void formADats_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            gPanel.BackColor = Color.FromArgb(128, 255, 255, 255);
            richTextBox3.Dock = DockStyle.Fill;
        }


    }
}
