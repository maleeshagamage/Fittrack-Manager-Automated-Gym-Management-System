using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FittrackMS
{
    public partial class Equipmentadding : Form
    {
        private string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

        public Equipmentadding()
        {
            InitializeComponent();
        }

        private void Equipmentadding_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e) // Save Button Click Event
        {
            // Validate form input
            if (string.IsNullOrEmpty(txtItemName.Text) || cmbCategory.SelectedItem == null ||
                string.IsNullOrEmpty(txtQuantity.Text) || cmbStatus.SelectedItem == null ||
                string.IsNullOrEmpty(txtSupplier.Text) || string.IsNullOrEmpty(txtCostPerUnit.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return; 
            }

            try
            {
                int quantity = int.Parse(txtQuantity.Text);  
                decimal costPerUnit = decimal.Parse(txtCostPerUnit.Text);  
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input for Quantity or Cost Per Unit.");
                return;
            }

            // Collecting data from form fields
            string itemName = txtItemName.Text;
            string category = cmbCategory.SelectedItem.ToString();
            int quantityVal = int.Parse(txtQuantity.Text);
            DateTime dateAdded = Added_dateTimePicker1.Value;
            DateTime lastUpdated = Lastupdate_dateTimePicker2.Value;
            string status = cmbStatus.SelectedItem.ToString();
            string supplier = txtSupplier.Text;
            decimal costPerUnitVal = decimal.Parse(txtCostPerUnit.Text);

            // SQL Insert Query
            string query = "INSERT INTO inventory (ItemName, Category, Quantity, DateAdded, LastUpdated, Status, Supplier, CostPerUnit) " +
                           "VALUES (@ItemName, @Category, @Quantity, @DateAdded, @LastUpdated, @Status, @Supplier, @CostPerUnit)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                    
                        cmd.Parameters.AddWithValue("@ItemName", itemName);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@Quantity", quantityVal);
                        cmd.Parameters.AddWithValue("@DateAdded", dateAdded);
                        cmd.Parameters.AddWithValue("@LastUpdated", lastUpdated);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Supplier", supplier);
                        cmd.Parameters.AddWithValue("@CostPerUnit", costPerUnitVal);

                   
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Inventory item saved successfully.");
                            ClearForm(); 
                        }
                        else
                        {
                            MessageBox.Show("Error saving inventory item.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();  
        }

      
        private void ClearForm()
        {
            txtItemName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtQuantity.Clear();
            Added_dateTimePicker1.Value = DateTime.Now;
            Lastupdate_dateTimePicker2.Value = DateTime.Now;
            cmbStatus.SelectedIndex = -1;
            txtSupplier.Clear();
            txtCostPerUnit.Clear();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipmentreg form2 = new Equipmentreg();
            form2.ShowDialog();
            this.Show();

        }
    }
}
