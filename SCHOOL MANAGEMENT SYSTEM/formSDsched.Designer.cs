
namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class formSDsched
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.seprofPanel = new System.Windows.Forms.Panel();
            this.sSched = new System.Windows.Forms.DataGridView();
            this.ssSelect = new System.Windows.Forms.Button();
            this.ssDays = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sSched)).BeginInit();
            this.SuspendLayout();
            // 
            // seprofPanel
            // 
            this.seprofPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(51)))));
            this.seprofPanel.Location = new System.Drawing.Point(1265, 12);
            this.seprofPanel.Name = "seprofPanel";
            this.seprofPanel.Size = new System.Drawing.Size(200, 629);
            this.seprofPanel.TabIndex = 56;
            // 
            // sSched
            // 
            this.sSched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sSched.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sSched.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sSched.Location = new System.Drawing.Point(38, 87);
            this.sSched.Name = "sSched";
            this.sSched.RowHeadersWidth = 51;
            this.sSched.RowTemplate.Height = 24;
            this.sSched.Size = new System.Drawing.Size(1190, 536);
            this.sSched.TabIndex = 69;
            // 
            // ssSelect
            // 
            this.ssSelect.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssSelect.Location = new System.Drawing.Point(1094, 25);
            this.ssSelect.Name = "ssSelect";
            this.ssSelect.Size = new System.Drawing.Size(134, 41);
            this.ssSelect.TabIndex = 77;
            this.ssSelect.Text = "Select";
            this.ssSelect.UseVisualStyleBackColor = true;
            this.ssSelect.Click += new System.EventHandler(this.ssSelect_Click);
            // 
            // ssDays
            // 
            this.ssDays.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssDays.FormattingEnabled = true;
            this.ssDays.Items.AddRange(new object[] {
            "All",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.ssDays.Location = new System.Drawing.Point(38, 26);
            this.ssDays.Name = "ssDays";
            this.ssDays.Size = new System.Drawing.Size(1031, 40);
            this.ssDays.TabIndex = 76;
            this.ssDays.Text = "Choose a certain day:";
            // 
            // formSDsched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1477, 699);
            this.Controls.Add(this.ssSelect);
            this.Controls.Add(this.ssDays);
            this.Controls.Add(this.sSched);
            this.Controls.Add(this.seprofPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSDsched";
            this.Text = "formSDsched";
            this.Load += new System.EventHandler(this.formSDsched_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sSched)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel seprofPanel;
        private System.Windows.Forms.DataGridView sSched;
        private System.Windows.Forms.Button ssSelect;
        private System.Windows.Forms.ComboBox ssDays;
    }
}