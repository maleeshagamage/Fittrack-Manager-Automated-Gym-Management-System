using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace FittrackMS
{
    public partial class Staffidcard : Form
    {
        public Staffidcard()
        {
            InitializeComponent();
        }

        // Set details for the Staff ID Card
        public void SetStaffDetails(string name, string nicNumber, string staffId, string staffCategory, byte[] nicImage)
        {
            lblname.Text = name;
            lblstaffid.Text = staffId;
            lblstaffcategory.Text = staffCategory;

            if (nicImage != null)
            {
                using (MemoryStream ms = new MemoryStream(nicImage))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        // Print the Staff ID card
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            previewDialog.ShowDialog();
        }

        // Capture and print the ID card view
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
