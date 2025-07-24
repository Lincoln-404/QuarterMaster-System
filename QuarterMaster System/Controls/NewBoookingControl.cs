using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarterMaster_System
{
    public partial class NewBoookingControl : UserControl
    {
        private bool isTypingBookedBy = false;
        private bool isTypingNotes = false;
        private Form overlayFrom; // Overlay form to be used for displaying additional information or controls
        private bool isList = false; // Flag to indicate if this control is used for a list
        public NewBoookingControl(Form OverlayForm)
        {
            InitializeComponent();
            overlayFrom = OverlayForm;// Initialize the overlay form
        }

        public void islist()
        {
            lblList.Text = "List: ";
            isList = true; // Set the flag to indicate this control is used for a list
        }
        
        private void txtBookedBy_Leave(object sender, EventArgs e)
        {
            if (txtBookedBy.Text == string.Empty)
            {
                txtBookedBy.Text = "Section or Name";
                txtBookedBy.ForeColor = Color.Gray;                
            }
            isTypingBookedBy = false;
        }        

        private void txtNotes_Leave(object sender, EventArgs e)
        {
            if (txtNotes.Text == string.Empty)
            {
                txtNotes.Text = "Section or Name";
                txtNotes.ForeColor = Color.Gray;
            }
            isTypingNotes = false;
        }

        private void txtBookedBy_Click(object sender, EventArgs e)
        {
            if (txtBookedBy.Text == "Section or Name" && !isTypingBookedBy)
            {
                txtBookedBy.Text = string.Empty;
                isTypingBookedBy = true;
                txtBookedBy.ForeColor = Color.Black;
            }
        }

        private void txtNotes_Click(object sender, EventArgs e)
        {
            if (txtNotes.Text == "Section or Name" && !isTypingNotes)
            {
                txtNotes.Text = string.Empty;
                isTypingNotes = true;
                txtNotes.ForeColor = Color.Black;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            overlayFrom.Close(); // Close the overlay form when cancel button is clicked
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            using (Form overlayForm2 = new Form())
            {
                AddItemControl addItem = new AddItemControl(overlayForm2, 0);

                overlayForm2.FormBorderStyle = FormBorderStyle.None;
                overlayForm2.StartPosition = FormStartPosition.CenterParent;
                overlayForm2.ShowInTaskbar = false;
                overlayForm2.BackColor = Color.White;
                overlayForm2.Size = new Size(addItem.Width, addItem.Height); // Adjust size as needed

                // Position the overlay near the More button
                //var screenPoint = btnMore.PointToScreen(new Point(0, btnMore.Height));
                //overlayForm.Location = screenPoint;

                // Subscribe to the MoreMenuControl's ItemDeleted event
                //AddItemMenu.ItemAdded += (s, args) => LoadEquipmentList();


                // Add your MoreMenuControl to the form

                addItem.Dock = DockStyle.Fill;
                overlayForm2.Controls.Add(addItem);

                // Show as a dialog (modal) or use Show() for non-modal
                overlayForm2.ShowDialog();


            }
        }
    }
}
