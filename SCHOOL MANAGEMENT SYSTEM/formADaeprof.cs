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
using System.Drawing.Imaging;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class formADaeprof : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002");
        string AconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        public string loggedInUser;
        private Image adminImage;


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
            // Validate the birth date
            if (!DateTime.TryParse(abirth.Text.Trim(), out DateTime birthDate))
            {
                MessageBox.Show("Please enter a valid birth date in the format yyyy-MM-dd");
                return;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(auname.Text.Trim()))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            if (string.IsNullOrWhiteSpace(apass.Text.Trim()))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (string.IsNullOrWhiteSpace(aname.Text.Trim()))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (string.IsNullOrWhiteSpace(agender.Text.Trim()))
            {
                MessageBox.Show("Please enter a gender.");
                return;
            }
            if (string.IsNullOrWhiteSpace(aaddress.Text.Trim()))
            {
                MessageBox.Show("Please enter an address.");
                return;
            }
            if (string.IsNullOrWhiteSpace(aemail.Text.Trim()))
            {
                MessageBox.Show("Please enter an email address.");
                return;
            }
            if (!IsNumeric(aage.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid age (numeric value).");
                return;
            }
            //if (!IsNumeric(acnumber.Text.Trim()))
           // {
             //   MessageBox.Show("Please enter a valid contact number (numeric value).");
            //    return;
            //}
            //if (acnumber.Text.Trim().Length != 11)
           // {
             //   MessageBox.Show("Please enter a valid contact number with 11 digits.");
             //   return;
           // }

            byte[] imageBytes = null;
            if (adminpic.Image != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        adminpic.Image.Save(ms, adminpic.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while processing the image: " + ex.Message);
                    return;
                }
            }

            using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
            {
                try
                {
                    amysqlCon.Open();

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
                   amysqlCmd.Parameters.AddWithValue("_adcnumber", "09000000000");

                    if (imageBytes != null)
                    {

                        // Dispose the previous adminImage if it exists


                        if (adminImage != null)
                        {
                            adminImage.Dispose();
                        }
                        adminImage = adminpic.Image; // Assign the new image to the adminImage variable
                    }

                    // Add the image to the parameters
                    amysqlCmd.Parameters.AddWithValue("_aimage", imageBytes ?? (object)DBNull.Value);

                    amysqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the data: " + ex.Message);
                }
                finally
                {

                    LoadData();
                }
            }
        }

        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
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
                          //  acnumber.Text = mdr.GetString("adcnumber");

                            // Load image into picture box
                            object imageData = mdr["aimage"];
                            if (imageData != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])imageData;
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    // Convert JPEG image to PNG
                                    using (Image image = Image.FromStream(ms))
                                    {
                                        using (MemoryStream pngMs = new MemoryStream())
                                        {
                                            image.Save(pngMs, ImageFormat.Png);
                                            adminpic.Image = Image.FromStream(pngMs);
                                        }
                                    }
                                    adminpic.SizeMode = PictureBoxSizeMode.Zoom;

                                    Image img = Image.FromStream(ms);
                                    adminpic.Image = img;


                                }
                            }
                            else
                            {
                                adminpic.Image = null; // Set the picture box image to null if no image is present
                            }

                            aname.Enabled = false;
                            aage.Enabled = false;
                            agender.Enabled = false;
                            abirth.Enabled = false;
                            aaddress.Enabled = false;
                            aemail.Enabled = false;
                            apass.Enabled = false;
                            auname.Enabled = false;
                           // acnumber.Enabled = false;
                            ASave.Enabled = false;
                            Asearch.Enabled = false;
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
            //acnumber.Enabled = true;
            ASave.Enabled = true;
            Asearch.Enabled = true;
        }

        private void Asearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                adminpic.Image = Image.FromFile(opf.FileName);

            }
        }
    }
}



