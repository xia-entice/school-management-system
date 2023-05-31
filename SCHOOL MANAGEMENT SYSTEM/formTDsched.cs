using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class formTDsched : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd=karmakun_2002");
        string CconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd=karmakun_2002";
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
                string subject = "";
                int unit = 0;
                string code = "";
                string schedule = "";
                string section = "";
                string description = "";

                MySqlCommand selectCmd = new MySqlCommand("SELECT subject, units, code, schedule, section, description FROM class WHERE idclass = @idclass", cmysqlCon);
                selectCmd.Parameters.AddWithValue("@idclass", idclass);

                using (MySqlDataReader reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        subject = reader.IsDBNull(0) ? "" : reader.GetString(0);
                        unit = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                        code = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        schedule = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        section = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        description = reader.IsDBNull(5) ? "" : reader.GetString(5);

                        reader.Close();
                    }
                }

                bool isOverlapping = IsScheduleOverlapping(schedule, tsStart.Text.Trim(), tsEnd.Text.Trim(), idclass);
                if (isOverlapping)
                {
                    MessageBox.Show("The selected day and time overlap with an existing schedule. Please choose a different day and time.");
                    return;
                }

                MySqlCommand cmysqlCmd = new MySqlCommand("classAddorEdit", cmysqlCon);
                cmysqlCmd.CommandType = CommandType.StoredProcedure;
                cmysqlCmd.Parameters.AddWithValue("_idclass", idclass);
                cmysqlCmd.Parameters.AddWithValue("_subject", subject);
                cmysqlCmd.Parameters.AddWithValue("_unit", unit);
                cmysqlCmd.Parameters.AddWithValue("_code", code);
                cmysqlCmd.Parameters.AddWithValue("_schedule", schedule);
                cmysqlCmd.Parameters.AddWithValue("_section", section);
                cmysqlCmd.Parameters.AddWithValue("_description", description);
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

        private bool IsScheduleOverlapping(string day, string startTime, string endTime, int currentClassId)
        {
            using (MySqlConnection cmysqlCon = new MySqlConnection(CconnectionString))
            {
                cmysqlCon.Open();

                MySqlCommand selectCmd = new MySqlCommand("SELECT idclass, schedule, timestart, timeend FROM class WHERE idclass <> @currentClassId AND schedule LIKE @day", cmysqlCon);
                selectCmd.Parameters.AddWithValue("@currentClassId", currentClassId);
                selectCmd.Parameters.AddWithValue("@day", $"%{day}%");

                using (MySqlDataReader reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int existingClassId = reader.GetInt32(0);
                        string existingSchedule = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        string existingStartTime = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        string existingEndTime = reader.IsDBNull(3) ? "" : reader.GetString(3);

                        DateTime subjectStartTime;
                        DateTime subjectEndTime;
                        DateTime newStartTime;
                        DateTime newEndTime;

                        bool isSubjectStartTimeValid = DateTime.TryParseExact(existingStartTime, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out subjectStartTime);
                        bool isSubjectEndTimeValid = DateTime.TryParseExact(existingEndTime, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out subjectEndTime);
                        bool isNewStartTimeValid = DateTime.TryParseExact(startTime, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out newStartTime);
                        bool isNewEndTimeValid = DateTime.TryParseExact(endTime, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out newEndTime);

                        if (!isSubjectStartTimeValid || !isSubjectEndTimeValid || !isNewStartTimeValid || !isNewEndTimeValid)
                        {
                            // Handle the case when time parsing fails
                            // For example, display an error message or take appropriate action
                            MessageBox.Show("Invalid time format.");
                            return false;
                        }
                        else
                        {
                            if (existingSchedule.Equals(day, StringComparison.OrdinalIgnoreCase) &&
                                ((newStartTime >= subjectStartTime && newStartTime < subjectEndTime) ||
                                (newEndTime > subjectStartTime && newEndTime <= subjectEndTime) ||
                                (newStartTime <= subjectStartTime && newEndTime >= subjectEndTime)))
                            {
                                MessageBox.Show($"Class {existingClassId} has an overlapping schedule.");
                                return true; // Overlapping schedule found
                            }
                        }
                    }
                }
            }

            return false; // No overlapping schedule found
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
                // Assuming you have a DataGridView named dataGridView1

                // Create a new DataGridViewCellStyle object
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();

                // Set the desired font properties for the header
                headerStyle.Font = new Font("Open Sans", 11, FontStyle.Regular);

                // Apply the header style to the DataGridView
                tSchedview.ColumnHeadersDefaultCellStyle = headerStyle;
                tSchedview.DataSource = adtbl;
                tSchedview.Columns[0].Visible = true;
                tSchedview.Columns[5].Visible = false;
                tSchedview.Columns[6].Visible = false;
                tSchedview.Columns[7].Visible = false;

            }
            sortbyID();
        }

        private void formTDsched_Load(object sender, EventArgs e)
        {
            GetID(loggedInUser);
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
                idclass = Convert.ToInt32(tSchedview.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show(idclass.ToString());
                tsSub.Text = tSchedview.CurrentRow.Cells[1].Value.ToString();
                tsClass.Text = tSchedview.CurrentRow.Cells[3].Value.ToString();
                tsRoom.Text = tSchedview.CurrentRow.Cells[8].Value.ToString();

                DateTime startDateTime;
                if (DateTime.TryParse(tSchedview.CurrentRow.Cells[9].Value.ToString(), out startDateTime))
                {
                    tsStart.Text = startDateTime.ToString("hh:mm tt");
                }
                DateTime endDateTime;
                if (DateTime.TryParse(tSchedview.CurrentRow.Cells[10].Value.ToString(), out endDateTime))
                {
                    tsEnd.Text = endDateTime.ToString("hh:mm tt");
                }

                tsSave.Text = "Update";
                tsDelete.Enabled = true;
            }
        }

        public void sortbyID()
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(CconnectionString))
            {
                amysqlCon.Open();
                MySqlDataAdapter asqlDa = new MySqlDataAdapter("SearchByID", amysqlCon);
                asqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                asqlDa.SelectCommand.Parameters.AddWithValue("_AccID", AccID);
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
        }

        public void GetID(string loggedInUser)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT TeacherAc FROM teacheracc WHERE teachername=@loggedInUser", con);
            cmd.Parameters.AddWithValue("@loggedInUser", loggedInUser);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            AccID = i;
        }

        private void tsSelect_Click(object sender, EventArgs e)
        {
            CGridFill();
            sortbyID();
            using (MySqlConnection amysqlCon = new MySqlConnection(CconnectionString))
            {
                amysqlCon.Open();
                MySqlDataAdapter asqlDa = new MySqlDataAdapter("SortBySchedule", amysqlCon);
                asqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (tsDays.Text == "All")
                {
                    tsDays.Text = "";
                }
                asqlDa.SelectCommand.Parameters.AddWithValue("_schedule", tsDays.Text);
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
        }
    }
}