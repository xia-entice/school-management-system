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
        string SconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd = karmakun_2002";
        public string loggedInUser;

        public formSDclass()
        {
            InitializeComponent();
        }

        public void GetSection(string loggedInUser)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT section FROM studentacc WHERE studuname=@loggedInUser", con);
            cmd.Parameters.AddWithValue("@loggedInUser", loggedInUser);
            string i = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            sbsection.Text = i;
        }

        private void formSDclass_Load(object sender, EventArgs e)
        {
            GetSection(loggedInUser);

        }
    }
}
