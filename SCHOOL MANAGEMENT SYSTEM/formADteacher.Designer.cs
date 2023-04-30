
namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class formADteacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formADteacher));
            this.Tpanel2 = new System.Windows.Forms.Panel();
            this.pictureBox1t = new System.Windows.Forms.PictureBox();
            this.ATsearch = new System.Windows.Forms.Button();
            this.ATview = new System.Windows.Forms.DataGridView();
            this.tsearch = new System.Windows.Forms.TextBox();
            this.Tpanel1 = new System.Windows.Forms.Panel();
            this.labelt = new System.Windows.Forms.Label();
            this.pictureBoxt = new System.Windows.Forms.PictureBox();
            this.ATdelete = new System.Windows.Forms.Button();
            this.ATsave = new System.Windows.Forms.Button();
            this.ATpw = new System.Windows.Forms.Label();
            this.ATun = new System.Windows.Forms.Label();
            this.tpass = new System.Windows.Forms.TextBox();
            this.tuname = new System.Windows.Forms.TextBox();
            this.Tpanel3 = new System.Windows.Forms.Panel();
            this.Tpanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATview)).BeginInit();
            this.Tpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxt)).BeginInit();
            this.SuspendLayout();
            // 
            // Tpanel2
            // 
            this.Tpanel2.BackColor = System.Drawing.Color.White;
            this.Tpanel2.Controls.Add(this.pictureBox1t);
            this.Tpanel2.Controls.Add(this.ATsearch);
            this.Tpanel2.Controls.Add(this.ATview);
            this.Tpanel2.Controls.Add(this.tsearch);
            this.Tpanel2.Location = new System.Drawing.Point(360, 20);
            this.Tpanel2.Name = "Tpanel2";
            this.Tpanel2.Size = new System.Drawing.Size(883, 610);
            this.Tpanel2.TabIndex = 8;
            // 
            // pictureBox1t
            // 
            this.pictureBox1t.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1t.Image")));
            this.pictureBox1t.Location = new System.Drawing.Point(707, 38);
            this.pictureBox1t.Name = "pictureBox1t";
            this.pictureBox1t.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1t.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1t.TabIndex = 9;
            this.pictureBox1t.TabStop = false;
            // 
            // ATsearch
            // 
            this.ATsearch.BackColor = System.Drawing.Color.White;
            this.ATsearch.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATsearch.Location = new System.Drawing.Point(757, 35);
            this.ATsearch.Name = "ATsearch";
            this.ATsearch.Size = new System.Drawing.Size(102, 36);
            this.ATsearch.TabIndex = 8;
            this.ATsearch.Text = "Search";
            this.ATsearch.UseVisualStyleBackColor = false;
            this.ATsearch.Click += new System.EventHandler(this.ATsearch_Click);
            // 
            // ATview
            // 
            this.ATview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ATview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.ATview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ATview.Location = new System.Drawing.Point(26, 90);
            this.ATview.Name = "ATview";
            this.ATview.RowHeadersWidth = 51;
            this.ATview.RowTemplate.Height = 24;
            this.ATview.Size = new System.Drawing.Size(833, 484);
            this.ATview.TabIndex = 0;
            this.ATview.DoubleClick += new System.EventHandler(this.ATview_DoubleClick);
            // 
            // tsearch
            // 
            this.tsearch.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsearch.Location = new System.Drawing.Point(26, 37);
            this.tsearch.Name = "tsearch";
            this.tsearch.Size = new System.Drawing.Size(715, 35);
            this.tsearch.TabIndex = 8;
            // 
            // Tpanel1
            // 
            this.Tpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.Tpanel1.Controls.Add(this.labelt);
            this.Tpanel1.Controls.Add(this.pictureBoxt);
            this.Tpanel1.Controls.Add(this.ATdelete);
            this.Tpanel1.Controls.Add(this.ATsave);
            this.Tpanel1.Controls.Add(this.ATpw);
            this.Tpanel1.Controls.Add(this.ATun);
            this.Tpanel1.Controls.Add(this.tpass);
            this.Tpanel1.Controls.Add(this.tuname);
            this.Tpanel1.Location = new System.Drawing.Point(17, 20);
            this.Tpanel1.Name = "Tpanel1";
            this.Tpanel1.Size = new System.Drawing.Size(327, 610);
            this.Tpanel1.TabIndex = 10;
            // 
            // labelt
            // 
            this.labelt.AutoSize = true;
            this.labelt.Font = new System.Drawing.Font("Open Sans Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelt.Location = new System.Drawing.Point(83, 212);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(144, 76);
            this.labelt.TabIndex = 11;
            this.labelt.Text = " TEACHER\r\nACCOUNT";
            // 
            // pictureBoxt
            // 
            this.pictureBoxt.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxt.Image")));
            this.pictureBoxt.Location = new System.Drawing.Point(69, 37);
            this.pictureBoxt.Name = "pictureBoxt";
            this.pictureBoxt.Size = new System.Drawing.Size(182, 172);
            this.pictureBoxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxt.TabIndex = 10;
            this.pictureBoxt.TabStop = false;
            // 
            // ATdelete
            // 
            this.ATdelete.BackColor = System.Drawing.Color.White;
            this.ATdelete.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATdelete.Location = new System.Drawing.Point(181, 473);
            this.ATdelete.Name = "ATdelete";
            this.ATdelete.Size = new System.Drawing.Size(123, 36);
            this.ATdelete.TabIndex = 7;
            this.ATdelete.Text = "Delete";
            this.ATdelete.UseVisualStyleBackColor = false;
            this.ATdelete.Click += new System.EventHandler(this.ATdelete_Click);
            // 
            // ATsave
            // 
            this.ATsave.BackColor = System.Drawing.Color.White;
            this.ATsave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATsave.Location = new System.Drawing.Point(19, 473);
            this.ATsave.Name = "ATsave";
            this.ATsave.Size = new System.Drawing.Size(123, 36);
            this.ATsave.TabIndex = 6;
            this.ATsave.Text = "Save";
            this.ATsave.UseVisualStyleBackColor = false;
            this.ATsave.Click += new System.EventHandler(this.ATsave_Click);
            // 
            // ATpw
            // 
            this.ATpw.AutoSize = true;
            this.ATpw.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATpw.Location = new System.Drawing.Point(14, 383);
            this.ATpw.Name = "ATpw";
            this.ATpw.Size = new System.Drawing.Size(103, 26);
            this.ATpw.TabIndex = 2;
            this.ATpw.Text = "Password:";
            // 
            // ATun
            // 
            this.ATun.AutoSize = true;
            this.ATun.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATun.Location = new System.Drawing.Point(14, 306);
            this.ATun.Name = "ATun";
            this.ATun.Size = new System.Drawing.Size(111, 26);
            this.ATun.TabIndex = 1;
            this.ATun.Text = "Username:";
            // 
            // tpass
            // 
            this.tpass.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpass.Location = new System.Drawing.Point(18, 414);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(286, 35);
            this.tpass.TabIndex = 4;
            // 
            // tuname
            // 
            this.tuname.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuname.Location = new System.Drawing.Point(18, 337);
            this.tuname.Name = "tuname";
            this.tuname.Size = new System.Drawing.Size(286, 35);
            this.tuname.TabIndex = 3;
            // 
            // Tpanel3
            // 
            this.Tpanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.Tpanel3.Location = new System.Drawing.Point(1265, 20);
            this.Tpanel3.Name = "Tpanel3";
            this.Tpanel3.Size = new System.Drawing.Size(200, 610);
            this.Tpanel3.TabIndex = 12;
            // 
            // formADteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1477, 699);
            this.Controls.Add(this.Tpanel3);
            this.Controls.Add(this.Tpanel1);
            this.Controls.Add(this.Tpanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formADteacher";
            this.Text = "formADteacher";
            this.Load += new System.EventHandler(this.formADteacher_Load);
            this.Tpanel2.ResumeLayout(false);
            this.Tpanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATview)).EndInit();
            this.Tpanel1.ResumeLayout(false);
            this.Tpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Tpanel2;
        private System.Windows.Forms.PictureBox pictureBox1t;
        private System.Windows.Forms.Button ATsearch;
        private System.Windows.Forms.DataGridView ATview;
        private System.Windows.Forms.TextBox tsearch;
        private System.Windows.Forms.Panel Tpanel1;
        private System.Windows.Forms.PictureBox pictureBoxt;
        private System.Windows.Forms.Button ATdelete;
        private System.Windows.Forms.Button ATsave;
        private System.Windows.Forms.Label ATpw;
        private System.Windows.Forms.Label ATun;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.TextBox tuname;
        private System.Windows.Forms.Label labelt;
        private System.Windows.Forms.Panel Tpanel3;
    }
}