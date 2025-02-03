using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FittrackMS
{
    public partial class Staffview : Form
    {
        private string connectionString = "server=localhost;database=fittrackmaindb;uid=root;pwd=newpassword;";

        public Staffview()
        {
            InitializeComponent();
            LoadStaffData();

        }

        private void LoadStaffData(string searchFilter = "")
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string query;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    if (string.IsNullOrEmpty(searchFilter))
                    {
                        // Default query to load all staff in descending order by DateRegistered
                        query = "SELECT StaffID, NameWithInitials, NICNumber, DateRegistered, StaffCategory, Gender FROM staff ORDER BY staffID DESC";
                    }
                    else if (int.TryParse(searchFilter, out int staffId))
                    {
                        // Search by numeric StaffID
                        query = "SELECT StaffID, NameWithInitials, NICNumber, DateRegistered, StaffCategory, Gender FROM staff WHERE StaffID = @staffId ORDER BY DateRegistered DESC";
                        cmd.Parameters.AddWithValue("@staffId", staffId);
                    }
                    else
                    {
                        // Search by NameWithInitials pattern
                        query = "SELECT StaffID, NameWithInitials, NICNumber, DateRegistered, StaffCategory, Gender FROM staff WHERE NameWithInitials LIKE @namePattern ORDER BY DateRegistered DESC";
                        cmd.Parameters.AddWithValue("@namePattern", "%" + searchFilter + "%");
                    }

                    cmd.CommandText = query;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["StaffID"].DisplayIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading staff data: {ex.Message}");
                }
            }
        }

        // Search button click event
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string searchText = richTextBox1.Text.Trim();
            LoadStaffData(searchText);
        }


        // Reset button click event
        private void Resetbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            LoadStaffData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatestaff form2 = new Updatestaff();
            form2.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard form2 = new Dashboard();
            form2.ShowDialog();
            this.Show();
        }

        private void Staffview_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
