﻿
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbsched = new System.Windows.Forms.ComboBox();
            this.tsched = new System.Windows.Forms.Label();
            this.tclassDelete = new System.Windows.Forms.Button();
            this.tclassSave = new System.Windows.Forms.Button();
            this.tbcode = new System.Windows.Forms.TextBox();
            this.tcode = new System.Windows.Forms.Label();
            this.tbunit = new System.Windows.Forms.TextBox();
            this.tunit = new System.Windows.Forms.Label();
            this.tcdesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbclass = new System.Windows.Forms.TextBox();
            this.tclass = new System.Windows.Forms.Label();
            this.tbsub = new System.Windows.Forms.TextBox();
            this.tsub = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seprofPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.tbsched.Location = new System.Drawing.Point(570, 173);
            this.tbsched.Name = "tbsched";
            this.tbsched.Size = new System.Drawing.Size(649, 35);
            this.tbsched.TabIndex = 70;
            // 
            // tsched
            // 
            this.tsched.AutoSize = true;
            this.tsched.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsched.Location = new System.Drawing.Point(465, 178);
            this.tsched.Name = "tsched";
            this.tsched.Size = new System.Drawing.Size(99, 26);
            this.tsched.TabIndex = 69;
            this.tsched.Text = "Schedule:";
            // 
            // tclassDelete
            // 
            this.tclassDelete.BackColor = System.Drawing.Color.White;
            this.tclassDelete.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclassDelete.Location = new System.Drawing.Point(1117, 597);
            this.tclassDelete.Name = "tclassDelete";
            this.tclassDelete.Size = new System.Drawing.Size(102, 36);
            this.tclassDelete.TabIndex = 68;
            this.tclassDelete.Text = "Delete";
            this.tclassDelete.UseVisualStyleBackColor = false;
            // 
            // tclassSave
            // 
            this.tclassSave.BackColor = System.Drawing.Color.White;
            this.tclassSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclassSave.Location = new System.Drawing.Point(998, 597);
            this.tclassSave.Name = "tclassSave";
            this.tclassSave.Size = new System.Drawing.Size(102, 36);
            this.tclassSave.TabIndex = 67;
            this.tclassSave.Text = "Save";
            this.tclassSave.UseVisualStyleBackColor = false;
            // 
            // tbcode
            // 
            this.tbcode.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcode.Location = new System.Drawing.Point(916, 81);
            this.tbcode.Name = "tbcode";
            this.tbcode.Size = new System.Drawing.Size(303, 35);
            this.tbcode.TabIndex = 66;
            // 
            // tcode
            // 
            this.tcode.AutoSize = true;
            this.tcode.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcode.Location = new System.Drawing.Point(832, 86);
            this.tcode.Name = "tcode";
            this.tcode.Size = new System.Drawing.Size(63, 26);
            this.tcode.TabIndex = 65;
            this.tcode.Text = "Code:";
            // 
            // tbunit
            // 
            this.tbunit.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbunit.Location = new System.Drawing.Point(570, 83);
            this.tbunit.Name = "tbunit";
            this.tbunit.Size = new System.Drawing.Size(227, 35);
            this.tbunit.TabIndex = 64;
            // 
            // tunit
            // 
            this.tunit.AutoSize = true;
            this.tunit.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tunit.Location = new System.Drawing.Point(465, 86);
            this.tunit.Name = "tunit";
            this.tunit.Size = new System.Drawing.Size(64, 26);
            this.tunit.TabIndex = 63;
            this.tunit.Text = "Units:";
            // 
            // tcdesc
            // 
            this.tcdesc.BackColor = System.Drawing.SystemColors.Window;
            this.tcdesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tcdesc.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcdesc.Location = new System.Drawing.Point(470, 262);
            this.tcdesc.Name = "tcdesc";
            this.tcdesc.Size = new System.Drawing.Size(749, 319);
            this.tcdesc.TabIndex = 62;
            this.tcdesc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 61;
            this.label2.Text = "Course Description:";
            // 
            // tbclass
            // 
            this.tbclass.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbclass.Location = new System.Drawing.Point(570, 128);
            this.tbclass.Name = "tbclass";
            this.tbclass.Size = new System.Drawing.Size(649, 35);
            this.tbclass.TabIndex = 60;
            // 
            // tclass
            // 
            this.tclass.AutoSize = true;
            this.tclass.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclass.Location = new System.Drawing.Point(465, 133);
            this.tclass.Name = "tclass";
            this.tclass.Size = new System.Drawing.Size(63, 26);
            this.tclass.TabIndex = 59;
            this.tclass.Text = "Class:";
            // 
            // tbsub
            // 
            this.tbsub.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsub.Location = new System.Drawing.Point(570, 37);
            this.tbsub.Name = "tbsub";
            this.tbsub.Size = new System.Drawing.Size(649, 35);
            this.tbsub.TabIndex = 58;
            // 
            // tsub
            // 
            this.tsub.AutoSize = true;
            this.tsub.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsub.Location = new System.Drawing.Point(465, 42);
            this.tsub.Name = "tsub";
            this.tsub.Size = new System.Drawing.Size(83, 26);
            this.tsub.TabIndex = 57;
            this.tsub.Text = "Subject:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 618);
            this.dataGridView1.TabIndex = 56;
            // 
            // seprofPanel
            // 
            this.seprofPanel.BackColor = System.Drawing.Color.White;
            this.seprofPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seprofPanel.Location = new System.Drawing.Point(1259, 18);
            this.seprofPanel.Name = "seprofPanel";
            this.seprofPanel.Size = new System.Drawing.Size(200, 618);
            this.seprofPanel.TabIndex = 55;
            // 
            // formTDclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbsched);
            this.Controls.Add(this.tsched);
            this.Controls.Add(this.tclassDelete);
            this.Controls.Add(this.tclassSave);
            this.Controls.Add(this.tbcode);
            this.Controls.Add(this.tcode);
            this.Controls.Add(this.tbunit);
            this.Controls.Add(this.tunit);
            this.Controls.Add(this.tcdesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbclass);
            this.Controls.Add(this.tclass);
            this.Controls.Add(this.tbsub);
            this.Controls.Add(this.tsub);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.seprofPanel);
            this.Name = "formTDclass";
            this.Size = new System.Drawing.Size(1477, 699);
            this.Load += new System.EventHandler(this.formTDclass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tbsched;
        private System.Windows.Forms.Label tsched;
        private System.Windows.Forms.Button tclassDelete;
        private System.Windows.Forms.Button tclassSave;
        private System.Windows.Forms.TextBox tbcode;
        private System.Windows.Forms.Label tcode;
        private System.Windows.Forms.TextBox tbunit;
        private System.Windows.Forms.Label tunit;
        private System.Windows.Forms.RichTextBox tcdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbclass;
        private System.Windows.Forms.Label tclass;
        private System.Windows.Forms.TextBox tbsub;
        private System.Windows.Forms.Label tsub;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel seprofPanel;
    }
}
