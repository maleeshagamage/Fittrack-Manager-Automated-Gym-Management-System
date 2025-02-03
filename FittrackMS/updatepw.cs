using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FittrackMS
{
    public partial class PasswordUpdate : Form
    {
        private string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public PasswordUpdate()
        {
            InitializeComponent();
            LoadStaffID();
        }

        private void LoadStaffID()
        {
            // Assuming UserSession.StaffID holds the logged-in staff ID
            labelStaffID.Text = UserSession.StaffID.ToString();
        }

        private void BTNChangepw_Click(object sender, EventArgs e)
        {
            string currentPassword = currentpassword.Text;
            string newPassword = textBox2.Text;
            string confirmPassword = textBox3.Text;

            // Check if the new passwords match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation password do not match.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Verify current password
                    MySqlCommand cmd = new MySqlCommand("SELECT PasswordHash FROM system_users WHERE StaffID = @StaffID", conn);
                    cmd.Parameters.AddWithValue("@StaffID", UserSession.StaffID);
                    string storedPasswordHash = cmd.ExecuteScalar()?.ToString();

                    if (storedPasswordHash == null || !BCrypt.Net.BCrypt.Verify(currentPassword, storedPasswordHash))
                    {
                        MessageBox.Show("Current password is incorrect.");
                        return;
                    }

                    // Hash the new password
                    string newPasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

                    // Update the password in the database
                    MySqlCommand updateCmd = new MySqlCommand("UPDATE system_users SET PasswordHash = @PasswordHash WHERE StaffID = @StaffID", conn);
                    updateCmd.Parameters.AddWithValue("@PasswordHash", newPasswordHash);
                    updateCmd.Parameters.AddWithValue("@StaffID", UserSession.StaffID);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password update failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
