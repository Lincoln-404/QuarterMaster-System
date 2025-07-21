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
    public partial class Equipment_Search : Form
    {
        Boolean typing = false; // Boolean to track if user is typing in the search box

        private ContextMenuStrip filterMenu = new ContextMenuStrip();
        private string selectedCategory = null;
        private string selectedAvailability = null;
        private HashSet<string> selectedCategories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private HashSet<string> selectedAvailabilities = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public Equipment_Search()
        {
            InitializeComponent();

            // Example code for adding test items (commented out).
            /*
            int numberOfItems = 30; // Set this to however many items you want to test

            for (int i = 0; i < numberOfItems; i++)
            {
                var itemExample = new EquipmentItemControl
                {
                    ItemIcon = Properties.Resources.Scouts_Australia_Logo, // Placeholder icon
                    ItemName = $"Item Name {i + 1}",
                    ItemExternalID = $"External ID {i + 1}",
                    Quantity = (i * 2).ToString(),
                    StorageLocation = $"Storage Location {i + 1}",
                    Availability = (i % 2 == 0) ? "Available" : "Checked Out"
                };
                flpEquipmentScroll.Controls.Add(itemExample);
            }
            */

            this.WindowState = FormWindowState.Maximized; // Maximize window on open

            LoadInventoryItems(); // Load items from the database into the flow layout panel

            // Prevent space bar from being used in the search box
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // Update search results as text changes
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);

            // Attach filter button click event
            btnFilter.Click += btnFilter_Click;
        }

        /// <summary>
        /// Handles the Back button click event, closing the current form.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close current form
        }

        /// <summary>
        /// Prevents the Enter key from adding a new line in the search box.
        /// </summary>
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Check if the pressed key is Enter
            {
                e.Handled = true; // Prevent new line
            }
        }

        /// <summary>
        /// Handles mouse click in the search box to clear placeholder text and set typing state.
        /// </summary>
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "Search" && !typing) // if the search box contains the placeholder text and user is not typing
            {
                txtSearch.Text = string.Empty; // Clear the placeholder text
                typing = true; // Set typing to true to prevent clearing again
                txtSearch.ForeColor = Color.Black; // Change text color to black
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
        /// Loads inventory items from the database and populates the flow layout panel.
        /// </summary>
        private void LoadInventoryItems()
        {
            flpEquipmentScroll.Controls.Clear(); // Clear existing controls in the table layout
            string connectionString = GlobalVariables.GetConnectionString(); // Get the connection string from GlobalVariables, using string type due to the project settings
            string query = "SELECT itemID, itemName, itemCategory, itemExternalID, quantity, storageLocation, available, condition, Notes, icon FROM InventoryTable"; // SQL query to select all items from the InventoryTable, using string type due to being a string of characters

            using (SqlConnection conn = new SqlConnection(connectionString)) // Create a new SqlConnection using the connection string
            using (SqlCommand cmd = new SqlCommand(query, conn)) // Create a new SqlCommand with the query and connection
            {
                try // Attempt to open the SQL connection and execute the command
                {
                    conn.Open(); // Open the SQL connection
                    Debug.WriteLine("SQL connection successful."); // Debug output
                    // Console.WriteLine("SQL connection successful."); // Alternative: prints to console if available

                    using (SqlDataReader reader = cmd.ExecuteReader()) // Execute the command and get a SqlDataReader to read the results
                    {
                        while (reader.Read()) // Read each row from the SqlDataReader
                        {
                            // Create a new EquipmentItemControl for each item in the database
                            var itemControl = new EquipmentItemControl
                            {
                                ItemID = int.Parse(reader["itemID"].ToString()), // Convert itemID from database to int and set it as the ItemID property
                                ItemName = reader["itemName"].ToString(), // Set the ItemName property from the database 
                                ItemCategory = reader["itemCategory"].ToString(), // Set the ItemCategory property from the database
                                ItemExternalID = reader["itemExternalID"].ToString(), // Set the ItemExternalID property from the database
                                Quantity = reader["quantity"].ToString(), // Set the Quantity property from the database
                                StorageLocation = reader["storageLocation"].ToString(), // Set the StorageLocation property from the database
                                Availability = reader["available"].ToString() // Set the Availability property from the database
                            };

                            // Subscribe to the ItemDeleted event to refresh the list when an item is deleted
                            itemControl.ItemDeleted += (s, e) => LoadInventoryItems();

                            flpEquipmentScroll.Controls.Add(itemControl); // Add the new EquipmentItemControl to the flow layout panel
                        }
                    }
                }
                catch (Exception ex) // Catch any exceptions that occur during the SQL operations
                {
                    Debug.WriteLine("SQL connection failed: " + ex.Message); // Debug output for error
                }
            }
        }

        /// <summary>
        /// Handles the Add Item button click event, opening the MoreMenuControl for item addition.
        /// </summary>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.elevatedPrivileges == true) // Check if the user has elevated privileges
            {
                GlobalVariables.isAddingNewItem = true; // Set the flag to indicate a new item is being added
                // Create a new Form to host the MoreMenuControl
                using (Form overlayForm = new Form())
                {
                    MoreMenuControl moreMenu = new MoreMenuControl(0, overlayForm); //Create a new instance of MoreMenuControl with itemID 0 (indicating a new item) 

                    // Set up the overlay form properties
                    overlayForm.FormBorderStyle = FormBorderStyle.None;
                    overlayForm.StartPosition = FormStartPosition.CenterParent;
                    overlayForm.ShowInTaskbar = false;
                    overlayForm.BackColor = Color.White;
                    overlayForm.Size = new Size(moreMenu.Width, moreMenu.Height); // Adjust size as needed

                    // Subscribe to the MoreMenuControl's ItemDeleted event to refresh the list
                    moreMenu.ItemDeleted += (s, args) => LoadInventoryItems();

                    moreMenu.Dock = DockStyle.Fill; // Fill the overlay form with the MoreMenuControl
                    overlayForm.Controls.Add(moreMenu); // Add the MoreMenuControl to the overlay form

                    // Show as a dialog (modal)
                    overlayForm.ShowDialog();
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
            var categories = flpEquipmentScroll.Controls.OfType<EquipmentItemControl>()
                .Select(i => i.ItemCategory.Trim())
                .Where(c => !string.IsNullOrEmpty(c))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(c => c)
                .ToList();

            var categoryMenu = new ToolStripMenuItem("Category"); // Create a new menu item for categories
            foreach (var cat in categories) // Iterate through each unique category found in the equipment items
            {
                var item = new ToolStripMenuItem(cat) { Checked = selectedCategories.Contains(cat), CheckOnClick = true }; // Create a new menu item for each category, checking if it's selected
                // Attach click event to toggle selection
                item.Click += (s, ev) =>
                {
                    if (item.Checked)
                        selectedCategories.Add(cat);
                    else
                        selectedCategories.Remove(cat);
                    ApplyFilters();
                };
                categoryMenu.DropDownItems.Add(item);
            }
            filterMenu.Items.Add(categoryMenu); // Add the category menu to the filter menu

            // Build availability filter menu
            var availabilities = flpEquipmentScroll.Controls.OfType<EquipmentItemControl>()
                .Select(i => i.Availability.Trim())
                .Where(a => !string.IsNullOrEmpty(a))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(a => a)
                .ToList();

            var availMenu = new ToolStripMenuItem("Availability"); // Create a new menu item for availabilities
            foreach (var avail in availabilities) // Iterate through each unique availability found in the equipment items
            {
                var item = new ToolStripMenuItem(avail) { Checked = selectedAvailabilities.Contains(avail), CheckOnClick = true }; // Create a new menu item for each availability, checking if it's selected
                // Attach click event to toggle selection
                item.Click += (s, ev) =>
                {
                    if (item.Checked)
                        selectedAvailabilities.Add(avail);
                    else
                        selectedAvailabilities.Remove(avail);
                    ApplyFilters();
                };
                availMenu.DropDownItems.Add(item);
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
            string searchText = txtSearch.Text.Trim().ToLower(); // Get the search text from the search box, trimmed and converted to lowercase

            // Treat placeholder as empty search
            if (searchText == "search")
                searchText = string.Empty;

            foreach (Control ctrl in flpEquipmentScroll.Controls) // Iterate through each control in the flow layout panel
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

                    item.Visible = match && categoryMatch && availMatch; // Set visibility based on search and filter criteria
                }
            }
        }
    }
}
