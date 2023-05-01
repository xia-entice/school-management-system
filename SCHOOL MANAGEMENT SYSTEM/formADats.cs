using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
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
