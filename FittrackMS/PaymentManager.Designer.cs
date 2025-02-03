namespace FittrackMS
{
    partial class PaymentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentManager));
            buttonsearchuser = new Button();
            textSearch = new TextBox();
            lblname = new Label();
            label1 = new Label();
            lblNIC = new Label();
            label3 = new Label();
            label2 = new Label();
            lblfeetype = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            BtnAddpyment = new Button();
            txtAmount = new TextBox();
            BtnReset = new Button();
            dataGridView1 = new DataGridView();
            textsearch2 = new TextBox();
            btnsearchrecord = new Button();
            datestart = new DateTimePicker();
            dateend = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonsearchuser
            // 
            buttonsearchuser.BackColor = SystemColors.ActiveCaption;
            buttonsearchuser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonsearchuser.Location = new Point(508, 98);
            buttonsearchuser.Name = "buttonsearchuser";
            buttonsearchuser.Size = new Size(75, 23);
            buttonsearchuser.TabIndex = 0;
            buttonsearchuser.Text = "Search";
            buttonsearchuser.UseVisualStyleBackColor = false;
            buttonsearchuser.Click += button1_Click_1;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(176, 98);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(326, 23);
            textSearch.TabIndex = 1;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(212, 150);
            lblname.Name = "lblname";
            lblname.Size = new Size(82, 15);
            lblname.TabIndex = 2;
            lblname.Text = "_______________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 150);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Name   :";
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.Location = new Point(353, 150);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(82, 15);
            lblNIC.TabIndex = 4;
            lblNIC.Text = "_______________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 150);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "NIC   :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 150);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Fee Type   :";
            // 
            // lblfeetype
            // 
            lblfeetype.AutoSize = true;
            lblfeetype.Location = new Point(510, 150);
            lblfeetype.Name = "lblfeetype";
            lblfeetype.Size = new Size(87, 15);
            lblfeetype.TabIndex = 7;
            lblfeetype.Text = "________________";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(196, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 200);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Date  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 200);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "Amount  :";
            // 
            // BtnAddpyment
            // 
            BtnAddpyment.BackColor = Color.FromArgb(203, 0, 0);
            BtnAddpyment.Location = new Point(269, 237);
            BtnAddpyment.Name = "BtnAddpyment";
            BtnAddpyment.Size = new Size(108, 32);
            BtnAddpyment.TabIndex = 11;
            BtnAddpyment.Text = "Add Payment";
            BtnAddpyment.UseVisualStyleBackColor = false;
            BtnAddpyment.Click += BtnAddpyment_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(494, 192);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(116, 23);
            txtAmount.TabIndex = 12;
            // 
            // BtnReset
            // 
            BtnReset.BackColor = Color.FromArgb(128, 255, 255);
            BtnReset.Location = new Point(383, 237);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(108, 32);
            BtnReset.TabIndex = 14;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = false;
            BtnReset.Click += BtnReset_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 363);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(635, 244);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textsearch2
            // 
            textsearch2.Location = new Point(383, 325);
            textsearch2.Name = "textsearch2";
            textsearch2.Size = new Size(178, 23);
            textsearch2.TabIndex = 16;
            // 
            // btnsearchrecord
            // 
            btnsearchrecord.BackColor = SystemColors.ActiveCaption;
            btnsearchrecord.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearchrecord.Location = new Point(567, 318);
            btnsearchrecord.Name = "btnsearchrecord";
            btnsearchrecord.Size = new Size(132, 35);
            btnsearchrecord.TabIndex = 17;
            btnsearchrecord.Text = "Search Record";
            btnsearchrecord.UseVisualStyleBackColor = false;
            btnsearchrecord.Click += btnsearchrecord_Click;
            // 
            // datestart
            // 
            datestart.Location = new Point(64, 325);
            datestart.Name = "datestart";
            datestart.Size = new Size(154, 23);
            datestart.TabIndex = 18;
            // 
            // dateend
            // 
            dateend.Location = new Point(224, 325);
            dateend.Name = "dateend";
            dateend.Size = new Size(153, 23);
            dateend.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(336, 64);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 20;
            label6.Text = "Add Payment";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(336, 288);
            label7.Name = "label7";
            label7.Size = new Size(112, 21);
            label7.TabIndex = 21;
            label7.Text = "View Records";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(40, 22);
            button3.Name = "button3";
            button3.Size = new Size(32, 24);
            button3.TabIndex = 30;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // PaymentManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(781, 645);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dateend);
            Controls.Add(datestart);
            Controls.Add(btnsearchrecord);
            Controls.Add(textsearch2);
            Controls.Add(dataGridView1);
            Controls.Add(BtnReset);
            Controls.Add(txtAmount);
            Controls.Add(BtnAddpyment);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblfeetype);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblNIC);
            Controls.Add(label1);
            Controls.Add(lblname);
            Controls.Add(textSearch);
            Controls.Add(buttonsearchuser);
            DoubleBuffered = true;
            Name = "PaymentManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentManager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonsearchuser;
        private TextBox textSearch;
        private Label lblname;
        private Label label1;
        private Label lblNIC;
        private Label label3;
        private Label label2;
        private Label lblfeetype;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Button BtnAddpyment;
        private TextBox txtAmount;
        private Button BtnReset;
        private DataGridView dataGridView1;
        private TextBox textsearch2;
        private Button btnsearchrecord;
        private DateTimePicker datestart;
        private DateTimePicker dateend;
        private Label label6;
        private Label label7;
        private Button button3;
    }
}