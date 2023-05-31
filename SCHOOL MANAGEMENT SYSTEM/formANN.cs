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
    public partial class formANN : Form
    {

        string AnconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd=karmakun_2002";
        int AnID = 0;

        public formANN()
        {
            InitializeComponent();
        }

        List<string> announcementsList = new List<string>();

        private void LoadAnnouncements()
        {
            using (MySqlConnection anmysqlCon = new MySqlConnection(AnconnectionString))
            {
                anmysqlCon.Open();

                // Clear the existing announcements from the panel and the list
                Annpanel1.Controls.Clear();
                announcementsList.Clear();

                // Retrieve all the announcements from the database
                string query = "SELECT AnID, Announcement FROM announcement";
                MySqlCommand cmd = new MySqlCommand(query, anmysqlCon);
                MySqlDataReader reader = cmd.ExecuteReader();

                int top = 10;
                int left = 10;
                int tabIndex = 1;
                while (reader.Read())
                {
                    // Add each announcement to the list
                    int anId = reader.GetInt32(0);
                    string announcement = reader.GetString(1);
                    announcementsList.Add(announcement);

                    // Create a new label for each announcement and add it to the panel
                    Label lbl = new Label();
                    lbl.Name = $"lbl{anId}";
                    lbl.Top = top;
                    lbl.Left = left;
                    lbl.Width = Annpanel1.Width - 20;
                    lbl.ForeColor = Color.Black;
                    lbl.BackColor = Color.FromArgb(255, 214, 51);
                    lbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    lbl.Text = announcement;
                    lbl.Margin = new Padding(0, 10, 0, 0); // Add margin to separate the labels
                    lbl.AutoSize = true; // Enable auto-sizing to adjust label height
                    lbl.MaximumSize = new Size(lbl.Width, 0); // Set maximum width to label width
                    lbl.TextAlign = ContentAlignment.TopLeft; // Set the text alignment to top-left
                    Annpanel1.Controls.Add(lbl);

                    // Increase the top position for the next label
                    top = lbl.Bottom + 10;
                }

                // Resize the panel and update the scrollable area
                Annpanel1.AutoScroll = true;
                Annpanel1.AutoScrollMinSize = new Size(0, top);
            }
        }

        private void formANN_Load(object sender, EventArgs e)
        {
            LoadAnnouncements();
        }
    }
}
