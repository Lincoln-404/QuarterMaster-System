using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarterMaster_System
{
    public partial class MoreMenuControl : UserControl
    {
        public event EventHandler ItemDeleted;

        private Form overlayForm; // Reference to the overlay form
        private Boolean isEditing = false; // Flag to track if the item is being edited
        
        public MoreMenuControl(int itemID, Form OverlayForm)
        {
            InitializeComponent();
            overlayForm = OverlayForm; // Store the reference to the overlay form
            privilegesCheck(); // Check privileges to set button visibility
            if (GlobalVariables.isAddingNewItem == true) // Check if a new item is being added
            {
                addItem(); // Call method to add a new item if the flag is set
            }
            else
            {
                LoadInventoryItem(itemID); // Load inventory items from the database

            }
            


        }

        private void LoadInventoryItem(int ItemID)
        {
            string connectionString = GlobalVariables.GetConnectionString();
            string query = "SELECT itemID, itemName, itemCategory, itemExternalID, quantity, storageLocation, available, condition, Notes, icon FROM InventoryTable WHERE itemID = @ItemID"; // SQL query to retrieve item details based on ItemID
            Boolean available = true; // Variable to hold availability status
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ItemID", ItemID);
                try
                {
                    conn.Open();
                    Debug.WriteLine("SQL connection successful."); // Debug output
                    // Console.WriteLine("SQL connection successful."); // Alternative: prints to console if available
                    try
                    {
                        Debug.WriteLine("item ID: " + ItemID.ToString());
                        Debug.WriteLine("SQL Query Successful");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                Debug.WriteLine("SQL Query: " + reader["itemID"]);
                                txtItemInternalID.Text = reader["itemID"].ToString();
                                txtItemInternalID.AutoSizeToText(); // Adjust width to fit text
                                txtItemName.Text = reader["itemName"].ToString();
                                txtItemName.AutoSizeToText(); // Adjust width to fit text
                                txtItemCategory.Text = reader["itemCategory"].ToString();
                                txtItemCategory.AutoSizeToText(); // Adjust width to fit text
                                txtItemExternalID.Text = reader["itemExternalID"].ToString();
                                txtItemExternalID.AutoSizeToText(); // Adjust width to fit text
                                txtItemQuantity.Text = reader["quantity"].ToString();
                                txtItemQuantity.AutoSizeToText(); // Adjust width to fit text
                                txtItemLocation.Text = reader["storageLocation"].ToString();
                                txtItemLocation.AutoSizeToText(); // Adjust width to fit text
                                available = Convert.ToBoolean(reader["available"]);
                                txtItemCondition.Text = reader["condition"].ToString();
                                txtItemCondition.AutoSizeToText(); // Adjust width to fit text
                                rtbNotes.Text = reader["Notes"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("SQL Query Failed: " + ex.Message);
                    }


                }
                catch (Exception ex)
                {
                    Debug.WriteLine("SQL connection failed: " + ex.Message);
                }
            }

            picAvailable.BackColor = available ? Color.Green : Color.Red;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            overlayForm.Close(); // Close the overlay form when the close button is clicked
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.elevatedPrivileges == true && isEditing == false)
            {
                isEditing = true;
                btnEdit.Text = "Save"; // Change button text to "Save" when editing
                txtItemName.ReadOnly = false; // Make the item name editable
                txtItemCategory.ReadOnly = false; // Make the item category editable
                txtItemExternalID.ReadOnly = false; // Make the external ID editable
                txtItemQuantity.ReadOnly = false; // Make the quantity editable
                txtItemLocation.ReadOnly = false; // Make the storage location editable
                txtItemCondition.ReadOnly = false; // Make the condition editable
                rtbNotes.ReadOnly = false; // Make the notes editable
            }
            else if (GlobalVariables.elevatedPrivileges == true && isEditing == true)
            {
                isEditing = false;
                btnEdit.Text = "Edit"; // Change button text back to "Edit"
                txtItemName.ReadOnly = true; // Make the item name read-only
                txtItemCategory.ReadOnly = true; // Make the item category read-only
                txtItemExternalID.ReadOnly = true; // Make the external ID read-only
                txtItemQuantity.ReadOnly = true; // Make the quantity read-only
                txtItemLocation.ReadOnly = true; // Make the storage location read-only
                txtItemCondition.ReadOnly = true; // Make the condition read-only
                rtbNotes.ReadOnly = true; // Make the notes read-only
                SaveChanges(); // Call method to save changes to the database
            }
        }

        private void SaveChanges()
        {
            if (GlobalVariables.isAddingNewItem == false)
            {
                Debug.WriteLine("Saving Changes");
                string connectionString = GlobalVariables.GetConnectionString();
                string query = "UPDATE InventoryTable SET itemName = @itemName, itemCategory = @itemCategory, itemExternalID = @itemExternalID, quantity = @quantity, storageLocation = @storageLocation, condition = @condition, Notes = @Notes WHERE itemID = @itemID"; // SQL query to update item details
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemID", txtItemInternalID.Text);
                    cmd.Parameters.AddWithValue("@itemName", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@itemCategory", txtItemCategory.Text);
                    cmd.Parameters.AddWithValue("@itemExternalID", txtItemExternalID.Text);
                    cmd.Parameters.AddWithValue("@quantity", txtItemQuantity.Text);
                    cmd.Parameters.AddWithValue("@storageLocation", txtItemLocation.Text);
                    cmd.Parameters.AddWithValue("@condition", txtItemCondition.Text);
                    cmd.Parameters.AddWithValue("@Notes", rtbNotes.Text);
                    try
                    {
                        conn.Open();
                        Debug.WriteLine("SQL connection successful."); // Debug output
                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the update command
                        Debug.WriteLine($"{rowsAffected} row(s) updated successfully.");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("SQL connection failed: " + ex.Message); // Log any errors
                    }

                }
            }
            else if (GlobalVariables.isAddingNewItem == true)
            {
                Debug.WriteLine("Adding New Item");

                // Prepare lists for columns and parameters
                var columns = new List<string>();
                var parameters = new List<string>();
                var sqlParams = new List<SqlParameter>();

                // Helper function to check if a field is valid (not empty and not placeholder)
                bool IsValid(string value, string placeholder) =>
                    !string.IsNullOrWhiteSpace(value) && value != placeholder;

                //Go through each field checking if item name is valid, if so add it to the columns and parameters lists and create a SqlParameter for it
                // Item Name
                if (IsValid(txtItemName.Text, "[Items Name]")) 
                {
                    columns.Add("itemName"); // Add itemName to columns list
                    parameters.Add("@itemName"); // Add parameter for itemName
                    sqlParams.Add(new SqlParameter("@itemName", txtItemName.Text)); 
                }
                // Item Category
                if (IsValid(txtItemCategory.Text, "[Items Category]"))
                {
                    columns.Add("itemCategory");
                    parameters.Add("@itemCategory");
                    sqlParams.Add(new SqlParameter("@itemCategory", txtItemCategory.Text));
                }
                // External ID
                if (IsValid(txtItemExternalID.Text, "[Items Serial]"))
                {
                    columns.Add("itemExternalID");
                    parameters.Add("@itemExternalID");
                    sqlParams.Add(new SqlParameter("@itemExternalID", txtItemExternalID.Text));
                }
                // Quantity
                if (IsValid(txtItemQuantity.Text, "[Items Quantity]"))
                {
                    columns.Add("quantity");
                    parameters.Add("@quantity");
                    sqlParams.Add(new SqlParameter("@quantity", txtItemQuantity.Text));
                }
                // Storage Location
                if (IsValid(txtItemLocation.Text, "[Items Location]"))
                {
                    columns.Add("storageLocation");
                    parameters.Add("@storageLocation");
                    sqlParams.Add(new SqlParameter("@storageLocation", txtItemLocation.Text));
                }
                // Condition
                if (IsValid(txtItemCondition.Text, "[Items Condition]"))
                {
                    columns.Add("condition");
                    parameters.Add("@condition");
                    sqlParams.Add(new SqlParameter("@condition", txtItemCondition.Text));
                }
                // Notes
                if (IsValid(rtbNotes.Text, "Notes"))
                {
                    columns.Add("Notes");
                    parameters.Add("@Notes");
                    sqlParams.Add(new SqlParameter("@Notes", rtbNotes.Text));
                }

                // Build the SQL statement dynamically
                string query = $"INSERT INTO InventoryTable ({string.Join(", ", columns)}) VALUES ({string.Join(", ", parameters)})";
                string connectionString = GlobalVariables.GetConnectionString(); // Get the connection string from GlobalVariables

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(sqlParams.ToArray());
                    try
                    {
                        conn.Open();
                        Debug.WriteLine("SQL connection successful."); // Debug output
                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the insert command
                        Debug.WriteLine($"{rowsAffected} row(s) inserted successfully.");
                        GlobalVariables.isAddingNewItem = false; // Reset the flag after adding a new item
                        overlayForm.Close(); // Close the overlay form after saving changes
                        ItemDeleted?.Invoke(this, EventArgs.Empty); // Raise the ItemDeleted event to refresh the item list
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("SQL connection failed: " + ex.Message); // Log any errors
                        MessageBox.Show("Failed to add new item. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.elevatedPrivileges == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string connectionString = GlobalVariables.GetConnectionString();
                    string query = "DELETE FROM InventoryTable WHERE itemID = @itemID"; // SQL query to delete the item
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemID", txtItemInternalID.Text); // Set the item ID parameter
                        try
                        {
                            conn.Open();
                            Debug.WriteLine("SQL connection successful."); // Debug output
                            int rowsAffected = cmd.ExecuteNonQuery(); // Execute the delete command
                            Debug.WriteLine($"{rowsAffected} row(s) deleted successfully.");
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine("SQL connection failed: " + ex.Message); // Log any errors
                        }
                        overlayForm.Close(); // Close the overlay form after deletion
                        ItemDeleted?.Invoke(this, EventArgs.Empty); // Raise the ItemDeleted event
                    }
                }

            }
        }

        private void privilegesCheck()
        {
            // Set the initial state of the controls based on elevated privileges
            if (GlobalVariables.elevatedPrivileges == false)
            {
                btnEdit.Visible = false; // Hide the edit button if not elevated
                btnDelete.Visible = false; // Hide the delete button if not elevated
            }
            else
            {
                btnEdit.Visible = true; // Show the edit button if elevated
                btnDelete.Visible = true; // Show the delete button if elevated
            }
        }
        private void addItem()
        {
            isEditing = true; // Set editing mode to true
            btnEdit.Text = "Save"; // Change button text to "Save" when editing
            txtItemName.ReadOnly = false; // Make the item name editable
            txtItemCategory.ReadOnly = false; // Make the item category editable
            txtItemExternalID.ReadOnly = false; // Make the external ID editable
            txtItemQuantity.ReadOnly = false; // Make the quantity editable
            txtItemLocation.ReadOnly = false; // Make the storage location editable
            txtItemCondition.ReadOnly = false; // Make the condition editable
            rtbNotes.ReadOnly = false; // Make the notes editable
            picAvailable.BackColor = Color.Green; // Set availability to green (available)
            txtItemInternalID.Text = "New Item"; // Set a placeholder for the internal ID

        }
    }
}
