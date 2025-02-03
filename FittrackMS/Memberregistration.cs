using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FittrackMS
{
    public partial class Memberregistration : Form
    {
        private string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public Memberregistration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!ValidateFields())
            {
                return;
            }

            
            string nameWithInitials = txtNameWithInitials.Text;
            string nicNumber = txtNICNumber.Text;
            string contactNumber = txtContactNumber.Text;
            string address = txtAddress.Text;
            string gender = rbtnMale.Checked ? "Male" : "Female";
            decimal height = decimal.Parse(txtHeight.Text);
            decimal weight = decimal.Parse(txtWeight.Text);
            string membershipType = GetSelectedMembershipType();
            string feesMade = cmbFeesMade.SelectedItem.ToString();
            byte[] nicImage = GetImageBytes(NICImagePath.Image);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if NIC already exists
                    if (NicExists(conn, nicNumber))
                    {
                        MessageBox.Show("This NIC number already exists. Please use a different NIC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert new user data and retrieve the inserted ID
                    string query = "INSERT INTO users (NameWithInitials, NICNumber, Address, ContactNumber, Gender, Height, Weight, MembershipType, FeesMade, NICImage, DateCreated) " +
                                   "VALUES (@NameWithInitials, @NICNumber, @Address, @ContactNumber, @Gender, @Height, @Weight, @MembershipType, @FeesMade, @NICImage, @DateCreated); " +
                                   "SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NameWithInitials", nameWithInitials);
                        cmd.Parameters.AddWithValue("@NICNumber", nicNumber);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Height", height);
                        cmd.Parameters.AddWithValue("@Weight", weight);
                        cmd.Parameters.AddWithValue("@MembershipType", membershipType);
                        cmd.Parameters.AddWithValue("@FeesMade", feesMade);
                        cmd.Parameters.AddWithValue("@NICImage", nicImage);
                        cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);

                        // Execute the command and get the user ID
                        var userId = Convert.ToInt32(cmd.ExecuteScalar());

                        MessageBox.Show("Member registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Show the ID Card Form with member details after registration
                        MemberIDCard idCardForm = new MemberIDCard();
                        idCardForm.SetMemberDetails(nameWithInitials, nicNumber, userId.ToString(), nicImage);
                        idCardForm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtNameWithInitials.Text) ||
                string.IsNullOrWhiteSpace(txtNICNumber.Text) ||
                string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtHeight.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                (rbtnMale.Checked == false && rbtnFemale.Checked == false) ||
                cmbFeesMade.SelectedItem == null ||
                NICImagePath.Image == null)
            {
                MessageBox.Show("Please fill in all fields and upload the NIC image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Ensure numeric inputs are valid
            if (!decimal.TryParse(txtHeight.Text, out _) || !decimal.TryParse(txtWeight.Text, out _))
            {
                MessageBox.Show("Height and Weight must be valid decimal numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Check if NIC already exists in the database
        private bool NicExists(MySqlConnection conn, string nicNumber)
        {
            string query = "SELECT COUNT(*) FROM users WHERE NICNumber = @NICNumber";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NICNumber", nicNumber);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // Get selected membership type
        private string GetSelectedMembershipType()
        {
            List<string> membershipTypes = new List<string>();
            if (chkGym.Checked) membershipTypes.Add("Gym");
            if (chkCardio.Checked) membershipTypes.Add("Cardio");
            if (chkPersonalTrainer.Checked) membershipTypes.Add("Personal Trainer");
            return string.Join(", ", membershipTypes);
        }

        // Convert image to byte array
        private byte[] GetImageBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    NICImagePath.Image = Image.FromFile(filePath);
                    NICImagePath.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNameWithInitials.Clear();
            txtNICNumber.Clear();
            txtContactNumber.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            txtAddress.Clear();
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            chkGym.Checked = false;
            chkCardio.Checked = false;
            chkPersonalTrainer.Checked = false;
            cmbFeesMade.SelectedIndex = -1;
            NICImagePath.Image = null;
            txtNameWithInitials.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard form2 = new Dashboard();
            form2.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_member_details form2 = new Update_member_details();
            form2.ShowDialog();
            this.Show();
        }
    }
}
