using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FittrackMS
{
    public partial class Updatestaff : Form
    {
        private string connectionString = "server=localhost;database=fittrackmaindb;user=root;password=newpassword;";
        private string originalName, originalNIC, originalAddress, originalContactNumber, originalGender, originalStaffCategory;
        private byte[] originalNICImage;
        private TimeSpan? originalShiftStart, originalShiftEnd;

        public Updatestaff()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textname.Text))
            {
                MessageBox.Show("Please enter Name with Initials.");
                textname.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textNIC.Text))
            {
                MessageBox.Show("Please enter NIC Number.");
                textNIC.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textAddress.Text))
            {
                MessageBox.Show("Please enter Address.");
                textAddress.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textcontctNo.Text))
            {
                MessageBox.Show("Please enter Contact Number.");
                textcontctNo.Focus();
                return false;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a Staff Category.");
                comboBox1.Focus();
                return false;
            }
            if (!male.Checked && !female.Checked)
            {
                MessageBox.Show("Please select Gender.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(shiftstartcmb.Text))
            {
                MessageBox.Show("Please select Shift Start time.");
                shiftstartcmb.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(shiftendcmb.Text))
            {
                MessageBox.Show("Please select Shift End time.");
                shiftendcmb.Focus();
                return false;
            }
            return true;
        }

        private void Buttonsearch_Click(object sender, EventArgs e)
        {
            string searchText = textSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        bool isNumeric = int.TryParse(searchText, out int staffId);
                        string query = isNumeric ? "SELECT * FROM staff WHERE StaffID = @staffId" : "SELECT * FROM staff WHERE NameWithInitials LIKE @namePattern";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        if (isNumeric)
                        {
                            cmd.Parameters.AddWithValue("@staffId", staffId);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@namePattern", $"%{searchText}%");
                        }
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textname.Text = reader["NameWithInitials"].ToString();
                                textNIC.Text = reader["NICNumber"].ToString();
                                textAddress.Text = reader["Address"].ToString();
                                textcontctNo.Text = reader["ContactNumber"].ToString();
                                comboBox1.SelectedItem = reader["StaffCategory"].ToString();
                                shiftstartcmb.Text = reader["ShiftStart"]?.ToString();
                                shiftendcmb.Text = reader["ShiftEnd"]?.ToString();
                                male.Checked = reader["Gender"].ToString() == "Male";
                                female.Checked = reader["Gender"].ToString() == "Female";
                                originalName = textname.Text;
                                originalNIC = textNIC.Text;
                                originalAddress = textAddress.Text;
                                originalContactNumber = textcontctNo.Text;
                                originalGender = male.Checked ? "Male" : "Female";
                                originalStaffCategory = comboBox1.SelectedItem?.ToString();
                                originalShiftStart = reader["ShiftStart"] != DBNull.Value ? (TimeSpan?)reader["ShiftStart"] : null;
                                originalShiftEnd = reader["ShiftEnd"] != DBNull.Value ? (TimeSpan?)reader["ShiftEnd"] : null;
                            }
                            else
                            {
                                MessageBox.Show("Staff member not found.");
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
                MessageBox.Show("Please enter a Staff ID or Name to search.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            string searchText = textSearch.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please search for a staff member before updating.");
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
                    if (textname.Text != originalName)
                    {
                        updateFields.Add("NameWithInitials = @NameWithInitials");
                        cmd.Parameters.AddWithValue("@NameWithInitials", textname.Text);
                    }
                    if (textNIC.Text != originalNIC)
                    {
                        updateFields.Add("NICNumber = @NICNumber");
                        cmd.Parameters.AddWithValue("@NICNumber", textNIC.Text);
                    }
                    if (textAddress.Text != originalAddress)
                    {
                        updateFields.Add("Address = @Address");
                        cmd.Parameters.AddWithValue("@Address", textAddress.Text);
                    }
                    if (textcontctNo.Text != originalContactNumber)
                    {
                        updateFields.Add("ContactNumber = @ContactNumber");
                        cmd.Parameters.AddWithValue("@ContactNumber", textcontctNo.Text);
                    }
                    if (comboBox1.SelectedItem?.ToString() != originalStaffCategory)
                    {
                        updateFields.Add("StaffCategory = @StaffCategory");
                        cmd.Parameters.AddWithValue("@StaffCategory", comboBox1.SelectedItem?.ToString());
                    }
                    string selectedGender = male.Checked ? "Male" : "Female";
                    if (selectedGender != originalGender)
                    {
                        updateFields.Add("Gender = @Gender");
                        cmd.Parameters.AddWithValue("@Gender", selectedGender);
                    }
                    if (shiftstartcmb.Text != originalShiftStart?.ToString())
                    {
                        updateFields.Add("ShiftStart = @ShiftStart");
                        cmd.Parameters.AddWithValue("@ShiftStart", TimeSpan.Parse(shiftstartcmb.Text));
                    }
                    if (shiftendcmb.Text != originalShiftEnd?.ToString())
                    {
                        updateFields.Add("ShiftEnd = @ShiftEnd");
                        cmd.Parameters.AddWithValue("@ShiftEnd", TimeSpan.Parse(shiftendcmb.Text));
                    }
                    
                    else if (originalNICImage != null)
                    {
                        updateFields.Add("NICImage = @NICImage");
                        cmd.Parameters.AddWithValue("@NICImage", DBNull.Value);
                    }
                    if (updateFields.Count > 0)
                    {
                        string updateQuery = $"UPDATE staff SET {string.Join(", ", updateFields)} WHERE StaffID = @staffId OR NameWithInitials = @namePattern";
                        cmd.CommandText = updateQuery;
                        cmd.Parameters.AddWithValue("@staffId", int.TryParse(searchText, out int staffId) ? staffId : DBNull.Value);
                        cmd.Parameters.AddWithValue("@namePattern", $"%{searchText}%");
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff details updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please ensure the staff member exists.");
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
            Dashboard mainForm = new Dashboard();
            mainForm.ShowDialog();
            this.Show();
        }

        private void Btnreset_Click(object sender, EventArgs e)
        {
            textSearch.Clear();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            string searchText = textSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please search for a staff member before deleting.");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this staff member?",
                                                  "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        bool isNumeric = int.TryParse(searchText, out int staffId);

                        string query = isNumeric ? "DELETE FROM staff WHERE StaffID = @staffId" : "DELETE FROM staff WHERE NameWithInitials LIKE @namePattern";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            if (isNumeric)
                            {
                                cmd.Parameters.AddWithValue("@staffId", staffId);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@namePattern", $"%{searchText}%");
                            }

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Staff member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear form fields after deletion
                                ClearFormFields();
                            }
                            else
                            {
                                MessageBox.Show("Deletion failed. Please ensure the staff member exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Method to clear form fields
        private void ClearFormFields()
        {
            textname.Clear();
            textNIC.Clear();
            textAddress.Clear();
            textcontctNo.Clear();
            comboBox1.SelectedIndex = -1;
            shiftstartcmb.Text = string.Empty;
            shiftendcmb.Text = string.Empty;
            male.Checked = false;
            female.Checked = false;
            textSearch.Clear();
        }

    }
}
