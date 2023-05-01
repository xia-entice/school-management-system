
namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class formSDats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSDats));
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ATSpanel = new System.Windows.Forms.Panel();
            this.ATSTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.ATSpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Location = new System.Drawing.Point(1269, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(193, 366);
            this.panel6.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-837, -186);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1107, 552);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // ATSpanel
            // 
            this.ATSpanel.BackColor = System.Drawing.Color.White;
            this.ATSpanel.Controls.Add(this.ATSTextBox1);
            this.ATSpanel.Location = new System.Drawing.Point(1265, 12);
            this.ATSpanel.Name = "ATSpanel";
            this.ATSpanel.Size = new System.Drawing.Size(200, 618);
            this.ATSpanel.TabIndex = 17;
            // 
            // ATSTextBox1
            // 
            this.ATSTextBox1.BackColor = System.Drawing.Color.White;
            this.ATSTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ATSTextBox1.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATSTextBox1.Location = new System.Drawing.Point(4, 375);
            this.ATSTextBox1.Name = "ATSTextBox1";
            this.ATSTextBox1.Size = new System.Drawing.Size(194, 237);
            this.ATSTextBox1.TabIndex = 22;
            this.ATSTextBox1.Text = "Cebu Technological University, formerly known as Cebu State College of Science an" +
    "d Technology (CSCST), became a state university on November 10, 2009 by virtue o" +
    "f Republic Act No. 9744.";
            // 
            // formSDats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1477, 699);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.ATSpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSDats";
            this.Text = "formSDats";
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ATSpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel ATSpanel;
        private System.Windows.Forms.RichTextBox ATSTextBox1;
    }
}