﻿using System;
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

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class formADstudent : Form
    {

        string SconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int StudentAc = 1310000;

        public formADstudent()
        {
            InitializeComponent();
            SGridFill();
            SClear();
        }

        private void formADstudent_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            ASsave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ASsave.Width, ASsave.Height, 20, 20));
            ASdelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ASdelete.Width, ASdelete.Height, 20, 20));
            ASsearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ASsearch.Width, ASsearch.Height, 15, 15));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int v);

        private void ASsave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
            {
                smysqlCon.Open();
                string name = "";
                int age = 0;
                string gender = "";
                int cnumber = 0;
                string address = "";
                string email = "";
                DateTime birthdate = new DateTime();
                byte[] image = null;
                string dept = "";
                string section = "";

                MySqlCommand selectCmd = new MySqlCommand("SELECT studname, sage, sgender, scnumber, saddress, semail, sbirthdate, simage,sdept FROM studentacc WHERE StudentAc = @StudentAc", smysqlCon);
                selectCmd.Parameters.AddWithValue("@StudentAc", StudentAc);
                using (MySqlDataReader reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
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
                            section = reader.IsDBNull(9) ? "" : reader.GetString(9);
                            reader.Close();
                        }
                    }
                }


                MySqlCommand smysqlCmd = new MySqlCommand("studentAddOrUp", smysqlCon);
                smysqlCmd.CommandType = CommandType.StoredProcedure;
                smysqlCmd.Parameters.AddWithValue("_StudentAc", StudentAc);
                smysqlCmd.Parameters.AddWithValue("_studuname", suname.Text.Trim());
                smysqlCmd.Parameters.AddWithValue("_studpass", spass.Text.Trim());
                smysqlCmd.Parameters.AddWithValue("_studname", name);
                smysqlCmd.Parameters.AddWithValue("_sage", age);
                smysqlCmd.Parameters.AddWithValue("_sgender", gender);
                smysqlCmd.Parameters.AddWithValue("_sbirthdate", birthdate);
                smysqlCmd.Parameters.AddWithValue("_saddress", address);
                smysqlCmd.Parameters.AddWithValue("_semail", email);
                smysqlCmd.Parameters.AddWithValue("_scnumber", cnumber);
                if (image != null && image.Length > 0)
                {
                    smysqlCmd.Parameters.AddWithValue("_simage", image);
                }
                else
                {
                    smysqlCmd.Parameters.AddWithValue("_simage", DBNull.Value);
                }
                smysqlCmd.Parameters.AddWithValue("_sdept", dept);
                smysqlCmd.Parameters.AddWithValue("_section", section);

                smysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                SGridFill();
                SClear();
            }
        }

        void SGridFill()
        {
            using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
            {
                smysqlCon.Open();
                MySqlDataAdapter ssqlDa = new MySqlDataAdapter("StudentView", smysqlCon);
                ssqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable sdtbl = new DataTable();
                ssqlDa.Fill(sdtbl);
                ASview.DataSource = sdtbl;
                ASview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ASview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // Assuming you have a DataGridView named dataGridView1

                // Create a new DataGridViewCellStyle object
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();

                // Set the desired font properties for the header
                headerStyle.Font = new Font("Open Sans", 11, FontStyle.Regular);

                // Apply the header style to the DataGridView
                ASview.ColumnHeadersDefaultCellStyle = headerStyle;
                ASview.Columns[0].HeaderText = "Student ID";
                ASview.Columns[1].Visible = false;
                ASview.Columns[2].Visible = false;
                ASview.Columns[3].HeaderText = "Student Name";
                ASview.Columns[4].Visible = false;
                ASview.Columns[5].Visible = false;
                ASview.Columns[6].Visible = false;
                ASview.Columns[7].Visible = false;
                ASview.Columns[8].HeaderText = "Student Email";
                ASview.Columns[9].HeaderText = "Student Contact Number";
                ASview.Columns[10].Visible = false;
                ASview.Columns[11].HeaderText = "Department and Course";
                ASview.Columns[12].Visible = false;
            }

        }

        void SClear()
        {
            suname.Text = spass.Text = ssearch.Text = "";
            StudentAc = 0;
            ASsave.Text = "Save";
            ASdelete.Enabled = false;
        }


        private void ASdelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
            {
                smysqlCon.Open();
                MySqlCommand smysqlCmd = new MySqlCommand("StudentDelete", smysqlCon);
                smysqlCmd.CommandType = CommandType.StoredProcedure;
                smysqlCmd.Parameters.AddWithValue("_StudentAc", StudentAc);
                smysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                SGridFill();
                SClear();
            }
        }

        private void ASview_DoubleClick(object sender, EventArgs e)
        {
            if (ASview.CurrentRow.Index != -1)
            {
                suname.Text = ASview.CurrentRow.Cells[1].Value.ToString();
                StudentAc = Convert.ToInt32(ASview.CurrentRow.Cells[0].Value.ToString());
                ASsave.Text = "Update";
                ASdelete.Enabled = true;
            }
        }

        private void ASsearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection smysqlCon = new MySqlConnection(SconnectionString))
            {
                smysqlCon.Open();
                MySqlDataAdapter ssqlDa = new MySqlDataAdapter("StudentSearch", smysqlCon);
                ssqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                ssqlDa.SelectCommand.Parameters.AddWithValue("_StudentSearch", ssearch.Text);
                DataTable sdtbl = new DataTable();
                ssqlDa.Fill(sdtbl);
                ASview.DataSource = sdtbl;
                ASview.Columns[1].Visible = false;
                ASview.Columns[2].Visible = false;
                //change x2
            }
        }
    }
}