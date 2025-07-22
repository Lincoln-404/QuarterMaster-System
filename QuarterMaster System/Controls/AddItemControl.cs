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
    public partial class AddItemControl : UserControl
    {
        private Form overlayform; // Form to be used as an overlay
        Boolean typing = false; // Boolean to track if user is typing in the search box
        private int listID; // Backing field for ListID property

        private ContextMenuStrip filterMenu = new ContextMenuStrip();
        private string selectedCategory = null;
        private string selectedAvailability = null;
        private HashSet<string> selectedCategories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private HashSet<string> selectedAvailabilities = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public AddItemControl(Form Overlyform, int ListID)
        {
            InitializeComponent();
            overlayform = Overlyform; // Initialize the overlay form
            listID = ListID; // Set the ListID from the constructor parameter   
            loadInventoryItems();
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged); // Add this line

            btnFilter.Click += btnFilter_Click; // Add this line
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            overlayform.Close(); // Close the overlay form when cancel button is clicked
        }

        public int NumberOfItems
        {
            get =>  (int)nudNumItem.Value; // Return the number of items in the flow layout panel
        }

        private void loadInventoryItems()
        {
            flpItemControlScroll.Controls.Clear(); // Clear existing controls in the table layout
            string connectionString = GlobalVariables.GetConnectionString();
            string query = "SELECT itemID, itemName, itemCategory, itemExternalID, quantity, storageLocation, available, condition, Notes, icon FROM InventoryTable";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    Debug.WriteLine("SQL connection successful."); // Debug output
                    // Console.WriteLine("SQL connection successful."); // Alternative: prints to console if available

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
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

                            

                            itemControl.ItemAdded += (s, args) => overlayform.Close(); // Close the overlay form when an item is added
                            itemControl.Addbutton();
                            // Subscribe to the ItemDeleted event
                            flpItemControlScroll.Controls.Add(itemControl);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("SQL connection failed: " + ex.Message);
                    // Console.WriteLine("SQL connection failed: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filterMenu.Items.Clear();

            // Categories
            var categories = flpItemControlScroll.Controls.OfType<EquipmentItemControl>()
                .Select(i => i.ItemCategory.Trim())
                .Where(c => !string.IsNullOrEmpty(c))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(c => c)
                .ToList();

            var categoryMenu = new ToolStripMenuItem("Category");
            foreach (var cat in categories)
            {
                var item = new ToolStripMenuItem(cat) { Checked = selectedCategories.Contains(cat), CheckOnClick = true };
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
            filterMenu.Items.Add(categoryMenu);

            // Availabilities
            var availabilities = flpItemControlScroll.Controls.OfType<EquipmentItemControl>()
                .Select(i => i.Availability.Trim())
                .Where(a => !string.IsNullOrEmpty(a))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(a => a)
                .ToList();

            var availMenu = new ToolStripMenuItem("Availability");
            foreach (var avail in availabilities)
            {
                var item = new ToolStripMenuItem(avail) { Checked = selectedAvailabilities.Contains(avail), CheckOnClick = true };
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
            filterMenu.Items.Add(availMenu);

            filterMenu.Show(btnFilter, new Point(0, btnFilter.Height));
        }

        private void ApplyFilters()
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            // Treat placeholder as empty search
            if (searchText == "search")
                searchText = string.Empty;

            foreach (Control ctrl in flpItemControlScroll.Controls)
            {
                if (ctrl is EquipmentItemControl item)
                {
                    bool match = (string.IsNullOrEmpty(searchText) ||
                                  item.ItemName.ToLower().Contains(searchText) ||
                                  item.ItemCategory.ToLower().Contains(searchText) ||
                                  item.ItemExternalID.ToLower().Contains(searchText) ||
                                  item.StorageLocation.ToLower().Contains(searchText) ||
                                  item.Availability.ToLower().Contains(searchText));

                    bool categoryMatch = selectedCategories.Count == 0 || selectedCategories.Contains(item.ItemCategory.Trim());
                    bool availMatch = selectedAvailabilities.Count == 0 || selectedAvailabilities.Contains(item.Availability.Trim());

                    item.Visible = match && categoryMatch && availMatch;
                }
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                txtSearch.Text = "Search"; // Reset to placeholder text
                typing = false; // Reset typing state
                txtSearch.ForeColor = Color.Gray; // Change text color back to gray
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtSearch.Text == "Search" && !typing)
            {
                txtSearch.Text = string.Empty; // Clear the placeholder text
                typing = true; // Set typing to true to prevent clearing again
                txtSearch.ForeColor = Color.Black; // Change text color to black
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent new line
            }
        }
    }
}
