namespace FittrackMS
{
    partial class Staffview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staffview));
            dataGridView1 = new DataGridView();
            richTextBox1 = new RichTextBox();
            Searchbtn = new Button();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(157, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(524, 271);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(157, 132);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(326, 32);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Searchbtn
            // 
            Searchbtn.BackColor = Color.FromArgb(255, 192, 192);
            Searchbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchbtn.Location = new Point(489, 132);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(93, 32);
            Searchbtn.TabIndex = 2;
            Searchbtn.Text = "Search ";
            Searchbtn.UseVisualStyleBackColor = false;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(588, 132);
            button1.Name = "button1";
            button1.Size = new Size(93, 32);
            button1.TabIndex = 3;
            button1.Text = "Reset ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(29, 43);
            button3.Name = "button3";
            button3.Size = new Size(32, 24);
            button3.TabIndex = 32;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Staffview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(837, 522);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(Searchbtn);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Staffview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staffview";
            Load += Staffview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private RichTextBox richTextBox1;
        private Button Searchbtn;
        private Button button1;
        private Button button3;
    }
}