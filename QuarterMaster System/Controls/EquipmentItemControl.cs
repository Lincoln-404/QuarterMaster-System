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
    public partial class EquipmentItemControl : UserControl
    {
        private int itemID; // Backing field for ItemID property

        public event EventHandler ItemDeleted;

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
                lblItemQuantity.Text = value; // Set the text of the label for quantity
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

        public Button MoreButton
        {
            get => btnMore; // Property to get the More button, allowing external code to access it
            set
            {
                btnMore = value; // Set the More button to the provided value
                btnMore.AutoFitFont(8); // Adjust font size to fit the button
            }

        }

        private void btnMore_Click(object sender, EventArgs e)
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

                moreMenu.Dock = DockStyle.Fill;
                overlayForm.Controls.Add(moreMenu);

                // Show as a dialog (modal) or use Show() for non-modal
                overlayForm.ShowDialog();
            }
        }
    }
}
