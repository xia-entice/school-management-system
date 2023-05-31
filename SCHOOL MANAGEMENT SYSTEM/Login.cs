using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd=karmakun_2002");

        public Form1()
        {
            InitializeComponent();
            roleCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username_txt.Text == "" || Password_txt.Text == "" || roleCB.Text == "Role")
            {
                MessageBox.Show("LogIn Failed, Input Correct Information!");
            }
            else if (roleCB.Text == "Admin")
            {
                con.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT COUNT(*) FROM adminacc WHERE uname = '" + Username_txt.Text + "' AND pass = '" + Password_txt.Text + "'", con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    string loggedInUser = Username_txt.Text;
                    formADaeprof form2 = new formADaeprof();
                    form2.loggedInUser = Username_txt.Text;
                    form2.GetID(loggedInUser);

                    formADann form = new formADann();
                    form.loggedInUser = Username_txt.Text;
                    form.GetID(loggedInUser);
                  

                    AdminDashboard Obj = new AdminDashboard();
                    Obj.loggedInUser = Username_txt.Text;
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username and Password");
                    Username_txt.Text = "";
                    Password_txt.Text = "";
                }
                con.Close();
            }
            else if (roleCB.Text == "Teacher")
            {
                con.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT COUNT(*) FROM teacheracc WHERE teachername = '" + Username_txt.Text + "' AND teacherpassword = '" + Password_txt.Text + "'", con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    string loggedInUser = Username_txt.Text;
                    formTDteprof form2 = new formTDteprof();
                    form2.loggedInUser = Username_txt.Text;
                    form2.GetID(loggedInUser);
                    formTDclass form = new formTDclass();
                    form.loggedInUser = Username_txt.Text;
                    form.GetID(loggedInUser);
                    formTDsched form1 = new formTDsched();
                    form1.loggedInUser = Username_txt.Text;
                    form1.GetID(loggedInUser);
                    TeacherDashboard Obj = new TeacherDashboard();
                    Obj.loggedInUser = Username_txt.Text;
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username and Password");
                    Username_txt.Text = "";
                    Password_txt.Text = "";
                }
                con.Close();
            }
            else if (roleCB.Text == "Student")
            {
                con.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter("SELECT COUNT(*) FROM studentacc WHERE studuname = '" + Username_txt.Text + "' AND studpass = '" + Password_txt.Text + "'", con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    string loggedInUser = Username_txt.Text;
                    formSDseprof form2 = new formSDseprof();
                    form2.loggedInUser = Username_txt.Text;
                    form2.GetID(loggedInUser);
                    formSDclass form1 = new formSDclass();
                    form1.loggedInUser = Username_txt.Text;
                    form1.GetID(loggedInUser);
                    formSDsched form3 = new formSDsched();
                    form3.loggedInUser = Username_txt.Text;
                    form3.GetID(loggedInUser);
                    StudentDashboard Obj = new StudentDashboard();
                    Obj.loggedInUser = Username_txt.Text;
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username and Password");
                    Username_txt.Text = "";
                    Password_txt.Text = "";
                }
                con.Close();
            }
        }
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Hide Password");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Show Password");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Password_txt.UseSystemPasswordChar = false;
            pictureBox2.Hide();
            pictureBox3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Password_txt.UseSystemPasswordChar = true;
            pictureBox2.Show();
            pictureBox3.Hide();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Define the RGB values for the start and end colors
            int startRed = 245;   // Example: start color red component
            int startGreen = 196;   // Example: start color green component
            int startBlue = 0;    // Example: start color blue component

            int endRed = 255;       // Example: end color red component
            int endGreen = 222;     // Example: end color green component
            int endBlue = 92;    // Example: end color blue component

            // Create a new LinearGradientBrush with the desired gradient colors and coordinates
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(startRed, startGreen, startBlue), // Start color
                Color.FromArgb(endRed, endGreen, endBlue),       // End color
                LinearGradientMode.ForwardDiagonal);                 // Gradient direction

            // Fill the form with the gradient brush
            e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);

            // Call the base class implementation to ensure the standard painting is done
            base.OnPaint(e);
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int v);


        private int GetLoggedInAdminAc()
        {
            int adminAc = 0;
            MySqlDataAdapter msda = new MySqlDataAdapter("SELECT adminac FROM adminacc WHERE uname = '" + Username_txt.Text + "' AND pass = '" + Password_txt.Text + "'", con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                adminAc = Convert.ToInt32(dt.Rows[0]["adminac"]);
            }
            con.Close();
            return adminAc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Password_txt.UseSystemPasswordChar = true;
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, Username_txt.Height, 20, 20));
        }
    }
}
