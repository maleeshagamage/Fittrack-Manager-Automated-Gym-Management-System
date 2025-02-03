using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace FittrackMS
{
    public partial class MemberIDCard : Form
    {
        public MemberIDCard()
        {
            InitializeComponent();
        }

        // Method to set ID card details
        public void SetMemberDetails(string nameWithInitials, string nicNumber, string userid, byte[] nicImage)
        {
            lblname.Text = nameWithInitials;
            lblNIC.Text = nicNumber;
            lbluserid.Text = userid;

         
        }

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

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
