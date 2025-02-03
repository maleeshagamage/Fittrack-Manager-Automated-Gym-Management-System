using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FittrackMS
{
    public partial class InventoryView : Form
    {
        private string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public InventoryView()
        {
            InitializeComponent();
            LoadInventoryData();
            CustomizeDataGridView();
        }

        private void LoadInventoryData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ItemID, ItemName, Category, Quantity, DateAdded, LastUpdated, Status, Supplier, CostPerUnit FROM inventory";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable inventoryTable = new DataTable();
                    adapter.Fill(inventoryTable);

                    // Binding data to the DataGridView
                    InventorydGV.DataSource = inventoryTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void CustomizeDataGridView()
        {
            // Customize header styles
            InventorydGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            InventorydGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            InventorydGV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Alternating row styles
            InventorydGV.RowsDefaultCellStyle.BackColor = Color.LightGray;
            InventorydGV.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Auto-size columns
            InventorydGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Format CostPerUnit column
            InventorydGV.Columns["CostPerUnit"].DefaultCellStyle.Format = "C"; // Currency format

            // Subscribe to CellValueChanged event
            InventorydGV.CellValueChanged += InventorydGV_CellValueChanged;
        }

        private void InventorydGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                // Get column name and new value
                string columnName = InventorydGV.Columns[e.ColumnIndex].Name;
                var newValue = InventorydGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var itemId = InventorydGV.Rows[e.RowIndex].Cells["ItemID"].Value; // Primary key

                // Allow updates only on specific columns
                if (columnName == "Quantity" || columnName == "Status" || columnName == "Supplier" || columnName == "CostPerUnit")
                {
                    UpdateInventory(itemId, columnName, newValue);
                }
                else
                {
                    MessageBox.Show($"Column '{columnName}' is not editable.");
                }
            }
        }

        private void UpdateInventory(object itemId, string columnName, object newValue)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Update the specified column and set LastUpdated to the current timestamp
                    string query = $"UPDATE inventory SET {columnName} = @newValue, LastUpdated = @lastUpdated WHERE ItemID = @itemId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@newValue", newValue);
                        cmd.Parameters.AddWithValue("@lastUpdated", DateTime.Now);
                        cmd.Parameters.AddWithValue("@itemId", itemId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inventory updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the database: " + ex.Message);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
           
        }

        private void InventorydGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Add handling for cell content clicks if necessary.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard form2 = new Dashboard();
            form2.ShowDialog();
            this.Show();
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            string searchTerm = textSearch.Text; // Get the search term from the text box

            // Use a SQL query with a wildcard search on the ItemName column
            string query = "SELECT * FROM inventory WHERE ItemName LIKE @ItemName";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add wildcard characters (%) before and after the search term
                    cmd.Parameters.AddWithValue("@ItemName", "%" + searchTerm + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable inventoryTable = new DataTable();
                    adapter.Fill(inventoryTable);

                    // Bind filtered data to the DataGridView
                    InventorydGV.DataSource = inventoryTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            textSearch.Clear(); // Clear the search textbox
            LoadInventoryData(); // Reload original data
        }
    }
}
