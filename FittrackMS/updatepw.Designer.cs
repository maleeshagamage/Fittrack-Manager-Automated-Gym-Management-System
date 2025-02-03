namespace FittrackMS
{
    partial class PasswordUpdate
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
            label1 = new Label();
            label2 = new Label();
            labelStaffID = new Label();
            label3 = new Label();
            Newpassword1 = new Label();
            Newpassword2 = new Label();
            currentpassword = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            BTNChangepw = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(72, 47);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 0;
            label1.Text = "Password Update";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 120);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "User_ID    :";
            // 
            // labelStaffID
            // 
            labelStaffID.AutoSize = true;
            labelStaffID.Location = new Point(186, 120);
            labelStaffID.Name = "labelStaffID";
            labelStaffID.Size = new Size(92, 15);
            labelStaffID.TabIndex = 2;
            labelStaffID.Text = "_________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 176);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 3;
            label3.Text = "Current Password   :";
            // 
            // Newpassword1
            // 
            Newpassword1.AutoSize = true;
            Newpassword1.Location = new Point(58, 225);
            Newpassword1.Name = "Newpassword1";
            Newpassword1.Size = new Size(96, 15);
            Newpassword1.TabIndex = 4;
            Newpassword1.Text = "New Password   :";
            // 
            // Newpassword2
            // 
            Newpassword2.AutoSize = true;
            Newpassword2.Location = new Point(58, 275);
            Newpassword2.Name = "Newpassword2";
            Newpassword2.Size = new Size(116, 15);
            Newpassword2.TabIndex = 5;
            Newpassword2.Text = "Confirm Password   :";
            // 
            // currentpassword
            // 
            currentpassword.Location = new Point(178, 168);
            currentpassword.Name = "currentpassword";
            currentpassword.PasswordChar = '*';
            currentpassword.Size = new Size(153, 23);
            currentpassword.TabIndex = 6;
            currentpassword.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(178, 222);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(153, 23);
            textBox2.TabIndex = 7;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(178, 272);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(153, 23);
            textBox3.TabIndex = 8;
            textBox3.UseSystemPasswordChar = true;
            // 
            // BTNChangepw
            // 
            BTNChangepw.BackColor = Color.Crimson;
            BTNChangepw.Location = new Point(142, 328);
            BTNChangepw.Name = "BTNChangepw";
            BTNChangepw.Size = new Size(108, 38);
            BTNChangepw.TabIndex = 9;
            BTNChangepw.Text = "Change";
            BTNChangepw.UseVisualStyleBackColor = false;
            BTNChangepw.Click += BTNChangepw_Click;
            // 
            // PasswordUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(395, 396);
            Controls.Add(BTNChangepw);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(currentpassword);
            Controls.Add(Newpassword2);
            Controls.Add(Newpassword1);
            Controls.Add(label3);
            Controls.Add(labelStaffID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PasswordUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelStaffID;
        private Label label3;
        private Label Newpassword1;
        private Label Newpassword2;
        private TextBox currentpassword;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button BTNChangepw;
    }
}