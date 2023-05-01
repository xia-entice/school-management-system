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
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username_txt.Text == "" || Password_txt.Text == "" || roleCB.Text == "Role")
            {
                MessageBox.Show(" LogIn Failed, Input Correct Information!");
            }
            else if (roleCB.Text == "Admin")

            {
                con.Open();
                MySqlDataAdapter msda = new MySqlDataAdapter("select count(*) from adminacc where uname= '" + Username_txt.Text + "' and pass= '" + Password_txt.Text + "'", con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    AdminDashboard Obj = new AdminDashboard();
                    Obj.Show();
                    this.Hide();
                    con.Close();

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
                MySqlDataAdapter msda = new MySqlDataAdapter("select count(*) from teacheracc where teachername= '" + Username_txt.Text + "' and teacherpassword= '" + Password_txt.Text + "'", con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    TeacherDashboard Obj = new TeacherDashboard();
                    Obj.Show();
                    this.Hide();
                    con.Close();

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
                MySqlDataAdapter msda = new MySqlDataAdapter("select count(*) from studentacc where studuname= '" + Username_txt.Text + "' and studpass= '" + Password_txt.Text + "'", con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    StudentDashboard Obj = new StudentDashboard();
                    Obj.Show();
                    this.Hide();
                    con.Close();

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
    }
}
