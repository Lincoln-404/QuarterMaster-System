using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarterMaster_System
{
    public partial class EquipmentItemControl : UserControl
    {
        private int itemID; // Backing field for ItemID property

        public event EventHandler ItemDeleted;

        private string btnActionMode = "more"; // Flag to check if the More button is enabled

        private int listID; // Backing field for ListID property

        private int NumberofItems; // Backing field for NumberOfItems property

        public event EventHandler ItemAdded; // Event to notify when an item is added

        public event EventHandler NumberOfItemsChanged; // Event to notify when the number of items changes

        public EquipmentItemControl()
        {
            InitializeComponent(); // Initialize the component, which sets up the UI elements
        }

        public int ItemID // Property to get or set the item ID
        {
            get => itemID; // Get the text of the label for item ID
            set => itemID = value;
        }

        public Image ItemIcon // Property to get or set the item icon image
        {
            get => picIcon.Image; // Get the current image of the PictureBox
            set => picIcon.Image = value; // Set the image of the PictureBox to the provided value
        }

        public string ItemName // Property to get or set the item name
        {
            get => lblItemName.Text; // Get the text of the label
            set
            {
                lblItemName.Text = value; // Set the text of the label
                lblItemName.AutoFitFont(8); // Adjust font size to fit the label
            }
        }

        public string ItemCategory // Property to get or set the item category
        {
            get => lblItemCategory.Text; // Get the text of the label for item category
            set
            {
                lblItemCategory.Text = value; // Set the text of the label for item category
                lblItemCategory.AutoFitFont(8); // Adjust font size to fit the label
            }
        }

        public string ItemExternalID // Property to get or set the external ID of the item
        {
            get => lblItemExternalID.Text; // Get the text of the label for external ID
            set
            {
                lblItemExternalID.Text = value; // Set the text of the label for external ID
                lblItemExternalID.AutoFitFont(8); // Adjust font size to fit the label
            }   
        }

        public string Quantity // Property to get or set the quantity of the item
        {
            get => lblItemQuantity.Text; // Get the text of the label for quantity
            set
            {
                lblItemQuantity.Text = value + " Items"; // Set the text of the label for quantity
                lblItemQuantity.AutoFitFont(8); // Adjust font size to fit the label
            }
        }

        public string StorageLocation // Property to get or set the storage location of the item
        {
            get => lblItemStoragelocation.Text; // Get the text of the label for storage location
            set
            {
                lblItemStoragelocation.Text = value; // Set the text of the label for storage location
                lblItemStoragelocation.AutoFitFont(8); // Adjust font size to fit the label
            }
        }

        public string Availability // Property to get or set the availability status of the item
        {
            get => lblItemAvailability.Text; // Get the text of the label for availability
            set
            {
                lblItemAvailability.Text = value; // Set the text of the label for availability
                lblItemAvailability.AutoFitFont(8); // Adjust font size to fit the label
            }
        }

        public Button ActionButton
        {
            get => btnAction; // Property to get the More button, allowing external code to access it
            set
            {
                btnAction = value; // Set the More button to the provided value
                btnAction.AutoFitFont(8); // Adjust font size to fit the button
            }
        }

        public int ListID // Property to get or set the list ID
        {
            get => listID; // Get the list ID
            set => listID = value; // Set the list ID
        }

        public int NumbItems
        {
            get => NumberofItems; // Get the number of items from the numeric up-down control
            set => NumberofItems = value; // Set the number of items in the numeric up-down control
        }


        private void btnMore_Click(object sender, EventArgs e)
        {
            if (btnActionMode == "more")
            {
                // Create a new Form to host the MoreMenuControl
                using (Form overlayForm = new Form())
                {
                    MoreMenuControl moreMenu = new MoreMenuControl(itemID, overlayForm);

                    overlayForm.FormBorderStyle = FormBorderStyle.None;
                    overlayForm.StartPosition = FormStartPosition.CenterParent;
                    overlayForm.ShowInTaskbar = false;
                    overlayForm.BackColor = Color.White;
                    overlayForm.Size = new Size(moreMenu.Width, moreMenu.Height); // Adjust size as needed

                    // Position the overlay near the More button
                    /*var screenPoint = btnMore.PointToScreen(new Point(0, btnMore.Height));
                    overlayForm.Location = screenPoint;*/

                    // Subscribe to the MoreMenuControl's ItemDeleted event
                    moreMenu.ItemDeleted += (s, args) =>
                    {
                        ItemDeleted?.Invoke(this, EventArgs.Empty); // Bubble up the event
                        overlayForm.Close(); // Ensure the overlay closes after delete
                    };

                    // Add your MoreMenuControl to the form

                moreMenu.Dock = DockStyle.Fill; // Fill the overlay form with the MoreMenuControl
                overlayForm.Controls.Add(moreMenu); // Add the MoreMenuControl to the overlay form

                    // Show as a dialog (modal) or use Show() for non-modal
                    overlayForm.ShowDialog();
                }
            }
            else if (btnActionMode == "add") 
            {
                
                string connectionString = GlobalVariables.GetConnectionString();
                string query = "INSERT INTO listItemsTable (listID, itemID, quantity) VALUES (@listID, @itemID, @quantity)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        ItemAdded?.Invoke(this, EventArgs.Empty); // Raise the ItemAdded event if there are any subscribers
                        conn.Open(); // Open the SQL connection
                        cmd.Parameters.AddWithValue("@listID", listID); // Set the ListID parameter
                        cmd.Parameters.AddWithValue("@itemID", itemID); // Set the ItemID parameter
                        cmd.Parameters.AddWithValue("@quantity", NumberofItems); // Set the quantity to 1 for adding an item
                        cmd.ExecuteNonQuery(); // Execute the insert command
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding item to list: " + ex.Message); // Show error message if any exception occurs
                    }
                }
            }
            else if (btnActionMode == "delete")
            {
                string connectionString = GlobalVariables.GetConnectionString();
                string query = "DELETE FROM listItemsTable WHERE listID = @listID AND itemID = @itemID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this list?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                        try
                        {
                            
                            conn.Open(); // Open the SQL connection
                            cmd.Parameters.AddWithValue("@listID", listID); // Set the ListID parameter
                            cmd.Parameters.AddWithValue("@itemID", itemID); // Set the ItemID parameter
                            cmd.ExecuteNonQuery(); // Execute the delete command
                            ItemDeleted?.Invoke(this, EventArgs.Empty); // Raise the ItemDeleted event if there are any subscribers
                        }
                        catch (Exception ex)
                        {
                        MessageBox.Show("Error deleting item from list: " + ex.Message); // Show error message if any exception occurs
                        }
                }
            }
        }

        public void DeleteButton()
        {
            btnAction.Text = "Delete"; // Change the button text to "Delete"
            btnActionMode = "delete"; // Set the flag to indicate this is a delete button

        }

        public void Addbutton()
        {
            btnAction.Text = "Add"; // Change the button text to "Add"
            btnActionMode = "add"; // Set the flag to indicate this is not a add button
        }
    }
}
