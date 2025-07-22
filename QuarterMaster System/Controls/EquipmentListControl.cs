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

namespace QuarterMaster_System.Controls
{
    public partial class EquipmentListControl : UserControl
    {
        private int listID; // Backing field for ListID property
        public event EventHandler ItemDeleted; // Event to notify when an item is deleted
        public event EventHandler openNew;

        public EquipmentListControl()
        {
            InitializeComponent();
        }

        public string ListName
        {
            get => lblListName.Text; // Get the text of the label for list name
            set
            {
                lblListName.Text = value; // Set the text of the label for list name
            }
        }

        public int ListSize
        {
            get => int.Parse(lblListSize.Text.Split(' ')[0]); // Get only the number before the space
            set
            {
                lblListSize.Text = value.ToString() + " Items"; // Set the text of the label for list size
            }
        }

        public string ListOwner
        {
             
            get => lblListOwner.Text.Substring(12); // Get the text of the label for list owner
            set
            {
                lblListOwner.Text = "List Owner: " + value; // Set the text of the label for list owner
            }
        }

        public string ListBooking
        {
            get => lblListBooking.Text.Substring(9); // Get the text of the label for list booking
            set
            {
                lblListBooking.Text = "Booking: " + value; // Set the text of the label for list booking
            }
        }

        public int ListID // Property to get or set the list ID
        {
            get => listID; // Get the list ID
            set => listID = value; // Set the list ID
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openNew?.Invoke(this, EventArgs.Empty); // Raise the openNew event when the Open button is clicked
            EquipmentListView ListViewer = new EquipmentListView(listID);
            ListViewer.listDeleted += (s, args) =>
            {
                ItemDeleted?.Invoke(this, EventArgs.Empty); // Raise the ItemDeleted event when the list is deleted
            };
            ListViewer.Text = "QuarterMaster [" + ListName + "]"; // Set the title of the new form
            ListViewer.ShowDialog(); // Blocks until the new form is closed
            this.Show(); // Show this form again after the other one closes
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                        cmd1.Parameters.AddWithValue("@listID", ListID); // Use the ListID property to set the parameter
                        try
                        {
                            conn.Open();
                            cmd1.ExecuteNonQuery(); // Execute the delete command
                            ItemDeleted?.Invoke(this, EventArgs.Empty); // Raise the ItemDeleted event
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting list: " + ex.Message);
                        }
                    }

                }
            }
        }

        public bool buttonsUsable
        {
            get => btnOpen.Enabled && btnBooking.Enabled && btnDelete.Enabled; // Check if all buttons are enabled
            set
            {
                btnOpen.Enabled = value; // Set the enabled state of the Open button
                btnBooking.Enabled = value; // Set the enabled state of the Booking button
                btnDelete.Enabled = value; // Set the enabled state of the Delete button
            }
        }
    }
}
