using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FittrackMS
{
    public partial class PaymentManager : Form
    {
        // Database connection string
        string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public PaymentManager()
        {
            InitializeComponent();
            LoadPayments();
            CustomizeDataGridView();
        }

        // Calculate next payment due date based on the fee type
        private DateTime CalculateNextPaymentDate(DateTime lastPaymentDate, string feeType)
        {
            switch (feeType)
            {
                case "Monthly":
                    return lastPaymentDate.AddMonths(1);
                case "Quarter-wise":
                    return lastPaymentDate.AddMonths(3);
                case "Semester-wise":
                    return lastPaymentDate.AddMonths(6);
                case "Annually":
                    return lastPaymentDate.AddYears(1);
                default:
                    throw new Exception("Unknown fee type");
            }
        }

        // Add payment to the database after validation
        private void BtnAddpyment_Click(object sender, EventArgs e)
        {
            string memberId = textSearch.Text;
            string paymentDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string amount = txtAmount.Text;

            if (string.IsNullOrEmpty(memberId) || string.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Please enter the required details.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Retrieve last payment date and fee type for the user
                string query = "SELECT PaymentDate, FeesMade FROM paymentTable p " +
                               "JOIN users u ON p.UserID = u.UserID WHERE p.UserID = @UserID " +
                               "ORDER BY p.PaymentDate DESC LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", memberId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DateTime lastPaymentDate = Convert.ToDateTime(reader["PaymentDate"]);
                    string feeType = reader["FeesMade"].ToString();
                    DateTime nextPaymentDate = CalculateNextPaymentDate(lastPaymentDate, feeType);

                    if (dateTimePicker1.Value < nextPaymentDate)
                    {
                        MessageBox.Show($"You are trying to pay too early. Your next payment date is {nextPaymentDate:yyyy-MM-dd}.");
                        return;
                    }
                }

                reader.Close();

                // Insert the payment record if validation passes
                string insertQuery = "INSERT INTO paymentTable (UserID, PaymentDate, Amount) VALUES (@UserID, @PaymentDate, @Amount)";
                cmd = new MySqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@UserID", memberId);
                cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                cmd.Parameters.AddWithValue("@Amount", amount);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment added successfully!");

                // Reload payment data in the DataGridView
                LoadPayments();
            }
        }

        private void LoadPayments()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT PaymentID, UserID, PaymentDate, Amount FROM paymentTable ORDER BY PaymentDate DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    

                    dataGridView1.DataSource = dt;

                    
                    dataGridView1.Columns["PaymentID"].HeaderText = "Payment ID";
                    dataGridView1.Columns["UserID"].HeaderText = "User ID";
                    dataGridView1.Columns["PaymentDate"].HeaderText = "Payment Date";
                    dataGridView1.Columns["Amount"].HeaderText = "Amount";

     
                    dataGridView1.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading payments: " + ex.Message);
            }
        }



        // Reset button to clear all fields
        private void BtnReset_Click(object sender, EventArgs e)
        {

        }

        // Search user by UserID or NameWithInitials
        private void button1_Click_1(object sender, EventArgs e)
        {
            string searchText = textSearch.Text;

            string query = "SELECT NameWithInitials, NICNumber, FeesMade FROM users WHERE UserID = @searchText OR NameWithInitials = @searchText";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchText", searchText);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblname.Text = reader["NameWithInitials"].ToString();
                    lblNIC.Text = reader["NICNumber"].ToString();
                    lblfeetype.Text = reader["FeesMade"].ToString();
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
        }

        // Search payments for a specific user within an optional date range
        private void btnsearchrecord_Click(object sender, EventArgs e)
        {
            string userId = textsearch2.Text;

            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please enter the UserID to search payments.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT PaymentID, UserID, PaymentDate, Amount FROM paymentTable ORDER BY PaymentDate DESC";

                if (datestart.Value != DateTime.MinValue && dateend.Value != DateTime.MinValue)
                {
                    query += "AND p.PaymentDate BETWEEN @FromDate AND @ToDate ";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                if (datestart.Value != DateTime.MinValue && dateend.Value != DateTime.MinValue)
                {
                    cmd.Parameters.AddWithValue("@FromDate", datestart.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@ToDate", dateend.Value.ToString("yyyy-MM-dd"));
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No previous payments found for this user.");
                    dataGridView1.DataSource = null;
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

        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            textSearch.Clear();
            lblname.Text = "";
            lblNIC.Text = "";
            lblfeetype.Text = "";
            txtAmount.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }































        private void CustomizeDataGridView()
        {
            dataGridView1.Size = new Size(635, 244);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Header styling
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 30;

            // Row styling
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.RowTemplate.Height = 25;

            // Specific column adjustments
            dataGridView1.Columns["PaymentID"].FillWeight = 20;
            dataGridView1.Columns["UserID"].FillWeight = 25;
            dataGridView1.Columns["PaymentDate"].FillWeight = 35;
            dataGridView1.Columns["Amount"].FillWeight = 20;
            dataGridView1.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["PaymentDate"].DefaultCellStyle.Format = "yyyy-MM-dd";

            // Border and grid line styling
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.LightGray;
        }

        
    }
}
