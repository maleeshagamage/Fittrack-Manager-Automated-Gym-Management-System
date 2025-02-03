using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FittrackMS
{
    public partial class Update_member_details : Form
    {
        private string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";

       
        private string originalNameWithInitials, originalNICNumber, originalContactNumber, originalAddress, originalGender, originalFeesMade, originalMembershipType;
        private decimal? originalHeight, originalWeight;
        private byte[] originalNICImage;

        public Update_member_details()
        {
            InitializeComponent();
        }

      
        private void Btnsearch_Click(object sender, EventArgs e)
        {

            string searchText = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Check if input is numeric (User ID) or string (NameWithInitials)
                        bool isNumeric = int.TryParse(searchText, out int userId);
                        string query = isNumeric
                            ? "SELECT * FROM Users WHERE UserID = @userId"
                            : "SELECT * FROM Users WHERE NameWithInitials LIKE @namePattern";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        if (isNumeric)
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@namePattern", $"%{searchText}%");
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Load data into text boxes and combo boxes
                                txtNameWithInitials.Text = reader["NameWithInitials"].ToString();
                                txtNICNumber.Text = reader["NICNumber"].ToString();
                                txtContactNumber.Text = reader["ContactNumber"].ToString();
                                txtHeight.Text = reader["Height"] != DBNull.Value ? reader["Height"].ToString() : string.Empty;
                                txtWeight.Text = reader["Weight"] != DBNull.Value ? reader["Weight"].ToString() : string.Empty;
                                txtAddress.Text = reader["Address"].ToString();
                                cmbFeesMade.SelectedItem = reader["FeesMade"].ToString();

                                // Gender radio button selection
                                rbtnMale.Checked = reader["Gender"].ToString() == "Male";
                                rbtnFemale.Checked = reader["Gender"].ToString() == "Female";

                                // Set the lblshowname text to the user's name
                                lblshowname.Text = reader["NameWithInitials"].ToString();

                                

                                // Store original values for change tracking
                                originalNameWithInitials = txtNameWithInitials.Text;
                                originalNICNumber = txtNICNumber.Text;
                                originalContactNumber = txtContactNumber.Text;
                                originalAddress = txtAddress.Text;
                                originalGender = rbtnMale.Checked ? "Male" : "Female";
                                originalHeight = reader["Height"] != DBNull.Value ? (decimal?)reader["Height"] : null;
                                originalWeight = reader["Weight"] != DBNull.Value ? (decimal?)reader["Weight"] : null;
                                originalFeesMade = cmbFeesMade.SelectedItem?.ToString();
                            }
                            else
                            {
                                MessageBox.Show("User  not found.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a User ID or Name to search.");
            }
        }

        // Update functionality to modify only changed user details
        private void btnupdate_Click(object sender, EventArgs e)
        {
            string idOrName = textBox1.Text;

            if (string.IsNullOrEmpty(idOrName))
            {
                MessageBox.Show("Please search for a user before updating.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    List<string> updateFields = new List<string>();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    // Add changed fields to update list
                    if (txtNameWithInitials.Text != originalNameWithInitials)
                    {
                        updateFields.Add("NameWithInitials = @NameWithInitials");
                        cmd.Parameters.AddWithValue("@NameWithInitials", txtNameWithInitials.Text);
                    }
                    if (txtNICNumber.Text != originalNICNumber)
                    {
                        updateFields.Add("NICNumber = @NICNumber");
                        cmd.Parameters.AddWithValue("@NICNumber", txtNICNumber.Text);
                    }
                    if (txtContactNumber.Text != originalContactNumber)
                    {
                        updateFields.Add("ContactNumber = @ContactNumber");
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                    }
                    if (txtHeight.Text != originalHeight?.ToString())
                    {
                        updateFields.Add("Height = @Height");
                        cmd.Parameters.AddWithValue("@Height", string.IsNullOrEmpty(txtHeight.Text) ? DBNull.Value : (object)Convert.ToDecimal(txtHeight.Text));
                    }
                    if (txtWeight.Text != originalWeight?.ToString())
                    {
                        updateFields.Add("Weight = @Weight");
                        cmd.Parameters.AddWithValue("@Weight", string.IsNullOrEmpty(txtWeight.Text) ? DBNull.Value : (object)Convert.ToDecimal(txtWeight.Text));
                    }
                    if (txtAddress.Text != originalAddress)
                    {
                        updateFields.Add("Address = @Address");
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    }
                    if (cmbFeesMade.SelectedItem?.ToString() != originalFeesMade)
                    {
                        updateFields.Add("FeesMade = @FeesMade");
                        cmd.Parameters.AddWithValue("@FeesMade", cmbFeesMade.SelectedItem?.ToString());
                    }

                    string selectedGender = rbtnMale.Checked ? "Male" : "Female";
                    if (selectedGender != originalGender)
                    {
                        updateFields.Add("Gender = @Gender");
                        cmd.Parameters.AddWithValue("@Gender", selectedGender);
                    }
                    
                    

                    // Proceed with the update if there are fields to update
                    if (updateFields.Count > 0)
                    {
                        string updateQuery = $"UPDATE Users SET {string.Join(", ", updateFields)} WHERE UserID = @userId OR NameWithInitials = @namePattern";
                        cmd.CommandText = updateQuery;
                        cmd.Parameters.AddWithValue("@userId", int.TryParse(idOrName, out int userId) ? userId : DBNull.Value);
                        cmd.Parameters.AddWithValue("@namePattern", $"%{idOrName}%");

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please ensure the user exists.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No changes to update.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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

        private void BtnDeleteuser_Click(object sender, EventArgs e)
        {
            // Get the ID or Name entered in the search textbox
            string idOrName = textBox1.Text;

            // Check if a user has been loaded by verifying if the ID or Name field is filled
            if (string.IsNullOrEmpty(idOrName))
            {
                MessageBox.Show("Please search for a user before attempting to delete.");
                return;
            }

            // Show a confirmation dialog
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // If user clicked Yes, proceed with deletion
            if (confirmResult == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Determine whether we're deleting by UserID or NameWithInitials
                        bool isNumeric = int.TryParse(idOrName, out int userId);
                        string deleteQuery = isNumeric
                            ? "DELETE FROM Users WHERE UserID = @userId"
                            : "DELETE FROM Users WHERE NameWithInitials = @namePattern";

                        MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);

                        if (isNumeric)
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@namePattern", $"%{idOrName}%");
                        }

                        // Execute the delete command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if the deletion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.");

                            // Clear the form fields after deletion
                            ClearFormFields();
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed. User may not exist.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Helper function to clear the form fields after a deletion
        private void ClearFormFields()
        {
            txtNameWithInitials.Clear();
            txtNICNumber.Clear();
            txtContactNumber.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            txtAddress.Clear();
            cmbFeesMade.SelectedIndex = -1;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
           
            lblshowname.Text = string.Empty;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Dashboard form2 = new Dashboard();
            form2.ShowDialog();
            this.Show();
        }

        private void Update_member_details_Load(object sender, EventArgs e)
        {

        }

        private void Update_member_details_Load_1(object sender, EventArgs e)
        {

        }
    }
}
