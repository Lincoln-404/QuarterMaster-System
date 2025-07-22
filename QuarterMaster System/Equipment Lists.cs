using QuarterMaster_System.Controls;
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
    public partial class EquipmentLists : Form
    {
        public EquipmentLists()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; // Maximize the form at runtime

            loadEquipmentList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
        }

        private void loadEquipmentList()
        {
            flpLeftListScroll.Controls.Clear(); // Clear the left flow layout panel
            flpRightListScroll.Controls.Clear(); // Clear the right flow layout panel
            string connectionString = GlobalVariables.GetConnectionString();
            string query = @"SELECT listName AS [List Name], listSize AS [List Size], listOwner AS [List Owner], listID AS [List ID] FROM EquipmentListTable";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool hasRows = false;
                        while (reader.Read())
                        {
                            hasRows = true;
                            var EquipmentListPreview = new Controls.EquipmentListControl()
                            {
                                ListName = reader["List Name"].ToString(),
                                ListSize = Convert.ToInt32(reader["List Size"]),
                                ListOwner = reader["List Owner"].ToString(),
                                ListBooking = "Not Booked", // Default value, can be changed later
                                ListID = Convert.ToInt32(reader["List ID"]) // Assuming you have a List ID column in your query
                            };

                            EquipmentListPreview.ItemDeleted += (s, args) =>
                            {
                                // Refresh the equipment list when an item is deleted
                                loadEquipmentList();
                            };

                            EquipmentListPreview.openNew += (s, args) => this.Hide(); // Hide the current form when a list is opened

                            // Add the label to the appropriate flow layout panel
                            if (flpLeftListScroll.Controls.Count <= flpRightListScroll.Controls.Count)
                            {
                                flpLeftListScroll.Controls.Add(EquipmentListPreview);
                            }
                            else
                            {
                                flpRightListScroll.Controls.Add(EquipmentListPreview);
                            }
                        }

                        if (!hasRows)
                        {
                            var EquipmentListPreview = new Controls.EquipmentListControl()
                            {
                                ListName = "Equipment List Preview",
                                ListSize = 12,
                                ListOwner = "Section",
                                ListBooking = "Not Booked",
                            };
                            EquipmentListPreview.buttonsUsable = false; // Disable the button if no lists are found
                            flpLeftListScroll.Controls.Add(EquipmentListPreview);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading equipment lists: " + ex.Message);
                }
            }

        }

        private void btnNewList_Click(object sender, EventArgs e)
        {
            using (Form overlayForm = new Form())
            {
                NewListControl createListControl = new NewListControl(overlayForm);

                overlayForm.FormBorderStyle = FormBorderStyle.None;
                overlayForm.StartPosition = FormStartPosition.CenterParent;
                overlayForm.ShowInTaskbar = false;
                overlayForm.BackColor = Color.White;
                overlayForm.Size = new Size(createListControl.Width, createListControl.Height); // Adjust size as needed

                // Position the overlay near the More button
                //var screenPoint = btnMore.PointToScreen(new Point(0, btnMore.Height));
                //overlayForm.Location = screenPoint;

                // Subscribe to the MoreMenuControl's ItemDeleted event
                //AddItemMenu.ItemAdded += (s, args) => LoadEquipmentList();


                // Add your MoreMenuControl to the form

                createListControl.Dock = DockStyle.Fill;
                overlayForm.Controls.Add(createListControl);

                createListControl.openNew += (s, args) =>
                {
                    loadEquipmentList(); // When a new list is created, reload the equipment list
                    this.Hide(); // Hide the current form when a new list is created
                };

                createListControl.ItemDeleted += (s, args) =>
                {
                    // When an item is deleted, reload the equipment list
                    loadEquipmentList();
                };

                // Show as a dialog (modal) or use Show() for non-modal
                overlayForm.ShowDialog();

                
            }
        }        
    }    
}
