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

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd=karmakun_2002");

        public Form1()
        {
            InitializeComponent();
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
        }
    }
}
