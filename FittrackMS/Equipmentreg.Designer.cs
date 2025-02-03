namespace FittrackMS
{
    partial class Equipmentreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipmentreg));
            button1 = new Button();
            Inventoryview = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(68, 361);
            button1.Name = "button1";
            button1.Size = new Size(371, 94);
            button1.TabIndex = 0;
            button1.Text = "Add New Item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Inventoryview
            // 
            Inventoryview.BackColor = Color.DarkSlateBlue;
            Inventoryview.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inventoryview.ForeColor = SystemColors.ButtonHighlight;
            Inventoryview.Location = new Point(464, 361);
            Inventoryview.Name = "Inventoryview";
            Inventoryview.Size = new Size(357, 94);
            Inventoryview.TabIndex = 2;
            Inventoryview.Text = "View & Update Inventory";
            Inventoryview.UseVisualStyleBackColor = false;
            Inventoryview.Click += button3_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(35, 38);
            button3.Name = "button3";
            button3.Size = new Size(32, 24);
            button3.TabIndex = 23;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Equipmentreg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(916, 519);
            Controls.Add(button3);
            Controls.Add(Inventoryview);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Equipmentreg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipmentreg";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button Inventoryview;
        private Button button3;
    }
}