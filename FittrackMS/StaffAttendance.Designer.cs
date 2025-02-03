namespace FittrackMS
{
    partial class StaffAttendance
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffAttendance));
            lblstaffID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Staff_ID = new Label();
            Member_Name = new Label();
            Shift_start = new Label();
            txtsearch = new TextBox();
            Btnsearch = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            staffAttendanceGrid = new DataGridView();
            BtnCheckin = new Button();
            BtnCheckout = new Button();
            Shift_End = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)staffAttendanceGrid).BeginInit();
            SuspendLayout();
            // 
            // lblstaffID
            // 
            lblstaffID.AutoSize = true;
            lblstaffID.BackColor = SystemColors.ButtonHighlight;
            lblstaffID.Location = new Point(138, 186);
            lblstaffID.Name = "lblstaffID";
            lblstaffID.Size = new Size(56, 15);
            lblstaffID.TabIndex = 0;
            lblstaffID.Text = "Staff_ID  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(138, 219);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Member_Name  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(659, 186);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(442, 186);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 3;
            label4.Text = "Member_Shift  :";
            // 
            // Staff_ID
            // 
            Staff_ID.AutoSize = true;
            Staff_ID.BackColor = SystemColors.ButtonHighlight;
            Staff_ID.Location = new Point(260, 186);
            Staff_ID.Name = "Staff_ID";
            Staff_ID.Size = new Size(47, 15);
            Staff_ID.TabIndex = 4;
            Staff_ID.Text = "Staff_ID";
            // 
            // Member_Name
            // 
            Member_Name.AutoSize = true;
            Member_Name.BackColor = SystemColors.ButtonHighlight;
            Member_Name.Location = new Point(260, 219);
            Member_Name.Name = "Member_Name";
            Member_Name.Size = new Size(89, 15);
            Member_Name.TabIndex = 5;
            Member_Name.Text = "Member_Name";
            // 
            // Shift_start
            // 
            Shift_start.AutoSize = true;
            Shift_start.BackColor = SystemColors.ButtonHighlight;
            Shift_start.Location = new Point(556, 186);
            Shift_start.Name = "Shift_start";
            Shift_start.Size = new Size(63, 15);
            Shift_start.TabIndex = 6;
            Shift_start.Text = "Shift_ Start";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(375, 145);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(294, 23);
            txtsearch.TabIndex = 7;
            // 
            // Btnsearch
            // 
            Btnsearch.BackColor = Color.LightSkyBlue;
            Btnsearch.Location = new Point(675, 139);
            Btnsearch.Name = "Btnsearch";
            Btnsearch.Size = new Size(76, 33);
            Btnsearch.TabIndex = 8;
            Btnsearch.Text = "Search";
            Btnsearch.UseVisualStyleBackColor = false;
            Btnsearch.Click += Btnsearch_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(537, 219);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(445, 227);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Date  :";
            // 
            // staffAttendanceGrid
            // 
            staffAttendanceGrid.BackgroundColor = SystemColors.ButtonHighlight;
            staffAttendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffAttendanceGrid.Location = new Point(77, 267);
            staffAttendanceGrid.Name = "staffAttendanceGrid";
            staffAttendanceGrid.Size = new Size(750, 206);
            staffAttendanceGrid.TabIndex = 11;
            // 
            // BtnCheckin
            // 
            BtnCheckin.BackColor = Color.FromArgb(192, 0, 0);
            BtnCheckin.Location = new Point(769, 177);
            BtnCheckin.Name = "BtnCheckin";
            BtnCheckin.Size = new Size(76, 33);
            BtnCheckin.TabIndex = 12;
            BtnCheckin.Text = "Check In";
            BtnCheckin.UseVisualStyleBackColor = false;
            BtnCheckin.Click += BtnCheckin_Click;
            // 
            // BtnCheckout
            // 
            BtnCheckout.BackColor = Color.FromArgb(128, 128, 255);
            BtnCheckout.Location = new Point(769, 216);
            BtnCheckout.Name = "BtnCheckout";
            BtnCheckout.Size = new Size(76, 33);
            BtnCheckout.TabIndex = 13;
            BtnCheckout.Text = "Checkout";
            BtnCheckout.UseVisualStyleBackColor = false;
            BtnCheckout.Click += BtnCheckout_Click;
            // 
            // Shift_End
            // 
            Shift_End.AutoSize = true;
            Shift_End.BackColor = SystemColors.ButtonHighlight;
            Shift_End.Location = new Point(635, 186);
            Shift_End.Name = "Shift_End";
            Shift_End.Size = new Size(56, 15);
            Shift_End.TabIndex = 14;
            Shift_End.Text = "Shift_End";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(39, 40);
            button3.Name = "button3";
            button3.Size = new Size(32, 24);
            button3.TabIndex = 31;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // StaffAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Add_a_heading__21_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 510);
            Controls.Add(button3);
            Controls.Add(Shift_End);
            Controls.Add(BtnCheckout);
            Controls.Add(BtnCheckin);
            Controls.Add(staffAttendanceGrid);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(Btnsearch);
            Controls.Add(txtsearch);
            Controls.Add(Shift_start);
            Controls.Add(Member_Name);
            Controls.Add(Staff_ID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblstaffID);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "StaffAttendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberAttendance";
            ((System.ComponentModel.ISupportInitialize)staffAttendanceGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblstaffID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Staff_ID;
        private Label Member_Name;
        private Label Shift_start;
        private TextBox txtsearch;
        private Button Btnsearch;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DataGridView staffAttendanceGrid;
        private Button BtnCheckin;
        private Button BtnCheckout;
        private Label Shift_End;
        private Button button3;
    }
    
    }
