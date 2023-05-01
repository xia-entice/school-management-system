
namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class formADann
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formADann));
            this.Annpanel = new System.Windows.Forms.Panel();
            this.Annpanel1 = new System.Windows.Forms.Panel();
            this.ann1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.annDelete = new System.Windows.Forms.Button();
            this.annPost = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Annpanel
            // 
            this.Annpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.Annpanel.Location = new System.Drawing.Point(1265, 12);
            this.Annpanel.Name = "Annpanel";
            this.Annpanel.Size = new System.Drawing.Size(200, 629);
            this.Annpanel.TabIndex = 15;
            // 
            // Annpanel1
            // 
            this.Annpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(178)))), ((int)(((byte)(85)))));
            this.Annpanel1.Location = new System.Drawing.Point(468, 79);
            this.Annpanel1.Name = "Annpanel1";
            this.Annpanel1.Size = new System.Drawing.Size(746, 521);
            this.Annpanel1.TabIndex = 17;
            // 
            // ann1
            // 
            this.ann1.AutoSize = true;
            this.ann1.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ann1.Location = new System.Drawing.Point(677, 22);
            this.ann1.Name = "ann1";
            this.ann1.Size = new System.Drawing.Size(369, 38);
            this.ann1.TabIndex = 20;
            this.ann1.Text = "ANNOUNCEMENT BOARD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.annPost);
            this.panel1.Controls.Add(this.Annpanel1);
            this.panel1.Controls.Add(this.annDelete);
            this.panel1.Controls.Add(this.ann1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 629);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // annDelete
            // 
            this.annDelete.BackColor = System.Drawing.Color.White;
            this.annDelete.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annDelete.Location = new System.Drawing.Point(346, 564);
            this.annDelete.Name = "annDelete";
            this.annDelete.Size = new System.Drawing.Size(102, 36);
            this.annDelete.TabIndex = 19;
            this.annDelete.Text = "Delete";
            this.annDelete.UseVisualStyleBackColor = false;
            // 
            // annPost
            // 
            this.annPost.BackColor = System.Drawing.Color.White;
            this.annPost.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annPost.Location = new System.Drawing.Point(238, 564);
            this.annPost.Name = "annPost";
            this.annPost.Size = new System.Drawing.Size(102, 36);
            this.annPost.TabIndex = 18;
            this.annPost.Text = "Post";
            this.annPost.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(21, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(427, 528);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // formADann
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Annpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formADann";
            this.Text = "formADann";
            this.Load += new System.EventHandler(this.formADann_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Annpanel;
        private System.Windows.Forms.Panel Annpanel1;
        private System.Windows.Forms.Label ann1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button annPost;
        private System.Windows.Forms.Button annDelete;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}