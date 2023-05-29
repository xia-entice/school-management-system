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
    public partial class formTDsched : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002");
        string CconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int idclass = 0;
        public string loggedInUser;
        int AccID;
        public formTDsched()

        {
            InitializeComponent();
            GetID(loggedInUser);
            CGridFill();
            CClear();
            sortbyID();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cmysqlCon = new MySqlConnection(CconnectionString))
            {
                cmysqlCon.Open();
                int idclass = 0;
                int AccID = 0;
                string subject = "";
                string section = "";
                int rnumber = 0;
                string timestart = "";
                string timeend = "";

                MySqlCommand selectCmd = new MySqlCommand("SELECT AccID, subject, section, rnumber, timestart, timeend FROM class WHERE idclass = @idclass", cmysqlCon);
                selectCmd.Parameters.AddWithValue("@idclass", idclass);
                using (MySqlDataReader reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idclass = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        AccID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        subject = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        rnumber = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                        timestart = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        timeend = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        reader.Close();
                    }
                }

                MySqlCommand cmysqlCmd = new MySqlCommand("classAddorEdit", cmysqlCon);
                cmysqlCmd.CommandType = CommandType.StoredProcedure;
                cmysqlCmd.Parameters.AddWithValue("_idclass", idclass);
                cmysqlCmd.Parameters.AddWithValue("_subject", tsSub.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_section", tsClass.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_rnumber", tsRoom.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_timestart", tsStart.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_timeend", tsEnd.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_AccID", AccID);
                cmysqlCmd.ExecuteNonQuery();
                cmysqlCon.Close();
                MessageBox.Show("Saved Successfully");
                CClear();
                CGridFill();
            }


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
                tSchedview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tSchedview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tSchedview.DataSource = adtbl;
                tSchedview.Columns[0].Visible = false;
                tSchedview.Columns[5].Visible = false;
                tSchedview.Columns[6].Visible = false;
                tSchedview.Columns[7].Visible = false;
            }
            sortbyID();
        }

        private void formTDsched_Load(object sender, EventArgs e)
        {
            CGridFill();
            CClear();
            sortbyID();
        }
        void CClear()
        {
            tsSub.Text = tsClass.Text = tsRoom.Text = tsStart.Text = tsEnd.Text = "";
            idclass = 0;
        }

        private void tSchedview_DoubleClick(object sender, EventArgs e)
        {
            if (tSchedview.CurrentRow.Index != -1)
            {
                tsSub.Text = tSchedview.CurrentRow.Cells[1].Value.ToString();
                tsClass.Text = tSchedview.CurrentRow.Cells[6].Value.ToString();
                tsRoom.Text = tSchedview.CurrentRow.Cells[2].Value.ToString();
                tsStart.Text = tSchedview.CurrentRow.Cells[4].Value.ToString();
                tsEnd.Text = tSchedview.CurrentRow.Cells[3].Value.ToString();
                AccID = Convert.ToInt32(tSchedview.CurrentRow.Cells[5].Value.ToString());
                idclass = Convert.ToInt32(tSchedview.CurrentRow.Cells[0].Value.ToString());
                tsSave.Text = "Update";
                tsDelete.Enabled = true;
            }
            sortbyID();
        }
    }
}
