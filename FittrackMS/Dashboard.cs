using System;
using MySql.Data.MySqlClient; // For SQL interactions
using System.Windows.Forms;
using System.Linq;

namespace FittrackMS
{
    public partial class Dashboard : Form
    {
        private readonly string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonVisibility();
            DisplayWelcomeMessage();
            DisplayUserInformation();
        }

        private void SetButtonVisibility()
        {
            if (UserSession.Role == "Coach")
            {
                // Show only specific buttons for coaches
                button7.Visible = true;
                button9.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                Logout.Visible = true;
                lableusertype.Visible = true;
                buttonexit.Visible = true;

                // Hide all other buttons
                lableusername.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button8.Visible = false;
            }
            else
            {
                // If not a coach, show all buttons (for Admin/Owner)
                buttonexit.Visible = true;
                lableusername.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                Logout.Visible = true;
                lableusertype.Visible = false;
            }
        }

        private void DisplayUserInformation()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to retrieve NameWithInitials and Role
                    string query = @"
                        SELECT s.NameWithInitials, su.Role 
                        FROM staff s
                        INNER JOIN system_users su ON s.StaffID = su.StaffID
                        WHERE su.UserID = @UserID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserSession.UserID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                lableusername.Text = $"{reader["NameWithInitials"]}";
                                lableusertype.Text = $" {reader["Role"]}";
                                lableusername.Visible = true;
                                lableusertype.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("User information could not be retrieved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving user information:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Memberregistration form2 = new Memberregistration();
            form2.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GymStaffRegistration form2 = new GymStaffRegistration();
            form2.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipmentreg form2 = new Equipmentreg();
            form2.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staffview form2 = new Staffview();
            form2.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentManager form2 = new PaymentManager();
            form2.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Membersview form2 = new Membersview();
            form2.ShowDialog();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberAttendance form2 = new MemberAttendance();
            form2.ShowDialog();
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffAttendance form2 = new StaffAttendance();
            form2.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Confirmation dialog for logout
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?",
                                                          "Confirm Logout",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                
                ClearUserSession();

                Application.Restart();
                Environment.Exit(0); 
            }
            else
            {
                MessageBox.Show("You chose to stay logged in.");
            }
        }
        private void DisplayWelcomeMessage()
        {
            
            labalewelcomemsg.Text = $"Staff ID : {UserSession.StaffID}";
            labalewelcomemsg.Visible = true;
        }
        private void ClearUserSession()
        {
            UserSession.ClearSession();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PasswordUpdate form2 = new PasswordUpdate();
            form2.ShowDialog();
            this.Show();
        }
    }
}
