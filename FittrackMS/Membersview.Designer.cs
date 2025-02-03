namespace FittrackMS
{
    partial class Membersview
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membersview));
            dataGridView1 = new DataGridView();
            btnsearch = new Button();
            btnReset = new Button();
            txtsearch = new RichTextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(853, 307);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.LightCoral;
            btnsearch.Location = new Point(577, 106);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(106, 32);
            btnsearch.TabIndex = 1;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ActiveCaption;
            btnReset.Location = new Point(689, 106);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(107, 32);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click_1;
            // 
            // txtsearch
            // 
            txtsearch.BorderStyle = BorderStyle.FixedSingle;
            txtsearch.Font = new Font("Ubuntu Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsearch.ForeColor = SystemColors.AppWorkspace;
            txtsearch.Location = new Point(245, 106);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(317, 32);
            txtsearch.TabIndex = 3;
            txtsearch.Text = "";
            txtsearch.WordWrap = false;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(34, 36);
            button3.Name = "button3";
            button3.Size = new Size(32, 24);
            button3.TabIndex = 29;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Membersview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 523);
            Controls.Add(button3);
            Controls.Add(txtsearch);
            Controls.Add(btnReset);
            Controls.Add(btnsearch);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "Membersview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Membersview";
            Load += Membersview_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnsearch;
        private Button btnReset;
        private RichTextBox txtsearch;
        private Button button3;
    }
}
