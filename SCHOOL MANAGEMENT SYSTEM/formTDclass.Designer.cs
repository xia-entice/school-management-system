
namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class formTDclass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tclassview = new System.Windows.Forms.DataGridView();
            this.tdclassPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbsched = new System.Windows.Forms.ComboBox();
            this.tbunit = new System.Windows.Forms.TextBox();
            this.tsched = new System.Windows.Forms.Label();
            this.tsub = new System.Windows.Forms.Label();
            this.tclassDelete = new System.Windows.Forms.Button();
            this.tbsub = new System.Windows.Forms.TextBox();
            this.tclassSave = new System.Windows.Forms.Button();
            this.tclass = new System.Windows.Forms.Label();
            this.tbcode = new System.Windows.Forms.TextBox();
            this.tbclass = new System.Windows.Forms.TextBox();
            this.tcode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcdesc = new System.Windows.Forms.RichTextBox();
            this.tunit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tclassview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tclassview
            // 
            this.tclassview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tclassview.BackgroundColor = System.Drawing.Color.LightGray;
            this.tclassview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tclassview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tclassview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tclassview.Location = new System.Drawing.Point(11, 12);
            this.tclassview.Name = "tclassview";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tclassview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tclassview.RowHeadersWidth = 51;
            this.tclassview.RowTemplate.Height = 24;
            this.tclassview.Size = new System.Drawing.Size(426, 629);
            this.tclassview.TabIndex = 56;
            this.tclassview.DoubleClick += new System.EventHandler(this.tclassview_DoubleClick);
            // 
            // tdclassPanel
            // 
            this.tdclassPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(51)))));
            this.tdclassPanel.Location = new System.Drawing.Point(1265, 12);
            this.tdclassPanel.Name = "tdclassPanel";
            this.tdclassPanel.Size = new System.Drawing.Size(200, 629);
            this.tdclassPanel.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(51)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbsched);
            this.panel1.Controls.Add(this.tbunit);
            this.panel1.Controls.Add(this.tsched);
            this.panel1.Controls.Add(this.tsub);
            this.panel1.Controls.Add(this.tclassDelete);
            this.panel1.Controls.Add(this.tbsub);
            this.panel1.Controls.Add(this.tclassSave);
            this.panel1.Controls.Add(this.tclass);
            this.panel1.Controls.Add(this.tbcode);
            this.panel1.Controls.Add(this.tbclass);
            this.panel1.Controls.Add(this.tcode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tcdesc);
            this.panel1.Controls.Add(this.tunit);
            this.panel1.Location = new System.Drawing.Point(452, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 629);
            this.panel1.TabIndex = 56;
            // 
            // tbsched
            // 
            this.tbsched.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsched.FormattingEnabled = true;
            this.tbsched.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.tbsched.Location = new System.Drawing.Point(126, 160);
            this.tbsched.Name = "tbsched";
            this.tbsched.Size = new System.Drawing.Size(649, 35);
            this.tbsched.TabIndex = 98;
            // 
            // tbunit
            // 
            this.tbunit.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbunit.Location = new System.Drawing.Point(126, 70);
            this.tbunit.Name = "tbunit";
            this.tbunit.Size = new System.Drawing.Size(227, 35);
            this.tbunit.TabIndex = 92;
            // 
            // tsched
            // 
            this.tsched.AutoSize = true;
            this.tsched.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsched.Location = new System.Drawing.Point(21, 165);
            this.tsched.Name = "tsched";
            this.tsched.Size = new System.Drawing.Size(99, 26);
            this.tsched.TabIndex = 97;
            this.tsched.Text = "Schedule:";
            // 
            // tsub
            // 
            this.tsub.AutoSize = true;
            this.tsub.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsub.Location = new System.Drawing.Point(21, 29);
            this.tsub.Name = "tsub";
            this.tsub.Size = new System.Drawing.Size(83, 26);
            this.tsub.TabIndex = 85;
            this.tsub.Text = "Subject:";
            // 
            // tclassDelete
            // 
            this.tclassDelete.BackColor = System.Drawing.Color.White;
            this.tclassDelete.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclassDelete.Location = new System.Drawing.Point(673, 572);
            this.tclassDelete.Name = "tclassDelete";
            this.tclassDelete.Size = new System.Drawing.Size(102, 36);
            this.tclassDelete.TabIndex = 96;
            this.tclassDelete.Text = "Delete";
            this.tclassDelete.UseVisualStyleBackColor = false;
            this.tclassDelete.Click += new System.EventHandler(this.tclassDelete_Click);
            // 
            // tbsub
            // 
            this.tbsub.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsub.Location = new System.Drawing.Point(126, 24);
            this.tbsub.Name = "tbsub";
            this.tbsub.Size = new System.Drawing.Size(649, 35);
            this.tbsub.TabIndex = 86;
            // 
            // tclassSave
            // 
            this.tclassSave.BackColor = System.Drawing.Color.White;
            this.tclassSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclassSave.Location = new System.Drawing.Point(554, 572);
            this.tclassSave.Name = "tclassSave";
            this.tclassSave.Size = new System.Drawing.Size(102, 36);
            this.tclassSave.TabIndex = 95;
            this.tclassSave.Text = "Save";
            this.tclassSave.UseVisualStyleBackColor = false;
            this.tclassSave.Click += new System.EventHandler(this.tclassSave_Click);
            // 
            // tclass
            // 
            this.tclass.AutoSize = true;
            this.tclass.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclass.Location = new System.Drawing.Point(21, 120);
            this.tclass.Name = "tclass";
            this.tclass.Size = new System.Drawing.Size(63, 26);
            this.tclass.TabIndex = 87;
            this.tclass.Text = "Class:";
            // 
            // tbcode
            // 
            this.tbcode.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcode.Location = new System.Drawing.Point(472, 68);
            this.tbcode.Name = "tbcode";
            this.tbcode.Size = new System.Drawing.Size(303, 35);
            this.tbcode.TabIndex = 94;
            // 
            // tbclass
            // 
            this.tbclass.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbclass.Location = new System.Drawing.Point(126, 115);
            this.tbclass.Name = "tbclass";
            this.tbclass.Size = new System.Drawing.Size(649, 35);
            this.tbclass.TabIndex = 88;
            // 
            // tcode
            // 
            this.tcode.AutoSize = true;
            this.tcode.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcode.Location = new System.Drawing.Point(388, 73);
            this.tcode.Name = "tcode";
            this.tcode.Size = new System.Drawing.Size(63, 26);
            this.tcode.TabIndex = 93;
            this.tcode.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 89;
            this.label2.Text = "Course Description:";
            // 
            // tcdesc
            // 
            this.tcdesc.BackColor = System.Drawing.SystemColors.Window;
            this.tcdesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tcdesc.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcdesc.Location = new System.Drawing.Point(26, 249);
            this.tcdesc.Name = "tcdesc";
            this.tcdesc.Size = new System.Drawing.Size(749, 307);
            this.tcdesc.TabIndex = 90;
            this.tcdesc.Text = "";
            // 
            // tunit
            // 
            this.tunit.AutoSize = true;
            this.tunit.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tunit.Location = new System.Drawing.Point(21, 73);
            this.tunit.Name = "tunit";
            this.tunit.Size = new System.Drawing.Size(64, 26);
            this.tunit.TabIndex = 91;
            this.tunit.Text = "Units:";
            // 
            // formTDclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1477, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tclassview);
            this.Controls.Add(this.tdclassPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTDclass";
            this.Text = "formTDclass";
            this.Load += new System.EventHandler(this.formTDclass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tclassview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tclassview;
        private System.Windows.Forms.Panel tdclassPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox tbsched;
        private System.Windows.Forms.TextBox tbunit;
        private System.Windows.Forms.Label tsched;
        private System.Windows.Forms.Label tsub;
        private System.Windows.Forms.Button tclassDelete;
        private System.Windows.Forms.TextBox tbsub;
        private System.Windows.Forms.Button tclassSave;
        private System.Windows.Forms.Label tclass;
        private System.Windows.Forms.TextBox tbcode;
        private System.Windows.Forms.TextBox tbclass;
        private System.Windows.Forms.Label tcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tcdesc;
        private System.Windows.Forms.Label tunit;
    }
}