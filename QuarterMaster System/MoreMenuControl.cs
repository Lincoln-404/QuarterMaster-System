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
    /// <summary>
    /// UserControl for viewing, editing, adding, and deleting inventory items.
    /// </summary>
    public partial class MoreMenuControl : UserControl
    {
        /// <summary>
        /// Event raised when an item is deleted or added, to notify parent forms to refresh their lists.
        /// </summary>
        public event EventHandler ItemDeleted;

        // Reference to the overlay form that hosts this control.
        // Form is used to allow closing the overlay from within the control.
        private Form overlayForm;

        // Flag to track if the item is currently being edited.
        // Boolean is used for simple true/false state.
        private Boolean isEditing = false;

        /// <summary>
        /// Constructor for MoreMenuControl.
        /// </summary>
        /// <param name="itemID">ID of the item to load, or 0 for new item.</param>
        /// <param name="OverlayForm">Reference to the overlay form hosting this control.</param>
        public MoreMenuControl(int itemID, Form OverlayForm)
        {
            InitializeComponent();
            overlayForm = OverlayForm; // Store the reference to the overlay form
            privilegesCheck(); // Set button visibility based on privileges
            if (GlobalVariables.isAddingNewItem == true) // If adding a new item
            {
                addItem(); // Prepare UI for new item entry
            }
            else
            {
                LoadInventoryItem(itemID); // Load inventory items from the database

            }
            


        }
        /// <summary>
        /// Method to load inventory item details from the database based on the provided ItemID.
        /// </summary>
        /// <param name="ItemID"></param>

        private void LoadInventoryItem(int ItemID)
        {
            string connectionString = GlobalVariables.GetConnectionString(); // Get the connection string from GlobalVariables, using string type because of the original data type
            string query = "SELECT itemID, itemName, itemCategory, itemExternalID, quantity, storageLocation, available, condition, Notes, icon FROM InventoryTable WHERE itemID = @ItemID"; // SQL query to retrieve item details based on ItemID
            Boolean available = true; // Variable to hold availability status
            using (SqlConnection conn = new SqlConnection(connectionString)) // Create a new SQL connection using the connection string
            using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a new SQL command with the query and connection
            {
                cmd.Parameters.AddWithValue("@ItemID", ItemID); // Add the ItemID parameter to the command to prevent SQL injection
                try // Attempt to open the SQL connection
                {
                    conn.Open(); // Open the connection to the database
                    Debug.WriteLine("SQL connection successful."); // Debug output
                    // Console.WriteLine("SQL connection successful."); // Alternative: prints to console if available
                    try // Attempt to execute the SQL command
                    {
                        Debug.WriteLine("item ID: " + ItemID.ToString()); // Debug output to show the item ID being queried
                        Debug.WriteLine("SQL Query Successful"); // Debug output to indicate the SQL query was successful
                        using (SqlDataReader reader = cmd.ExecuteReader()) // Execute the command and get a SqlDataReader to read the results
                        {

                            if (reader.Read()) // Read the first row of the result set
                            {
                                Debug.WriteLine("SQL Query: " + reader["itemID"]); // Debug output to show the item ID retrieved from the database
                                txtItemInternalID.Text = reader["itemID"].ToString(); // Set the internal ID text box to the item ID from the database
                                txtItemInternalID.AutoSizeToText(); // Adjust width to fit text
                                txtItemName.Text = reader["itemName"].ToString(); // Set the item name text box to the item name from the database
                                txtItemName.AutoSizeToText(); // Adjust width to fit text
                                txtItemCategory.Text = reader["itemCategory"].ToString(); // Set the item category text box to the item category from the database
                                txtItemCategory.AutoSizeToText(); // Adjust width to fit text
                                txtItemExternalID.Text = reader["itemExternalID"].ToString();   // Set the external ID text box to the item external ID from the database
                                txtItemExternalID.AutoSizeToText(); // Adjust width to fit text
                                txtItemQuantity.Text = reader["quantity"].ToString(); // Set the quantity text box to the item quantity from the database
                                txtItemQuantity.AutoSizeToText(); // Adjust width to fit text
                                txtItemLocation.Text = reader["storageLocation"].ToString(); // Set the storage location text box to the item storage location from the database
                                txtItemLocation.AutoSizeToText(); // Adjust width to fit text
                                available = Convert.ToBoolean(reader["available"]); // Convert the available field to a boolean value
                                txtItemCondition.Text = reader["condition"].ToString(); // Set the condition text box to the item condition from the database
                                txtItemCondition.AutoSizeToText(); // Adjust width to fit text
                                rtbNotes.Text = reader["Notes"].ToString(); // Set the notes rich text box to the item notes from the database
                            }
                        }
                    }
                    catch (Exception ex) // Catch any exceptions that occur during the SQL command execution
                    {
                        Debug.WriteLine("SQL Query Failed: " + ex.Message); // Log the error message to the debug output
                    }


                }
                catch (Exception ex) // Catch any exceptions that occur while opening the SQL connection
                {
                    Debug.WriteLine("SQL connection failed: " + ex.Message); // Log the error message to the debug output
                }
            }

            picAvailable.BackColor = available ? Color.Green : Color.Red; // Set the background color of the availability picture box based on the availability status
        }
        /// <summary>
        /// event handler for the close button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e) 
        {
            overlayForm.Close(); // Close the overlay form when the close button is clicked
        }

        /// <summary>
        /// event handler for the Edit button click event.
        /// </summary>
        /// <param name="sender"></param>
        // <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.elevatedPrivileges == true && isEditing == false) // Check if the user has elevated privileges and is not currently editing
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
            else if (GlobalVariables.elevatedPrivileges == true && isEditing == true) // If the user has elevated privileges and is currently editing
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

        /// <summary>
        /// Saves changes to the database, either updating an existing item or inserting a new one.
        /// </summary>
        private void SaveChanges()
        {
            if (GlobalVariables.isAddingNewItem == false) // Check if we are editing an existing item
            {
                Debug.WriteLine("Saving Changes"); // Debug output to indicate saving changes
                string connectionString = GlobalVariables.GetConnectionString(); // Get the connection string from GlobalVariables, using string type because of the original data type
                string query = "UPDATE InventoryTable SET itemName = @itemName, itemCategory = @itemCategory, itemExternalID = @itemExternalID, quantity = @quantity, storageLocation = @storageLocation, condition = @condition, Notes = @Notes WHERE itemID = @itemID"; // SQL query to update item details
                using (SqlConnection conn = new SqlConnection(connectionString)) // Create a new SQL connection using the connection string
                using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a new SQL command with the query and connection
                {
                    // Add parameters to the command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@itemID", txtItemInternalID.Text);
                    cmd.Parameters.AddWithValue("@itemName", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@itemCategory", txtItemCategory.Text);
                    cmd.Parameters.AddWithValue("@itemExternalID", txtItemExternalID.Text);
                    cmd.Parameters.AddWithValue("@quantity", txtItemQuantity.Text);
                    cmd.Parameters.AddWithValue("@storageLocation", txtItemLocation.Text);
                    cmd.Parameters.AddWithValue("@condition", txtItemCondition.Text);
                    cmd.Parameters.AddWithValue("@Notes", rtbNotes.Text);
                    try // Attempt to open the SQL connection
                    {
                        conn.Open(); // Open the connection to the database
                        Debug.WriteLine("SQL connection successful."); // Debug output
                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the update command
                        Debug.WriteLine($"{rowsAffected} row(s) updated successfully."); // Debug output to show how many rows were updated
                    }
                    catch (Exception ex) // Catch any exceptions that occur while opening the SQL connection or executing the command
                    {
                        Debug.WriteLine("SQL connection failed: " + ex.Message); // Log any errors
                    }

                }
            }
            else if (GlobalVariables.isAddingNewItem == true) // Check if we are adding a new item
            {
                Debug.WriteLine("Adding New Item"); // Debug output to indicate adding a new item

                // Use lists to build dynamic SQL for only filled fields
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
                    sqlParams.Add(new SqlParameter("@itemName", txtItemName.Text)); // Create a SqlParameter for itemName
                }
                // Item Category
                if (IsValid(txtItemCategory.Text, "[Items Category]"))
                {
                    columns.Add("itemCategory"); // Add itemCategory to columns list
                    parameters.Add("@itemCategory"); // Add parameter for itemCategory
                    sqlParams.Add(new SqlParameter("@itemCategory", txtItemCategory.Text)); // Create a SqlParameter for itemCategory
                }
                // External ID
                if (IsValid(txtItemExternalID.Text, "[Items Serial]"))
                {
                    columns.Add("itemExternalID"); // Add itemExternalID to columns list
                    parameters.Add("@itemExternalID"); // Add parameter for itemExternalID 
                    sqlParams.Add(new SqlParameter("@itemExternalID", txtItemExternalID.Text)); // Create a SqlParameter for itemExternalID
                }
                // Quantity
                if (IsValid(txtItemQuantity.Text, "[Items Quantity]"))
                {
                    columns.Add("quantity"); // Add quantity to columns list
                    parameters.Add("@quantity"); // Add parameter for quantity
                    sqlParams.Add(new SqlParameter("@quantity", txtItemQuantity.Text)); // Create a SqlParameter for quantity
                }
                // Storage Location
                if (IsValid(txtItemLocation.Text, "[Items Location]"))
                {
                    columns.Add("storageLocation"); // Add storageLocation to columns list
                    parameters.Add("@storageLocation"); // Add parameter for storageLocation
                    sqlParams.Add(new SqlParameter("@storageLocation", txtItemLocation.Text)); // Create a SqlParameter for storageLocation
                }
                // Condition
                if (IsValid(txtItemCondition.Text, "[Items Condition]"))
                {
                    columns.Add("condition"); // Add condition to columns list
                    parameters.Add("@condition"); // Add parameter for condition
                    sqlParams.Add(new SqlParameter("@condition", txtItemCondition.Text)); // Create a SqlParameter for condition
                }
                // Notes
                if (IsValid(rtbNotes.Text, "Notes"))
                {
                    columns.Add("Notes"); // Add Notes to columns list
                    parameters.Add("@Notes"); // Add parameter for Notes
                    sqlParams.Add(new SqlParameter("@Notes", rtbNotes.Text)); // Create a SqlParameter for Notes
                }

                // Build the SQL statement dynamically
                string query = $"INSERT INTO InventoryTable ({string.Join(", ", columns)}) VALUES ({string.Join(", ", parameters)})"; // Create the SQL insert statement using the columns and parameters lists
                string connectionString = GlobalVariables.GetConnectionString(); // Get the connection string from GlobalVariables

                using (SqlConnection conn = new SqlConnection(connectionString)) // Create a new SQL connection using the connection string
                using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a new SQL command with the query and connection
                {
                    cmd.Parameters.AddRange(sqlParams.ToArray()); // Add all SqlParameters to the command
                    try // Attempt to open the SQL connection
                    {
                        conn.Open(); // Open the connection to the database
                        Debug.WriteLine("SQL connection successful."); // Debug output
                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the insert command
                        Debug.WriteLine($"{rowsAffected} row(s) inserted successfully."); // Debug output to show how many rows were inserted
                        GlobalVariables.isAddingNewItem = false; // Reset the flag after adding a new item
                        overlayForm.Close(); // Close the overlay form after saving changes
                        ItemDeleted?.Invoke(this, EventArgs.Empty); // Raise the ItemDeleted event to refresh the item list
                    }
                    catch (Exception ex) // Catch any exceptions that occur while opening the SQL connection or executing the command
                    {
                        Debug.WriteLine("SQL connection failed: " + ex.Message); // Log any errors
                        MessageBox.Show("Failed to add new item. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Delete button click event, deleting the item from the database.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.elevatedPrivileges == true) // Check if the user has elevated privileges
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Show confirmation dialog before deleting
                if (result == DialogResult.Yes)
                {
                    string connectionString = GlobalVariables.GetConnectionString(); // Get the connection string from GlobalVariables, using string type because of the original data type
                    string query = "DELETE FROM InventoryTable WHERE itemID = @itemID"; // SQL query to delete the item
                    using (SqlConnection conn = new SqlConnection(connectionString)) // Create a new SQL connection using the connection string
                    using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a new SQL command with the query and connection
                    {
                        cmd.Parameters.AddWithValue("@itemID", txtItemInternalID.Text); // Set the item ID parameter
                        try // Attempt to open the SQL connection
                        {
                            conn.Open();
                            Debug.WriteLine("SQL connection successful."); // Debug output
                            int rowsAffected = cmd.ExecuteNonQuery(); // Execute the delete command
                            Debug.WriteLine($"{rowsAffected} row(s) deleted successfully."); // Debug output to show how many rows were deleted
                        }
                        catch (Exception ex) // Catch any exceptions that occur while opening the SQL connection or executing the command
                        {
                            Debug.WriteLine("SQL connection failed: " + ex.Message); // Log any errors
                        }
                        overlayForm.Close(); // Close the overlay form after deletion
                        ItemDeleted?.Invoke(this, EventArgs.Empty); // Raise the ItemDeleted event
                    }
                }

            }
        }

        /// <summary>
        /// Checks the user's privileges and sets the visibility of edit and delete buttons accordingly.
        /// </summary>
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
        /// <summary>
        /// Event handler for the Add Item button click event.
        /// </summary>        
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
