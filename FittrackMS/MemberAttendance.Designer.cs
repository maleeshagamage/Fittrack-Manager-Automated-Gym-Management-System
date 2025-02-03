namespace FittrackMS
{
    partial class MemberAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberAttendance));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Member_ID = new Label();
            Member_Name = new Label();
            Member_NIC = new Label();
            txtsearch = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            AttendanceGrid = new DataGridView();
            BtnCheckin = new Button();
            BtnCheckout = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)AttendanceGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(138, 186);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Member_ID  :";
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
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Member_NIC  :";
            // 
            // Member_ID
            // 
            Member_ID.AutoSize = true;
            Member_ID.BackColor = SystemColors.ButtonHighlight;
            Member_ID.Location = new Point(260, 186);
            Member_ID.Name = "Member_ID";
            Member_ID.Size = new Size(68, 15);
            Member_ID.TabIndex = 4;
            Member_ID.Text = "Member_ID";
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
            // Member_NIC
            // 
            Member_NIC.AutoSize = true;
            Member_NIC.BackColor = SystemColors.ButtonHighlight;
            Member_NIC.Location = new Point(537, 186);
            Member_NIC.Name = "Member_NIC";
            Member_NIC.Size = new Size(77, 15);
            Member_NIC.TabIndex = 6;
            Member_NIC.Text = "Member_NIC";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(375, 145);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(294, 23);
            txtsearch.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(675, 139);
            button1.Name = "button1";
            button1.Size = new Size(76, 33);
            button1.TabIndex = 8;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // AttendanceGrid
            // 
            AttendanceGrid.BackgroundColor = SystemColors.ButtonHighlight;
            AttendanceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceGrid.Location = new Point(152, 292);
            AttendanceGrid.Name = "AttendanceGrid";
            AttendanceGrid.Size = new Size(647, 180);
            AttendanceGrid.TabIndex = 11;
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
            BtnCheckout.Click += BtnCheckout_Click_1;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(33, 42);
            button3.Name = "button3";
            button3.Size = new Size(32, 24);
            button3.TabIndex = 21;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MemberAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 510);
            Controls.Add(button3);
            Controls.Add(BtnCheckout);
            Controls.Add(BtnCheckin);
            Controls.Add(AttendanceGrid);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(txtsearch);
            Controls.Add(Member_NIC);
            Controls.Add(Member_Name);
            Controls.Add(Member_ID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "MemberAttendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberAttendance";
            ((System.ComponentModel.ISupportInitialize)AttendanceGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Member_ID;
        private Label Member_Name;
        private Label Member_NIC;
        private TextBox txtsearch;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DataGridView AttendanceGrid;
        private Button BtnCheckin;
        private Button BtnCheckout;
        private Button button3;
    }
}