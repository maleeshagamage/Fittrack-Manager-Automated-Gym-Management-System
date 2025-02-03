using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FittrackMS
{
    public partial class StaffAttendance : Form
    {
        private string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public StaffAttendance()
        {
            InitializeComponent();
            LoadAttendanceData(); 
        }
        private void Btnsearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtsearch.Text.Trim();

            // SQL query to search by StaffID or NICNumber
            string query = "SELECT StaffID, NameWithInitials, ShiftStart, ShiftEnd FROM Staff WHERE StaffID = @StaffID ";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", searchValue);


                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If a result is found
                            {
                                Staff_ID.Text = reader["StaffID"].ToString();
                                Member_Name.Text = reader["NameWithInitials"].ToString();
                                Shift_start.Text = reader["ShiftStart"].ToString();
                                Shift_End.Text = reader["ShiftEnd"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No staff found with the given ID.", "Search Result");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void BtnCheckin_Click(object sender, EventArgs e)
        {
            string staffID = Staff_ID.Text.Trim();

            if (string.IsNullOrEmpty(staffID))
            {
                MessageBox.Show("Please enter a staff member ID.", "Error");
                return;
            }

            DateTime checkInTime = DateTime.Now;

            // SQL query to get the staff shift start time
            string shiftQuery = "SELECT ShiftStart FROM Staff WHERE StaffID = @StaffID";
            TimeSpan shiftStartTime;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Retrieve the staff member's shift start time
                    using (MySqlCommand cmd = new MySqlCommand(shiftQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffID);
                        var shiftTimeResult = cmd.ExecuteScalar();

                        if (shiftTimeResult != null)
                        {
                            shiftStartTime = TimeSpan.Parse(shiftTimeResult.ToString());

                            // Compare current time with the shift start time
                            if (checkInTime.TimeOfDay > shiftStartTime)
                            {
                                // Staff is late, prompt for lateness reason
                                string latenessReason = PromptForLatenessReason();

                                if (string.IsNullOrEmpty(latenessReason))
                                {
                                    MessageBox.Show("Check-in cancelled. A reason for lateness is required.", "Error");
                                    return; // Exit if no reason is provided
                                }

                                // Insert attendance with lateness reason
                                InsertAttendance(staffID, checkInTime, latenessReason);
                            }
                            else
                            {
                                // On-time check-in, no lateness reason needed
                                InsertAttendance(staffID, checkInTime, null);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Shift start time not found for this staff member.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        // Function to insert attendance into the database
        private void InsertAttendance(string staffID, DateTime checkInTime, string latenessReason)
        {
            
            string checkQuery = "SELECT COUNT(*) FROM StaffAttendance WHERE StaffID = @StaffID AND CheckOutTime IS NULL AND Status = 'Checked-in'";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Check if there's already an active check-in without a checkout 
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@StaffID", staffID);
                        int existingCheckInCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingCheckInCount > 0)
                        {
                            MessageBox.Show("The staff member is already checked in and has not checked out yet.", "Check-in Error");
                            return;
                        }
                    }

                    // If no active check-in is found, proceed with inserting the new check-in record
                    string insertQuery = "INSERT INTO StaffAttendance (StaffID, CheckInTime, LatenessReason, Status) " +
                                         "VALUES (@StaffID, @CheckInTime, @LatenessReason, 'Checked-in')";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@StaffID", staffID);
                        insertCmd.Parameters.AddWithValue("@CheckInTime", checkInTime);
                        insertCmd.Parameters.AddWithValue("@LatenessReason", latenessReason ?? (object)DBNull.Value); 

                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Staff check-in recorded successfully.", "Check-in Success");
                        LoadAttendanceData(); // Refresh the grid 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        // Function to prompt for lateness reason
        private string PromptForLatenessReason()
        {
            return Microsoft.VisualBasic.Interaction.InputBox(
                "You are checking in late. Please provide a reason for lateness:",
                "Lateness Reason", "");
        }

     
        private void LoadAttendanceData()
        {
            string query = "SELECT StaffID, CheckInTime, CheckOutTime, LatenessReason, EarlyDepartureReason FROM StaffAttendance ORDER BY CheckInTime DESC";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            staffAttendanceGrid.DataSource = dataTable;

                            // Optional: Format the grid for better UI
                            FormatGrid();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void FormatGrid()
        {
            // Adjust headers
            staffAttendanceGrid.Columns["StaffID"].HeaderText = "Staff ID";
            staffAttendanceGrid.Columns["CheckInTime"].HeaderText = "Check-In Time";
            staffAttendanceGrid.Columns["CheckOutTime"].HeaderText = "Check-Out Time";
            staffAttendanceGrid.Columns["LatenessReason"].HeaderText = "Reason for latency";

            // Set column width
            staffAttendanceGrid.Columns["StaffID"].Width = 100;
            staffAttendanceGrid.Columns["CheckInTime"].Width = 150;
            staffAttendanceGrid.Columns["CheckOutTime"].Width = 150;
            staffAttendanceGrid.Columns["LatenessReason"].Width = 200;

            // Set grid style (optional)
            staffAttendanceGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            staffAttendanceGrid.DefaultCellStyle.Font = new Font("Arial", 10);
            staffAttendanceGrid.RowHeadersVisible = false;
            staffAttendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Button for staff check-out
        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            string staffID = Staff_ID.Text.Trim();

            if (string.IsNullOrEmpty(staffID))
            {
                MessageBox.Show("Please search for a staff member first.", "Error");
                return;
            }

            DateTime checkOutTime = DateTime.Now;

            // SQL query to get the staff shift end time
            string shiftQuery = "SELECT ShiftEnd FROM Staff WHERE StaffID = @StaffID";
            TimeSpan shiftEndTime;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Retrieve the staff member's shift end time
                    using (MySqlCommand cmd = new MySqlCommand(shiftQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffID);
                        var shiftTimeResult = cmd.ExecuteScalar();

                        if (shiftTimeResult != null)
                        {
                            shiftEndTime = TimeSpan.Parse(shiftTimeResult.ToString());

                            string earlyDepartureReason = null;
                            if (checkOutTime.TimeOfDay < shiftEndTime)
                            {
                                // Prompt for early departure reason
                                earlyDepartureReason = PromptForEarlyDepartureReason();

                                if (string.IsNullOrEmpty(earlyDepartureReason))
                                {
                                    MessageBox.Show("Checkout cancelled. A reason for early departure is required.", "Error");
                                    return; // Exit if no reason is provided
                                }
                            }

                            // Update the attendance record with the checkout time and any early departure reason
                            UpdateCheckout(staffID, checkOutTime, earlyDepartureReason);
                        }
                        else
                        {
                            MessageBox.Show("Shift end time not found for this staff member.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void UpdateCheckout(string staffID, DateTime checkOutTime, string earlyDepartureReason)
        {
            // SQL query to update the checkout time in the StaffAttendance table
            string updateQuery = "UPDATE StaffAttendance SET CheckOutTime = @CheckOutTime, EarlyDepartureReason = @EarlyDepartureReason, Status = 'Checked-out' " +
                                 "WHERE StaffID = @StaffID AND CheckOutTime IS NULL";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@CheckOutTime", checkOutTime);
                        cmd.Parameters.AddWithValue("@EarlyDepartureReason", earlyDepartureReason ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@StaffID", staffID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff checkout recorded successfully.", "Checkout Success");
                            LoadAttendanceData(); // Refresh the grid after checkout
                        }
                        else
                        {
                            MessageBox.Show("No active check-in record found for this staff member.", "Checkout Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        // Function to prompt for early departure reason
        private string PromptForEarlyDepartureReason()
        {
            return Microsoft.VisualBasic.Interaction.InputBox(
                "You are checking out early. Please provide a reason for early departure:",
                "Early Departure Reason", "");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dashboard form2 = new Dashboard();
            form2.ShowDialog();
            this.Show();
        }
    }
}
