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
    public partial class formTDteprof : Form
    {

        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002");
        string TconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        public string loggedInUser;
        private Image teacherImage;
        public formTDteprof()
        {
            InitializeComponent();

        }

        private void Tsearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                timage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void tSave_Click(object sender, EventArgs e)
        {
            // Validate the birth date
            if (!DateTime.TryParse(tbirth.Text.Trim(), out DateTime birthDate))
            {
                MessageBox.Show("Please enter a valid birth date in the format yyyy-MM-dd");
                return;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(tuname.Text.Trim()))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tpass.Text.Trim()))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tname.Text.Trim()))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tgender.Text.Trim()))
            {
                MessageBox.Show("Please enter a gender.");
                return;
            }
            if (string.IsNullOrWhiteSpace(taddress.Text.Trim()))
            {
                MessageBox.Show("Please enter an address.");
                return;
            }
            if (string.IsNullOrWhiteSpace(temail.Text.Trim()))
            {
                MessageBox.Show("Please enter an email address.");
                return;
            }

            byte[] imageBytes = null;
            if (timage.Image != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        timage.Image.Save(ms, timage.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while processing the image: " + ex.Message);
                    return;
                }
            }

            using (MySqlConnection tmysqlCon = new MySqlConnection(TconnectionString))
            {
                try
                {
                    tmysqlCon.Open();

                    MySqlCommand tmysqlCmd = new MySqlCommand("teacherAddorUp", tmysqlCon);
                    tmysqlCmd.CommandType = CommandType.StoredProcedure;
                    tmysqlCmd.Parameters.AddWithValue("_TeacherAc", TeacherID.Text);
                    tmysqlCmd.Parameters.AddWithValue("_teachername", tuname.Text.Trim());
                    tmysqlCmd.Parameters.AddWithValue("_teacherpassword", tpass.Text.Trim());
                    tmysqlCmd.Parameters.AddWithValue("_tname", tname.Text.Trim());
                    tmysqlCmd.Parameters.AddWithValue("_tage", tage.Text.Trim());
                    tmysqlCmd.Parameters.AddWithValue("_tgender", tgender.Text.Trim());
                    tmysqlCmd.Parameters.AddWithValue("_tbirthdate", birthDate);
                    tmysqlCmd.Parameters.AddWithValue("_taddress", taddress.Text.Trim());
                    tmysqlCmd.Parameters.AddWithValue("_temail", temail.Text.Trim());
                    tmysqlCmd.Parameters.AddWithValue("_tcnumber", 123);
                    tmysqlCmd.Parameters.AddWithValue("_tdept", tdept.Text.Trim());

                    if (imageBytes != null)
                    {
                        if (teacherImage != null)
                        {
                            teacherImage.Dispose();
                        }
                        teacherImage = timage.Image; // Assign the new image to the adminImage variable
                    }

                    // Add the image to the parameters
                    tmysqlCmd.Parameters.AddWithValue("_timage", imageBytes ?? (object)DBNull.Value);


                    tmysqlCmd.ExecuteNonQuery();
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

        private void tedit_Click(object sender, EventArgs e)
        {
            tname.Enabled = true;
            tage.Enabled = true;
            tgender.Enabled = true;
            tbirth.Enabled = true;
            taddress.Enabled = true;
            temail.Enabled = true;
            tpass.Enabled = true;
            tuname.Enabled = true;
            tSave.Enabled = true;
            Tsearch.Enabled = true;
            tdept.Enabled = true;

        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection tmysqlCon = new MySqlConnection(TconnectionString))
                {
                    tmysqlCon.Open();
                    MySqlCommand amysqlCmd = new MySqlCommand("SELECT * FROM studmanagment.teacheracc WHERE TeacherAc=@teacherAc", tmysqlCon);
                    amysqlCmd.Parameters.AddWithValue("@teacherAc", TeacherID.Text);

                    amysqlCmd = new MySqlCommand("SELECT * FROM teacheracc WHERE TeacherAc=@TeacherAc", tmysqlCon);
                    amysqlCmd.Parameters.AddWithValue("@TeacherAc", TeacherID.Text);
                    MySqlDataReader mdr = amysqlCmd.ExecuteReader();

                    if (mdr.HasRows)
                    {
                        while (mdr.Read())
                        {
                            tname.Text = mdr.GetString("tname");
                            tage.Text = mdr.GetUInt32("tage").ToString();
                            tgender.Text = mdr.GetString("tgender");
                            tbirth.Text = mdr.GetDateTime("tbirthdate").ToString("yyyy-MM-dd");
                            taddress.Text = mdr.GetString("taddress");
                            temail.Text = mdr.GetString("temail");
                            tpass.Text = mdr.GetString("teacherpassword");
                            tuname.Text = mdr.GetString("teachername");
                            tdept.Text = mdr.GetString("tdept");

                            // Load image into picture box
                            object imageData = mdr["timage"];
                            if (imageData != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])imageData;
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    timage.Image = Image.FromStream(ms);
                                    timage.SizeMode = PictureBoxSizeMode.Zoom;
                                    Image img = Image.FromStream(ms);
                                    timage.Image = img;
                                }
                            }
                            else
                            {
                                timage.Image = null; // Set the picture box image to null if no image is present
                            }

                            tname.Enabled = false;
                            tage.Enabled = false;
                            tgender.Enabled = false;
                            tbirth.Enabled = false;
                            taddress.Enabled = false;
                            temail.Enabled = false;
                            tpass.Enabled = false;
                            tuname.Enabled = false;
                            tSave.Enabled = false;
                            Tsearch.Enabled = false;
                            tdept.Enabled = false;
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
            MySqlCommand cmd = new MySqlCommand("SELECT TeacherAc FROM teacheracc WHERE teachername=@loggedInUser", con);
            cmd.Parameters.AddWithValue("@loggedInUser", loggedInUser);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            TeacherID.Text = i.ToString();

        }

        private void formTDteprof_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            GetID(loggedInUser);
            LoadData();

        }
    }
}
