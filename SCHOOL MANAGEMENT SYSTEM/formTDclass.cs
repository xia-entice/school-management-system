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
    public partial class formTDclass : Form
    {
        string CconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
         int  idclass =0;
        public formTDclass()
        {
            InitializeComponent();
            CGridFill();
            CClear();
        }

        private void tclassSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cmysqlCon = new MySqlConnection(CconnectionString))
            {
                cmysqlCon.Open();
                MySqlCommand cmysqlCmd = new MySqlCommand("classAddOrEdit", cmysqlCon);
                cmysqlCmd.CommandType = CommandType.StoredProcedure;
                cmysqlCmd.Parameters.AddWithValue("_idclass", idclass);
                cmysqlCmd.Parameters.AddWithValue("_subject", tbsub.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_unit", tbunit.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_code", tbcode.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_schedule", tbsched.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_section", tbclass.Text.Trim());
                cmysqlCmd.Parameters.AddWithValue("_description", tcdesc.Text.Trim());
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
                
             


            }

        }

        void CClear()
        {
            tbsub.Text = tbunit.Text = tbcode.Text =tbclass.Text =tcdesc.Text = "";
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
        }
    }
}
