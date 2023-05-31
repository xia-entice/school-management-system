namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class formANN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formANN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ATSpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Annpanel1 = new System.Windows.Forms.Panel();
            this.ann1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.ATSpanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Annpanel1);
            this.panel1.Controls.Add(this.ann1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1485, 645);
            this.panel1.TabIndex = 19;
            // 
            // ATSpanel
            // 
            this.ATSpanel.BackColor = System.Drawing.Color.White;
            this.ATSpanel.Location = new System.Drawing.Point(1265, 0);
            this.ATSpanel.Name = "ATSpanel";
            this.ATSpanel.Size = new System.Drawing.Size(200, 645);
            this.ATSpanel.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Annpanel1
            // 
            this.Annpanel1.BackColor = System.Drawing.Color.White;
            this.Annpanel1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annpanel1.Location = new System.Drawing.Point(27, 92);
            this.Annpanel1.Name = "Annpanel1";
            this.Annpanel1.Size = new System.Drawing.Size(1215, 530);
            this.Annpanel1.TabIndex = 17;
            // 
            // ann1
            // 
            this.ann1.AutoSize = true;
            this.ann1.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ann1.Location = new System.Drawing.Point(465, 29);
            this.ann1.Name = "ann1";
            this.ann1.Size = new System.Drawing.Size(369, 38);
            this.ann1.TabIndex = 20;
            this.ann1.Text = "ANNOUNCEMENT BOARD";
            // 
            // formANN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1477, 699);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formANN";
            this.Text = "formANN";
            this.Load += new System.EventHandler(this.formANN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Annpanel1;
        private System.Windows.Forms.Label ann1;
        private System.Windows.Forms.Panel ATSpanel;
    }
}