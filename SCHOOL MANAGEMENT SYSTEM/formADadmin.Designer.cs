
namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class formADadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formADadmin));
            this.Apanel3 = new System.Windows.Forms.Panel();
            this.Apanel2 = new System.Windows.Forms.Panel();
            this.pictureBox1a = new System.Windows.Forms.PictureBox();
            this.AAsearch = new System.Windows.Forms.Button();
            this.AAview = new System.Windows.Forms.DataGridView();
            this.Asearch = new System.Windows.Forms.TextBox();
            this.Apanel1 = new System.Windows.Forms.Panel();
            this.labela = new System.Windows.Forms.Label();
            this.pictureBoxa = new System.Windows.Forms.PictureBox();
            this.AAdelete = new System.Windows.Forms.Button();
            this.AAsave = new System.Windows.Forms.Button();
            this.AApw = new System.Windows.Forms.Label();
            this.AAun = new System.Windows.Forms.Label();
            this.apass = new System.Windows.Forms.TextBox();
            this.auname = new System.Windows.Forms.TextBox();
            this.Apanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AAview)).BeginInit();
            this.Apanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxa)).BeginInit();
            this.SuspendLayout();
            // 
            // Apanel3
            // 
            this.Apanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.Apanel3.Location = new System.Drawing.Point(1265, 20);
            this.Apanel3.Name = "Apanel3";
            this.Apanel3.Size = new System.Drawing.Size(200, 610);
            this.Apanel3.TabIndex = 13;
            // 
            // Apanel2
            // 
            this.Apanel2.BackColor = System.Drawing.Color.White;
            this.Apanel2.Controls.Add(this.pictureBox1a);
            this.Apanel2.Controls.Add(this.AAsearch);
            this.Apanel2.Controls.Add(this.AAview);
            this.Apanel2.Controls.Add(this.Asearch);
            this.Apanel2.Location = new System.Drawing.Point(360, 20);
            this.Apanel2.Name = "Apanel2";
            this.Apanel2.Size = new System.Drawing.Size(883, 610);
            this.Apanel2.TabIndex = 14;
            // 
            // pictureBox1a
            // 
            this.pictureBox1a.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1a.Image")));
            this.pictureBox1a.Location = new System.Drawing.Point(707, 38);
            this.pictureBox1a.Name = "pictureBox1a";
            this.pictureBox1a.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1a.TabIndex = 9;
            this.pictureBox1a.TabStop = false;
            // 
            // AAsearch
            // 
            this.AAsearch.BackColor = System.Drawing.Color.White;
            this.AAsearch.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAsearch.Location = new System.Drawing.Point(757, 35);
            this.AAsearch.Name = "AAsearch";
            this.AAsearch.Size = new System.Drawing.Size(102, 36);
            this.AAsearch.TabIndex = 8;
            this.AAsearch.Text = "Search";
            this.AAsearch.UseVisualStyleBackColor = false;
            this.AAsearch.Click += new System.EventHandler(this.AAsearch_Click);
            // 
            // AAview
            // 
            this.AAview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AAview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.AAview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AAview.Location = new System.Drawing.Point(26, 90);
            this.AAview.Name = "AAview";
            this.AAview.RowHeadersWidth = 51;
            this.AAview.RowTemplate.Height = 24;
            this.AAview.Size = new System.Drawing.Size(833, 484);
            this.AAview.TabIndex = 0;
            this.AAview.DoubleClick += new System.EventHandler(this.AAview_DoubleClick);
            // 
            // Asearch
            // 
            this.Asearch.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asearch.Location = new System.Drawing.Point(26, 37);
            this.Asearch.Name = "Asearch";
            this.Asearch.Size = new System.Drawing.Size(715, 35);
            this.Asearch.TabIndex = 8;
            // 
            // Apanel1
            // 
            this.Apanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.Apanel1.Controls.Add(this.labela);
            this.Apanel1.Controls.Add(this.pictureBoxa);
            this.Apanel1.Controls.Add(this.AAdelete);
            this.Apanel1.Controls.Add(this.AAsave);
            this.Apanel1.Controls.Add(this.AApw);
            this.Apanel1.Controls.Add(this.AAun);
            this.Apanel1.Controls.Add(this.apass);
            this.Apanel1.Controls.Add(this.auname);
            this.Apanel1.Location = new System.Drawing.Point(17, 20);
            this.Apanel1.Name = "Apanel1";
            this.Apanel1.Size = new System.Drawing.Size(327, 610);
            this.Apanel1.TabIndex = 15;
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Open Sans Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.Location = new System.Drawing.Point(83, 212);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(144, 76);
            this.labela.TabIndex = 11;
            this.labela.Text = "   ADMIN\r\nACCOUNT";
            // 
            // pictureBoxa
            // 
            this.pictureBoxa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxa.Image")));
            this.pictureBoxa.Location = new System.Drawing.Point(69, 35);
            this.pictureBoxa.Name = "pictureBoxa";
            this.pictureBoxa.Size = new System.Drawing.Size(182, 172);
            this.pictureBoxa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxa.TabIndex = 10;
            this.pictureBoxa.TabStop = false;
            // 
            // AAdelete
            // 
            this.AAdelete.BackColor = System.Drawing.Color.White;
            this.AAdelete.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAdelete.Location = new System.Drawing.Point(181, 473);
            this.AAdelete.Name = "AAdelete";
            this.AAdelete.Size = new System.Drawing.Size(123, 36);
            this.AAdelete.TabIndex = 7;
            this.AAdelete.Text = "Delete";
            this.AAdelete.UseVisualStyleBackColor = false;
            this.AAdelete.Click += new System.EventHandler(this.AAdelete_Click);
            // 
            // AAsave
            // 
            this.AAsave.BackColor = System.Drawing.Color.White;
            this.AAsave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAsave.Location = new System.Drawing.Point(19, 473);
            this.AAsave.Name = "AAsave";
            this.AAsave.Size = new System.Drawing.Size(123, 36);
            this.AAsave.TabIndex = 6;
            this.AAsave.Text = "Save";
            this.AAsave.UseVisualStyleBackColor = false;
            this.AAsave.Click += new System.EventHandler(this.AAsave_Click);
            // 
            // AApw
            // 
            this.AApw.AutoSize = true;
            this.AApw.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AApw.Location = new System.Drawing.Point(14, 383);
            this.AApw.Name = "AApw";
            this.AApw.Size = new System.Drawing.Size(103, 26);
            this.AApw.TabIndex = 2;
            this.AApw.Text = "Password:";
            // 
            // AAun
            // 
            this.AAun.AutoSize = true;
            this.AAun.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAun.Location = new System.Drawing.Point(14, 306);
            this.AAun.Name = "AAun";
            this.AAun.Size = new System.Drawing.Size(111, 26);
            this.AAun.TabIndex = 1;
            this.AAun.Text = "Username:";
            // 
            // apass
            // 
            this.apass.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apass.Location = new System.Drawing.Point(18, 414);
            this.apass.Name = "apass";
            this.apass.Size = new System.Drawing.Size(286, 35);
            this.apass.TabIndex = 4;
            // 
            // auname
            // 
            this.auname.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auname.Location = new System.Drawing.Point(18, 337);
            this.auname.Name = "auname";
            this.auname.Size = new System.Drawing.Size(286, 35);
            this.auname.TabIndex = 3;
            // 
            // formADadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1477, 699);
            this.Controls.Add(this.Apanel1);
            this.Controls.Add(this.Apanel2);
            this.Controls.Add(this.Apanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formADadmin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.formADadmin_Load);
            this.Apanel2.ResumeLayout(false);
            this.Apanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AAview)).EndInit();
            this.Apanel1.ResumeLayout(false);
            this.Apanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Apanel3;
        private System.Windows.Forms.Panel Apanel2;
        private System.Windows.Forms.PictureBox pictureBox1a;
        private System.Windows.Forms.Button AAsearch;
        private System.Windows.Forms.DataGridView AAview;
        private System.Windows.Forms.TextBox Asearch;
        private System.Windows.Forms.Panel Apanel1;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.PictureBox pictureBoxa;
        private System.Windows.Forms.Button AAdelete;
        private System.Windows.Forms.Button AAsave;
        private System.Windows.Forms.Label AApw;
        private System.Windows.Forms.Label AAun;
        private System.Windows.Forms.TextBox apass;
        private System.Windows.Forms.TextBox auname;
    }
}