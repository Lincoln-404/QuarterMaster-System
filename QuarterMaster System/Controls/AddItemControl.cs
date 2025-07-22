using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarterMaster_System
{
    /// <summary>
    /// UserControl for adding items to a list, with search and filter functionality.
    /// </summary>
    public partial class AddItemControl : UserControl
    {
        // Reference to the overlay form that hosts this control.
        // Form is used so the control can close the overlay when needed.
        private Form overlayform;

        // Boolean to track if the user is currently typing in the search box.
        // Boolean is chosen for simple true/false state tracking.
        Boolean typing = false;

        // Backing field for the ListID property, representing the list to which items are being added.
        // int is used as IDs are numeric and used in database operations.
        private int listID;

        // ContextMenuStrip for displaying filter options (category, availability).
        // ContextMenuStrip is a standard WinForms control for context menus.
        private ContextMenuStrip filterMenu = new ContextMenuStrip();

        // Stores the currently selected single category filter.
        // string is used as categories are text labels.
        private string selectedCategory = null;

        // Stores the currently selected single availability filter.
        // string is used as availability is a text label.
        private string selectedAvailability = null;

        // Stores multiple selected categories for filtering.
        // HashSet<string> is used for fast lookup and uniqueness, with case-insensitive comparison.
        private HashSet<string> selectedCategories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        // Stores multiple selected availabilities for filtering.
        // HashSet<string> is used for fast lookup and uniqueness, with case-insensitive comparison.
        private HashSet<string> selectedAvailabilities = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Constructor for AddItemControl.
        /// </summary>
        /// <param name="Overlyform">Reference to the overlay form hosting this control.</param>
        /// <param name="ListID">ID of the list to which items are being added.</param>
        public AddItemControl(Form Overlyform, int ListID)
        {
            InitializeComponent();
            overlayform = Overlyform; // Store the reference to the overlay form
            listID = ListID; // Set the ListID from the constructor parameter

            loadInventoryItems(); // Load items from the database into the flow layout panel

            // Attach event handlers for search box and filter button
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);
            btnFilter.Click += btnFilter_Click;
        }

        /// <summary>
        /// Handles the Cancel button click event, closing the overlay form.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            overlayform.Close(); // Close the overlay form when cancel button is clicked
        }

        /// <summary>
        /// Loads inventory items from the database and populates the flow layout panel.
        /// </summary>
        private void loadInventoryItems()
        {
            flpItemControlScroll.Controls.Clear(); // Clear existing controls in the table layout
            string connectionString = GlobalVariables.GetConnectionString(); // Use string for connection string as required by SqlConnection
            string query = "SELECT itemID, itemName, itemCategory, itemExternalID, quantity, storageLocation, available, condition, Notes, icon FROM InventoryTable"; // SQL query to select all relevant fields from the inventory table using string for the query due to its text nature

            using (SqlConnection conn = new SqlConnection(connectionString)) // Create a new SqlConnection using the connection string
            using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a SqlCommand to execute the query
            {
                try //try to open the connection and execute the command
                {
                    conn.Open(); // Open the SQL connection
                    Debug.WriteLine("SQL connection successful."); // Debug output

                    using (SqlDataReader reader = cmd.ExecuteReader()) // Execute the command and get a SqlDataReader to read the results
                    {
                        while (reader.Read()) // Read each row from the SqlDataReader
                        {
                            // Create a new EquipmentItemControl for each item in the database
                            var itemControl = new EquipmentItemControl
                            {
                                ItemID = int.Parse(reader["itemID"].ToString()),
                                ItemName = reader["itemName"].ToString(),
                                ItemCategory = reader["itemCategory"].ToString(),
                                ItemExternalID = reader["itemExternalID"].ToString(),
                                Quantity = reader["quantity"].ToString(),
                                StorageLocation = reader["storageLocation"].ToString(),
                                Availability = reader["available"].ToString(),
                                ListID = listID, // Set the ListID for the item control
                            };

                            // When the ItemAdded event is raised, set the number of items to add from the numeric up-down control
                            itemControl.ItemAdded += (s, args) =>
                            {
                                itemControl.NumbItems = (int)nudNumItem.Value; // nudNumItem is a NumericUpDown control, so cast Value to int
                            };
                            // When the ItemAdded event is raised, close the overlay form
                            itemControl.ItemAdded += (s, args) => overlayform.Close();
                            // Set the action button to "Add" mode
                            itemControl.Addbutton();

                            // Add the item control to the flow layout panel
                            flpItemControlScroll.Controls.Add(itemControl);
                        }
                    }
                }
                catch (Exception ex) //if an exception occurs while trying to open the connection or execute the command
                {
                    Debug.WriteLine("SQL connection failed: " + ex.Message); // Debug output for connection failure
                }
            }
        }

        /// <summary>
        /// Handles text changes in the search box and applies filters.
        /// </summary>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters(); // Apply search and filter criteria to the equipment list
        }

        /// <summary>
        /// Handles the Filter button click event, building and displaying the filter menu.
        /// </summary>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filterMenu.Items.Clear(); // Clear existing items in the filter menu

            // Build category filter menu
            var categories = flpItemControlScroll.Controls.OfType<EquipmentItemControl>()
                .Select(i => i.ItemCategory.Trim())
                .Where(c => !string.IsNullOrEmpty(c))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(c => c)
                .ToList();

            var categoryMenu = new ToolStripMenuItem("Category"); // Create a new ToolStripMenuItem for categories
            foreach (var cat in categories) // Iterate through each unique category found in the item controls
            {
                var item = new ToolStripMenuItem(cat) { Checked = selectedCategories.Contains(cat), CheckOnClick = true }; // Create a new ToolStripMenuItem for each category, setting its checked state based on selectedCategories
                item.Click += (s, ev) =>
                {
                    if (item.Checked)
                        selectedCategories.Add(cat);
                    else
                        selectedCategories.Remove(cat);
                    ApplyFilters();
                };
                categoryMenu.DropDownItems.Add(item); // Add the category item to the category menu
            }
            filterMenu.Items.Add(categoryMenu); // Add the category menu to the filter menu

            // Build availability filter menu
            var availabilities = flpItemControlScroll.Controls.OfType<EquipmentItemControl>() 
                .Select(i => i.Availability.Trim())
                .Where(a => !string.IsNullOrEmpty(a))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(a => a)
                .ToList();

            var availMenu = new ToolStripMenuItem("Availability"); // Create a new ToolStripMenuItem for availabilities
            foreach (var avail in availabilities) // Iterate through each unique availability found in the item controls
            {
                var item = new ToolStripMenuItem(avail) { Checked = selectedAvailabilities.Contains(avail), CheckOnClick = true }; // Create a new ToolStripMenuItem for each availability, setting its checked state based on selectedAvailabilities
                item.Click += (s, ev) =>
                {
                    if (item.Checked)
                        selectedAvailabilities.Add(avail);
                    else
                        selectedAvailabilities.Remove(avail);
                    ApplyFilters();
                };
                availMenu.DropDownItems.Add(item); // Add the availability item to the availability menu
            }
            filterMenu.Items.Add(availMenu); // Add the availability menu to the filter menu

            // Show the filter menu below the filter button
            filterMenu.Show(btnFilter, new Point(0, btnFilter.Height));
        }

        /// <summary>
        /// Applies search and filter criteria to the equipment list.
        /// </summary>
        private void ApplyFilters()
        {
            string searchText = txtSearch.Text.Trim().ToLower(); // Get the search text from the search box, trimming whitespace and converting to lowercase

            // Treat placeholder as empty search
            if (searchText == "search")
                searchText = string.Empty;

            foreach (Control ctrl in flpItemControlScroll.Controls) // Iterate through each control in the flow layout panel
            {
                if (ctrl is EquipmentItemControl item) // Check if the control is of type EquipmentItemControl
                {
                    // Check if item matches search text in any relevant field
                    bool match = (string.IsNullOrEmpty(searchText) ||
                                  item.ItemName.ToLower().Contains(searchText) ||
                                  item.ItemCategory.ToLower().Contains(searchText) ||
                                  item.ItemExternalID.ToLower().Contains(searchText) ||
                                  item.StorageLocation.ToLower().Contains(searchText) ||
                                  item.Availability.ToLower().Contains(searchText));

                    // Check if item matches selected categories and availabilities
                    bool categoryMatch = selectedCategories.Count == 0 || selectedCategories.Contains(item.ItemCategory.Trim());
                    bool availMatch = selectedAvailabilities.Count == 0 || selectedAvailabilities.Contains(item.Availability.Trim());

                    item.Visible = match && categoryMatch && availMatch; // Set item visibility based on search and filter criteria
                }
            }
        }

        /// <summary>
        /// Restores placeholder text and resets typing state when search box loses focus.
        /// </summary>
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty) // if the search box is empty when it loses focus
            {
                txtSearch.Text = "Search"; // Reset to placeholder text
                typing = false; // Reset typing state
                txtSearch.ForeColor = Color.Gray; // Change text color back to gray
            }
        }

        /// <summary>
        /// Handles mouse click in the search box to clear placeholder text and set typing state.
        /// </summary>
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "Search" && !typing) // If the search box contains the placeholder text and the user is not currently typing
            {
                txtSearch.Text = string.Empty; // Clear the placeholder text
                typing = true; // Set typing to true to prevent clearing again
                txtSearch.ForeColor = Color.Black; // Change text color to black
            }
        }

        /// <summary>
        /// Prevents the Enter key from adding a new line in the search box.
        /// </summary>
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // If the Enter key is pressed
            {
                e.Handled = true; // Prevent new line
            }
        }
    }
}
