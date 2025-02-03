namespace FittrackMS
{
    partial class Equipmentadding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipmentadding));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtItemName = new TextBox();
            cmbCategory = new ComboBox();
            cmbStatus = new ComboBox();
            Added_dateTimePicker1 = new DateTimePicker();
            Lastupdate_dateTimePicker2 = new DateTimePicker();
            txtSupplier = new TextBox();
            btnSave = new Button();
            BtnClear = new Button();
            label8 = new Label();
            txtCostPerUnit = new TextBox();
            txtQuantity = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(325, 147);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(325, 186);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(325, 230);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(325, 273);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Date Added";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(325, 314);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 4;
            label5.Text = " Last Updated Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(325, 354);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = " Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(325, 395);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 6;
            label7.Text = "Suppliar ";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(453, 139);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(256, 23);
            txtItemName.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Cardio Equipment", "Strength Equipment", "Accessories", "Machines", "Supplies" });
            cmbCategory.Location = new Point(453, 186);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 8;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "", "In Maintenance", "", "Out of Stock", "", "Decommissioned" });
            cmbStatus.Location = new Point(453, 354);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 10;
            // 
            // Added_dateTimePicker1
            // 
            Added_dateTimePicker1.Location = new Point(453, 273);
            Added_dateTimePicker1.Name = "Added_dateTimePicker1";
            Added_dateTimePicker1.Size = new Size(200, 23);
            Added_dateTimePicker1.TabIndex = 11;
            // 
            // Lastupdate_dateTimePicker2
            // 
            Lastupdate_dateTimePicker2.Location = new Point(453, 314);
            Lastupdate_dateTimePicker2.Name = "Lastupdate_dateTimePicker2";
            Lastupdate_dateTimePicker2.Size = new Size(200, 23);
            Lastupdate_dateTimePicker2.TabIndex = 12;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(453, 395);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(256, 23);
            txtSupplier.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.IndianRed;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(764, 372);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 46);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button2_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.MediumTurquoise;
            BtnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(764, 314);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(116, 46);
            BtnClear.TabIndex = 16;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(325, 431);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 17;
            label8.Text = "Cost Per Unit ";
            // 
            // txtCostPerUnit
            // 
            txtCostPerUnit.Location = new Point(453, 431);
            txtCostPerUnit.Name = "txtCostPerUnit";
            txtCostPerUnit.Size = new Size(256, 23);
            txtCostPerUnit.TabIndex = 18;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(453, 230);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(121, 23);
            txtQuantity.TabIndex = 19;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(30, 41);
            button3.Name = "button3";
            button3.Size = new Size(32, 24);
            button3.TabIndex = 22;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Equipmentadding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(913, 518);
            Controls.Add(button3);
            Controls.Add(txtQuantity);
            Controls.Add(label8);
            Controls.Add(BtnClear);
            Controls.Add(btnSave);
            Controls.Add(txtSupplier);
            Controls.Add(Lastupdate_dateTimePicker2);
            Controls.Add(Added_dateTimePicker1);
            Controls.Add(cmbStatus);
            Controls.Add(cmbCategory);
            Controls.Add(txtItemName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCostPerUnit);
            DoubleBuffered = true;
            Name = "Equipmentadding";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipmentadding";
            Load += Equipmentadding_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtItemName;
        private ComboBox cmbCategory;
        private ComboBox cmbStatus;
        private DateTimePicker Added_dateTimePicker1;
        private DateTimePicker Lastupdate_dateTimePicker2;
        private TextBox txtSupplier;
        private Button btnSave;
        private Button BtnClear;
        private Label label8;
        private TextBox txtCostPerUnit;
        private TextBox txtQuantity;
        private Button button3;
    }
}