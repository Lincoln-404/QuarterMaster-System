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


            /*int numberOfItems = 30; // Set this to however many items you want to test

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

            this.WindowState = FormWindowState.Maximized;

            LoadInventoryItems(); // Load items from the database into the flow layout panel

            //creates the class to stop the space bar from being used when typing in the search box
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged); // Add this line

            btnFilter.Click += btnFilter_Click; // Add this line
        

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close current form
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent new line
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if( txtSearch.Text == "Search" && !typing)
            {
                txtSearch.Text = string.Empty; // Clear the placeholder text
                typing = true; // Set typing to true to prevent clearing again
                txtSearch.ForeColor = Color.Black; // Change text color to black
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if( txtSearch.Text == string.Empty)
            {
                txtSearch.Text = "Search"; // Reset to placeholder text
                typing = false; // Reset typing state
                txtSearch.ForeColor = Color.Gray; // Change text color back to gray
            }
        }
        private void LoadInventoryItems()
        {
            flpEquipmentScroll.Controls.Clear(); // Clear existing controls in the table layout
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
                                Availability = reader["available"].ToString()
                            };

                            // Subscribe to the ItemDeleted event
                            itemControl.ItemDeleted += (s, e) => LoadInventoryItems();

                            flpEquipmentScroll.Controls.Add(itemControl);
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.elevatedPrivileges == true)
            {
                GlobalVariables.isAddingNewItem = true; // Set the flag to indicate a new item is being added
                // Create a new Form to host the MoreMenuControl
                using (Form overlayForm = new Form())
                {
                    MoreMenuControl moreMenu = new MoreMenuControl(0, overlayForm);

                    overlayForm.FormBorderStyle = FormBorderStyle.None;
                    overlayForm.StartPosition = FormStartPosition.CenterParent;
                    overlayForm.ShowInTaskbar = false;
                    overlayForm.BackColor = Color.White;
                    overlayForm.Size = new Size(moreMenu.Width, moreMenu.Height); // Adjust size as needed

                    // Position the overlay near the More button
                    /*var screenPoint = btnMore.PointToScreen(new Point(0, btnMore.Height));
                    overlayForm.Location = screenPoint;*/

                    // Subscribe to the MoreMenuControl's ItemDeleted event
                    moreMenu.ItemDeleted += (s, args) => LoadInventoryItems();
                    

                    // Add your MoreMenuControl to the form

                    moreMenu.Dock = DockStyle.Fill;
                    overlayForm.Controls.Add(moreMenu);

                    // Show as a dialog (modal) or use Show() for non-modal
                    overlayForm.ShowDialog();
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
            var categories = flpEquipmentScroll.Controls.OfType<EquipmentItemControl>()
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
            var availabilities = flpEquipmentScroll.Controls.OfType<EquipmentItemControl>()
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

            foreach (Control ctrl in flpEquipmentScroll.Controls)
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
    }
}
