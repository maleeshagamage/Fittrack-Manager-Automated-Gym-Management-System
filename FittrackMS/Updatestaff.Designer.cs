using System.Windows.Forms;

namespace FittrackMS
{
    partial class Updatestaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updatestaff));
            buttonbck = new Button();
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
            BtnUpdate = new Button();
            Btnreset = new Button();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            shiftstartcmb = new ComboBox();
            label9 = new Label();
            shiftendcmb = new ComboBox();
            textSearch = new TextBox();
            Buttonsearch = new Button();
            Btndelete = new Button();
            SuspendLayout();
            // 
            // buttonbck
            // 
            buttonbck.BackgroundImage = (Image)resources.GetObject("buttonbck.BackgroundImage");
            buttonbck.BackgroundImageLayout = ImageLayout.Stretch;
            buttonbck.Location = new Point(31, 25);
            buttonbck.Name = "buttonbck";
            buttonbck.Size = new Size(32, 24);
            buttonbck.TabIndex = 33;
            buttonbck.UseVisualStyleBackColor = true;
            buttonbck.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(74, 177);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Name with Initials :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(74, 219);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "NIC Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(74, 257);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Adress :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(74, 392);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Contact Number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(74, 443);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = " Gender :";
            // 
            // textname
            // 
            textname.Location = new Point(188, 169);
            textname.Name = "textname";
            textname.Size = new Size(186, 23);
            textname.TabIndex = 5;
            // 
            // textNIC
            // 
            textNIC.Location = new Point(188, 211);
            textNIC.Name = "textNIC";
            textNIC.Size = new Size(186, 23);
            textNIC.TabIndex = 6;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(188, 257);
            textAddress.Multiline = true;
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(186, 38);
            textAddress.TabIndex = 7;
            // 
            // textcontctNo
            // 
            textcontctNo.Location = new Point(188, 389);
            textcontctNo.Name = "textcontctNo";
            textcontctNo.Size = new Size(186, 23);
            textcontctNo.TabIndex = 8;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(188, 443);
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
            female.Location = new Point(311, 441);
            female.Name = "female";
            female.Size = new Size(63, 19);
            female.TabIndex = 10;
            female.TabStop = true;
            female.Text = "FeMale";
            female.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.Cyan;
            BtnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUpdate.Location = new Point(494, 265);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(127, 42);
            BtnUpdate.TabIndex = 15;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += button1_Click;
            // 
            // Btnreset
            // 
            Btnreset.BackColor = Color.FromArgb(128, 255, 128);
            Btnreset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnreset.Location = new Point(530, 109);
            Btnreset.Name = "Btnreset";
            Btnreset.Size = new Size(91, 23);
            Btnreset.TabIndex = 16;
            Btnreset.Text = "Reset";
            Btnreset.UseVisualStyleBackColor = false;
            Btnreset.Click += Btnreset_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(494, 176);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 17;
            label7.Text = "Staff Category. :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Owner", "Coach", "Admin" });
            comboBox1.Location = new Point(494, 211);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(74, 319);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 21;
            label8.Text = "Shift Start  :";
            // 
            // shiftstartcmb
            // 
            shiftstartcmb.FormattingEnabled = true;
            shiftstartcmb.Items.AddRange(new object[] { "6.00 AM", "", "8.00 AM", "", "12.00 PM", "", "3.00 PM", "", "5.00 PM", "", "", "", "", "", "", "" });
            shiftstartcmb.Location = new Point(188, 316);
            shiftstartcmb.Name = "shiftstartcmb";
            shiftstartcmb.Size = new Size(112, 23);
            shiftstartcmb.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(74, 350);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 23;
            label9.Text = "Shift End :";
            // 
            // shiftendcmb
            // 
            shiftendcmb.FormattingEnabled = true;
            shiftendcmb.Items.AddRange(new object[] { "10.00 AM", "", "12.00 PM", "", "4.00 PM", "", "7.00 PM", "", "8.00 PM", "", "10.00 PM" });
            shiftendcmb.Location = new Point(188, 350);
            shiftendcmb.Name = "shiftendcmb";
            shiftendcmb.Size = new Size(112, 23);
            shiftendcmb.TabIndex = 24;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(74, 109);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(354, 23);
            textSearch.TabIndex = 34;
            // 
            // Buttonsearch
            // 
            Buttonsearch.BackColor = Color.FromArgb(192, 255, 255);
            Buttonsearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buttonsearch.Location = new Point(445, 109);
            Buttonsearch.Name = "Buttonsearch";
            Buttonsearch.Size = new Size(79, 23);
            Buttonsearch.TabIndex = 35;
            Buttonsearch.Text = "Search";
            Buttonsearch.UseVisualStyleBackColor = false;
            Buttonsearch.Click += Buttonsearch_Click;
            // 
            // Btndelete
            // 
            Btndelete.BackColor = Color.FromArgb(192, 0, 0);
            Btndelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btndelete.Location = new Point(642, 265);
            Btndelete.Name = "Btndelete";
            Btndelete.Size = new Size(127, 42);
            Btndelete.TabIndex = 36;
            Btndelete.Text = "Delete";
            Btndelete.UseVisualStyleBackColor = false;
            Btndelete.Click += Btndelete_Click;
            // 
            // Updatestaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(847, 529);
            Controls.Add(Btndelete);
            Controls.Add(Buttonsearch);
            Controls.Add(textSearch);
            Controls.Add(buttonbck);
            Controls.Add(shiftendcmb);
            Controls.Add(label9);
            Controls.Add(shiftstartcmb);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(Btnreset);
            Controls.Add(BtnUpdate);
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
            Name = "Updatestaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Staff";
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
        private Button BtnUpdate;
        private Button Btnreset;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox shiftstartcmb;
        private Label label9;
        private ComboBox shiftendcmb;
        private Button buttonbck;
        private TextBox textSearch;
        private Button Buttonsearch;
        private Button Btndelete;
    }
}