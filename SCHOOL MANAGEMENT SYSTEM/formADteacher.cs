using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class formADteacher : Form
    {
        string TconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int TeacherAc = 1210000;
        public formADteacher()
        {
            InitializeComponent();
            TGridFill();
            TClear();
        }

        private void formADteacher_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            ATsave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ATsave.Width, ATsave.Height, 20, 20));
            ATdelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ATdelete.Width, ATdelete.Height, 20, 20));
            ATsearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ATsearch.Width, ATsearch.Height, 15, 15));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int v);

        private void ATsave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection tmysqlCon = new MySqlConnection(TconnectionString))
            {
                tmysqlCon.Open();
                string name = "";
                int age = 0;
                string gender = "";
                int cnumber = 0;
                string address = "";
                string email = "";
                DateTime birthdate = new DateTime();
                byte[] image = null;
                string dept = "";

                MySqlCommand selectCmd = new MySqlCommand("SELECT tname, tage, tgender, tcnumber, taddress, temail, tbirthdate, timage,tdept FROM teacheracc WHERE TeacherAc = @TeacherAc", tmysqlCon);
                selectCmd.Parameters.AddWithValue("@TeacherAc", TeacherAc);
                using (MySqlDataReader reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        name = reader.IsDBNull(0) ? "" : reader.GetString(0);
                        age = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        gender = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        cnumber = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                        address = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        email = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        birthdate = reader.IsDBNull(6) ? new DateTime() : reader.GetDateTime(6);
                        if (!reader.IsDBNull(7))
                        {
                            image = (byte[])reader.GetValue(7);
                        }
                        dept = reader.IsDBNull(8) ? "" : reader.GetString(5);
                        reader.Close();
                    }
                }


                MySqlCommand tmysqlCmd = new MySqlCommand("teacherAddOrUp", tmysqlCon);
                tmysqlCmd.CommandType = CommandType.StoredProcedure;
                tmysqlCmd.Parameters.AddWithValue("_TeacherAc", TeacherAc);
                tmysqlCmd.Parameters.AddWithValue("_teachername", tuname.Text.Trim());
                tmysqlCmd.Parameters.AddWithValue("_teacherpassword", tpass.Text.Trim());
                tmysqlCmd.Parameters.AddWithValue("_tname", name);
                tmysqlCmd.Parameters.AddWithValue("_tage", age);
                tmysqlCmd.Parameters.AddWithValue("_tgender", gender);
                tmysqlCmd.Parameters.AddWithValue("_tbirthdate", birthdate);
                tmysqlCmd.Parameters.AddWithValue("_taddress", address);
                tmysqlCmd.Parameters.AddWithValue("_temail", email);
                tmysqlCmd.Parameters.AddWithValue("_tcnumber", cnumber);
                if (image != null && image.Length > 0)
                {
                    tmysqlCmd.Parameters.AddWithValue("_timage", image);
                }
                else
                {
                    tmysqlCmd.Parameters.AddWithValue("_timage", DBNull.Value);
                }
                tmysqlCmd.Parameters.AddWithValue("_tdept", dept);
                tmysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                TGridFill();
                TClear();
            }
        }

        void TGridFill()
        {
            using (MySqlConnection tmysqlCon = new MySqlConnection(TconnectionString))
            {
                tmysqlCon.Open();
                MySqlDataAdapter tsqlDa = new MySqlDataAdapter("TeacherView", tmysqlCon);
                tsqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tdtbl = new DataTable();
                tsqlDa.Fill(tdtbl);
                ATview.DataSource = tdtbl;
                ATview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ATview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // Assuming you have a DataGridView named dataGridView1

                // Create a new DataGridViewCellStyle object
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();

                // Set the desired font properties for the header
                headerStyle.Font = new Font("Open Sans", 11, FontStyle.Regular);

                // Apply the header style to the DataGridView
                ATview.ColumnHeadersDefaultCellStyle = headerStyle;
                ATview.Columns[0].HeaderText = "Teacher ID";
                ATview.Columns[1].Visible = false;
                ATview.Columns[2].Visible = false;
                ATview.Columns[3].HeaderText = "Admin Name";
                ATview.Columns[4].Visible = false;
                ATview.Columns[5].Visible = false;
                ATview.Columns[6].Visible = false;
                ATview.Columns[7].Visible = false;
                ATview.Columns[8].HeaderText = "Teacher Email";
                ATview.Columns[9].HeaderText = "Teacher Contact Number";
                ATview.Columns[10].Visible = false;
                ATview.Columns[11].HeaderText = "Department";
            }

        }

        void TClear()
        {
            tuname.Text = tpass.Text = tsearch.Text = "";
            TeacherAc = 0;
            ATsave.Text = "Save";
            ATdelete.Enabled = false;
        }

        private void ATview_DoubleClick(object sender, EventArgs e)
        {
            if (ATview.CurrentRow.Index != -1)
            {
                tuname.Text = ATview.CurrentRow.Cells[1].Value.ToString();
                TeacherAc = Convert.ToInt32(ATview.CurrentRow.Cells[0].Value.ToString());
                ATsave.Text = "Update";
                ATdelete.Enabled = true;
            }
        }

        private void ATsearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection tmysqlCon = new MySqlConnection(TconnectionString))
            {
                tmysqlCon.Open();
                MySqlDataAdapter tsqlDa = new MySqlDataAdapter("TeacherSearch", tmysqlCon);
                tsqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                tsqlDa.SelectCommand.Parameters.AddWithValue("_TeacherSearch", tsearch.Text);
                DataTable adtbl = new DataTable();
                tsqlDa.Fill(adtbl);
                ATview.DataSource = adtbl;
                ATview.Columns[1].Visible = false;
                ATview.Columns[2].Visible = false;
            }
        }

        private void ATdelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection tmysqlCon = new MySqlConnection(TconnectionString))
            {
                tmysqlCon.Open();
                MySqlCommand tmysqlCmd = new MySqlCommand("TeacherDelete", tmysqlCon);
                tmysqlCmd.CommandType = CommandType.StoredProcedure;
                tmysqlCmd.Parameters.AddWithValue("_TeacherAc", TeacherAc);
                tmysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                TGridFill();
                TClear();
            }
        }
    }
}
