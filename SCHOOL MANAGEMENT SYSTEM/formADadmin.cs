﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class formADadmin : Form
    {
        string AconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002"; //
        int AdminAc = 1110000;
        public formADadmin()
        {
            InitializeComponent();
            AGridFill();
            AClear();
        }

        private void formADadmin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            AAsave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AAsave.Width, AAsave.Height, 20, 20));
            AAdelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AAdelete.Width, AAdelete.Height, 20, 20));
            AAsearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AAsearch.Width, AAsearch.Height, 15, 15));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int v);


        private void AAsave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
            {
                amysqlCon.Open();
                string name = "";
                int age = 0;
                string gender = "";
                int cnumber = 0;
                string address = "";
                string email = "";
                DateTime birthdate = new DateTime();
                byte[] image = null;

                MySqlCommand selectCmd = new MySqlCommand("SELECT name, adage, adgender, adcnumber, adaddress, ademail, adbirthdate, aimage FROM adminacc WHERE AdminAc = @AdminAc", amysqlCon);
                selectCmd.Parameters.AddWithValue("@AdminAc", AdminAc);
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
                        reader.Close();
                    }
                }



                MySqlCommand amysqlCmd = new MySqlCommand("adminAddOrUp", amysqlCon);
                amysqlCmd.CommandType = CommandType.StoredProcedure;
                amysqlCmd.Parameters.AddWithValue("_AdminAc", AdminAc);
                amysqlCmd.Parameters.AddWithValue("_uname", auname.Text.Trim());
                amysqlCmd.Parameters.AddWithValue("_pass", apass.Text.Trim());
                amysqlCmd.Parameters.AddWithValue("_name", name);
                amysqlCmd.Parameters.AddWithValue("_adage", age);
                amysqlCmd.Parameters.AddWithValue("_adgender", gender);
                amysqlCmd.Parameters.AddWithValue("_adbirthdate", birthdate);
                amysqlCmd.Parameters.AddWithValue("_adaddress", address);
                amysqlCmd.Parameters.AddWithValue("_ademail", email);
                amysqlCmd.Parameters.AddWithValue("_adcnumber", cnumber);
                if (image != null && image.Length > 0)
                {
                    amysqlCmd.Parameters.AddWithValue("_aimage", image);
                }
                else
                {
                    amysqlCmd.Parameters.AddWithValue("_aimage", DBNull.Value);
                }
                amysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                AGridFill();
                AClear();

            }
        }


        void AGridFill()
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
            {
                amysqlCon.Open();
                MySqlDataAdapter asqlDa = new MySqlDataAdapter("AdminView", amysqlCon);
                asqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable adtbl = new DataTable();
                asqlDa.Fill(adtbl);
                AAview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                AAview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                AAview.DataSource = adtbl;
                // Assuming you have a DataGridView named dataGridView1

                // Create a new DataGridViewCellStyle object
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();

                // Set the desired font properties for the header
                headerStyle.Font = new Font("Open Sans", 11, FontStyle.Regular);

                // Apply the header style to the DataGridView
                AAview.ColumnHeadersDefaultCellStyle = headerStyle;

                AAview.Columns[0].HeaderText = "Admin ID";
                AAview.Columns[1].Visible = false;
                AAview.Columns[2].Visible = false;
                AAview.Columns[3].HeaderText = "Admin Name";
                AAview.Columns[4].Visible = false;
                AAview.Columns[5].Visible = false;
                AAview.Columns[6].Visible = false;
                AAview.Columns[7].Visible = false;
                AAview.Columns[8].HeaderText = "Admin Email";
                AAview.Columns[9].HeaderText = "Admin Contact Number";
                AAview.Columns[10].Visible = false;

            }

        }
        void AClear()
        {
            auname.Text = apass.Text = Asearch.Text = "";
            AdminAc = 0;
            AAsave.Text = "Save";
            AAdelete.Enabled = false;
        }

        private void AAview_DoubleClick(object sender, EventArgs e)
        {
            if (AAview.CurrentRow.Index != -1)
            {
                auname.Text = AAview.CurrentRow.Cells[1].Value.ToString();
                AdminAc = Convert.ToInt32(AAview.CurrentRow.Cells[0].Value.ToString());
                AAsave.Text = "Update";
                AAdelete.Enabled = true;
            }
        }

        private void AAsearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
            {
                amysqlCon.Open();
                MySqlDataAdapter asqlDa = new MySqlDataAdapter("AdminSearch", amysqlCon);
                asqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                asqlDa.SelectCommand.Parameters.AddWithValue("_AdminSearch", Asearch.Text);
                DataTable adtbl = new DataTable();
                asqlDa.Fill(adtbl);
                AAview.DataSource = adtbl;
                AAview.Columns[1].Visible = false;
                AAview.Columns[2].Visible = false;
            }
        }

        private void AAdelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(AconnectionString))
            {
                amysqlCon.Open();
                MySqlCommand amysqlCmd = new MySqlCommand("AdminDelete", amysqlCon);
                amysqlCmd.CommandType = CommandType.StoredProcedure;
                amysqlCmd.Parameters.AddWithValue("_AdminAc", AdminAc);
                amysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                AGridFill();
                AClear();
            }
        }
    }
}
