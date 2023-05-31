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
    public partial class formSDseprof : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002");
        string SconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        public string loggedInUser;
        private Image studentImage;

        

        public formSDseprof()
        {
            InitializeComponent();
        }

        private void formSDseprof_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            GetID(loggedInUser);
            LoadData();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Hide Password");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Show Password");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            spass.UseSystemPasswordChar = false;
            pictureBox2.Hide();
            pictureBox1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            spass.UseSystemPasswordChar = true;
            pictureBox2.Show();
            pictureBox1.Hide();
        }

        private void Ssearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                simage.Image = Image.FromFile(opf.FileName);
            }
            simage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            sname.Enabled = true;
            sage.Enabled = true;
            sgender.Enabled = true;
            sbirth.Enabled = true;
            saddress.Enabled = true;
            semail.Enabled = true;
            spass.Enabled = true;
            suname.Enabled = true;
            save.Enabled = true;
            Ssearch.Enabled = true;
            Sdept.Enabled = true;
            scnum.Enabled = true;
            ssection.Enabled = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            // Validate the birth date
            if (!DateTime.TryParse(sbirth.Text.Trim(), out DateTime birthDate))
            {
                MessageBox.Show("Please enter a valid birth date in the format yyyy-MM-dd");
                return;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(suname.Text.Trim()))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            if (string.IsNullOrWhiteSpace(spass.Text.Trim()))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (string.IsNullOrWhiteSpace(sname.Text.Trim()))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (string.IsNullOrWhiteSpace(sgender.Text.Trim()))
            {
                MessageBox.Show("Please enter a gender.");
                return;
            }
            if (string.IsNullOrWhiteSpace(saddress.Text.Trim()))
            {
                MessageBox.Show("Please enter an address.");
                return;
            }
            if (string.IsNullOrWhiteSpace(semail.Text.Trim()))
            {
                MessageBox.Show("Please enter an email address.");
                return;
            }

            if (!IsNumeric(sage.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid age (numeric value).");
                return;
            }
            string numericContactNumber = new string(scnum.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", "").Where(char.IsDigit).ToArray());
            if (numericContactNumber.Length != 11)
            {
                MessageBox.Show("Please enter a valid contact number with 11 digits.");
                return;
            }

            byte[] imageBytes = null;
            if (simage.Image != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        simage.Image.Save(ms, simage.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while processing the image: " + ex.Message);
                    return;
                }
            }

            using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
            {
                try
                {
                    smysqlCon.Open();

                    MySqlCommand smysqlCmd = new MySqlCommand("studentAddorUp", smysqlCon);
                    smysqlCmd.CommandType = CommandType.StoredProcedure;
                    smysqlCmd.Parameters.AddWithValue("_StudentAc", StudentID.Text);
                    smysqlCmd.Parameters.AddWithValue("_studuname", suname.Text.Trim());
                    smysqlCmd.Parameters.AddWithValue("_studpass", spass.Text.Trim());
                    smysqlCmd.Parameters.AddWithValue("_studname", sname.Text.Trim());
                    smysqlCmd.Parameters.AddWithValue("_sage", sage.Text.Trim());
                    smysqlCmd.Parameters.AddWithValue("_sgender", sgender.Text.Trim());
                    smysqlCmd.Parameters.AddWithValue("_sbirthdate", birthDate);
                    smysqlCmd.Parameters.AddWithValue("_saddress", saddress.Text.Trim());
                    smysqlCmd.Parameters.AddWithValue("_semail", semail.Text.Trim());
                    smysqlCmd.Parameters.AddWithValue("_scnumber", scnum.Text.Trim());
                    smysqlCmd.Parameters.AddWithValue("_sdept", Sdept.Text.Trim());
                    smysqlCmd.Parameters.AddWithValue("_section", ssection.Text.Trim());

                    if (imageBytes != null)
                    {
                        if (studentImage != null)
                        {
                            studentImage.Dispose();
                        }
                        studentImage = simage.Image; // Assign the new image to the adminImage variable
                    }

                    // Add the image to the parameters
                    smysqlCmd.Parameters.AddWithValue("_simage", imageBytes ?? (object)DBNull.Value);


                    smysqlCmd.ExecuteNonQuery();
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
                using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
                {
                    smysqlCon.Open();
                    MySqlCommand smysqlCmd = new MySqlCommand("SELECT * FROM studmanagment.studentacc WHERE StudentAc=@studentAc", smysqlCon);
                    smysqlCmd.Parameters.AddWithValue("@studentAc", StudentID.Text);

                    smysqlCmd = new MySqlCommand("SELECT * FROM studentacc WHERE StudentAc=@StudentAc", smysqlCon);
                    smysqlCmd.Parameters.AddWithValue("@StudentAc", StudentID.Text);
                    MySqlDataReader mdr = smysqlCmd.ExecuteReader();

                    if (mdr.HasRows)
                    {
                        while (mdr.Read())
                        {
                            sname.Text = mdr.GetString("studname");
                            sage.Text = mdr.GetUInt32("sage").ToString();
                            sgender.Text = mdr.GetString("sgender");
                            sbirth.Text = mdr.GetDateTime("sbirthdate").ToString("yyyy-MM-dd");
                            saddress.Text = mdr.GetString("saddress");
                            semail.Text = mdr.GetString("semail");
                            spass.Text = mdr.GetString("studpass");
                            suname.Text = mdr.GetString("studuname");
                            Sdept.Text = mdr.GetString("sdept");
                            scnum.Text = "0"+mdr.GetString("scnumber");
                            ssection.Text = mdr.GetString("section");

                            // Load image into picture box
                            object imageData = mdr["simage"];
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
                                            simage.Image = Image.FromStream(pngMs);
                                        }
                                    }
                                   simage.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            else
                            {
                                simage.Image = null; // Set the picture box image to null if no image is present
                            }


                            sname.Enabled = false;
                            sage.Enabled = false;
                            sgender.Enabled = false;
                            sbirth.Enabled = false;
                            saddress.Enabled = false;
                            semail.Enabled = false;
                            spass.Enabled = false;
                            suname.Enabled = false;
                            save.Enabled = false;
                            Ssearch.Enabled = false;
                            Sdept.Enabled = false;
                            scnum.Enabled = false;
                            ssection.Enabled = false;
   
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
                //MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void GetID(string loggedInUser)
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT StudentAc FROM studentacc WHERE studuname=@loggedInUser", con);
            cmd.Parameters.AddWithValue("@loggedInUser", loggedInUser);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            StudentID.Text = i.ToString();

        }

        

    }
}
