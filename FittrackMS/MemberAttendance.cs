using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FittrackMS
{
    public partial class MemberAttendance : Form
    {
        private string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public MemberAttendance()
        {
            InitializeComponent();
            LoadAttendanceData(); // Load attendance data when form initializes
            CustomizeDataGridView(); // Customize the DataGridView appearance
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the search input from the textbox (either Member ID or NIC)
            string searchValue = txtsearch.Text.Trim();

            // SQL query to search by MemberID or NICNumber
            string query = "SELECT UserID, NameWithInitials, NICNumber FROM users WHERE UserID = @UserID OR NICNumber = @NICNumber";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", searchValue);
                        cmd.Parameters.AddWithValue("@NICNumber", searchValue);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If a result is found
                            {
                                Member_ID.Text = reader["UserID"].ToString();       // Member_ID
                                Member_Name.Text = reader["NameWithInitials"].ToString(); // Member_Name
                                Member_NIC.Text = reader["NICNumber"].ToString();    // Member_NIC
                            }
                            else
                            {
                                MessageBox.Show("No member found with the given ID or NIC.", "Search Result");
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
            string memberID = Member_ID.Text.Trim();

            if (string.IsNullOrEmpty(memberID))
            {
                MessageBox.Show("Please search for a member first.", "Error");
                return;
            }

            DateTime checkInTime = DateTime.Now;
            DateTime currentDate = DateTime.Today;

            // Insert query for check-in
            string query = "INSERT INTO Attendance (MemberID, CheckInTime, CheckOutTime, Status, Date) " +
                           "VALUES (@MemberID, @CheckInTime, NULL, 'Checked-in', @Date)";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@CheckInTime", checkInTime);
                        cmd.Parameters.AddWithValue("@Date", currentDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member checked in successfully.", "Check-in Success");
                            LoadAttendanceData(); // Refresh the DataGridView to show the updated attendance
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
        }

        private void LoadAttendanceData()
        {
            string query = "SELECT MemberID, CheckInTime, CheckOutTime, Status, Date FROM Attendance";

            DataTable attendanceData = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(attendanceData);
                        }
                    }

                    AttendanceGrid.DataSource = attendanceData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading attendance data: " + ex.Message, "Error");
                }
            }
        }

        private void CustomizeDataGridView()
        {
            // Make the DataGridView visually appealing
            AttendanceGrid.BorderStyle = BorderStyle.None;
            AttendanceGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            AttendanceGrid.DefaultCellStyle.ForeColor = Color.Black;
            AttendanceGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255);
            AttendanceGrid.DefaultCellStyle.SelectionForeColor = Color.White;

            // Add column headers customization
            AttendanceGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 102, 204);
            AttendanceGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            AttendanceGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            AttendanceGrid.EnableHeadersVisualStyles = false;

            // Adjust the column widths
            AttendanceGrid.Columns["MemberID"].Width = 100;
            AttendanceGrid.Columns["CheckInTime"].Width = 150;
            AttendanceGrid.Columns["CheckOutTime"].Width = 150;
            AttendanceGrid.Columns["Status"].Width = 100;
            AttendanceGrid.Columns["Date"].Width = 100;

            // Disable cell editing
            AttendanceGrid.ReadOnly = true;
        }

        private void BtnCheckout_Click_1(object sender, EventArgs e)
        {
            string memberID = Member_ID.Text.Trim();

            if (string.IsNullOrEmpty(memberID))
            {
                MessageBox.Show("Please search for a member first.", "Error");
                return;
            }

            DateTime checkOutTime = DateTime.Now;

            // Update query for check-out
            string query = "UPDATE Attendance SET CheckOutTime = @CheckOutTime, Status = 'Checked-out' " +
                           "WHERE MemberID = @MemberID AND Date = CURDATE()";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@CheckOutTime", checkOutTime);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Member checked out successfully.", "Check-out Success");
                            LoadAttendanceData(); // Refresh the DataGridView to show updated attendance
                        }
                        else
                        {
                            MessageBox.Show("No check-in record found for today.", "Check-out Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
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
    }

}
