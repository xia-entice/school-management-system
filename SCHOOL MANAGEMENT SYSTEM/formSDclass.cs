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
    public partial class formSDclass : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002");
        string CconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        int idclass = 0;
        public string loggedInUser;
  
        public formSDclass()
        {
            InitializeComponent();
        }


        private void formSDclass_Load(object sender, EventArgs e)
        {
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
                sclassview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                sclassview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                sclassview.DataSource = adtbl;
                sclassview.Columns[0].Visible = false;
                sclassview.Columns[5].Visible = false;
                sclassview.Columns[6].Visible = false;
                sclassview.Columns[7].Visible = false;
            }
            sortbySection();
        }

        private void sclassview_DoubleClick(object sender, EventArgs e)
        {
            if (sclassview.CurrentRow.Index != -1)
            {
                sbsub.Text = sclassview.CurrentRow.Cells[1].Value.ToString();
                sbunit.Text = sclassview.CurrentRow.Cells[6].Value.ToString();
                sbcode.Text = sclassview.CurrentRow.Cells[2].Value.ToString();
                sbsched.Text = sclassview.CurrentRow.Cells[4].Value.ToString();
                sbsection.Text = sclassview.CurrentRow.Cells[3].Value.ToString();
                scdesc.Text = sclassview.CurrentRow.Cells[5].Value.ToString();
                idclass = Convert.ToInt32(sclassview.CurrentRow.Cells[0].Value.ToString());
            
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

            sbsection.Text = result.ToString();
      
        }

        public void sortbySection()
        {
            using (MySqlConnection amysqlCon = new MySqlConnection(CconnectionString))
            {
                amysqlCon.Open();
                MySqlDataAdapter asqlDa = new MySqlDataAdapter("classSearch", amysqlCon);
                asqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                asqlDa.SelectCommand.Parameters.AddWithValue("_classSearch", sbsection.Text.Trim());
                DataTable adtbl = new DataTable();
                asqlDa.Fill(adtbl);
                sclassview.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                sclassview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                sclassview.DataSource = adtbl;
                sclassview.Columns[0].Visible = false;
                sclassview.Columns[3].Visible = false;
                sclassview.Columns[4].Visible = false;
                sclassview.Columns[5].Visible = false;
                sclassview.Columns[6].Visible = false;
                sclassview.Columns[7].Visible = false;
                sclassview.Columns[8].Visible = false;
                sclassview.Columns[9].Visible = false;
                sclassview.Columns[10].Visible = false;




            }

        }
    }
}
