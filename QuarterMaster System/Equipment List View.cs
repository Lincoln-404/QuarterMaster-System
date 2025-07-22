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
    public partial class EquipmentListView : Form
    {
        private int listID; // Backing field for ListID property
        private Boolean isBooked = false; // Default value for isBooked
        public event EventHandler listDeleted;
        public EquipmentListView(int ID)
        {
            InitializeComponent();
            listID = ID; // Set the ListID from the constructor parameter
            LoadEquipmentList(); // Call the method to load the equipment list
            if (isBooked == true)
            {
                btnBookList.Text = "View Booking";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            if (isBooked == true)
            {
                //Go to the Calendar Page specific to this list
            }
            else
            {
                //open the booking form for this list
            }
        }
        private void LoadEquipmentList()
        {
            flpListItemScroll.Controls.Clear(); // Clear existing controls in the flow layout panel
            string connectionString = GlobalVariables.GetConnectionString(); // Get the connection string from global variables
            string listquery = "SELECT listName, listOwner, listID, listSize, CreationDate, listNotes FROM EquipmentListTable WHERE listID = @listID";
            string itemquery = "SELECT l.listItemID, l.listID, l.itemID, l.quantity, l.notes, I.itemID, I.itemName, I.itemCategory, I.itemExternalID, I.storageLocation, I.available FROM listItemsTable l LEFT JOIN InventoryTable I ON l.itemID = I.itemID WHERE l.listID = @listID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Open the database connection
                    using (SqlCommand cmd = new SqlCommand(listquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@listID", listID); // Add the listID parameter to the command
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) // Read the result
                            {
                                lblListName.Text = reader["listName"].ToString(); // Set the list name label
                                lblListOwner.Text = "List Owner: " + reader["listOwner"].ToString(); // Set the list owner label
                                lblListSize.Text = reader["listSize"].ToString() + " Items"; // Set the list size label
                                if (reader["CreationDate"] != DBNull.Value)
                                {
                                    lblCreationDate.Text = "Created On: " + Convert.ToDateTime(reader["CreationDate"]).ToString("dd/MM/yyyy"); // Set the creation date label
                                }
                                rtbNotes.Text = reader["listNotes"].ToString(); // Set the list notes text box
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand(itemquery, conn))
                    {
                        cmd.Parameters.AddWithValue("@listID", listID); // Add the listID parameter to the command
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) // Read each row of the result
                            {
                                var itemControl = new EquipmentItemControl
                                {
                                    ItemName = reader["itemName"].ToString(), // Set the item name
                                    ItemCategory = reader["itemCategory"].ToString(), // Set the item category
                                    ItemExternalID = reader["itemExternalID"].ToString(), // Set the item external ID
                                    ItemID = Convert.ToInt32(reader["itemID"]), // Set the item ID
                                    Quantity = reader["quantity"].ToString(), // Set the item quantity
                                    StorageLocation = reader["storageLocation"].ToString(), // Set the storage location
                                    Availability = reader["available"].ToString(), // Set the availability
                                    ListID =  listID, // Set the ListID for the item control
                                };

                                itemControl.DeleteButton();                                
                                itemControl.ItemDeleted += (s, args) => LoadEquipmentList(); // Subscribe to the ItemDeleted event to refresh the list when an item is deleted
                                flpListItemScroll.Controls.Add(itemControl); // Add the item control to the flow layout panel

                                
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the equipment list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.elevatedPrivileges == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this list?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string connectionString = GlobalVariables.GetConnectionString();
                    string query1 = "DELETE FROM EquipmentListTable WHERE listID = @listID";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.AddWithValue("@listID", listID); // Use the ListID property to set the parameter
                        try
                        {
                            conn.Open();
                            cmd1.ExecuteNonQuery(); // Execute the delete command
                            listDeleted?.Invoke(this, EventArgs.Empty); // Invoke the listDeleted event if there are any subscribers
                            this.Close(); // Close the current form

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting list: " + ex.Message);
                        }
                    }

                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
                                                    
            using (Form overlayForm = new Form())
            {
                AddItemControl AddItemMenu = new AddItemControl(overlayForm, listID);

                overlayForm.FormBorderStyle = FormBorderStyle.None;
                overlayForm.StartPosition = FormStartPosition.CenterParent;
                overlayForm.ShowInTaskbar = false;
                overlayForm.BackColor = Color.White;
                overlayForm.Size = new Size(AddItemMenu.Width, AddItemMenu.Height); // Adjust size as needed

                // Position the overlay near the More button
                //var screenPoint = btnMore.PointToScreen(new Point(0, btnMore.Height));
                //overlayForm.Location = screenPoint;

                // Subscribe to the MoreMenuControl's ItemAdded event
                AddItemMenu.ItemAdded += (s, args) => LoadEquipmentList();


                // Add your MoreMenuControl to the form

                AddItemMenu.Dock = DockStyle.Fill;
                overlayForm.Controls.Add(AddItemMenu);

                // Show as a dialog (modal) or use Show() for non-modal
                overlayForm.ShowDialog();

                
            }
        }
    }
}
