namespace FittrackMS
{
    partial class GymStaffRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymStaffRegistration));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textname = new TextBox();
            textNIC = new TextBox();
            textAddress = new TextBox();
            textcontctNo = new TextBox();
            male = new RadioButton();
            female = new RadioButton();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btnbrowse = new Button();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            comboBox1 = new ComboBox();
            linkLabel1 = new LinkLabel();
            button3 = new Button();
            label8 = new Label();
            shiftstartcmb = new ComboBox();
            label9 = new Label();
            shiftendcmb = new ComboBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label10 = new Label();
            txtbxage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(37, 123);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Name with Initials :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(37, 165);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "NIC Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(37, 203);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Adress :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(37, 338);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Contact Number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(37, 389);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = " Gender :";
            // 
            // textname
            // 
            textname.Location = new Point(151, 115);
            textname.Name = "textname";
            textname.Size = new Size(186, 23);
            textname.TabIndex = 5;
            // 
            // textNIC
            // 
            textNIC.Location = new Point(151, 157);
            textNIC.Name = "textNIC";
            textNIC.Size = new Size(186, 23);
            textNIC.TabIndex = 6;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(151, 203);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(186, 38);
            textAddress.TabIndex = 7;
            // 
            // textcontctNo
            // 
            textcontctNo.Location = new Point(151, 335);
            textcontctNo.Name = "textcontctNo";
            textcontctNo.Size = new Size(186, 23);
            textcontctNo.TabIndex = 8;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(151, 389);
            male.Name = "male";
            male.Size = new Size(51, 19);
            male.TabIndex = 9;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(274, 387);
            female.Name = "female";
            female.Size = new Size(63, 19);
            female.TabIndex = 10;
            female.TabStop = true;
            female.Text = "FeMale";
            female.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(458, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(383, 118);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 12;
            label6.Text = "NIC Image :";
            // 
            // btnbrowse
            // 
            btnbrowse.BackColor = Color.DeepSkyBlue;
            btnbrowse.Location = new Point(612, 195);
            btnbrowse.Name = "btnbrowse";
            btnbrowse.Size = new Size(75, 23);
            btnbrowse.TabIndex = 13;
            btnbrowse.Text = "Browse";
            btnbrowse.UseVisualStyleBackColor = false;
            btnbrowse.Click += btnbrowse_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(383, 339);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(229, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "I Agree fo All the Rules and Conditions";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(383, 377);
            button1.Name = "button1";
            button1.Size = new Size(127, 42);
            button1.TabIndex = 15;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(537, 377);
            button2.Name = "button2";
            button2.Size = new Size(127, 42);
            button2.TabIndex = 16;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(383, 237);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 17;
            label7.Text = "Staff Category. :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Owner", "Coach", "Admin" });
            comboBox1.Location = new Point(383, 272);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 18;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ButtonHighlight;
            linkLabel1.DisabledLinkColor = Color.FromArgb(224, 224, 224);
            linkLabel1.Location = new Point(383, 311);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(102, 15);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Terms & Conditions";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(37, 42);
            button3.Name = "button3";
            button3.Size = new Size(32, 24);
            button3.TabIndex = 20;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(37, 265);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 21;
            label8.Text = "Shift Start  :";
            // 
            // shiftstartcmb
            // 
            shiftstartcmb.FormattingEnabled = true;
            shiftstartcmb.Items.AddRange(new object[] { "6.00 AM", "8.00 AM", "12.00 PM", "3.00 PM", "5.00 PM", "", "", "", "", "", "" });
            shiftstartcmb.Location = new Point(151, 262);
            shiftstartcmb.Name = "shiftstartcmb";
            shiftstartcmb.Size = new Size(112, 23);
            shiftstartcmb.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(37, 296);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 23;
            label9.Text = "Shift End :";
            // 
            // shiftendcmb
            // 
            shiftendcmb.FormattingEnabled = true;
            shiftendcmb.Items.AddRange(new object[] { "10.00 AM", "12.00 PM", "4.00 PM", "7.00 PM", "8.00 PM", "10.00 PM" });
            shiftendcmb.Location = new Point(151, 296);
            shiftendcmb.Name = "shiftendcmb";
            shiftendcmb.Size = new Size(112, 23);
            shiftendcmb.TabIndex = 24;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(771, 33);
            button4.Name = "button4";
            button4.Size = new Size(127, 42);
            button4.TabIndex = 25;
            button4.Text = "  Update /  Delete       A User";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(690, 377);
            button5.Name = "button5";
            button5.Size = new Size(127, 42);
            button5.TabIndex = 26;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(756, 195);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 27;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(666, 247);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 28;
            label10.Text = "Age : ";
            label10.Click += label10_Click;
            // 
            // txtbxage
            // 
            txtbxage.Location = new Point(709, 244);
            txtbxage.Name = "txtbxage";
            txtbxage.Size = new Size(186, 23);
            txtbxage.TabIndex = 29;
            // 
            // GymStaffRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(926, 486);
            Controls.Add(txtbxage);
            Controls.Add(label10);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(shiftendcmb);
            Controls.Add(label9);
            Controls.Add(shiftstartcmb);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(linkLabel1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(btnbrowse);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(textcontctNo);
            Controls.Add(textAddress);
            Controls.Add(textNIC);
            Controls.Add(textname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "GymStaffRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GymStaffRegistration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textname;
        private TextBox textNIC;
        private TextBox textAddress;
        private TextBox textcontctNo;
        private RadioButton male;
        private RadioButton female;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnbrowse;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Label label7;
        private ComboBox comboBox1;
        private LinkLabel linkLabel1;
        private Button button3;
        private Label label8;
        private ComboBox shiftstartcmb;
        private Label label9;
        private ComboBox shiftendcmb;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label10;
        private TextBox txtbxage;
    }
}