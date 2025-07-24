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
    public partial class NewListControl : UserControl
    {
        private bool isTypingName = false;
        private bool isTypingOwner = false;
        private bool isTypingNotes = false;
        private Form overlayFrom;
        public event EventHandler openNew; // Event to notify when a new list is opened
        public event EventHandler ItemDeleted; // Event to notify when an item is deleted

        public NewListControl(Form OverlayForm)
        {
            InitializeComponent();            

            overlayFrom = OverlayForm;
        }

        

        private void txtListName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtListName.Text == "Spring Camp 2020" && !isTypingName)
            {
                txtListName.Text = string.Empty;
                isTypingName = true;
                txtListName.ForeColor = Color.Black;
            }
        }

        private void txtListOwner_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtListOwner.Text == "Section or Name" && !isTypingOwner)
            {
                txtListOwner.Text = string.Empty;
                isTypingOwner = true;
                txtListOwner.ForeColor = Color.Black;
            }
        }

        private void txtListOwner_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void rtbListNotes_MouseClick(object sender, MouseEventArgs e)
        {
            if (rtbListNotes.Text == "Optional" && !isTypingNotes)
            {
                rtbListNotes.Text = string.Empty;
                isTypingNotes = true;
                rtbListNotes.ForeColor = Color.Black;
            }
        }        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtListName.Text == "Spring Camp 2020" || txtListOwner.Text == "Section or Name")
            {
                MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string connectionString = GlobalVariables.GetConnectionString();
                string query = @"INSERT INTO EquipmentListTable (listName, listOwner, listNotes, CreationDate, listSize) VALUES (@listName, @listOwner, @listNotes, @CreationDate, @listSize); SELECT CAST(SCOPE_IDENTITY() AS int);";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@listName", txtListName.Text);
                        cmd.Parameters.AddWithValue("@listOwner", txtListOwner.Text);
                        cmd.Parameters.AddWithValue("@listNotes", rtbListNotes.Text != "Optional" ? (object)rtbListNotes.Text : string.Empty);
                        cmd.Parameters.AddWithValue("@CreationDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@listSize", 0); // Assuming the initial size is 0, can be adjusted later

                        openNew?.Invoke(this, EventArgs.Empty); // Notify subscribers that a new list is opened                        
                        int newListID = (int)cmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row in the result set
                        EquipmentListView ListViewer = new EquipmentListView(newListID); // Creates a new EquipmentListView form, passing the list ID
                        ListViewer.listDeleted += (s, args) =>
                        {
                            ItemDeleted?.Invoke(this, EventArgs.Empty); // Raises the ItemDeleted event if the list is deleted in the viewer
                        };                        
                        ListViewer.Text = "QuarterMaster [" + txtListName.Text + "]"; // Sets the window title to include the list name
                        ListViewer.ShowDialog(); // Shows the form as a modal dialog (blocks until closed)
                        this.Show(); // Shows this control again after the dialog closes (typically not needed for UserControl, but included for consistency)
                        overlayFrom.Close(); // Close the overlay form
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while creating the list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            overlayFrom.Close(); // Close the overlay form
        }

        private void txtListName_Leave(object sender, EventArgs e)
        {
            if (txtListName.Text == string.Empty)
            {
                txtListName.Text = "Spring Camp 2020";
                txtListName.ForeColor = Color.Gray;                
            }
            isTypingName = false;
        }

        private void txtListOwner_Leave(object sender, EventArgs e)
        {
            if (txtListOwner.Text == string.Empty)
            {
                txtListOwner.Text = "Section or Name";
                txtListOwner.ForeColor = Color.Gray;                
            }
            isTypingOwner = false;

        }

        private void rtbListNotes_Leave(object sender, EventArgs e)
        {
            if (rtbListNotes.Text == string.Empty)
            {
                rtbListNotes.Text = "Optional";
                rtbListNotes.ForeColor = Color.Gray;                
            }
            isTypingNotes = false;
        }
    }
}
