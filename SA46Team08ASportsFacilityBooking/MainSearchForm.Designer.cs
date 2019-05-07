namespace SA46Team08ASportsFacilityBooking
{
    partial class MainSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSearchForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.facilityIDLabel = new System.Windows.Forms.Label();
            this.facilityIDTextBox = new System.Windows.Forms.TextBox();
            this.facilityTypeTextBox = new System.Windows.Forms.TextBox();
            this.facilityAddressTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lookUpFacilityButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timeSlotLabel1 = new System.Windows.Forms.Label();
            this.timeSlotLabel2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timeSlotLabel4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.timeSlotLabel3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timeSlotLabel6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.timeSlotLabel5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.timeSlotLabel12 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.timeSlotLabel11 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.timeSlotLabel10 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.timeSlotLabel9 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.timeSlotLabel8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.timeSlotLabel7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeSlotLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(240, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(557, 52);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Search Facility Availability";
            // 
            // facilityIDLabel
            // 
            this.facilityIDLabel.AutoSize = true;
            this.facilityIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityIDLabel.Location = new System.Drawing.Point(156, 153);
            this.facilityIDLabel.Name = "facilityIDLabel";
            this.facilityIDLabel.Size = new System.Drawing.Size(153, 25);
            this.facilityIDLabel.TabIndex = 2;
            this.facilityIDLabel.Text = "Enter Facility ID:";
            // 
            // facilityIDTextBox
            // 
            this.facilityIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityIDTextBox.Location = new System.Drawing.Point(314, 148);
            this.facilityIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facilityIDTextBox.Name = "facilityIDTextBox";
            this.facilityIDTextBox.Size = new System.Drawing.Size(84, 30);
            this.facilityIDTextBox.TabIndex = 5;
            this.facilityIDTextBox.TextChanged += new System.EventHandler(this.facilityIDTextBox_TextChanged);
            this.facilityIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.facilityIDTextBox_KeyPress);
            // 
            // facilityTypeTextBox
            // 
            this.facilityTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityTypeTextBox.Location = new System.Drawing.Point(314, 181);
            this.facilityTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facilityTypeTextBox.Name = "facilityTypeTextBox";
            this.facilityTypeTextBox.ReadOnly = true;
            this.facilityTypeTextBox.Size = new System.Drawing.Size(172, 30);
            this.facilityTypeTextBox.TabIndex = 6;
            // 
            // facilityAddressTextBox
            // 
            this.facilityAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityAddressTextBox.Location = new System.Drawing.Point(314, 213);
            this.facilityAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facilityAddressTextBox.Name = "facilityAddressTextBox";
            this.facilityAddressTextBox.ReadOnly = true;
            this.facilityAddressTextBox.Size = new System.Drawing.Size(340, 30);
            this.facilityAddressTextBox.TabIndex = 7;
            this.facilityAddressTextBox.TextChanged += new System.EventHandler(this.facilityAddressTextBox_TextChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(166, 257);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(142, 25);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Date Required:";
            this.dateLabel.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 252);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 30);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.VisibleChanged += new System.EventHandler(this.dateTimePicker1_VisibleChanged);
            // 
            // lookUpFacilityButton
            // 
            this.lookUpFacilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpFacilityButton.Location = new System.Drawing.Point(425, 144);
            this.lookUpFacilityButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lookUpFacilityButton.Name = "lookUpFacilityButton";
            this.lookUpFacilityButton.Size = new System.Drawing.Size(189, 32);
            this.lookUpFacilityButton.TabIndex = 17;
            this.lookUpFacilityButton.Text = "Look Up Facility";
            this.lookUpFacilityButton.UseVisualStyleBackColor = true;
            this.lookUpFacilityButton.Click += new System.EventHandler(this.lookUpFacilityButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.Location = new System.Drawing.Point(401, 488);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(184, 40);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Back";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 32);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel1
            // 
            this.timeSlotLabel1.AutoSize = true;
            this.timeSlotLabel1.Location = new System.Drawing.Point(192, 26);
            this.timeSlotLabel1.Name = "timeSlotLabel1";
            this.timeSlotLabel1.Size = new System.Drawing.Size(68, 20);
            this.timeSlotLabel1.TabIndex = 21;
            this.timeSlotLabel1.Text = "9:00 AM";
            // 
            // timeSlotLabel2
            // 
            this.timeSlotLabel2.AutoSize = true;
            this.timeSlotLabel2.Location = new System.Drawing.Point(242, 26);
            this.timeSlotLabel2.Name = "timeSlotLabel2";
            this.timeSlotLabel2.Size = new System.Drawing.Size(77, 20);
            this.timeSlotLabel2.TabIndex = 23;
            this.timeSlotLabel2.Text = "10:00 AM";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 32);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel4
            // 
            this.timeSlotLabel4.AutoSize = true;
            this.timeSlotLabel4.Location = new System.Drawing.Point(343, 26);
            this.timeSlotLabel4.Name = "timeSlotLabel4";
            this.timeSlotLabel4.Size = new System.Drawing.Size(76, 20);
            this.timeSlotLabel4.TabIndex = 27;
            this.timeSlotLabel4.Text = "12:00 PM";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(345, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 32);
            this.button4.TabIndex = 26;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel3
            // 
            this.timeSlotLabel3.AutoSize = true;
            this.timeSlotLabel3.Location = new System.Drawing.Point(293, 26);
            this.timeSlotLabel3.Name = "timeSlotLabel3";
            this.timeSlotLabel3.Size = new System.Drawing.Size(77, 20);
            this.timeSlotLabel3.TabIndex = 25;
            this.timeSlotLabel3.Text = "11:00 AM";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 32);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel6
            // 
            this.timeSlotLabel6.AutoSize = true;
            this.timeSlotLabel6.Location = new System.Drawing.Point(444, 26);
            this.timeSlotLabel6.Name = "timeSlotLabel6";
            this.timeSlotLabel6.Size = new System.Drawing.Size(67, 20);
            this.timeSlotLabel6.TabIndex = 31;
            this.timeSlotLabel6.Text = "2:00 PM";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(446, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 32);
            this.button6.TabIndex = 30;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel5
            // 
            this.timeSlotLabel5.AutoSize = true;
            this.timeSlotLabel5.Location = new System.Drawing.Point(394, 26);
            this.timeSlotLabel5.Name = "timeSlotLabel5";
            this.timeSlotLabel5.Size = new System.Drawing.Size(67, 20);
            this.timeSlotLabel5.TabIndex = 29;
            this.timeSlotLabel5.Text = "1:00 PM";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(397, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 32);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel12
            // 
            this.timeSlotLabel12.AutoSize = true;
            this.timeSlotLabel12.Location = new System.Drawing.Point(746, 26);
            this.timeSlotLabel12.Name = "timeSlotLabel12";
            this.timeSlotLabel12.Size = new System.Drawing.Size(67, 20);
            this.timeSlotLabel12.TabIndex = 43;
            this.timeSlotLabel12.Text = "8:00 PM";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(748, 50);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(44, 32);
            this.button12.TabIndex = 42;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel11
            // 
            this.timeSlotLabel11.AutoSize = true;
            this.timeSlotLabel11.Location = new System.Drawing.Point(696, 26);
            this.timeSlotLabel11.Name = "timeSlotLabel11";
            this.timeSlotLabel11.Size = new System.Drawing.Size(67, 20);
            this.timeSlotLabel11.TabIndex = 41;
            this.timeSlotLabel11.Text = "7:00 PM";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(698, 50);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(44, 32);
            this.button11.TabIndex = 40;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel10
            // 
            this.timeSlotLabel10.AutoSize = true;
            this.timeSlotLabel10.Location = new System.Drawing.Point(645, 26);
            this.timeSlotLabel10.Name = "timeSlotLabel10";
            this.timeSlotLabel10.Size = new System.Drawing.Size(67, 20);
            this.timeSlotLabel10.TabIndex = 39;
            this.timeSlotLabel10.Text = "6:00 PM";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(647, 50);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 32);
            this.button10.TabIndex = 38;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel9
            // 
            this.timeSlotLabel9.AutoSize = true;
            this.timeSlotLabel9.Location = new System.Drawing.Point(595, 26);
            this.timeSlotLabel9.Name = "timeSlotLabel9";
            this.timeSlotLabel9.Size = new System.Drawing.Size(67, 20);
            this.timeSlotLabel9.TabIndex = 37;
            this.timeSlotLabel9.Text = "5:00 PM";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(597, 50);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 32);
            this.button9.TabIndex = 36;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel8
            // 
            this.timeSlotLabel8.AutoSize = true;
            this.timeSlotLabel8.Location = new System.Drawing.Point(544, 26);
            this.timeSlotLabel8.Name = "timeSlotLabel8";
            this.timeSlotLabel8.Size = new System.Drawing.Size(67, 20);
            this.timeSlotLabel8.TabIndex = 35;
            this.timeSlotLabel8.Text = "4:00 PM";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(546, 50);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 32);
            this.button8.TabIndex = 34;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // timeSlotLabel7
            // 
            this.timeSlotLabel7.AutoSize = true;
            this.timeSlotLabel7.Location = new System.Drawing.Point(494, 26);
            this.timeSlotLabel7.Name = "timeSlotLabel7";
            this.timeSlotLabel7.Size = new System.Drawing.Size(67, 20);
            this.timeSlotLabel7.TabIndex = 33;
            this.timeSlotLabel7.Text = "3:00 PM";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(496, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 32);
            this.button7.TabIndex = 32;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeSlotLabel);
            this.panel1.Controls.Add(this.timeSlotLabel12);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.timeSlotLabel11);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.timeSlotLabel10);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.timeSlotLabel9);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.timeSlotLabel8);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.timeSlotLabel7);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.timeSlotLabel6);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.timeSlotLabel5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.timeSlotLabel4);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.timeSlotLabel3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.timeSlotLabel2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.timeSlotLabel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(124, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 109);
            this.panel1.TabIndex = 44;
            this.panel1.Visible = false;
            // 
            // timeSlotLabel
            // 
            this.timeSlotLabel.AutoSize = true;
            this.timeSlotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSlotLabel.Location = new System.Drawing.Point(23, 52);
            this.timeSlotLabel.Name = "timeSlotLabel";
            this.timeSlotLabel.Size = new System.Drawing.Size(173, 25);
            this.timeSlotLabel.TabIndex = 44;
            this.timeSlotLabel.Text = "Time slot required:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 45;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(924, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // MainSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.lookUpFacilityButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.facilityAddressTextBox);
            this.Controls.Add(this.facilityTypeTextBox);
            this.Controls.Add(this.facilityIDTextBox);
            this.Controls.Add(this.facilityIDLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seach for Facility Availability";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label facilityIDLabel;
        private System.Windows.Forms.TextBox facilityIDTextBox;
        private System.Windows.Forms.TextBox facilityTypeTextBox;
        private System.Windows.Forms.TextBox facilityAddressTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button lookUpFacilityButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label timeSlotLabel1;
        private System.Windows.Forms.Label timeSlotLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label timeSlotLabel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label timeSlotLabel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label timeSlotLabel6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label timeSlotLabel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label timeSlotLabel12;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label timeSlotLabel11;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label timeSlotLabel10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label timeSlotLabel9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label timeSlotLabel8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label timeSlotLabel7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeSlotLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}