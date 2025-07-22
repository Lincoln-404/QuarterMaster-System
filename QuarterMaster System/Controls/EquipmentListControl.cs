using System; // Provides base class libraries for fundamental types
using System.Collections.Generic; // Provides generic collection classes
using System.ComponentModel; // Provides classes for component and control design
using System.Data; // Provides access to ADO.NET basic data classes
using System.Data.SqlClient; // Provides classes for SQL Server database access
using System.Drawing; // Provides access to GDI+ graphics functionality
using System.Linq; // Provides LINQ query capabilities
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms; 

namespace QuarterMaster_System.Controls 
{
    
    public partial class EquipmentListControl : UserControl // Inherits from UserControl for custom UI component
    {
        private int listID; // Backing field for ListID property; int is used for unique numeric identifiers

        public event EventHandler ItemDeleted; // Event to notify when an item is deleted; EventHandler is standard for event patterns
        public event EventHandler openNew; // Event to notify when a list is opened; EventHandler is used for simplicity

        public EquipmentListControl()
        {
            InitializeComponent(); // Initializes the UI components for this control
        }

        /// <summary>
        /// Gets or sets the name of the list.
        /// </summary>
        public string ListName // string is used for textual data
        {
            get => lblListName.Text; // Gets the text from the label displaying the list name
            set
            {
                lblListName.Text = value; // Sets the label text to the provided value
            }
        }

        /// <summary>
        /// Gets or sets the size of the list (number of items).
        /// </summary>
        public int ListSize // int is used for numeric count of items
        {
            get => int.Parse(lblListSize.Text.Split(' ')[0]); // Parses the number from the label (e.g., "5 Items")
            set
            {
                lblListSize.Text = value.ToString() + " Items"; // Sets the label to show the count and "Items"
            }
        }

        /// <summary>
        /// Gets or sets the owner of the list.
        /// </summary>
        public string ListOwner // string is used for owner names
        {
            get => lblListOwner.Text.Substring(12); // Gets the owner name by removing "List Owner: "
            set
            {
                lblListOwner.Text = "List Owner: " + value; // Sets the label to show the owner
            }
        }

        /// <summary>
        /// Gets or sets the booking information for the list.
        /// </summary>
        public string ListBooking // string is used for booking details
        {
            get => lblListBooking.Text.Substring(9); // Gets the booking info by removing "Booking: "
            set
            {
                lblListBooking.Text = "Booking: " + value; // Sets the label to show the booking info
            }
        }

        /// <summary>
        /// Gets or sets the unique ID for the list.
        /// </summary>
        public int ListID // int is used for unique numeric identifiers
        {
            get => listID; // Returns the backing field value
            set => listID = value; // Sets the backing field value
        }

        /// <summary>
        /// Handles the Open button click event to open the list in a new form.
        /// </summary>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openNew?.Invoke(this, EventArgs.Empty); // Raises the openNew event if there are subscribers
            EquipmentListView ListViewer = new EquipmentListView(listID); // Creates a new EquipmentListView form, passing the list ID
            ListViewer.listDeleted += (s, args) =>
            {
                ItemDeleted?.Invoke(this, EventArgs.Empty); // Raises the ItemDeleted event if the list is deleted in the viewer
            };
            ListViewer.Text = "QuarterMaster [" + ListName + "]"; // Sets the window title to include the list name
            ListViewer.ShowDialog(); // Shows the form as a modal dialog (blocks until closed)
            this.Show(); // Shows this control again after the dialog closes (typically not needed for UserControl, but included for consistency)
        }

        /// <summary>
        /// Handles the Booking button click event (currently not implemented).
        /// </summary>
        private void btnBooking_Click(object sender, EventArgs e)
        {
            // No implementation provided
        }

        /// <summary>
        /// Handles the Delete button click event to delete the list from the database.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.elevatedPrivileges == true) // Checks if the user has elevated privileges
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this list?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // Shows a confirmation dialog
                if (result == DialogResult.Yes) // If the user confirms deletion
                {
                    string connectionString = GlobalVariables.GetConnectionString(); // Gets the database connection string
                    string query1 = "DELETE FROM EquipmentListTable WHERE listID = @listID"; // SQL query to delete the list
                    using (SqlConnection conn = new SqlConnection(connectionString)) // Creates a new SQL connection
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn)) // Creates a new SQL command
                    {
                        cmd1.Parameters.AddWithValue("@listID", ListID); // Adds the list ID as a parameter to prevent SQL injection
                        try
                        {
                            conn.Open(); // Opens the database connection
                            cmd1.ExecuteNonQuery(); // Executes the delete command
                            ItemDeleted?.Invoke(this, EventArgs.Empty); // Raises the ItemDeleted event to notify subscribers
                        }
                        catch (Exception ex) // Catches any exceptions during the database operation
                        {
                            MessageBox.Show("Error deleting list: " + ex.Message); // Shows an error message if deletion fails
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets whether all action buttons are enabled.
        /// </summary>
        public bool buttonsUsable // bool is used for true/false state
        {
            get => btnOpen.Enabled && btnBooking.Enabled && btnDelete.Enabled; // Returns true if all buttons are enabled
            set
            {
                btnOpen.Enabled = value; // Sets the enabled state of the Open button
                btnBooking.Enabled = value; // Sets the enabled state of the Booking button
                btnDelete.Enabled = value; // Sets the enabled state of the Delete button
            }
        }
    }
}
