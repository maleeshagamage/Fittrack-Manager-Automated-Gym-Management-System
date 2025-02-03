using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace FittrackMS
{
    public partial class GymStaffRegistration : Form
    {
        string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public GymStaffRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve input values
            string nameWithInitials = textname.Text.Trim();
            string nicNumber = textNIC.Text.Trim();
            string address = textAddress.Text.Trim();
            string contactNumber = textcontctNo.Text.Trim();
            string gender = male.Checked ? "Male" : female.Checked ? "Female" : string.Empty;
            string staffCategory = comboBox1.SelectedItem?.ToString() ?? string.Empty;
            string shiftStart = shiftstartcmb.SelectedItem?.ToString() ?? string.Empty;
            string shiftEnd = shiftendcmb.SelectedItem?.ToString() ?? string.Empty;
            bool agreedToTerms = checkBox1.Checked;

            // Validate inputs
            if (string.IsNullOrEmpty(nameWithInitials) || string.IsNullOrEmpty(nicNumber) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(contactNumber) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(staffCategory) ||
                string.IsNullOrEmpty(shiftStart) || string.IsNullOrEmpty(shiftEnd))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!agreedToTerms)
            {
                MessageBox.Show("You must agree to the terms and conditions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Handling NIC image upload
            byte[] nicImage = null;
            if (pictureBox1.Image != null)
            {
                try
                {
                    using (var ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        nicImage = ms.ToArray();
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to process NIC image. Please upload a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please upload a NIC image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check for duplicate NIC number
                    string checkQuery = "SELECT COUNT(*) FROM staff WHERE NICNumber = @NICNumber";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@NICNumber", nicNumber);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("This NIC Number is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Define a shared DateTime for consistency
                    DateTime currentDateTime = DateTime.Now;

                    // Insert staff data
                    string insertStaffQuery = "INSERT INTO staff (NameWithInitials, NICNumber, Address, ContactNumber, Gender, StaffCategory, ShiftStart, ShiftEnd, NICImage, DateRegistered) " +
                                               "VALUES (@NameWithInitials, @NICNumber, @Address, @ContactNumber, @Gender, @StaffCategory, @ShiftStart, @ShiftEnd, @NICImage, @DateRegistered)";
                    long staffId;
                    using (MySqlCommand insertStaffCmd = new MySqlCommand(insertStaffQuery, conn))
                    {
                        insertStaffCmd.Parameters.AddWithValue("@NameWithInitials", nameWithInitials);
                        insertStaffCmd.Parameters.AddWithValue("@NICNumber", nicNumber);
                        insertStaffCmd.Parameters.AddWithValue("@Address", address);
                        insertStaffCmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        insertStaffCmd.Parameters.AddWithValue("@Gender", gender);
                        insertStaffCmd.Parameters.AddWithValue("@StaffCategory", staffCategory);
                        insertStaffCmd.Parameters.AddWithValue("@ShiftStart", DateTime.Parse(shiftStart).TimeOfDay);
                        insertStaffCmd.Parameters.AddWithValue("@ShiftEnd", DateTime.Parse(shiftEnd).TimeOfDay);
                        insertStaffCmd.Parameters.AddWithValue("@NICImage", nicImage);
                        insertStaffCmd.Parameters.AddWithValue("@DateRegistered", currentDateTime);
                        insertStaffCmd.ExecuteNonQuery();

                        // Get the last inserted staff ID
                        staffId = Convert.ToInt64(new MySqlCommand("SELECT LAST_INSERT_ID();", conn).ExecuteScalar());
                    }

                    // Generate and hash the initial password
                    string initialPassword = staffCategory switch
                    {
                        "Coach" => "Coach123",
                        "Admin" => "Admin123",
                        "Owner" => "Owner123",
                        _ => throw new Exception("Invalid role selected.")
                    };
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(initialPassword);

                    // Insert system user data
                    string insertUserQuery = "INSERT INTO system_users (StaffID, PasswordHash, Role, DateCreated) " +
                                             "VALUES (@StaffID, @PasswordHash, @Role, @DateCreated)";
                    using (MySqlCommand insertUserCmd = new MySqlCommand(insertUserQuery, conn))
                    {
                        insertUserCmd.Parameters.AddWithValue("@StaffID", staffId);
                        insertUserCmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                        insertUserCmd.Parameters.AddWithValue("@Role", staffCategory);
                        insertUserCmd.Parameters.AddWithValue("@DateCreated", currentDateTime);
                        insertUserCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Staff registered successfully with initial login credentials.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Staffidcard staffIdCardForm = new Staffidcard();
                    staffIdCardForm.SetStaffDetails(nameWithInitials, nicNumber, staffId.ToString(), staffCategory, nicImage);
                    staffIdCardForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            textname.Clear();
            textNIC.Clear();
            textAddress.Clear();
            textcontctNo.Clear();
            male.Checked = false;
            female.Checked = false;
            pictureBox1.Image = null;
            checkBox1.Checked = false;
            comboBox1.SelectedIndex = -1;
            shiftstartcmb.SelectedIndex = -1;
            shiftendcmb.SelectedIndex = -1;
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard form2 = new Dashboard();
            form2.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatestaff form2 = new Updatestaff();
            form2.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
