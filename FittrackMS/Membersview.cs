using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace FittrackMS
{
    public partial class Membersview : Form
    {
        string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public Membersview()
        {
            InitializeComponent();
        }

        private void Membersview_Load(object sender, EventArgs e)
        {
            LoadMembersData("");

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.AliceBlue;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.RowHeadersVisible = false;
        }

        private void LoadMembersData(string searchQuery)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT UserID, NICNumber, NameWithInitials, ContactNumber, Gender, FeesMade, MembershipType, DateCreated, Address, Height, Weight " +
                                   "FROM Users WHERE NICNumber LIKE @search OR NameWithInitials LIKE @search ORDER BY DateCreated DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchText = txtsearch.Text.Trim();
            LoadMembersData(searchText);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            LoadMembersData("");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_member_details form2 = new Update_member_details();
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

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtsearch.Clear();
            LoadMembersData("");
        }
    }
}
