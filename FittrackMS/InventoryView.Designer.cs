namespace FittrackMS
{
    partial class InventoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryView));
            InventorydGV = new DataGridView();
            BtnSearch = new Button();
            BtnReset = new Button();
            textSearch = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)InventorydGV).BeginInit();
            SuspendLayout();
            // 
            // InventorydGV
            // 
            InventorydGV.BackgroundColor = SystemColors.ButtonHighlight;
            InventorydGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventorydGV.Location = new Point(78, 207);
            InventorydGV.Name = "InventorydGV";
            InventorydGV.Size = new Size(766, 256);
            InventorydGV.TabIndex = 0;
            InventorydGV.CellContentClick += InventorydGV_CellContentClick;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.PaleTurquoise;
            BtnSearch.BackgroundImageLayout = ImageLayout.Center;
            BtnSearch.Location = new Point(621, 149);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(68, 33);
            BtnSearch.TabIndex = 1;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearch_Click_1;
            // 
            // BtnReset
            // 
            BtnReset.BackColor = Color.Pink;
            BtnReset.Location = new Point(695, 149);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(75, 32);
            BtnReset.TabIndex = 2;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = false;
            BtnReset.Click += BtnReset_Click_1;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(317, 155);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(298, 23);
            textSearch.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(35, 34);
            button3.Name = "button3";
            button3.Size = new Size(32, 24);
            button3.TabIndex = 21;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // InventoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(913, 518);
            Controls.Add(button3);
            Controls.Add(textSearch);
            Controls.Add(BtnReset);
            Controls.Add(BtnSearch);
            Controls.Add(InventorydGV);
            DoubleBuffered = true;
            Name = "InventoryView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryView";
            ((System.ComponentModel.ISupportInitialize)InventorydGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView InventorydGV;
        private Button BtnSearch;
        private Button BtnReset;
        private TextBox textSearch;
        private Button button3;
    }
}