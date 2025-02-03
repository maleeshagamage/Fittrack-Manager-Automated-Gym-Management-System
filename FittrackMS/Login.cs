using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace FittrackMS
{
    public partial class Login : Form
    {
        private string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string staffId = txtuserid.Text.Trim();
            string password = txtpassword.Text;
            string role = cmbusertype.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(staffId) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please enter all fields (Staff ID, Password, and Role).");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT UserID, PasswordHash, Role FROM system_users WHERE StaffID = @StaffID AND Role = @Role";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffId);
                        cmd.Parameters.AddWithValue("@Role", role);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPasswordHash = reader.GetString("PasswordHash");

                                bool isPasswordMatch = BCrypt.Net.BCrypt.Verify(password, storedPasswordHash);

                                if (isPasswordMatch)
                                {
                                 
                                    UserSession.UserID = reader.GetInt32("UserID");
                                    UserSession.StaffID = int.Parse(staffId);
                                    UserSession.Role = role;
                                  
                                    MessageBox.Show("Login successful!");
                                    this.Hide();
                                    var dashboard = new Dashboard();
                                    dashboard.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password. Please try again.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found or role mismatch. Please check your credentials.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}