
namespace SCHOOL_MANAGEMENT_SYSTEM
{
    partial class formTDsched
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
            this.tsPanel = new System.Windows.Forms.Panel();
            this.tsDelete = new System.Windows.Forms.Button();
            this.tsSave = new System.Windows.Forms.Button();
            this.tsSelect = new System.Windows.Forms.Button();
            this.tsDays = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tsAdd = new System.Windows.Forms.Button();
            this.tsRoom = new System.Windows.Forms.TextBox();
            this.tsClass = new System.Windows.Forms.TextBox();
            this.tsSub = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tsEnd = new System.Windows.Forms.DateTimePicker();
            this.tsStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tSched = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tSched)).BeginInit();
            this.SuspendLayout();
            // 
            // tsPanel
            // 
            this.tsPanel.BackColor = System.Drawing.Color.White;
            this.tsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsPanel.Location = new System.Drawing.Point(1265, 12);
            this.tsPanel.Name = "tsPanel";
            this.tsPanel.Size = new System.Drawing.Size(200, 618);
            this.tsPanel.TabIndex = 56;
            // 
            // tsDelete
            // 
            this.tsDelete.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDelete.Location = new System.Drawing.Point(979, 598);
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(109, 34);
            this.tsDelete.TabIndex = 62;
            this.tsDelete.Text = "Delete";
            this.tsDelete.UseVisualStyleBackColor = true;
            // 
            // tsSave
            // 
            this.tsSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSave.Location = new System.Drawing.Point(1105, 598);
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(109, 34);
            this.tsSave.TabIndex = 61;
            this.tsSave.Text = "Save";
            this.tsSave.UseVisualStyleBackColor = true;
            // 
            // tsSelect
            // 
            this.tsSelect.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSelect.Location = new System.Drawing.Point(1080, 37);
            this.tsSelect.Name = "tsSelect";
            this.tsSelect.Size = new System.Drawing.Size(134, 41);
            this.tsSelect.TabIndex = 60;
            this.tsSelect.Text = "Select";
            this.tsSelect.UseVisualStyleBackColor = true;
            // 
            // tsDays
            // 
            this.tsDays.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDays.FormattingEnabled = true;
            this.tsDays.Items.AddRange(new object[] {
            "All",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.tsDays.Location = new System.Drawing.Point(355, 37);
            this.tsDays.Name = "tsDays";
            this.tsDays.Size = new System.Drawing.Size(708, 40);
            this.tsDays.TabIndex = 59;
            this.tsDays.Text = "Choose a certain day:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tsAdd);
            this.panel1.Controls.Add(this.tsRoom);
            this.panel1.Controls.Add(this.tsClass);
            this.panel1.Controls.Add(this.tsSub);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 618);
            this.panel1.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 27);
            this.label6.TabIndex = 50;
            this.label6.Text = "Class Duration:";
            // 
            // tsAdd
            // 
            this.tsAdd.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAdd.Location = new System.Drawing.Point(152, 537);
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(109, 34);
            this.tsAdd.TabIndex = 44;
            this.tsAdd.Text = "Add";
            this.tsAdd.UseVisualStyleBackColor = true;
            // 
            // tsRoom
            // 
            this.tsRoom.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsRoom.Location = new System.Drawing.Point(25, 278);
            this.tsRoom.Name = "tsRoom";
            this.tsRoom.Size = new System.Drawing.Size(236, 35);
            this.tsRoom.TabIndex = 52;
            // 
            // tsClass
            // 
            this.tsClass.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsClass.Location = new System.Drawing.Point(25, 199);
            this.tsClass.Name = "tsClass";
            this.tsClass.Size = new System.Drawing.Size(236, 35);
            this.tsClass.TabIndex = 51;
            // 
            // tsSub
            // 
            this.tsSub.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSub.Location = new System.Drawing.Point(25, 122);
            this.tsSub.Name = "tsSub";
            this.tsSub.Size = new System.Drawing.Size(236, 35);
            this.tsSub.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 27);
            this.label7.TabIndex = 50;
            this.label7.Text = "Room Number:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tsEnd);
            this.panel2.Controls.Add(this.tsStart);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(25, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 134);
            this.panel2.TabIndex = 41;
            // 
            // tsEnd
            // 
            this.tsEnd.CalendarFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tsEnd.Location = new System.Drawing.Point(17, 99);
            this.tsEnd.Name = "tsEnd";
            this.tsEnd.Size = new System.Drawing.Size(188, 22);
            this.tsEnd.TabIndex = 49;
            // 
            // tsStart
            // 
            this.tsStart.CalendarFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tsStart.Location = new System.Drawing.Point(17, 38);
            this.tsStart.Name = "tsStart";
            this.tsStart.Size = new System.Drawing.Size(188, 22);
            this.tsStart.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 48;
            this.label5.Text = "End Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 47;
            this.label4.Text = "Start Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 46;
            this.label3.Text = "Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 27);
            this.label2.TabIndex = 45;
            this.label2.Text = "Subject Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 44;
            this.label1.Text = "EDIT SCHEDULE";
            // 
            // tSched
            // 
            this.tSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tSched.Location = new System.Drawing.Point(355, 101);
            this.tSched.Name = "tSched";
            this.tSched.RowHeadersWidth = 51;
            this.tSched.RowTemplate.Height = 24;
            this.tSched.Size = new System.Drawing.Size(859, 483);
            this.tSched.TabIndex = 58;
            // 
            // formTDsched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 699);
            this.Controls.Add(this.tsDelete);
            this.Controls.Add(this.tsSave);
            this.Controls.Add(this.tsSelect);
            this.Controls.Add(this.tsDays);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tSched);
            this.Controls.Add(this.tsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTDsched";
            this.Text = "formTDsched";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tSched)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tsPanel;
        private System.Windows.Forms.Button tsDelete;
        private System.Windows.Forms.Button tsSave;
        private System.Windows.Forms.Button tsSelect;
        private System.Windows.Forms.ComboBox tsDays;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tsAdd;
        private System.Windows.Forms.TextBox tsRoom;
        private System.Windows.Forms.TextBox tsClass;
        private System.Windows.Forms.TextBox tsSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker tsEnd;
        private System.Windows.Forms.DateTimePicker tsStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tSched;
    }
}