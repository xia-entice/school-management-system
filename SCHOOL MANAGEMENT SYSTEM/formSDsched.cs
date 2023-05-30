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
    public partial class formSDsched : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002");
        string CconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int idclass = 0;
        public string loggedInUser;
        private string section;
        public formSDsched()
        {
            InitializeComponent();
            GetID(loggedInUser);
            CGridFill();
            sortbySection();
        }

        void CGridFill()
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(CconnectionString))
            {
                amysqlCon.Open();
                MySqlDataAdapter asqlDa = new MySqlDataAdapter("classView", amysqlCon);
                asqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable adtbl = new DataTable();
                asqlDa.Fill(adtbl);
                sSched.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                sSched.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                sSched.DataSource = adtbl;
                sSched.Columns[0].Visible = true;
                sSched.Columns[5].Visible = false;
                sSched.Columns[6].Visible = false;
                sSched.Columns[7].Visible = false;
            }
            sortbySection();
        }

        public void GetID(string loggedInUser)
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT section FROM studentacc WHERE studuname=@loggedInUser", con);
            cmd.Parameters.AddWithValue("@loggedInUser", loggedInUser);
            string result = cmd.ExecuteScalar()?.ToString();
            con.Close();
            section = result;

        }

        public void sortbySection()
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(CconnectionString))
            {
                amysqlCon.Open();
                MySqlDataAdapter asqlDa = new MySqlDataAdapter("classSearch", amysqlCon);
                asqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                asqlDa.SelectCommand.Parameters.AddWithValue("_classSearch", section);
                DataTable adtbl = new DataTable();
                asqlDa.Fill(adtbl);
                sSched.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                sSched.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                sSched.DataSource = adtbl;
                sSched.Columns[0].Visible = false;
                sSched.Columns[3].Visible = false;
                sSched.Columns[4].Visible = true;
                sSched.Columns[5].Visible = false;
                sSched.Columns[6].Visible = false;
                sSched.Columns[7].Visible = false;
                sSched.Columns[8].Visible = false;
                sSched.Columns[9].Visible = true;
                sSched.Columns[10].Visible = true;

            }

        }

        private void ssSelect_Click(object sender, EventArgs e)
        {
            CGridFill();
            sortbySection();
            using (MySqlConnection amysqlCon = new MySqlConnection(CconnectionString))
            {
                amysqlCon.Open();
                MySqlDataAdapter asqlDa = new MySqlDataAdapter("SortBySchedule", amysqlCon);
                asqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (ssDays.Text == "All")
                {
                    ssDays.Text = "";
                }
                asqlDa.SelectCommand.Parameters.AddWithValue("_schedule", ssDays.Text);
                DataTable adtbl = new DataTable();
                asqlDa.Fill(adtbl);
                sSched.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                sSched.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                sSched.DataSource = adtbl;
                sSched.Columns[0].Visible = false;
                sSched.Columns[5].Visible = false;
                sSched.Columns[6].Visible = false;
                sSched.Columns[7].Visible = false;
            }
        }

        private void formSDsched_Load(object sender, EventArgs e)
        {
            GetID(loggedInUser);
            CGridFill();
            sortbySection();
        }
    }
}
