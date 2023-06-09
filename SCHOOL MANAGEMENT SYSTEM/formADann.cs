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
    public partial class formADann : Form
    {
        MySqlConnection con = new MySqlConnection(@"Server=localhost;Database=studmanagment;Uid=root;Pwd=karmakun_2002");
        string AnconnectionString = @"Server=localhost;Database=studmanagment;Uid=root;Pwd=karmakun_2002";
        int AnID = 0;
        public string loggedInUser;
        string user;

        public formADann()
        {
            InitializeComponent();
            loggedInUser = ""; // Assign a value to loggedInUser
            GetID(loggedInUser);
            NameandTime();
            LoadAnnouncements();
            AnClear();
        }

        private void formADann_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            GetID(loggedInUser);
            NameandTime();
            LoadAnnouncements();
            AnClear();
            annPost.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, annPost.Width, annPost.Height, 20, 20));
            annDelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, annDelete.Width, annDelete.Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int v);


        List<string> announcementsList = new List<string>();

        private void NameandTime()
        {
            DateTime currenttime = DateTime.Now;
            Postrtb.Text = "From: " + user + "\n" + currenttime + "\n\n";
        }

        private void annPost_Click(object sender, EventArgs e)
        {
            using (MySqlConnection anmysqlCon = new MySqlConnection(AnconnectionString))
            {
                anmysqlCon.Open();
                MySqlCommand anmysqlCmd = new MySqlCommand("AnAddorEdit", anmysqlCon);
                anmysqlCmd.CommandType = CommandType.StoredProcedure;
                anmysqlCmd.Parameters.AddWithValue("_AnID", AnID);
                anmysqlCmd.Parameters.AddWithValue("_announcement", Postrtb.Text.Trim());
                AnID = Convert.ToInt32(anmysqlCmd.ExecuteScalar()); // Update the AnID variable with the newly inserted/updated announcement ID
                MessageBox.Show("Posted Successfully");

                AnClear();

                // Reload the announcements from the database and display them in the panel
                LoadAnnouncements();
            }
        }

        void AnClear()
        {
            NameandTime();
            SelectedAnnouncementId = 0;
            annPost.Text = "Post";
        }

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
                    lbl.TabIndex = tabIndex++; // Set the tab index to make the label selectable
                    lbl.Click += Label_Click; // Attach the Click event handler to make the label focused
                    Annpanel1.Controls.Add(lbl);

                    // Increase the top position for the next label
                    top = lbl.Bottom + 10;
                }

                // Resize the panel and update the scrollable area
                Annpanel1.AutoScroll = true;
                Annpanel1.AutoScrollMinSize = new Size(0, top);
            }
        }

        private int SelectedAnnouncementId { get; set; }

        private void Label_Click(object sender, EventArgs e)
        {
            foreach (Label label in Annpanel1.Controls.OfType<Label>())
            {
                label.BackColor = Color.FromArgb(255, 214, 51);
            }
            Label clickedLabel = (Label)sender;
            clickedLabel.BackColor = Color.FromArgb(245, 196, 0); // Set the background color of the clicked label to WhiteSmoke

            // Get the ID of the selected announcement and store it in the SelectedAnnouncementId property
            int selectedIndex = Annpanel1.Controls.IndexOf(clickedLabel);
            SelectedAnnouncementId = selectedIndex >= 0 ? selectedIndex + 1 : 0;

            // Update the AnID variable
            AnID = SelectedAnnouncementId;
            Postrtb.Text = clickedLabel.Text;
            annPost.Text = "Update";
        }

        private void annDelete_Click(object sender, EventArgs e)
        {
            if (Annpanel1.Controls.Count == 0)
            {
                MessageBox.Show("There are no announcements to delete");
                return;
            }

            // Check if a label was selected
            if (SelectedAnnouncementId == 0)
            {
                MessageBox.Show("Please select a label to delete");
                return;
            }

            // Show confirmation dialog before deleting the announcement
            DialogResult result = MessageBox.Show("Are you sure you want to delete this announcement?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                using (MySqlConnection anmysqlCon = new MySqlConnection(AnconnectionString))
                {
                    anmysqlCon.Open();
                    MySqlCommand anmysqlCmd = new MySqlCommand("AnDelete", anmysqlCon);
                    anmysqlCmd.CommandType = CommandType.StoredProcedure;
                    anmysqlCmd.Parameters.AddWithValue("_AnId", SelectedAnnouncementId); // Use the selected announcement ID
                    anmysqlCmd.ExecuteNonQuery();
                }

                // Remove the label from the panel and the announcements list
                Control[] labels = Annpanel1.Controls.Find($"lbl{SelectedAnnouncementId}", true);
                if (labels.Length > 0)
                {
                    Label label = (Label)labels[0];
                    Annpanel1.Controls.Remove(label);
                    announcementsList.RemoveAt(SelectedAnnouncementId - 1);
                    SelectedAnnouncementId = 0;
                }

                LoadAnnouncements();
                Postrtb.Text = "";
            }
        }

        public void GetID(string loggedInUser)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT name FROM adminacc WHERE uname=@loggedInUser", con);
            cmd.Parameters.AddWithValue("@loggedInUser", loggedInUser);
            string result = cmd.ExecuteScalar()?.ToString();
            con.Close();
            user = result;
        }
    }
}