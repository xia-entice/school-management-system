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
using System.Runtime.InteropServices;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class formTDclass : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002");
        string CconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int idclass = 0;
        public string loggedInUser;
        int AccID;

        public formTDclass()
        {
            InitializeComponent();
            GetID(loggedInUser);
            CGridFill();
            CClear();
            sortbyID();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int v);

        private void tclassSave_Click(object sender, EventArgs e)
        {



            using (MySqlConnection cmysqlCon = new MySqlConnection(CconnectionString))
            {
                cmysqlCon.Open();
                int rnum = 0;
                string  tstart= "";
                string tend = "";

                MySqlCommand selectCmd = new MySqlCommand("SELECT rnumber, timestart, timeend FROM class WHERE idclass = @idclass", cmysqlCon);
                selectCmd.Parameters.AddWithValue("@idclass", idclass);
                using (MySqlDataReader reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rnum = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        tstart = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        tend = reader.IsDBNull(2) ? "" : reader.GetString(2);

                        reader.Close();
                    }
                }



                MySqlCommand cmysqlCmd = new MySqlCommand("classAddOrEdit", cmysqlCon);
                cmysqlCmd.CommandType = CommandType.StoredProcedure;
                cmysqlCmd.Parameters.AddWithValue("_idclass", idclass);
                cmysqlCmd.Parameters.AddWithValue("_subject", tbsub.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_unit", tbunit.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_code", tbcode.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_schedule", tbsched.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_section", tbclass.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_description", tcdesc.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_AccID", AccID);
                cmysqlCmd.Parameters.AddWithValue("_rnumber", rnum);
                cmysqlCmd.Parameters.AddWithValue("_timestart", tstart);
                cmysqlCmd.Parameters.AddWithValue("_timeend", tend);
                cmysqlCmd.ExecuteNonQuery();
                cmysqlCon.Close();
                MessageBox.Show("Saved Successfully");
                CGridFill();
                CClear();


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
                tclassview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tclassview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tclassview.DataSource = adtbl;
                tclassview.Columns[0].Visible = false;
                tclassview.Columns[5].Visible = false;
                tclassview.Columns[6].Visible = false;
                tclassview.Columns[7].Visible = false;
                tclassview.Columns[8].Visible = false;
                tclassview.Columns[9].Visible = false;
                tclassview.Columns[10].Visible = false;
            }
            sortbyID();
        }

        void CClear()
        {
            tbsub.Text = tbunit.Text = tbcode.Text = tbclass.Text = tcdesc.Text = tbsched.Text = "";
            idclass = 0;
        }

        private void tclassview_DoubleClick(object sender, EventArgs e)
        {
            if (tclassview.CurrentRow.Index != -1)
            {
                tbsub.Text = tclassview.CurrentRow.Cells[1].Value.ToString();
                tbunit.Text = tclassview.CurrentRow.Cells[6].Value.ToString();
                tbcode.Text = tclassview.CurrentRow.Cells[2].Value.ToString();
                tbsched.Text = tclassview.CurrentRow.Cells[4].Value.ToString();
                tbclass.Text = tclassview.CurrentRow.Cells[3].Value.ToString();
                tcdesc.Text = tclassview.CurrentRow.Cells[5].Value.ToString();
                idclass = Convert.ToInt32(tclassview.CurrentRow.Cells[0].Value.ToString());
                tclassSave.Text = "Update";
                tclassDelete.Enabled = true;
            }
            sortbyID();
        }

        private void tclassDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(CconnectionString))
            {
                amysqlCon.Open();
                MySqlCommand amysqlCmd = new MySqlCommand("classDelete", amysqlCon);
                amysqlCmd.CommandType = CommandType.StoredProcedure;
                amysqlCmd.Parameters.AddWithValue("_idclass", idclass);
                amysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                CGridFill();
                CClear();
            }
            sortbyID();
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
                tclassview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tclassview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tclassview.DataSource = adtbl;
                tclassview.Columns[0].Visible = false;
                tclassview.Columns[5].Visible = false;
                tclassview.Columns[6].Visible = false;
                tclassview.Columns[7].Visible = false;




            }

        }


        private void formTDclass_Load(object sender, EventArgs e)
        {
            GetID(loggedInUser);
            CGridFill();
            CClear();
            sortbyID();
            tclassSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tclassSave.Width, tclassSave.Height, 20, 20));
            tclassDelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tclassDelete.Width, tclassDelete.Height, 20, 20));
        }
    }


}
