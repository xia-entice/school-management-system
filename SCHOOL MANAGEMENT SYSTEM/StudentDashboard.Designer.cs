
namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class StudentDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            this.sdpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Sats = new System.Windows.Forms.Button();
            this.sout = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SAnnouncement = new System.Windows.Forms.Button();
            this.sprof = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsMenu = new System.Windows.Forms.PictureBox();
            this.ssidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnss = new System.Windows.Forms.Panel();
            this.btnSDs = new System.Windows.Forms.Button();
            this.pnsc = new System.Windows.Forms.Panel();
            this.btnSDc = new System.Windows.Forms.Button();
            this.ssidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.sdpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sout)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsMenu)).BeginInit();
            this.ssidebar.SuspendLayout();
            this.pnss.SuspendLayout();
            this.pnsc.SuspendLayout();
            this.SuspendLayout();
            // 
            // sdpanel
            // 
            this.sdpanel.BackColor = System.Drawing.Color.White;
            this.sdpanel.Controls.Add(this.panel3);
            this.sdpanel.Controls.Add(this.sout);
            this.sdpanel.Controls.Add(this.panel2);
            this.sdpanel.Controls.Add(this.sprof);
            this.sdpanel.Controls.Add(this.label2);
            this.sdpanel.Controls.Add(this.label1);
            this.sdpanel.Controls.Add(this.btnsMenu);
            this.sdpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sdpanel.Location = new System.Drawing.Point(0, 0);
            this.sdpanel.Name = "sdpanel";
            this.sdpanel.Size = new System.Drawing.Size(1199, 97);
            this.sdpanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Sats);
            this.panel3.Location = new System.Drawing.Point(880, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 45);
            this.panel3.TabIndex = 4;
            // 
            // Sats
            // 
            this.Sats.BackColor = System.Drawing.Color.White;
            this.Sats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sats.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sats.Location = new System.Drawing.Point(-48, -15);
            this.Sats.Name = "Sats";
            this.Sats.Size = new System.Drawing.Size(202, 77);
            this.Sats.TabIndex = 4;
            this.Sats.Text = "About Us";
            this.Sats.UseVisualStyleBackColor = false;
            this.Sats.Click += new System.EventHandler(this.Sats_Click);
            // 
            // sout
            // 
            this.sout.Image = ((System.Drawing.Image)(resources.GetObject("sout.Image")));
            this.sout.Location = new System.Drawing.Point(1103, 22);
            this.sout.Name = "sout";
            this.sout.Size = new System.Drawing.Size(61, 52);
            this.sout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sout.TabIndex = 6;
            this.sout.TabStop = false;
            this.sout.Click += new System.EventHandler(this.sout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SAnnouncement);
            this.panel2.Location = new System.Drawing.Point(685, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 46);
            this.panel2.TabIndex = 3;
            // 
            // SAnnouncement
            // 
            this.SAnnouncement.BackColor = System.Drawing.Color.White;
            this.SAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAnnouncement.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAnnouncement.Location = new System.Drawing.Point(-22, -16);
            this.SAnnouncement.Name = "SAnnouncement";
            this.SAnnouncement.Size = new System.Drawing.Size(202, 77);
            this.SAnnouncement.TabIndex = 3;
            this.SAnnouncement.Text = "Announcement";
            this.SAnnouncement.UseVisualStyleBackColor = false;
            this.SAnnouncement.Click += new System.EventHandler(this.SAnnouncement_Click);
            // 
            // sprof
            // 
            this.sprof.Image = ((System.Drawing.Image)(resources.GetObject("sprof.Image")));
            this.sprof.Location = new System.Drawing.Point(1041, 22);
            this.sprof.Name = "sprof";
            this.sprof.Size = new System.Drawing.Size(61, 52);
            this.sprof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sprof.TabIndex = 5;
            this.sprof.TabStop = false;
            this.sprof.Click += new System.EventHandler(this.sprof_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "CEBU TECHNOLOGICAL UNIVERSITY";
            // 
            // btnsMenu
            // 
            this.btnsMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnsMenu.Image")));
            this.btnsMenu.Location = new System.Drawing.Point(12, 12);
            this.btnsMenu.Name = "btnsMenu";
            this.btnsMenu.Size = new System.Drawing.Size(85, 72);
            this.btnsMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnsMenu.TabIndex = 1;
            this.btnsMenu.TabStop = false;
            this.btnsMenu.Click += new System.EventHandler(this.btnsMenu_Click);
            // 
            // ssidebar
            // 
            this.ssidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.ssidebar.Controls.Add(this.pnss);
            this.ssidebar.Controls.Add(this.pnsc);
            this.ssidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ssidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ssidebar.Location = new System.Drawing.Point(0, 97);
            this.ssidebar.Name = "ssidebar";
            this.ssidebar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.ssidebar.Size = new System.Drawing.Size(230, 550);
            this.ssidebar.TabIndex = 3;
            // 
            // pnss
            // 
            this.pnss.Controls.Add(this.btnSDs);
            this.pnss.Location = new System.Drawing.Point(3, 23);
            this.pnss.Name = "pnss";
            this.pnss.Size = new System.Drawing.Size(260, 63);
            this.pnss.TabIndex = 2;
            // 
            // btnSDs
            // 
            this.btnSDs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.btnSDs.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDs.Image = ((System.Drawing.Image)(resources.GetObject("btnSDs.Image")));
            this.btnSDs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSDs.Location = new System.Drawing.Point(-11, -30);
            this.btnSDs.Name = "btnSDs";
            this.btnSDs.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSDs.Size = new System.Drawing.Size(289, 122);
            this.btnSDs.TabIndex = 3;
            this.btnSDs.Text = "             Schedule";
            this.btnSDs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSDs.UseVisualStyleBackColor = false;
            this.btnSDs.Click += new System.EventHandler(this.btnSDs_Click);
            // 
            // pnsc
            // 
            this.pnsc.Controls.Add(this.btnSDc);
            this.pnsc.Location = new System.Drawing.Point(3, 92);
            this.pnsc.Name = "pnsc";
            this.pnsc.Size = new System.Drawing.Size(260, 63);
            this.pnsc.TabIndex = 4;
            // 
            // btnSDc
            // 
            this.btnSDc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.btnSDc.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDc.Image = ((System.Drawing.Image)(resources.GetObject("btnSDc.Image")));
            this.btnSDc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSDc.Location = new System.Drawing.Point(-11, -30);
            this.btnSDc.Name = "btnSDc";
            this.btnSDc.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSDc.Size = new System.Drawing.Size(289, 122);
            this.btnSDc.TabIndex = 3;
            this.btnSDc.Text = "             Classes";
            this.btnSDc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSDc.UseVisualStyleBackColor = false;
            this.btnSDc.Click += new System.EventHandler(this.btnSDc_Click);
            // 
            // ssidebarTransition
            // 
            this.ssidebarTransition.Interval = 10;
            this.ssidebarTransition.Tick += new System.EventHandler(this.ssidebarTransition_Tick);
            // 
            // StudentDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1199, 647);
            this.Controls.Add(this.ssidebar);
            this.Controls.Add(this.sdpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.sdpanel.ResumeLayout(false);
            this.sdpanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sout)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sprof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsMenu)).EndInit();
            this.ssidebar.ResumeLayout(false);
            this.pnss.ResumeLayout(false);
            this.pnsc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sdpanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Sats;
        private System.Windows.Forms.PictureBox sout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SAnnouncement;
        private System.Windows.Forms.PictureBox sprof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnsMenu;
        private System.Windows.Forms.FlowLayoutPanel ssidebar;
        private System.Windows.Forms.Panel pnss;
        private System.Windows.Forms.Button btnSDs;
        private System.Windows.Forms.Panel pnsc;
        private System.Windows.Forms.Button btnSDc;
        private System.Windows.Forms.Timer ssidebarTransition;
    }
}