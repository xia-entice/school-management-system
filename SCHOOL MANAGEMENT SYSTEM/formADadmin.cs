using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class formADadmin : Form
    {
        string AconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
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
        }

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

                MySqlCommand selectCmd = new MySqlCommand("SELECT name, adage, adgender, adcnumber, adaddress, ademail, adbirthdate FROM adminacc WHERE AdminAc = @AdminAc", amysqlCon);
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
                AAview.Columns[0].HeaderText = "Admin ID";
                AAview.Columns[1].Visible = false;
                AAview.Columns[2].Visible = false;

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
