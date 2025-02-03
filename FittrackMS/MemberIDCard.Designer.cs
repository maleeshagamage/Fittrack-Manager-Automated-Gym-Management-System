namespace FittrackMS
{
    partial class MemberIDCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberIDCard));
            label1 = new Label();
            label2 = new Label();
            lblname = new Label();
            label3 = new Label();
            lbluserid = new Label();
            label4 = new Label();
            lblNIC = new Label();
            btnPrint = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(41, 20);
            label1.Name = "label1";
            label1.Size = new Size(204, 36);
            label1.TabIndex = 0;
            label1.Text = "Member ID Card";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(28, 212);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 1;
            label2.Text = "Member Name :";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 10F);
            lblname.Location = new Point(142, 212);
            lblname.Name = "lblname";
            lblname.Size = new Size(117, 19);
            lblname.TabIndex = 2;
            lblname.Text = "__________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(28, 274);
            label3.Name = "label3";
            label3.Size = new Size(102, 19);
            label3.TabIndex = 3;
            label3.Text = "Member ID     :";
            // 
            // lbluserid
            // 
            lbluserid.AutoSize = true;
            lbluserid.Font = new Font("Segoe UI", 10F);
            lbluserid.Location = new Point(142, 274);
            lbluserid.Name = "lbluserid";
            lbluserid.Size = new Size(117, 19);
            lbluserid.TabIndex = 4;
            lbluserid.Text = "__________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(28, 331);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 5;
            label4.Text = "Member NIC  :";
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.Font = new Font("Segoe UI", 10F);
            lblNIC.Location = new Point(142, 331);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(117, 19);
            lblNIC.TabIndex = 6;
            lblNIC.Text = "__________________";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.IndianRed;
            btnPrint.Location = new Point(79, 384);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(106, 37);
            btnPrint.TabIndex = 7;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
          
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // MemberIDCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(280, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnPrint);
            Controls.Add(lblNIC);
            Controls.Add(label4);
            Controls.Add(lbluserid);
            Controls.Add(label3);
            Controls.Add(lblname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MemberIDCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MemberIDCard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblname;
        private Label label3;
        private Label lbluserid;
        private Label label4;
        private Label lblNIC;
        private Button btnPrint;
        private PictureBox pictureBox1;
    }
}