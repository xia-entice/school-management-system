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
using System.IO;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class formADaeprof : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002");
        string AconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        MySqlConnection adminconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=karmakun_2002");
        MySqlCommand command;
        MySqlDataReader mdr;
        public string loggedInUser;


        public formADaeprof()
        {
            InitializeComponent();
        }

        private void formADaeprof_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            GetID(loggedInUser);
            LoadData();
        }

        private void ASave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
                {
                    amysqlCon.Open();

                    // Validate the birth date
                    DateTime birthDate;
                    if (!DateTime.TryParse(abirth.Text.Trim(), out birthDate))
                    {
                        MessageBox.Show("Please enter a valid birth date in the format yyyy-MM-dd");
                        return;
                    }

                    // Convert the image to a byte array
                    byte[] imageBytes = null;
                    if (adminpic.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        adminpic.Image.Save(ms, adminpic.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    MySqlCommand amysqlCmd = new MySqlCommand("adminAddorUp", amysqlCon);
                    amysqlCmd.CommandType = CommandType.StoredProcedure;
                    amysqlCmd.Parameters.AddWithValue("_AdminAc", AdminID.Text);
                    amysqlCmd.Parameters.AddWithValue("_uname", auname.Text.Trim());
                    amysqlCmd.Parameters.AddWithValue("_pass", apass.Text.Trim());
                    amysqlCmd.Parameters.AddWithValue("_name", aname.Text.Trim());
                    amysqlCmd.Parameters.AddWithValue("_adage", aage.Text.Trim());
                    amysqlCmd.Parameters.AddWithValue("_adgender", agender.Text.Trim());
                    amysqlCmd.Parameters.AddWithValue("_adbirthdate", birthDate);
                    amysqlCmd.Parameters.AddWithValue("_adaddress", aaddress.Text.Trim());
                    amysqlCmd.Parameters.AddWithValue("_ademail", aemail.Text.Trim());
                    amysqlCmd.Parameters.AddWithValue("_adcnumber", 123);

                    // Add the image to the parameters
                    amysqlCmd.Parameters.AddWithValue("_aimage", imageBytes);

                    amysqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
                {
                    amysqlCon.Open();
                    MySqlCommand amysqlCmd = new MySqlCommand("SELECT * FROM studmanagment.adminacc WHERE AdminAc=@adminAc", amysqlCon);
                    amysqlCmd.Parameters.AddWithValue("@adminAc", AdminID.Text);

                    amysqlCmd = new MySqlCommand("SELECT * FROM adminacc WHERE AdminAc=@AdminAc", amysqlCon);
                    amysqlCmd.Parameters.AddWithValue("@AdminAc", AdminID.Text);
                    MySqlDataReader mdr = amysqlCmd.ExecuteReader();

                    if (mdr.HasRows)
                    {
                        while (mdr.Read())
                        {
                            aname.Text = mdr.GetString("name");
                            aage.Text = mdr.GetUInt32("adage").ToString();
                            agender.Text = mdr.GetString("adgender");
                            abirth.Text = mdr.GetDateTime("adbirthdate").ToString("yyyy-MM-dd");
                            aaddress.Text = mdr.GetString("adaddress");
                            aemail.Text = mdr.GetString("ademail");
                            apass.Text = mdr.GetString("pass");
                            auname.Text = mdr.GetString("uname");

                            // Load image into picture box
                            byte[] imageData = (byte[])mdr["aimage"];
                            if (imageData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    adminpic.Image = Image.FromStream(ms);
                                    adminpic.SizeMode = PictureBoxSizeMode.Zoom;
                                    Image img = Image.FromStream(ms);
                                    adminpic.Image = img;
                                }
                            }

                            aname.Enabled = false;
                            aage.Enabled = false;
                            agender.Enabled = false;
                            abirth.Enabled = false;
                            aaddress.Enabled = false;
                            aemail.Enabled = false;
                            apass.Enabled = false;
                            auname.Enabled = false;
                            ASave.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void GetID(string loggedInUser)
        {
 
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT AdminAc FROM adminacc WHERE uname=@loggedInUser", con);
            cmd.Parameters.AddWithValue("@loggedInUser", loggedInUser);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            AdminID.Text = i.ToString();

        }

        private void edit_Click(object sender, EventArgs e)
        {
            // Enable the textboxes and save button
            aname.Enabled = true;
            aage.Enabled = true;
            agender.Enabled = true;
            abirth.Enabled = true;
            aaddress.Enabled = true;
            aemail.Enabled = true;
            apass.Enabled = true;
            auname.Enabled = true;
            ASave.Enabled = true;

        }

        private void Asearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                adminpic.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}



