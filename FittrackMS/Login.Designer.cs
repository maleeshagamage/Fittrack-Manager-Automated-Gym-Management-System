namespace FittrackMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txtuserid = new TextBox();
            txtpassword = new TextBox();
            Password = new Label();
            btnlogin = new Button();
            cmbusertype = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(548, 261);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            // 
            // txtuserid
            // 
            txtuserid.BorderStyle = BorderStyle.FixedSingle;
            txtuserid.Location = new Point(457, 298);
            txtuserid.Multiline = true;
            txtuserid.Name = "txtuserid";
            txtuserid.Size = new Size(237, 41);
            txtuserid.TabIndex = 1;
            txtuserid.TextAlign = HorizontalAlignment.Center;
            txtuserid.UseWaitCursor = true;
            // 
            // txtpassword
            // 
            txtpassword.AccessibleRole = AccessibleRole.HotkeyField;
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Location = new Point(457, 394);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(237, 41);
            txtpassword.TabIndex = 3;
            txtpassword.TextAlign = HorizontalAlignment.Center;
            txtpassword.UseWaitCursor = true;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Password.ForeColor = SystemColors.ButtonHighlight;
            Password.Location = new Point(534, 354);
            Password.Name = "Password";
            Password.Size = new Size(76, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Purple;
            btnlogin.Font = new Font("Segoe UI", 11F);
            btnlogin.ForeColor = SystemColors.ButtonHighlight;
            btnlogin.Location = new Point(534, 459);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(85, 32);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // cmbusertype
            // 
            cmbusertype.FormattingEnabled = true;
            cmbusertype.Items.AddRange(new object[] { "Coach", "Admin", "Owner" });
            cmbusertype.Location = new Point(573, 217);
            cmbusertype.Name = "cmbusertype";
            cmbusertype.Size = new Size(121, 23);
            cmbusertype.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(468, 220);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 6;
            label2.Text = "User Type";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(737, 531);
            Controls.Add(label2);
            Controls.Add(cmbusertype);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(Password);
            Controls.Add(txtuserid);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtuserid;
        private TextBox txtpassword;
        private Label Password;
        private Button btnlogin;
        private ComboBox cmbusertype;
        private Label label2;
    }
}